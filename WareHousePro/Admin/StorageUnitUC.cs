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

namespace WareHousePro.Admin
{
    public partial class StorageUnitUC : UserControl
    {
        int StorageId=0;
        public StorageUnitUC()
        {
            InitializeComponent();
        }

        //load
        private void StorageUnitTypeUC_Load(object sender, EventArgs e)
        {
            loadData();
            loadWareHouse();
            loadType();
            clear();
        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        s.unit_code AS [Unit Code],
                        w.name AS Warehouse,
                        t.type_name AS [Storage Type],
                        s.capacity AS Capacity,
                        'Rp ' + FORMAT( s.base_price_per_day, '#,##0') AS [Base Price /D],
                        s.is_active AS Status
                    FROM storage_units s
                    JOIN warehouses w ON w.warehouse_id = s.warehouse_id
                    JOIN storage_unit_types t ON t.type_id = s.type_id
                    WHERE w.name LIKE @n";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query, new SqlParameter("@n", "%" + txtSearch.Text + "%"));
        }
        private void loadWareHouse()
        {
            string query = "SELECT warehouse_id, name FROM warehouses WHERE is_active = 1";
            cmbWarehouse.DataSource = DBHelper.ExecuteQuery(query);
            cmbWarehouse.DisplayMember = "name";
            cmbWarehouse.ValueMember = "warehouse_id";
        }
        private void loadType()
        {
            string query = "SELECT type_id, type_name FROM storage_unit_types";
            cmbType.DataSource = DBHelper.ExecuteQuery(query);
            cmbType.DisplayMember = "type_name";
            cmbType.ValueMember = "type_id";
        }


        //TextBox
        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyNumber(e, out string msg);
            if (!string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (existCode())
            {
                MessageBox.Show("Unit code already exist", "Exist data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = @"
                    INSERT 
                    INTO storage_units (warehouse_id, type_id, unit_code, capacity, base_price_per_day) 
                    VALUES (@w, @t, @u, @c, @b)";
            string price = txtPrice.Text.Replace("Rp ", "").Replace(",", "");

            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@w", cmbWarehouse.SelectedValue),
                new SqlParameter("@t", cmbType.SelectedValue),
                new SqlParameter("@u", txtCode.Text),
                new SqlParameter("@c", Convert.ToInt32(txtCapacity.Text)),
                new SqlParameter("@b", Convert.ToDecimal(price))
            );
            if (i > 0)
            {
                MessageBox.Show("Success insert unit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (StorageId > 0)
            {
                string price = txtPrice.Text.Replace("Rp ", "").Replace(",", "");

                string query = "UPDATE storage_units SET warehouse_id = @w, type_id = @t, capacity = @c, base_price_per_day = @b WHERE unit_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", StorageId),
                    new SqlParameter("@w", cmbWarehouse.SelectedValue),
                    new SqlParameter("@t", cmbType.SelectedValue),
                    new SqlParameter("@c", Convert.ToInt32(txtCapacity.Text)),
                    new SqlParameter("@b", Convert.ToDecimal(price))
                );
                if(i> 0)
                {
                    MessageBox.Show("Success update unit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Select unit first to edit", "No selection data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(StorageId > 0)
            {
                string query = "UPDATE storage_units SET is_active = ~is_active WHERE unit_id = @id";
                int i = DBHelper.ExecuteNonQuery(query, new SqlParameter("@id", StorageId));
                if(i > 0)
                {
                    MessageBox.Show("Success insert unit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Select unit first to edit", "No selection data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //util
        private void clear()
        {
            txtCapacity.Clear();
            txtCode.Clear();
            txtPrice.Clear();
            cmbType.SelectedIndex = -1;
            cmbWarehouse.SelectedIndex = -1;
            StorageId = 0;

            txtCode.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cmbWarehouse.SelectedIndex = cmbWarehouse.FindStringExact(row.Cells["Warehouse"].Value.ToString());
                cmbType.SelectedIndex = cmbType.FindStringExact(row.Cells["Storage Type"].Value.ToString());
                txtCode.Text = row.Cells["Unit Code"].Value.ToString();
                txtCapacity.Text = row.Cells["Capacity"].Value.ToString();
                txtPrice.Text = row.Cells["Base Price /D"].Value.ToString();

                txtCode.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }



        //validation
        private bool existCode()
        {
            string query = "SELECT COUNT(*) FROM storage_units WHERE unit_code = @u";
            object unit = DBHelper.ExecuteScalar(query, new SqlParameter("@u", txtCode.Text));
            return Convert.ToInt32(unit) > 0;
        }
    }
}
