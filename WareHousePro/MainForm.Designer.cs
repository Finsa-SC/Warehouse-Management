namespace WareHousePro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnStorageUnit = new System.Windows.Forms.Button();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.pnlStaff = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnBookingList = new System.Windows.Forms.Button();
            this.pnlAct = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1946, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1857, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.Green;
            this.pnlAdmin.Controls.Add(this.btnDashboard);
            this.pnlAdmin.Controls.Add(this.btnUser);
            this.pnlAdmin.Controls.Add(this.btnWarehouse);
            this.pnlAdmin.Controls.Add(this.btnStorageUnit);
            this.pnlAdmin.Controls.Add(this.btnVoucher);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 55);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Padding = new System.Windows.Forms.Padding(1, 7, 0, 0);
            this.pnlAdmin.Size = new System.Drawing.Size(316, 1051);
            this.pnlAdmin.TabIndex = 1;
            this.pnlAdmin.Visible = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUser.FlatAppearance.BorderSize = 3;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.Green;
            this.btnUser.Location = new System.Drawing.Point(4, 93);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(307, 77);
            this.btnUser.TabIndex = 0;
            this.btnUser.Tag = "admin";
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.BackColor = System.Drawing.Color.White;
            this.btnWarehouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWarehouse.FlatAppearance.BorderSize = 3;
            this.btnWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouse.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnWarehouse.ForeColor = System.Drawing.Color.Green;
            this.btnWarehouse.Location = new System.Drawing.Point(4, 176);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(307, 77);
            this.btnWarehouse.TabIndex = 0;
            this.btnWarehouse.Tag = "admin";
            this.btnWarehouse.Text = "Warehouse Management";
            this.btnWarehouse.UseVisualStyleBackColor = false;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnStorageUnit
            // 
            this.btnStorageUnit.BackColor = System.Drawing.Color.White;
            this.btnStorageUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStorageUnit.FlatAppearance.BorderSize = 3;
            this.btnStorageUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorageUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnStorageUnit.ForeColor = System.Drawing.Color.Green;
            this.btnStorageUnit.Location = new System.Drawing.Point(4, 259);
            this.btnStorageUnit.Name = "btnStorageUnit";
            this.btnStorageUnit.Size = new System.Drawing.Size(307, 77);
            this.btnStorageUnit.TabIndex = 0;
            this.btnStorageUnit.Tag = "admin";
            this.btnStorageUnit.Text = "Storage Unit";
            this.btnStorageUnit.UseVisualStyleBackColor = false;
            this.btnStorageUnit.Click += new System.EventHandler(this.btnStorageUnit_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.BackColor = System.Drawing.Color.White;
            this.btnVoucher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnVoucher.FlatAppearance.BorderSize = 3;
            this.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnVoucher.ForeColor = System.Drawing.Color.Green;
            this.btnVoucher.Location = new System.Drawing.Point(4, 342);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(307, 77);
            this.btnVoucher.TabIndex = 0;
            this.btnVoucher.Tag = "admin";
            this.btnVoucher.Text = "Voucher Management";
            this.btnVoucher.UseVisualStyleBackColor = false;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.Color.Green;
            this.pnlStaff.Controls.Add(this.button5);
            this.pnlStaff.Controls.Add(this.btnBookingList);
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStaff.Location = new System.Drawing.Point(316, 55);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Padding = new System.Windows.Forms.Padding(1, 7, 0, 0);
            this.pnlStaff.Size = new System.Drawing.Size(316, 1051);
            this.pnlStaff.TabIndex = 3;
            this.pnlStaff.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(4, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(307, 77);
            this.button5.TabIndex = 0;
            this.button5.Tag = "staff";
            this.button5.Text = "Booking Creation";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBookingList
            // 
            this.btnBookingList.BackColor = System.Drawing.Color.White;
            this.btnBookingList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBookingList.FlatAppearance.BorderSize = 3;
            this.btnBookingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBookingList.ForeColor = System.Drawing.Color.Green;
            this.btnBookingList.Location = new System.Drawing.Point(4, 93);
            this.btnBookingList.Name = "btnBookingList";
            this.btnBookingList.Size = new System.Drawing.Size(307, 77);
            this.btnBookingList.TabIndex = 0;
            this.btnBookingList.Tag = "staff";
            this.btnBookingList.Text = "Booking List";
            this.btnBookingList.UseVisualStyleBackColor = false;
            this.btnBookingList.Click += new System.EventHandler(this.btnBookingList_Click);
            // 
            // pnlAct
            // 
            this.pnlAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAct.Location = new System.Drawing.Point(632, 55);
            this.pnlAct.Name = "pnlAct";
            this.pnlAct.Size = new System.Drawing.Size(1314, 1051);
            this.pnlAct.TabIndex = 4;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashboard.FlatAppearance.BorderSize = 3;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.Green;
            this.btnDashboard.Location = new System.Drawing.Point(4, 10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(307, 77);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Tag = "admin";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.pnlAct);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlStaff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlAdmin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStorageUnit;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.FlowLayoutPanel pnlStaff;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlAct;
        private System.Windows.Forms.Button btnBookingList;
        private System.Windows.Forms.Button btnDashboard;
    }
}