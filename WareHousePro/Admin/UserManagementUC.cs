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
using System.Data.SqlClient;
using WareHousePro.core.util;

namespace WareHousePro.Admin
{
    public partial class UserManagementUC : UserControl
    {
        int UserId = 0;
        public UserManagementUC()
        {
            InitializeComponent();
        }

        //load data
        private void UserManagementUC_Load(object sender, EventArgs e)
        {
            loadData();
            loadRole();
            clear();
        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        u.user_id AS ID,
                        u.username As Username, 
                        u.password_hash AS pw,
                        r.role_code AS Role,
                        u.role_id,
                        u.is_active AS Status,
                        FORMAT(u.created_at, 'dddd, dd MMMM yyyy') AS [Created At]
                    FROM users u
                    LEFT JOIN roles r ON r.role_id = u.role_id
                    WHERE is_active = 1
                        AND u.username LIKE @s";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@s", "%"+txtSearch.Text+"%")
            );
            if (dataGridView1.Columns.Contains("role_id")) dataGridView1.Columns["role_id"].Visible = false;
            if (dataGridView1.Columns.Contains("pw")) dataGridView1.Columns["pw"].Visible = false;
        }

        private void loadRole()
        {
            string query = "SELECT role_id, role_code FROM roles";
            cmbRole.DataSource = DBHelper.ExecuteQuery(query);
            cmbRole.DisplayMember = "role_code";
            cmbRole.ValueMember = "role_id";
        }

        //button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (userExist())
            {
                MessageBox.Show("Username already taken", "Exist data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string query = @"
                    INSERT 
                    INTO users (username, password_hash, role_id, is_active, created_at) 
                    VALUES (@u, @p, @r, 1, GETDATE())";
            int i = DBHelper.ExecuteNonQuery(query, 
                new SqlParameter("@u", txtUsername.Text),
                new SqlParameter("@p", txtPassword.Text),
                new SqlParameter("@r", cmbRole.SelectedValue)
            );
            if (i > 0)
            {
                MessageBox.Show("Success Insert user", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ValidationHelper.hasNull(this, out string msg)){
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(UserId > 0)
            {
                string query = "UPDATE users SET username = @u, password_hash = @p, role_id = @r, is_active = @i WHERE user_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", UserId),
                    new SqlParameter("@u", txtUsername.Text),
                    new SqlParameter("@p", txtPassword.Text),
                    new SqlParameter("@r", cmbRole.SelectedValue),
                    new SqlParameter("@i", cmbStatus.SelectedIndex == 0?0:1)
                );
                if(i > 0)
                {
                    MessageBox.Show("Success Update user", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("No user selected to update", "Ambigous", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (UserId > 0)
            {
                string query = "UPDATE users SET is_active = 0 WHERE user_id = @id";
                int i = DBHelper.ExecuteNonQuery(query, new SqlParameter("@id", UserId));
                if(i > 0)
                {
                    MessageBox.Show("Success Deleting user", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("No user selected to delete", "Ambigous", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserId = Convert.ToInt32(row.Cells["Id"].Value);
                txtPassword.Text = row.Cells["pw"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                cmbRole.SelectedValue = row.Cells["role_id"].Value.ToString();
                cmbStatus.SelectedIndex = Convert.ToBoolean(row.Cells["Status"].Value)?1:0;
            }
        }


        //util
        private void clear()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            UserId = 0;
        }


        //valiation
        private bool userExist()
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @u";
            object user = DBHelper.ExecuteScalar(query, new SqlParameter("@u", txtUsername.Text));
            return Convert.ToInt32(user) > 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
