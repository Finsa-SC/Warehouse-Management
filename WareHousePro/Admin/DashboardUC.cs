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
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
            loadBox();
            loadChartBooking();
            loadUtilization();
        }

        private void loadBox()
        {
            lblWarehouse.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM warehouses WHERE is_active = 1").ToString();
            lblTotalUnit.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM storage_units WHERE is_active = 1").ToString();
            lblTotalBooking.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM bookings").ToString();
            lblConfirm.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM bookings WHERE status_code = 'CONFIRMED'").ToString();
            lblInUse.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM bookings WHERE status_code = 'IN_USE'").ToString();
            lblPending.Text = DBHelper.ExecuteScalar("SELECT COUNT(*) FROM bookings WHERE status_code = 'REQUESTED'").ToString();
            lblTotalRevenue.Text = DBHelper.ExecuteScalar("SELECT 'Rp ' + FORMAT(SUM(base_total), '#,##0') FROM booking_pricing").ToString();
        }

        private void loadChartBooking()
        {
            string query = @"
                    SELECT 
                    w.name AS [Warehouse Name],
                    COUNT(b.booking_id) AS [Total Booking]
                    FROM bookings b
                    JOIN warehouses w ON w.warehouse_id = b.warehouse_id
                    GROUP BY w.name";

            chart1.DataSource = DBHelper.ExecuteQuery(query);
            chart1.Series[0].YValueMembers = "Total Booking";
            chart1.Series[0].XValueMember = "Warehouse Name";
        }
        private void loadUtilization()
        {
            string query = @"
SELECT 
    w.name AS Warehouse, 
    CAST(
        COUNT(DISTINCT CASE WHEN b.status_code = 'IN_USE' 
              AND GETDATE() BETWEEN b.start_date AND b.end_date THEN b.unit_id END) * 100.0 
        / NULLIF(COUNT(DISTINCT u.unit_id), 0)
    AS DECIMAL(10,2)) AS Utilization
FROM warehouses w
JOIN storage_units u ON w.warehouse_id = u.warehouse_id
LEFT JOIN bookings b ON u.unit_id = b.unit_id
GROUP BY w.name";
            chtUtilization.DataSource = DBHelper.ExecuteQuery(query);
            chtUtilization.Series[0].YValueMembers = "Utilization";
            chtUtilization.Series[0].XValueMember = "Warehouse";
            chtUtilization.ChartAreas[0].AxisY.LabelStyle.Format = "{0}%";
            chtUtilization.DataBind();
        }
    }
}
