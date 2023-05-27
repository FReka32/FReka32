using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace raktarprogram
{
    public partial class Form1 : Form
    {
        public static bool be = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("User.txt");
            string bekertnev = username.Text;
            string bekertjelszo = password.Text;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] darabok = sor.Split(' ');
                string user = darabok[0];
                string password = darabok[1];
                if( user == bekertnev && password == bekertjelszo)
                {
                    be = true;
                    errormessage.Visible = false;
                }
                else 
                {
                    errormessage.Visible = true;
                }
            }
            sr.Close();
            
            if(be)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
    }
}
