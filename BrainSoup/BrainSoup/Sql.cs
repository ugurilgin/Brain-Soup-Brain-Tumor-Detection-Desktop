using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;

namespace BrainSoup
{
   
    
    public static class ServerInformation
    {
        public static string server= "localhost";
        public static string database= "brainsoup";
        public static string user= "root";
        public static string password="";
        public static string myHostName = "http://192.168.1.70:5000/";
    }
    class Sql
    {
        public static void Mail(string email)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string userkey="";
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT user_auth from users WHERE email = @email";
            cmd.Parameters.AddWithValue("@email",email);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                userkey = Convert.ToString(dr.GetString(0));

            }
            string message = "Merhabalar,\n  Şifrenizi Yenilemek İçin Aşağıdaki Bağlantıyı Kullanabilirsiniz\n" + ServerInformation.myHostName + "resetpass/" + userkey + "\nİyi Günler Dileriz";
            MailSender.Send(email, "Brain Soup Şifre Yenileme İsteği", message);
        }
        public static bool EmailControl(string email)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string userkey;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT name,user_auth,email from users WHERE email = @email ";
            cmd.Parameters.AddWithValue("@email", email);
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;

            }
            else
                return false;
        }
        public static void Login(string email,string password)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string userkey;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT name,user_auth,email from users WHERE email = @email AND password=@password";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", Encryptor.MD5Hash(password));
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserInformation.UserName = Convert.ToString(dr.GetString(0));
                UserInformation.UserKey = Convert.ToString(dr.GetString(1));
                UserInformation.UserEmail = Convert.ToString(dr.GetString(2));

            }
        }
        public static void Register(string name,string surname,string email, string password)
        {
           
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string userkey;
            userkey = Encryptor.BuildSecureHexString(64);
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO users ( name, surname,email, password, ban, user_auth, admin) VALUES (@name,@surname,@email,@password,'0',@user_auth,'0')";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            string mypassword = Encryptor.MD5Hash(password);
            cmd.Parameters.AddWithValue("@password",mypassword.ToLower() );
            cmd.Parameters.AddWithValue("@user_auth", userkey);
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
