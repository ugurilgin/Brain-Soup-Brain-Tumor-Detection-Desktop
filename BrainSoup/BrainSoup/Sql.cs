using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static string Count(string query)
        {
            try
            { 
            string count = "";
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               count= dr[0].ToString();

            }

            dr.Close();
            con.Close();
            return count;
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
                return "0";
            }

        }
        public static void Mail(string email)
        {
            try { 
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
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }

        }
        public static bool EmailControl(string email)
        {
            try { 
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
                { return false; }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
                return false;
            }


        }
        public static void MRInfo(string TC)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;

            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT date,imgloc,tumorloc,result from tumor WHERE TC=@TC AND doctor=@doctor";
            cmd.Parameters.AddWithValue("@TC", TC);
            cmd.Parameters.AddWithValue("@doctor", UserInformation.UserKey);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MRInformation.date =  Convert.ToString(dr.GetString(1));
                MRInformation.imgLoc = ServerInformation.myHostName+"static/"+ Convert.ToString(dr.GetString(1));
                MRInformation.tumorLoc = ServerInformation.myHostName + "static/" + Convert.ToString(dr.GetString(2));
                if (Convert.ToString(dr.GetString(3)) == "Pozitif")
                { MRInformation.result = "Tümör Bulundu"; }
                else
                { MRInformation.result = "Tümör Bulunamadı"; }
               


            }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }


        }
        public static void UpdateMR(string query)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }

        }
        public static void PatientInfo(string TC)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;

            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * from patients WHERE TC = @TC AND doctor=@doctor";
            cmd.Parameters.AddWithValue("@TC",  TC);
            cmd.Parameters.AddWithValue("@doctor", UserInformation.UserKey);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PatientsInformation.TC = Convert.ToString(dr.GetString(1));
                PatientsInformation.name = Convert.ToString(dr.GetString(2));
                PatientsInformation.surname = Convert.ToString(dr.GetString(3));
                PatientsInformation.email = Convert.ToString(dr.GetString(4));
                PatientsInformation.birthdate = Convert.ToString(dr.GetString(5));
                PatientsInformation.cinsiyet = Convert.ToString(dr.GetString(9));

            }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }


        }
        public static void UserInfo()
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
           
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT name,surname,user_auth,email from users WHERE email = @email AND user_auth=@user_auth";
            cmd.Parameters.AddWithValue("@email", UserInformation.UserEmail);
            cmd.Parameters.AddWithValue("@user_auth", UserInformation.UserKey);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserInformation.UserName = Convert.ToString(dr.GetString(0));
                UserInformation.UserSurname = Convert.ToString(dr.GetString(1));
                UserInformation.UserKey = Convert.ToString(dr.GetString(2));
                UserInformation.UserEmail = Convert.ToString(dr.GetString(3));
               
       
            }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }


        }
        public static void Select(string query, DataGridView dataGridView)
        {
            try { 

            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }


        }
        public static void Login(string email,string password,Form login,CheckBox Remember)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            string userkey;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT name,surname,user_auth,email from users WHERE email = @email AND password=@password";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", Encryptor.MD5Hash(password));
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserInformation.UserName = Convert.ToString(dr.GetString(0));
                UserInformation.UserSurname = Convert.ToString(dr.GetString(1));
                UserInformation.UserKey = Convert.ToString(dr.GetString(2));
                UserInformation.UserEmail = Convert.ToString(dr.GetString(3));
                Main frm = new Main();
                frm.Show();
                login.Hide();
                if (Remember.Checked == true)
                {
                    using (StreamWriter sw = new StreamWriter(@"auth.txt", false))
                    {
                        sw.WriteLine(email);
                        sw.WriteLine(password);
                        sw.WriteLine("true");
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(@"auth.txt", false))
                    {
                        sw.WriteLine(email);
                        sw.WriteLine(password);
                        sw.WriteLine("false");
                        sw.Close();
                    }

                }
            }
            else
            {
                Style.Error("Kullanıcı Adı veya Şifre Hatalı");
            }
        }
        public static int isThere(string query)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            MySqlDataReader dr;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
                return 0;
            }

        }
        public static void UpdateUser(string name, string surname,  string password)
        {
            try
            {
                MySqlConnection con;
                MySqlCommand cmd;
                MySqlDataReader dr;
                cmd = new MySqlCommand();
                con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
                con.Open();
                cmd.Connection = con;
                if (password == "No")
                {
                    cmd.CommandText = "UPDATE users  SET name = @name ,surname = @surname WHERE email=@email AND user_auth=@user_auth ";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@email", UserInformation.UserEmail);

                    cmd.Parameters.AddWithValue("@user_auth", UserInformation.UserKey);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    cmd.CommandText = "UPDATE users  SET name = @name ,surname = @surname ,password = @password WHERE email=@email AND user_auth=@user_auth ";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@email", UserInformation.UserEmail);
                    string mypassword = Encryptor.MD5Hash(password);
                    cmd.Parameters.AddWithValue("@password", mypassword.ToLower());
                    cmd.Parameters.AddWithValue("@user_auth", UserInformation.UserKey);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (UserInformation.savedUser[2] == "true")
                    {
                        using (StreamWriter sw = new StreamWriter(@"auth.txt", false))
                        {
                            sw.WriteLine(UserInformation.UserEmail);
                            sw.WriteLine(password);
                            sw.WriteLine("true");
                            sw.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(@"auth.txt", false))
                        {
                            sw.WriteLine(UserInformation.UserEmail);
                            sw.WriteLine(password);
                            sw.WriteLine("false");
                            sw.Close();
                        }

                    }
                }
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }

        }

        public static void UpdatePatients(string id,string TC, string name, string surname, string cinsiyet, string birth, string email,string TCSearch)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
           
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE patients SET TC=@TC,name=@name,surname=@surname,email=@email,birthdate=@birthdate,cinsiyet=@cinsiyet WHERE id=@id AND TC=@TCsearch AND doctor=@doctor";
            cmd.Parameters.AddWithValue("@TC", TC);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@birthdate", birth);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@TCsearch", TCSearch);

            cmd.Parameters.AddWithValue("@doctor", UserInformation.UserKey);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }

        }
        public static void InsertPatients(string TC,string name,string surname,string cinsiyet,string birth,string email)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO patients ( TC,name, surname,email, birthdate, date,doctor, ban, cinsiyet) VALUES (@TC,@name,@surname,@email,@birthdate,@date,@doctor,'0',@cinsiyet)";
            cmd.Parameters.AddWithValue("@TC", TC);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@birthdate", birth);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.Date.ToString("dd/MM/yyyy"));
            cmd.Parameters.AddWithValue("@doctor", UserInformation.UserKey);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }

        }
        public static void DeletePatients(string id,string TC)
        {
            try { 
            MySqlConnection con;
            MySqlCommand cmd;
           
            cmd = new MySqlCommand();
            con = new MySqlConnection("Server=" + ServerInformation.server + ";Database=" + ServerInformation.database + ";Uid=" + ServerInformation.user + ";Pwd=" + ServerInformation.password + ";");
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE patients SET ban='1' WHERE id=@id AND TC=@TC AND doctor=@doctor";
            cmd.Parameters.AddWithValue("@TC", TC);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@doctor", UserInformation.UserKey);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
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
            cmd.Parameters.AddWithValue("@user_auth", userkey.ToLower());
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
