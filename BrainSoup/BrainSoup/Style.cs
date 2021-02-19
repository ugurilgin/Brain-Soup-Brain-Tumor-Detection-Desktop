using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSoup
{
    class Opener
    {
        public static void Login(Form main)
        {
            LoginPage frm = new LoginPage();
            frm.Show();
            main.Close();

        }
        public static void Register(Form main)
        {

            Register frm = new Register();
            frm.Show();
            main.Hide();
        }
        public static void PatientPage(Form main)
        {
            PatientPage frm = new PatientPage();
            frm.Show();
            main.Close();

        }
        public static void UnsavedPage(Form main)
        {
            if (Sql.isThere("SELECT * from tumor WHERE TC='00000000000' AND doctor='" + UserInformation.UserKey + "'") == 1)
            {
                UnsavedPage frm = new UnsavedPage();
                frm.Show();
                main.Close();
            }
            else
            {
                Style.Error("Kaydedilmemiş Kayıt Bulunamadı");
            }
           

        }
        public static void MRView(Form main)
        {
            MRViewPage frm = new MRViewPage();
            frm.Show();
            main.Close();

        }
        public static void MRPredict(Form main)
        {
            PredictPage frm = new PredictPage();
            frm.Show();
            main.Close();

        }
        public static void Report(Form main)
        {


        }
        public static void Profile(Form main)
        {
            ProfilePage frm = new ProfilePage();
            frm.Show();
            main.Close();

        }
        public static void Main(Form main)
        {
            Main frm = new Main();
            frm.Show();
            main.Close();

        }
    }
    class ErrorInformation 
    {
        public static string Message { get; set; }
        public static string Title { get; set; }
        public static string Image { get; set; }
    }
    class Style
    {
        public static FormWindowState formState { get; set; }
        public static void Minimize(Form frm)
        {
            frm.WindowState = FormWindowState.Minimized;
        }
        public static void Maximize(Form frm)
        {

            if (frm.WindowState == FormWindowState.Maximized)
            {
                frm.WindowState = FormWindowState.Normal;

                
                frm.Width = Screen.PrimaryScreen.Bounds.Width-40; 
                frm.Height = Screen.PrimaryScreen.Bounds.Height - 40;
                formState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterScreen;

            }
            else
            {
                frm.WindowState = FormWindowState.Maximized;
              
                formState = FormWindowState.Maximized;


            }

        }
        public static void Error( string message)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string allpath = path + "img/error.png";
            Error frm = new Error();
            ErrorInformation.Title = "Hata";
            ErrorInformation.Message = message;
            ErrorInformation.Image = allpath;
            frm.Show();
        
        }
        public static void Message(string message)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string allpath = path + "img/info.png";
            Error frm = new Error();
            ErrorInformation.Title = "Mesaj";
            ErrorInformation.Message = message;
            ErrorInformation.Image = allpath;
            frm.Show();

        }
    }
    class Draggable
    {
        public static Point lastLocation { get; set; }
        public static bool mouseDown { get; set; }
        public static void MouseMove(Point lastLocation, bool mouseDown, Form frm, MouseEventArgs e)
        {
            if (mouseDown)
            {
                frm.Location = new Point(
                    (frm.Location.X - lastLocation.X) + e.X, (frm.Location.Y - lastLocation.Y) + e.Y);

                frm.Update();
            }
        }
    }

}
