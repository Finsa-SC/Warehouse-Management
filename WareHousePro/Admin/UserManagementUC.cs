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

namespace WareHousePro.Admin
{
    public partial class UserManagementUC : UserControl
    {
        public UserManagementUC()
        {
            InitializeComponent();
        }

        private void UserManagementUC_Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        u.user_id AS ID,
                        u.username As Username, 
                        u.password_hash AS pw,
                        r.role_code AS Role,
                        u.is_active AS Status,
                        u.created_at AS [Created At]
                    FROM users u
                    LEFT JOIN roles r
                    WHERE is_active = 1
                        AND u.username LIKE @u";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
