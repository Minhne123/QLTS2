
namespace QLTS
{
    partial class Supplier
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
            this.lsvSupplier = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.pnlInputSupplier = new System.Windows.Forms.Panel();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbSupplierName = new System.Windows.Forms.TextBox();
            this.txbSupplierAddress = new System.Windows.Forms.TextBox();
            this.txbSupplierEmail = new System.Windows.Forms.TextBox();
            this.txbSupplierPhone = new System.Windows.Forms.TextBox();
            this.txbSupplierID = new System.Windows.Forms.TextBox();
            this.lbSupplierEmail = new System.Windows.Forms.Label();
            this.lbSupplierName = new System.Windows.Forms.Label();
            this.lbSupplierAddress = new System.Windows.Forms.Label();
            this.lbSupplierPhone = new System.Windows.Forms.Label();
            this.lbSupplierID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlInputSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 596);
            this.panel1.TabIndex = 0;
            // 
            // lsvSupplier
            // 
            this.lsvSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSupplier.GridLines = true;
            this.lsvSupplier.HideSelection = false;
            this.lsvSupplier.Location = new System.Drawing.Point(0, 0);
            this.lsvSupplier.Name = "lsvSupplier";
            this.lsvSupplier.Size = new System.Drawing.Size(654, 596);
            this.lsvSupplier.TabIndex = 0;
            this.lsvSupplier.UseCompatibleStateImageBehavior = false;
            this.lsvSupplier.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Nhà Cung Cấp";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Nhà Cung Cấp";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa Chỉ";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điện Thoại";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // pnlInputSupplier
            // 
            this.pnlInputSupplier.Controls.Add(this.btnDelect);
            this.pnlInputSupplier.Controls.Add(this.btnEdit);
            this.pnlInputSupplier.Controls.Add(this.btnAdd);
            this.pnlInputSupplier.Controls.Add(this.txbSupplierName);
            this.pnlInputSupplier.Controls.Add(this.txbSupplierAddress);
            this.pnlInputSupplier.Controls.Add(this.txbSupplierEmail);
            this.pnlInputSupplier.Controls.Add(this.txbSupplierPhone);
            this.pnlInputSupplier.Controls.Add(this.txbSupplierID);
            this.pnlInputSupplier.Controls.Add(this.lbSupplierEmail);
            this.pnlInputSupplier.Controls.Add(this.lbSupplierName);
            this.pnlInputSupplier.Controls.Add(this.lbSupplierAddress);
            this.pnlInputSupplier.Controls.Add(this.lbSupplierPhone);
            this.pnlInputSupplier.Controls.Add(this.lbSupplierID);
            this.pnlInputSupplier.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInputSupplier.Location = new System.Drawing.Point(651, 0);
            this.pnlInputSupplier.Name = "pnlInputSupplier";
            this.pnlInputSupplier.Size = new System.Drawing.Size(460, 596);
            this.pnlInputSupplier.TabIndex = 1;
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(307, 445);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(94, 29);
            this.btnDelect.TabIndex = 12;
            this.btnDelect.Text = "Xóa";
            this.btnDelect.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(186, 445);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txbSupplierName
            // 
            this.txbSupplierName.Location = new System.Drawing.Point(186, 121);
            this.txbSupplierName.Name = "txbSupplierName";
            this.txbSupplierName.Size = new System.Drawing.Size(215, 27);
            this.txbSupplierName.TabIndex = 9;
            // 
            // txbSupplierAddress
            // 
            this.txbSupplierAddress.Location = new System.Drawing.Point(93, 195);
            this.txbSupplierAddress.Name = "txbSupplierAddress";
            this.txbSupplierAddress.Size = new System.Drawing.Size(308, 27);
            this.txbSupplierAddress.TabIndex = 8;
            // 
            // txbSupplierEmail
            // 
            this.txbSupplierEmail.Location = new System.Drawing.Point(79, 340);
            this.txbSupplierEmail.Name = "txbSupplierEmail";
            this.txbSupplierEmail.Size = new System.Drawing.Size(322, 27);
            this.txbSupplierEmail.TabIndex = 7;
            // 
            // txbSupplierPhone
            // 
            this.txbSupplierPhone.Location = new System.Drawing.Point(122, 266);
            this.txbSupplierPhone.Name = "txbSupplierPhone";
            this.txbSupplierPhone.Size = new System.Drawing.Size(279, 27);
            this.txbSupplierPhone.TabIndex = 6;
            // 
            // txbSupplierID
            // 
            this.txbSupplierID.Location = new System.Drawing.Point(186, 42);
            this.txbSupplierID.Name = "txbSupplierID";
            this.txbSupplierID.ReadOnly = true;
            this.txbSupplierID.Size = new System.Drawing.Size(215, 27);
            this.txbSupplierID.TabIndex = 5;
            // 
            // lbSupplierEmail
            // 
            this.lbSupplierEmail.AutoSize = true;
            this.lbSupplierEmail.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupplierEmail.Location = new System.Drawing.Point(9, 340);
            this.lbSupplierEmail.Name = "lbSupplierEmail";
            this.lbSupplierEmail.Size = new System.Drawing.Size(64, 27);
            this.lbSupplierEmail.TabIndex = 4;
            this.lbSupplierEmail.Text = "Email:";
            // 
            // lbSupplierName
            // 
            this.lbSupplierName.AutoSize = true;
            this.lbSupplierName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupplierName.Location = new System.Drawing.Point(9, 121);
            this.lbSupplierName.Name = "lbSupplierName";
            this.lbSupplierName.Size = new System.Drawing.Size(176, 27);
            this.lbSupplierName.TabIndex = 3;
            this.lbSupplierName.Text = "Tên Nhà Cung Cấp:";
            // 
            // lbSupplierAddress
            // 
            this.lbSupplierAddress.AutoSize = true;
            this.lbSupplierAddress.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupplierAddress.Location = new System.Drawing.Point(9, 195);
            this.lbSupplierAddress.Name = "lbSupplierAddress";
            this.lbSupplierAddress.Size = new System.Drawing.Size(78, 27);
            this.lbSupplierAddress.TabIndex = 2;
            this.lbSupplierAddress.Text = "Địa Chỉ:";
            // 
            // lbSupplierPhone
            // 
            this.lbSupplierPhone.AutoSize = true;
            this.lbSupplierPhone.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupplierPhone.Location = new System.Drawing.Point(9, 266);
            this.lbSupplierPhone.Name = "lbSupplierPhone";
            this.lbSupplierPhone.Size = new System.Drawing.Size(107, 27);
            this.lbSupplierPhone.TabIndex = 1;
            this.lbSupplierPhone.Text = "Điện Thoại:";
            // 
            // lbSupplierID
            // 
            this.lbSupplierID.AutoSize = true;
            this.lbSupplierID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSupplierID.Location = new System.Drawing.Point(9, 42);
            this.lbSupplierID.Name = "lbSupplierID";
            this.lbSupplierID.Size = new System.Drawing.Size(171, 27);
            this.lbSupplierID.TabIndex = 0;
            this.lbSupplierID.Text = "Mã Nhà Cung Cấp:";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 596);
            this.Controls.Add(this.pnlInputSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "Supplier";
            this.Text = "Nhà Cung Cấp";
            this.panel1.ResumeLayout(false);
            this.pnlInputSupplier.ResumeLayout(false);
            this.pnlInputSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlInputSupplier;
        private System.Windows.Forms.ListView lsvSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbSupplierName;
        private System.Windows.Forms.TextBox txbSupplierAddress;
        private System.Windows.Forms.TextBox txbSupplierEmail;
        private System.Windows.Forms.TextBox txbSupplierPhone;
        private System.Windows.Forms.TextBox txbSupplierID;
        private System.Windows.Forms.Label lbSupplierEmail;
        private System.Windows.Forms.Label lbSupplierName;
        private System.Windows.Forms.Label lbSupplierAddress;
        private System.Windows.Forms.Label lbSupplierPhone;
        private System.Windows.Forms.Label lbSupplierID;
    }
}