namespace WareHousePro.Admin
{
    partial class DashboardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalUnit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBooking = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblInUse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPending = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtUtilization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtUtilization)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.lblWarehouse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 226);
            this.panel1.TabIndex = 0;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblWarehouse.ForeColor = System.Drawing.Color.White;
            this.lblWarehouse.Location = new System.Drawing.Point(56, 130);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(54, 58);
            this.lblWarehouse.TabIndex = 0;
            this.lblWarehouse.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Warehouse";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.lblTotalUnit);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(573, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 226);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalUnit
            // 
            this.lblTotalUnit.AutoSize = true;
            this.lblTotalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTotalUnit.ForeColor = System.Drawing.Color.White;
            this.lblTotalUnit.Location = new System.Drawing.Point(56, 130);
            this.lblTotalUnit.Name = "lblTotalUnit";
            this.lblTotalUnit.Size = new System.Drawing.Size(54, 58);
            this.lblTotalUnit.TabIndex = 0;
            this.lblTotalUnit.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Storage Units";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.lblTotalBooking);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1087, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 226);
            this.panel3.TabIndex = 0;
            // 
            // lblTotalBooking
            // 
            this.lblTotalBooking.AutoSize = true;
            this.lblTotalBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooking.ForeColor = System.Drawing.Color.White;
            this.lblTotalBooking.Location = new System.Drawing.Point(56, 130);
            this.lblTotalBooking.Name = "lblTotalBooking";
            this.lblTotalBooking.Size = new System.Drawing.Size(54, 58);
            this.lblTotalBooking.TabIndex = 0;
            this.lblTotalBooking.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Booking";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Controls.Add(this.lblConfirm);
            this.panel4.Controls.Add(this.lblInUse);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(56, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 226);
            this.panel4.TabIndex = 0;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(203, 100);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(54, 58);
            this.lblConfirm.TabIndex = 0;
            this.lblConfirm.Text = "0";
            // 
            // lblInUse
            // 
            this.lblInUse.AutoSize = true;
            this.lblInUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblInUse.ForeColor = System.Drawing.Color.White;
            this.lblInUse.Location = new System.Drawing.Point(151, 158);
            this.lblInUse.Name = "lblInUse";
            this.lblInUse.Size = new System.Drawing.Size(54, 58);
            this.lblInUse.TabIndex = 0;
            this.lblInUse.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "In Use:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmed: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Active Bookings";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Controls.Add(this.lblPending);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(573, 276);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 226);
            this.panel5.TabIndex = 0;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.Color.White;
            this.lblPending.Location = new System.Drawing.Point(56, 130);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(54, 58);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 41);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pending Request";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Controls.Add(this.lblTotalRevenue);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(1087, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 226);
            this.panel6.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(56, 130);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(54, 58);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(42, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 41);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total Revenue";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(61, 551);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(718, 467);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chtUtilization
            // 
            chartArea2.Name = "ChartArea1";
            this.chtUtilization.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtUtilization.Legends.Add(legend2);
            this.chtUtilization.Location = new System.Drawing.Point(817, 551);
            this.chtUtilization.Name = "chtUtilization";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtUtilization.Series.Add(series2);
            this.chtUtilization.Size = new System.Drawing.Size(718, 467);
            this.chtUtilization.TabIndex = 1;
            this.chtUtilization.Text = "chart1";
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chtUtilization);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1600, 1051);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtUtilization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBooking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblInUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtUtilization;
    }
}
