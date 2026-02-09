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
    public partial class WarehouseUC : UserControl
    {
        int WarehouseId = 0;
        public WarehouseUC()
        {
            InitializeComponent();
        }
        private void WarehouseUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        warehouse_id AS ID,
                        warehouse_code AS [Warehouse Code],
                        name AS [Warehouse Name],
                        city AS City,
                        is_active AS Status
                    FROM warehouses
                    WHERE name LIKE @n";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query, new SqlParameter("@n", "%"+txtSearch.Text+"%"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (existWarehouse())
            {
                MessageBox.Show("Warehouse is already added", "Exists Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO warehouses (warehouse_code, name, city, is_active) VALUES (@w, @n, @c, @i)";
            int i = DBHelper.ExecuteNonQuery(query, 
                new SqlParameter("@n", txtName.Text),
                new SqlParameter("@w", txtCode.Text),
                new SqlParameter("@c", txtCity.Text),
                new SqlParameter("@i", cmbStatus.SelectedIndex == 0?0:1)
            );
            if (i > 0)
            {
                MessageBox.Show("Success Insert new warehouse", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (WarehouseId > 0)
            {
                string query = "UPDATE warehouses SET warehouse_code = @cd, name = @n, city = @c WHERE warehouse_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id",WarehouseId),
                    new SqlParameter("@cd",txtCode.Text),
                    new SqlParameter("@n",txtName.Text),
                    new SqlParameter("@c",txtCity.Text)
                );
                if(i > 0)
                {
                    MessageBox.Show("Success Update new warehouse", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Select warehouse first to edit", "No selection data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (WarehouseId > 0)
            {
                string query = "UPDATE warehouses SET is_active = ~is_active WHERE warehouse_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", WarehouseId)
                );
                if (i > 0)
                {
                    MessageBox.Show("Success Update new warehouse", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Select warehouse first to edit", "No selection data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //util
        private void clear()
        {
            txtCity.Text = string.Empty;
            txtName.Text = string.Empty;
            txtCode.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            WarehouseId = 0;
            cmbStatus.Enabled = true;
        }


        //validation
        private bool existWarehouse()
        {
            string query = "SELECT COUNT(*) FROM warehouses WHERE name = @n";
            object exist = DBHelper.ExecuteScalar(query, new SqlParameter("@n", txtName.Text));
            return Convert.ToInt32(exist) > 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                WarehouseId = Convert.ToInt32(row.Cells["ID"].Value);
                txtCode.Text = row.Cells["Warehouse Code"].Value.ToString();
                txtName.Text = row.Cells["Warehouse Name"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                cmbStatus.SelectedIndex = Convert.ToBoolean(row.Cells["Status"].Value)?1:0;
                cmbStatus.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
