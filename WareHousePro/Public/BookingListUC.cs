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

namespace WareHousePro.Public
{
    public partial class BookingListUC : UserControl
    {
        public BookingListUC()
        {
            InitializeComponent();
        }
        private void BookingListUC_Load(object sender, EventArgs e)
        {
            loadData();
            cmbStatus.SelectedIndex = 0;
            timer1.Start();
        }
        private void loadData()
        {
            if (cmbStatus.SelectedItem == null) return;
            string query = @"
                    SELECT 
                        b.booking_code AS Code,
                        w.name AS [Warehouse Name],
                        t.type_name AS Type,
                        b.requested_capacity AS Capacity,
                        FORMAT(b.start_date, 'hhhh,dd MMMM yyyy') AS [Start Date],
                        FORMAT(b.end_date, 'hhhh,dd MMMM yyyy') AS [End Date],
                        b.status_code AS Status,
                        u.username AS Username
                    FROM bookings b
                    JOIN warehouses w ON w.warehouse_id = b.warehouse_id
                    JOIN storage_units un ON un.unit_id = b.unit_id
                    JOIN storage_unit_types t ON t.type_id = un.type_id
                    JOIN users u ON u.user_id = b.created_by
                    WHERE w.name LIKE @n
                        AND (@s = 'All' OR b.status_code = @s)
                        AND @sd >= b.start_date
                        AND @ed <= b.end_date";
            dataGridView1.DataSource = DBHelper.ExecuteQuery(query,
                new SqlParameter("@n", "%" + txtWarehouse.Text + "%"),
                new SqlParameter("@sd", dteStart.Value),
                new SqlParameter("@ed", dteEnd.Value),
                new SqlParameter("@s", cmbStatus.SelectedItem)
            );
            addDetail();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            loadData();
        }

        private void addDetail()
        {
            if (dataGridView1.Columns.Contains("btnDetail")) return;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnDetail";
            btn.Text = "Detail";
            btn.HeaderText = "Action";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDetail")
                {
                    BookingDetailForm form = new BookingDetailForm();
                    form.ShowDialog();
                }
            }
        }
    }
}
