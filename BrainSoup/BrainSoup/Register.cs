using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BrainSoup
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string userkey;
        private void LoginPage_Load(object sender, EventArgs e)
        {
          

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
            if (NameT.Text == "")
            {
                nameProvider.SetError(NameT, "Bu Alan Boş Geçilemez");

            }
            if (Surname.Text == "")
            {
                surnameProvider.SetError(Surname, "Bu Alan Boş Geçilemez");

            }
            if (Email.Text == "")
            {
                mailProvider.SetError(Email, "Bu Alan Boş Geçilemez");
               
            }
            if (Password.Text == "")
            {
                passwordProvider.SetError(Password, "Bu Alan Boş Geçilemez");
                
            }
            if(NameT.Text !="" && Surname.Text!=""&&Email.Text !="" && Password.Text!="")
            {
                if (MailSender.GetValidEmail(Email.Text) == "valid" )
                {
                    if (Sql.EmailControl(Email.Text)==false)

                    {
                        Sql.Register(NameT.Text, Surname.Text, Email.Text, Password.Text); }
                   
                    else

                    {
                        Style.Error("Bu Mail Adresi Zaten Kullanılıyor");
                    }
                        
                }
                else
                    Style.Error("Lütfen Geçerli Bir Mail Adresi Giriniz");
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.Show();
            this.Close();
        }
    }
}
