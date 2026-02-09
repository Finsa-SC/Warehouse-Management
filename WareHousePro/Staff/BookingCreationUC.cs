using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WareHousePro.core.network;
using WareHousePro.core.util;

namespace WareHousePro.Staff
{
    public partial class BookingCreationUC : UserControl
    {
        object BookingId = 0;
        public BookingCreationUC()
        {
            InitializeComponent();
        }
        //load
        private void BookingCreationUC_Load(object sender, EventArgs e)
        {
            loadCode();
            clear();
        }
        private void loadCode() 
        {
            string query = "SELECT unit_id, unit_code FROM storage_units";
            cmbWarehouse.DataSource = DBHelper.ExecuteQuery(query);
            cmbWarehouse.ValueMember = "unit_id";
            cmbWarehouse.DisplayMember = "unit_code";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidationHelper.hasNull(this, out string msg))
            {
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (inUseUnit())
            {
                MessageBox.Show("The Unit is still in use now", "Already use", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int voucher = 0;
            if (!string.IsNullOrWhiteSpace(txtVoucher.Text))
            {
                voucher = getVoucher();
                if (voucher == 0) {
                    MessageBox.Show("Invalid Voucher");
                    return;
                }
            }

            string query = @"
                    BEGIN TRANSACTION;
                    BEGIN TRY

                        DECLARE @BookingId INT;
                        DECLARE @wid INT;
                        DECLARE @uid INT;

                        SELECT @wid = warehouse_id, @uid = unit_id FROM storage_units WHERE unit_id = @unitId

                        INSERT INTO bookings (booking_code, warehouse_id, unit_id, requested_capacity, start_date, end_date, status_code, created_by, created_at)
                        VALUES (@code, @wid, @uid, @rc, @sd, @ed, 'REQUESTED', @cb, GETDATE())

                        SET @BookingId = SCOPE_IDENTITY();

                        IF(@voucher != 0)
                        BEGIN
                            INSERT INTO booking_vouchers (booking_id, voucher_id) VALUES (@BookingId, @voucher)

                            UPDATE vouchers SET used_count = used_count + 1 WHERE voucher_id = @voucher
                        END

                        COMMIT TRANSACTION;
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                        THROW;
                    END CATCH
";
            int i = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@code", CodeBuilder.createCode("SELECT MAX(booking_code) FROM bookings", "BK-")),
                new SqlParameter("@unitId", cmbWarehouse.SelectedValue),
                new SqlParameter("@rc", Convert.ToInt32(txtCapacity.Text)),
                new SqlParameter("@sd", dteStart.Value),
                new SqlParameter("@ed", dteEnd.Value),
                new SqlParameter("@cb", UserSession.id),
                new SqlParameter("@voucher", voucher)
            );
            if (i > 0)
            {
                MessageBox.Show("Success Booking Unit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }



        //util
        private void clear()
        {
            txtCapacity.Clear();
            txtVoucher.Clear();
            cmbWarehouse.SelectedIndex = -1;
            dteEnd.Value = DateTime.UtcNow;
            dteStart.Value = DateTime.UtcNow;
        }



        //validation
        private bool inUseUnit()
        {
            string query = "SELECT COUNT(*) FROM bookings WHERE unit_id = @uid AND status_code = 'IN_USE'";
            object used = DBHelper.ExecuteScalar(query, new SqlParameter("@uid", cmbWarehouse.SelectedValue));
            return Convert.ToInt32(used) > 0;
        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.onlyNumber(e, out string msg);
            if (!string.IsNullOrWhiteSpace(msg))
            {
                MessageBox.Show("Only number available in this input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int getVoucher()
        {
            string query = @"
                    SELECT voucher_id 
                    FROM vouchers 
                    WHERE code = @code 
                    AND used_count < max_usage
                    AND GETDATE() >= valid_from
                    AND GETDATE() <= valid_to
                    AND is_active = 1;";
            object voucher = DBHelper.ExecuteScalar(query, new SqlParameter("@code", txtVoucher.Text.Trim()));
            if (voucher == null || voucher is null || voucher == DBNull.Value) return 0;
            return Convert.ToInt32(voucher);
        }
    }
}
