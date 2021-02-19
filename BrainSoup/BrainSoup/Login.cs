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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace BrainSoup
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string userkey;
        private void LoginPage_Load(object sender, EventArgs e)
        {
            Style.formState = FormWindowState.Normal;
            string yol = System.AppDomain.CurrentDomain.BaseDirectory;
            UserInformation.savedUser = System.IO.File.ReadAllLines(yol + "auth.txt");
            if(UserInformation.savedUser[2]=="true")
            { 
            Email.Text = UserInformation.savedUser[0];
            Password.Text = UserInformation.savedUser[1];
            Remember.Checked = true;
            }
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                string allpath = path + "auth.txt";
                if (Email.Text == "")
                {
                    mailProvider.SetError(Email, "Bu Alan Boş Geçilemez");

                }
                if (Password.Text == "")
                {
                    passwordProvider.SetError(Password, "Bu Alan Boş Geçilemez");

                }
                if (Email.Text != "" && Password.Text != "")
                {
                    Sql.Login(Email.Text, Password.Text, this, Remember);





                }
                else
                    Style.Error("Lütfen Tüm Alanları Doldurunuz");
            }
            catch
            {
                Style.Error("Veritabanına Bağlanılamıyor");
            }


        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void LoginPage_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Draggable.MouseMove(Draggable.lastLocation, Draggable.mouseDown, this, e);
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = false;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            Draggable.mouseDown = true;
            Draggable.lastLocation = e.Location;
        }

        private void Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            if (Email.Text == "")
            {
                mailProvider.SetError(Email, "Bu Alan Boş Geçilemez");
                Style.Error("Lütfen Mail Adresinizi Giriniz");
                passwordProvider.Clear();
            }
            else
            {
                mailProvider.Clear();
                Sql.Mail(Email.Text);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opener.Register(this);
        }
    }
}
