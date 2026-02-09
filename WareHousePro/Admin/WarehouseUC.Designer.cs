namespace WareHousePro.Admin
{
    partial class WarehouseUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(871, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(253, 71);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(588, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 71);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(312, 244);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(253, 71);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(39, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 71);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "In Active",
            "Active"});
            this.cmbStatus.Location = new System.Drawing.Point(41, 145);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(625, 53);
            this.cmbStatus.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1521, 675);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(839, 148);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(625, 50);
            this.txtCity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(42, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(840, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "City";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1150, 265);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(412, 50);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Tag = "nullable";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(839, 50);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(625, 50);
            this.txtName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(1151, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(42, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Warehouse Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(840, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Warehouse Name";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(47, 52);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(625, 50);
            this.txtCode.TabIndex = 7;
            // 
            // WarehouseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseUC";
            this.Size = new System.Drawing.Size(1600, 1051);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
    }
}
