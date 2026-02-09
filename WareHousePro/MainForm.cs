using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHousePro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            role();
        }

        private void loadUC(UserControl uc)
        {
            pnlAct.Controls.Clear();
            pnlAct.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            loadUC(new Admin.UserManagementUC());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            loadUC(new Admin.WarehouseUC());
        }

        private void btnStorageUnit_Click(object sender, EventArgs e)
        {
            loadUC(new Admin.StorageUnitUC());
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            loadUC(new Admin.VoucherManagementUC());
        }

        //check role
        private void role()
        {
            switch (UserSession.roleId)
            {
                case 1:
                    pnlAdmin.Visible = true;
                    loadUC(new Admin.DashboardUC());
                    break;
                case 2:
                    pnlStaff.Visible = true;
                    loadUC(new Staff.BookingCreationUC());
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadUC(new Staff.BookingCreationUC());
        }

        private void btnBookingList_Click(object sender, EventArgs e)
        {
            loadUC(new Public.BookingListUC());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadUC(new Admin.DashboardUC());
        }
    }
}
