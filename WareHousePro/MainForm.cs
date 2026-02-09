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
            loadUC(new Admin.UserManagementUC());
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
    }
}
