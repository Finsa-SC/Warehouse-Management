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
    public partial class VoucherManagementUC : UserControl
    {
        int VoucherId = 0;
        public VoucherManagementUC()
        {
            InitializeComponent();
        }
        private void VoucherManagementUC_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string query = @"
                    SELECT 
                        voucher_id AS ID,
                        code AS Code,
                        discount_type AS [Discount Type],
                        discount_value AS [Discount Value],
                        max_usage AS [Max Usage],
                        used_count AS Used,
                        valid_from AS [Valid From],
                        valid_to AS [Valid To],
                        is_active AS Status
                    FROM vouchers 
                    WHERE is_active = 1";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query);
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyNumber(e, out string msg);
            if (!string.IsNullOrWhiteSpace(msg)) MessageBox.Show("Only number available for this input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //button
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!validDate())
            {
                MessageBox.Show("Invalid date value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (existCode())
            {
                MessageBox.Show("Exist code Already Exists", "Exist data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = @"
                    INSERT INTO vouchers (code, discount_type, discount_value, max_usage, used_count, valid_from, valid_to, is_active) 
                    VALUES (@c, @dt, @dv, @mu, 0, @vf, @vt, 1)";
            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@c", txtCode.Text),
                new SqlParameter("@dt", cmbType.SelectedItem),
                new SqlParameter("@dv", txtValue.Text),
                new SqlParameter("@mu", Convert.ToInt32(txtMax.Text)),
                new SqlParameter("@vf", dteFrom.Value),
                new SqlParameter("@vt", dteTo.Value)
            );
            if (i > 0)
            {
                MessageBox.Show("Success insert new voucher", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(VoucherId > 0)
            {
                string query = "UPDATE vouchers SET discount_type = @dt, max_usage = @mu, discount_value = @dv, valid_from = @vf, valid_to = @vt WHERE voucher_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", VoucherId),
                    new SqlParameter("@dt", cmbType.SelectedItem),
                    new SqlParameter("@dv", Convert.ToDecimal(txtValue.Text)),
                    new SqlParameter("@mu", Convert.ToInt32(txtMax.Text)),
                    new SqlParameter("@vf", dteFrom.Value),
                    new SqlParameter("@vt", dteTo.Value)
                );
                if (i > 0)
                {
                    MessageBox.Show("Success update new voucher", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Select unit first to edit", "No selection data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (VoucherId > 0)
            {
                string query = "UPDATE vouchers SET is_active = 0 WHERE voucher_id = @id";
                int i = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", VoucherId)
                );
                if (i > 0)
                {
                    MessageBox.Show("Success delete new voucher", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadData();
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
            txtCode.Clear();
            txtMax.Clear();
            txtUsed.Clear();
            txtValue.Clear();
            cmbType.SelectedIndex = -1;
            dteFrom.Value = DateTime.UtcNow;
            dteTo.Value = DateTime.UtcNow;
            VoucherId = 0;

            txtCode.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                VoucherId = Convert.ToInt32(row.Cells["ID"].Value);
                txtCode.Text = row.Cells["Code"].Value.ToString();
                cmbType.SelectedIndex = cmbType.FindStringExact(row.Cells["Discount Type"].Value.ToString());
                txtValue.Text = row.Cells["Discount Value"].Value.ToString();
                txtMax.Text = row.Cells["Max Usage"].Value.ToString();
                txtUsed.Text = row.Cells["Used"].Value.ToString();
                dteFrom.Value = Convert.ToDateTime(row.Cells["Valid From"].Value);
                dteTo.Value = Convert.ToDateTime(row.Cells["Valid To"].Value);
                txtCode.Enabled = false;
            }
        }


        //validation
        private bool validDate()
        {
            if (dteFrom.Value > dteTo.Value) return false;
            return true;
        }
        private bool existCode()
        {
            string query = "SELECT COUNT(*) FROM vouchers WHERE code = @c";
            object code = DBHelper.ExecuteScalar(query, new SqlParameter("@c", txtCode.Text));
            return Convert.ToInt32(code) > 0;
        }
    }
}
