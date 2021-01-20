
namespace QLTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.cbxSwitchtables = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSwitchtables = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnManagerment = new System.Windows.Forms.Button();
            this.pnlTables = new System.Windows.Forms.Panel();
            this.lstViewTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lstViewBill = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numbericAmount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.pnlOptions.SuspendLayout();
            this.pnlTables.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOptions.Controls.Add(this.cbxSwitchtables);
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnSwitchtables);
            this.pnlOptions.Controls.Add(this.btnAccount);
            this.pnlOptions.Controls.Add(this.btnManagerment);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(250, 547);
            this.pnlOptions.TabIndex = 0;
            // 
            // cbxSwitchtables
            // 
            this.cbxSwitchtables.FormattingEnabled = true;
            this.cbxSwitchtables.Location = new System.Drawing.Point(49, 393);
            this.cbxSwitchtables.Name = "cbxSwitchtables";
            this.cbxSwitchtables.Size = new System.Drawing.Size(151, 28);
            this.cbxSwitchtables.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(47, 496);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(156, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSwitchtables
            // 
            this.btnSwitchtables.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchtables.Image")));
            this.btnSwitchtables.Location = new System.Drawing.Point(49, 349);
            this.btnSwitchtables.Name = "btnSwitchtables";
            this.btnSwitchtables.Size = new System.Drawing.Size(156, 38);
            this.btnSwitchtables.TabIndex = 2;
            this.btnSwitchtables.Text = "Chuyển bàn";
            this.btnSwitchtables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSwitchtables.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.Location = new System.Drawing.Point(49, 222);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(156, 44);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnManagerment
            // 
            this.btnManagerment.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerment.Image")));
            this.btnManagerment.Location = new System.Drawing.Point(49, 111);
            this.btnManagerment.Name = "btnManagerment";
            this.btnManagerment.Size = new System.Drawing.Size(156, 47);
            this.btnManagerment.TabIndex = 0;
            this.btnManagerment.Text = "Quản Lý";
            this.btnManagerment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagerment.UseVisualStyleBackColor = true;
            // 
            // pnlTables
            // 
            this.pnlTables.BackColor = System.Drawing.Color.White;
            this.pnlTables.Controls.Add(this.lstViewTable);
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(250, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(470, 547);
            this.pnlTables.TabIndex = 2;
            // 
            // lstViewTable
            // 
            this.lstViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewTable.GridLines = true;
            this.lstViewTable.HideSelection = false;
            this.lstViewTable.Location = new System.Drawing.Point(0, 0);
            this.lstViewTable.Name = "lstViewTable";
            this.lstViewTable.Size = new System.Drawing.Size(470, 547);
            this.lstViewTable.TabIndex = 0;
            this.lstViewTable.UseCompatibleStateImageBehavior = false;
            this.lstViewTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Khu Vực";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số bàn";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái sử dụng";
            this.columnHeader3.Width = 155;
            // 
            // lstViewBill
            // 
            this.lstViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstViewBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstViewBill.GridLines = true;
            this.lstViewBill.HideSelection = false;
            this.lstViewBill.Location = new System.Drawing.Point(0, 0);
            this.lstViewBill.Name = "lstViewBill";
            this.lstViewBill.Size = new System.Drawing.Size(406, 353);
            this.lstViewBill.TabIndex = 0;
            this.lstViewBill.UseCompatibleStateImageBehavior = false;
            this.lstViewBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên nước uống";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn giá";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.Width = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.numbericAmount);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.tbxTotal);
            this.panel2.Controls.Add(this.cbxMenu);
            this.panel2.Controls.Add(this.cbxCategory);
            this.panel2.Controls.Add(this.lstViewBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 547);
            this.panel2.TabIndex = 1;
            // 
            // numbericAmount
            // 
            this.numbericAmount.Location = new System.Drawing.Point(15, 393);
            this.numbericAmount.Name = "numbericAmount";
            this.numbericAmount.Size = new System.Drawing.Size(379, 27);
            this.numbericAmount.TabIndex = 6;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(15, 496);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(379, 29);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(379, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thên Món";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(15, 463);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(379, 27);
            this.tbxTotal.TabIndex = 3;
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(214, 359);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(180, 28);
            this.cbxMenu.TabIndex = 2;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(15, 359);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(193, 28);
            this.cbxCategory.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 547);
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOptions);
            this.Name = "MainForm";
            this.Text = "Quản Lý Quán Trà Sữa";
            this.pnlOptions.ResumeLayout(false);
            this.pnlTables.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.ListView lstViewTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstViewBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.NumericUpDown numbericAmount;
        private System.Windows.Forms.ComboBox cbxSwitchtables;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSwitchtables;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnManagerment;
    }
}