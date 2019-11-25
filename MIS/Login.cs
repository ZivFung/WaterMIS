using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }
        public void ButtonNormalUser_Click(object sender, EventArgs e)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
            mainform.Authority = 1;
            
            
        }

        private void ButtonAdministrator_Click(object sender, EventArgs e)
        {
            if (Admin_logkey_TextBox.Text == "123456")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
                mainform.Authority = 0;
            }
            else
            {
                MessageBox.Show("密码错误请重试！");
                Admin_logkey_TextBox.Clear();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Admin_logkey_TextBox.Focus();
        }
    }
}
