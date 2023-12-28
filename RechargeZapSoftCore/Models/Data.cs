using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Configuration;
using System.Security;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.IO;
using System.Net.Mail;

namespace RechargeZapSoftCore.Models
{
    public class Data
    {
        SqlConnection connection;

        public void StartConnection()
        {
            string strin = "server=rechargezap.cxefx3p4vv8b.us-east-2.rds.amazonaws.com,1433; Database=db_RechargeZapp;  USER ID=rechargezap;PASSWORD=nAFuOf7VJ6rGjdGh1Pdj; trusted_connection=false;";

            connection = new SqlConnection(strin);
            connection.Open();
        }
        public SqlConnection StartConnectionInTransaction()
        {
            string str = "server=rechargezap.cxefx3p4vv8b.us-east-2.rds.amazonaws.com,1433; Database=db_RechargeZapp;  USER ID=rechargezap;PASSWORD=nAFuOf7VJ6rGjdGh1Pdj; trusted_connection=false;";
            connection = new SqlConnection(str);
            connection.Open();
            return connection;
        }

        public void EndConnection()
        {
            connection.Close();
        }

        public DataSet RunSelectQuery(string sqlCon)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection);
            command.CommandTimeout = 100000;
            SqlDataAdapter data_A = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            data_A.Fill(ds);

            return ds;
        }

        public void RunInsUpDelQuery(string sqlCon)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection);
            command.ExecuteNonQuery();
        }

        public int RunInsUpDelQueryNew(string sqlCon)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection);
            int a = command.ExecuteNonQuery();
            return a;
        }
        public DataTable RunDataTableParam(string sql, SqlParameter[] sqlparam)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);

            for (int i = 0; i < sqlparam.Length; i++)
            {
                cmd.Parameters.Add(sqlparam[i]);
            }
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;
            }
            return dt;
        }

        public DataSet RunSelectQueryTrans(string sqlCon, SqlTransaction transaction)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection, transaction);
            SqlDataAdapter dataA = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            dataA.Fill(ds);

            return ds;
        }

        public void RunInsUpDelQueryTrans(string sqlCon, SqlTransaction transaction)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection, transaction);

            command.ExecuteNonQuery();

        }
        public void RunInsUpDelQueryTransProc(string sqlCon, SqlTransaction transaction, SqlParameter[] sqlparam)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection, transaction);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                command.Parameters.Add(sqlparam[i]);
            }
            command.ExecuteNonQuery();

        }
        public string RunInsUpDelQueryTransProcScalar(string sqlCon, SqlTransaction transaction, SqlParameter[] sqlparam)
        {
            SqlCommand command = new SqlCommand(sqlCon, connection, transaction);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                command.Parameters.Add(sqlparam[i]);
            }
            string s = command.ExecuteScalar().ToString();
            return s;

        }
        public DataTable RunDataTableProcedureTRans(string sql, SqlTransaction transaction, SqlParameter[] sqlparam)
        {
            SqlCommand cmd = new SqlCommand(sql, connection, transaction);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                cmd.Parameters.Add(sqlparam[i]);
            }
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        public DataSet RunDataSetProcedureTRans(string sql, SqlTransaction transaction, SqlParameter[] sqlparam)
        {
            SqlCommand cmd = new SqlCommand(sql, connection, transaction);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                cmd.Parameters.Add(sqlparam[i]);
            }
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                ds = null;
                throw;
            }
            return ds;
        }
        public DataTable RunDataTable(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandTimeout = 0;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        public DataTable RunDataTableProcedure(string sql, SqlParameter[] sqlparam)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                cmd.Parameters.Add(sqlparam[i]);
            }
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        public DataSet RunDataSetProcedure(string sql, SqlParameter[] sqlparam)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlparam.Length; i++)
            {
                cmd.Parameters.Add(sqlparam[i]);
            }
            //cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;
            }
            return dt;
        }
        public DataTable RunSelectQueryTTrans(string sql, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand(sql, connection, trans);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public string send_sms(string senders, string message)
        {


            string baseurl = "http://173.45.76.227/send.aspx?";
            WebRequest w = WebRequest.Create(baseurl);
            w.Method = "POST";
            w.ContentType = "application/x-www-form-urlencoded";
            string status = "";
            using (Stream requestStream = w.GetRequestStream())
            {

                byte[] buffer = new UTF8Encoding().GetBytes("username=AmbroCabs&pass=Lucknow01&route=trans1&senderid=AMBROC&numbers=" + senders + "&message=" + message);
                requestStream.Write(buffer, 0, buffer.Length);
            }
            using (HttpWebResponse r = (HttpWebResponse)w.GetResponse())
            {
                using (StreamReader reader = new StreamReader(r.GetResponseStream()))
                {
                    status = reader.ReadToEnd().ToString();

                }
            }




            return status;



        }

        public string SendMail(String to_Address, String Subject, String Body)
        {
            string Result = "";
            //try
            //{
            //    MailMessage mm = new MailMessage("mail@roundpaytech.com", to_Address);

            //    mm.Subject = Subject;
            //    mm.Body = Body;
            //    mm.IsBodyHtml = true;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "mail.roundpaytech.com";
            //    smtp.EnableSsl = true;
            //    NetworkCredential NetworkCred = new NetworkCredential();
            //    NetworkCred.UserName = "mail@roundpaytech.com";
            //    NetworkCred.Password = "Info@2015";
            //    smtp.UseDefaultCredentials = true;
            //    smtp.EnableSsl = false;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = 25;
            //    smtp.Send(mm);
            //    Result = "Mail Send";
            //}
            //catch (Exception ex)
            //{
            //    Result = ex.Message;
            //}

            try
            {
                //using (MailMessage mm = new MailMessage("info@teamrijent.com", str_email))
                //{
                //    mm.Subject = str_subject;
                //    mm.Body = str_body;
                //    //if (fuAttachment.HasFile)
                //    //{
                //    //    string FileName = Path.GetFileName(fuAttachment.PostedFile.FileName);
                //    //    mm.Attachments.Add(new Attachment(fuAttachment.PostedFile.InputStream, FileName));
                //    //}
                //    mm.IsBodyHtml = false;
                //    SmtpClient smtp = new SmtpClient();
                //    smtp.Host = "webmail.teamrijent.com";
                //    smtp.EnableSsl = true;
                //    NetworkCredential NetworkCred = new NetworkCredential("info@teamrijent.com", "Info@2020!");
                //    smtp.UseDefaultCredentials = true;
                //    smtp.Credentials = NetworkCred;
                //    smtp.Port = 25;
                //    smtp.Send(mm);
                //    //ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
                //   Insert_SendSMS(str_email,  "", str_body);
                //}
                String FROM = "noreply@rechargezap.in";
                String FROMNAME = "RechargeZap";

                // Replace recipient@example.com with a "To" address. If your account 
                // is still in the sandbox, this address must be verified.
                String TO = to_Address;

                // Replace smtp_username with your Amazon SES SMTP user name.
                String SMTP_USERNAME = "AKIAYU4RLSA3WP3G3EGL";

                // Replace smtp_password with your Amazon SES SMTP password.
                String SMTP_PASSWORD = "BA3jnwZsWmHt5a9KEC1v7Put5LENWpupPQaw2PdYcY8+";

                // (Optional) the name of a configuration set to use for this message.
                // If you comment out this line, you also need to remove or comment out
                // the "X-SES-CONFIGURATION-SET" header below.
                //String CONFIGSET = "ConfigSet";

                // If you're using Amazon SES in a region other than US West (Oregon), 
                // replace email-smtp.us-west-2.amazonaws.com with the Amazon SES SMTP  
                // endpoint in the appropriate AWS Region.
                String HOST = "email-smtp.us-east-2.amazonaws.com";

                // The port you will connect to on the Amazon SES SMTP endpoint. We
                // are choosing port 587 because we will use STARTTLS to encrypt
                // the connection.
                int PORT = 587;

                // The subject line of the email
                String SUBJECT = Subject;

                // The body of the email
                String BODY = Body;

                // Create and build a new MailMessage object
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(FROM, FROMNAME);
                message.To.Add(new MailAddress(TO));
                //message.Bcc.Add("reports@rechargezap.com");
                message.Bcc.Add("rechargezapreports@gmail.com");
                message.Subject = SUBJECT;
                message.Body = BODY;
                // Comment or delete the next line if you are not using a configuration set
                //message.Headers.Add("X-SES-CONFIGURATION-SET", CONFIGSET);

                using (var client = new System.Net.Mail.SmtpClient(HOST, PORT))
                {
                    // Pass SMTP credentials
                    client.Credentials =
                        new NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                    // Enable SSL encryption
                    client.EnableSsl = true;

                    // Try to send the message. Show status in console.
                    try
                    {
                        // Console.WriteLine("Attempting to send email...");
                        client.Send(message);
                        // Console.WriteLine("Email sent!");
                        Result = "Mail Sent";
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("The email was not sent.");
                        //Console.WriteLine("Error message: " + ex.Message);
                        Result = ex.Message.ToString();
                    }
                }
            }
            catch (Exception ep)
            {
                Result = ep.Message.ToString();

            }
            return Result;
        }
    }
}
