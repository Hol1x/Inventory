using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            // this checks textbox 1 and textbox 2 are the correct login length for user name and password
            if ((UsernameBox.Text.Length <= 4) || (passwordBox.Text.Length <= 4))
            {
                //Tells the user that the user name or password is not the correct length
                MessageBox.Show("Username or password is not the correct length", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            //this is the username and password
            if ((UsernameBox.Text == ConfigurationSettings.AppSettings["MasterUsername"]) && (passwordBox.Text == ConfigurationSettings.AppSettings["MasterPassword"]))
            {
                //tells the user that there login details are correct
                MessageBox.Show("Login information correct!");
                this.Hide();
                excelImportForm frm = new excelImportForm();
                frm.ShowDialog();
                this.Close();
                
            }
            else
            {
                //tells the user that there login details are not correct
                MessageBox.Show("Incorrect Login Details\n Please try again");
            }
        }
    }
}
