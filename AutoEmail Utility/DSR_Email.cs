using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace AutoEmail_Utility
{
    public class DSR_Email
    {
        #region DefineClassProperties
        private static string EmailTemplate;
        private static string EmailTitle;
        private static string AttachmentPath;
        private static string Email_Tos;
        private static string EmailBody;
        private static StringBuilder ListClassProperties = new StringBuilder();
        private static Int32 CountUsers;
        private static Int32 CountUserRowData = 0;
        #endregion

        public static void SendAutomatedEmails()
        {
            Read_SQL_tblUsers();
        }

        private static void PrintSingleEmail()
        {
            ListClassProperties.Clear();
            ListClassProperties.AppendLine(CountUserRowData.ToString() + " / " + CountUsers.ToString());
            ListClassProperties.AppendLine("Email template: " + EmailTemplate);
            ListClassProperties.AppendLine("Email title: " + EmailTitle);
            ListClassProperties.AppendLine("Attachment path: " + AttachmentPath);
            ListClassProperties.AppendLine("Email to addresses: " + Email_Tos);

            Console.WriteLine(ListClassProperties.ToString());
        }


        #region SQL_Connection
        // read the data from SQL with Microsoft Data Reader
        public static void Read_SQL_tblUsers()
        {
            if (Security.ActiveUser == "<<USER_NAME_insert>>") {
                string str = @"Data Source=<<Datasource_ConnectionString_insert";
                ReadOrderData(str);
            }
        }

        private static void ReadOrderData(string connectionString)
        {
            string queryString =
                "SELECT * FROM dbo.tblSendEmails_Data;";

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                SqlCommand command2 =
                    new SqlCommand("SELECT COUNT(*) FROM dbo.tblSendEmails_Data", connection);
                connection.Open();
                CountUsers = (Int32)command2.ExecuteScalar();

                SqlCommand command =
                    new SqlCommand(queryString, connection);

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    SetUserEmailInfo((IDataRecord)reader);
                    //SendSingleEmail(); // for production
                    PrintSingleEmail(); // for testing
                    ClearDSREmailInfo();
                }

                // Call Close when done reading.
                reader.Close();
            }
        }
        #endregion

        private static void SetUserEmailInfo(IDataRecord record)
        {
            CountUserRowData++;
            EmailTemplate = record[0].ToString();
            EmailTitle = record[1].ToString();
            AttachmentPath= record[2].ToString();
            Email_Tos= record[3].ToString();
            EmailBody = record[4].ToString();
        }

        // clear all the properties of the class for safety, before other user will use them
        private static void ClearDSREmailInfo()
        {
            EmailTemplate = "";
            EmailTitle = "";
            AttachmentPath = "";
            Email_Tos = "";
            EmailBody = "'";
        }

        // method for sending the email
        public static void SendSingleEmail()
        {
            Outlook.Application _app = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
            mail.To = Email_Tos;
            mail.Subject = EmailTitle;
            mail.Body = EmailBody;
            mail.Attachments.Add(AttachmentPath, Outlook.OlAttachmentType.olByValue, Type.Missing, Type.Missing);
            // mail.Send();
            mail.Display(true); // displays the email --- toggle between this option and mail.send  for testing
        }

        // end of class DSR_Email
    }
}
