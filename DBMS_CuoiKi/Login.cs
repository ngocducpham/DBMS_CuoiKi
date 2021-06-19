using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace DBMS_CuoiKi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlHelper.ConnectionString = $"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};" +
                $"User ID={txtUser.Text};Password={txtPassWord.Text}";
            if (!SqlHelper.TestConnection()) 
            {
                MessageBox.Show("Kết nối thất bại");
                return;
            }

            Hide();
            Main main = new Main(txtDatabase.Text);
            if (main.ShowDialog() == DialogResult.Cancel)
                Show();
        }
    }
}
