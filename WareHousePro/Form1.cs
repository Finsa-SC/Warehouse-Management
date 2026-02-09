using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHousePro.core.network;
using WareHousePro.core.util;
using System.Data.SqlClient;

namespace WareHousePro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = "SELECT user_id, username, role_id FROM users WHERE username = @u AND password_hash = @p";
            DBHelper.ExecuteReader(query, dr =>
            {
                UserSession.Login(
                    UserId: dr.GetInt32(0),
                    Username: dr.GetString(1),
                    RoleId: dr.GetInt32(2)
                );
                return true;
            },
            new SqlParameter("@u", txtUsername.Text),
            new SqlParameter("@p", txtPassword.Text)
            );
            if (UserSession.IsLoggedIn())
            {
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password incorrect", "Un-Authorization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
