
namespace QLTS
{
    partial class Rawmaterial
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
            this.pnlListRawmaterial = new System.Windows.Forms.Panel();
            this.lsvRawmaterialList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.pnlManipulation = new System.Windows.Forms.Panel();
            this.btnDelect = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudMaterialAmount = new System.Windows.Forms.NumericUpDown();
            this.txbMaterialName = new System.Windows.Forms.TextBox();
            this.txbMaterialUnit = new System.Windows.Forms.TextBox();
            this.txbMaterialID = new System.Windows.Forms.TextBox();
            this.lbMaterialName = new System.Windows.Forms.Label();
            this.lbMaterialUnit = new System.Windows.Forms.Label();
            this.lbMaterialAmount = new System.Windows.Forms.Label();
            this.lbMaterialID = new System.Windows.Forms.Label();
            this.pnlListRawmaterial.SuspendLayout();
            this.pnlManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlListRawmaterial
            // 
            this.pnlListRawmaterial.Controls.Add(this.lsvRawmaterialList);
            this.pnlListRawmaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListRawmaterial.Location = new System.Drawing.Point(0, 0);
            this.pnlListRawmaterial.Name = "pnlListRawmaterial";
            this.pnlListRawmaterial.Size = new System.Drawing.Size(1124, 588);
            this.pnlListRawmaterial.TabIndex = 0;
            // 
            // lsvRawmaterialList
            // 
            this.lsvRawmaterialList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvRawmaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvRawmaterialList.FullRowSelect = true;
            this.lsvRawmaterialList.GridLines = true;
            this.lsvRawmaterialList.HideSelection = false;
            this.lsvRawmaterialList.Location = new System.Drawing.Point(0, 0);
            this.lsvRawmaterialList.Name = "lsvRawmaterialList";
            this.lsvRawmaterialList.Size = new System.Drawing.Size(1124, 588);
            this.lsvRawmaterialList.TabIndex = 0;
            this.lsvRawmaterialList.UseCompatibleStateImageBehavior = false;
            this.lsvRawmaterialList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Nguyên Liệu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Nguyên Liệu";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Vị";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // pnlManipulation
            // 
            this.pnlManipulation.Controls.Add(this.btnDelect);
            this.pnlManipulation.Controls.Add(this.btnEdit);
            this.pnlManipulation.Controls.Add(this.btnAdd);
            this.pnlManipulation.Controls.Add(this.nudMaterialAmount);
            this.pnlManipulation.Controls.Add(this.txbMaterialName);
            this.pnlManipulation.Controls.Add(this.txbMaterialUnit);
            this.pnlManipulation.Controls.Add(this.txbMaterialID);
            this.pnlManipulation.Controls.Add(this.lbMaterialName);
            this.pnlManipulation.Controls.Add(this.lbMaterialUnit);
            this.pnlManipulation.Controls.Add(this.lbMaterialAmount);
            this.pnlManipulation.Controls.Add(this.lbMaterialID);
            this.pnlManipulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlManipulation.Location = new System.Drawing.Point(0, 320);
            this.pnlManipulation.Name = "pnlManipulation";
            this.pnlManipulation.Size = new System.Drawing.Size(1124, 268);
            this.pnlManipulation.TabIndex = 1;
            // 
            // btnDelect
            // 
            this.btnDelect.Location = new System.Drawing.Point(646, 200);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(94, 29);
            this.btnDelect.TabIndex = 11;
            this.btnDelect.Text = "Xóa";
            this.btnDelect.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(489, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(325, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // nudMaterialAmount
            // 
            this.nudMaterialAmount.Location = new System.Drawing.Point(746, 101);
            this.nudMaterialAmount.Name = "nudMaterialAmount";
            this.nudMaterialAmount.Size = new System.Drawing.Size(100, 27);
            this.nudMaterialAmount.TabIndex = 8;
            // 
            // txbMaterialName
            // 
            this.txbMaterialName.Location = new System.Drawing.Point(202, 98);
            this.txbMaterialName.Name = "txbMaterialName";
            this.txbMaterialName.Size = new System.Drawing.Size(281, 27);
            this.txbMaterialName.TabIndex = 7;
            // 
            // txbMaterialUnit
            // 
            this.txbMaterialUnit.Location = new System.Drawing.Point(746, 47);
            this.txbMaterialUnit.Name = "txbMaterialUnit";
            this.txbMaterialUnit.Size = new System.Drawing.Size(281, 27);
            this.txbMaterialUnit.TabIndex = 6;
            // 
            // txbMaterialID
            // 
            this.txbMaterialID.Location = new System.Drawing.Point(202, 45);
            this.txbMaterialID.Name = "txbMaterialID";
            this.txbMaterialID.ReadOnly = true;
            this.txbMaterialID.Size = new System.Drawing.Size(281, 27);
            this.txbMaterialID.TabIndex = 5;
            // 
            // lbMaterialName
            // 
            this.lbMaterialName.AutoSize = true;
            this.lbMaterialName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaterialName.Location = new System.Drawing.Point(54, 98);
            this.lbMaterialName.Name = "lbMaterialName";
            this.lbMaterialName.Size = new System.Drawing.Size(142, 27);
            this.lbMaterialName.TabIndex = 4;
            this.lbMaterialName.Text = "Tên Ngyên Liệu";
            // 
            // lbMaterialUnit
            // 
            this.lbMaterialUnit.AutoSize = true;
            this.lbMaterialUnit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaterialUnit.Location = new System.Drawing.Point(671, 45);
            this.lbMaterialUnit.Name = "lbMaterialUnit";
            this.lbMaterialUnit.Size = new System.Drawing.Size(69, 27);
            this.lbMaterialUnit.TabIndex = 3;
            this.lbMaterialUnit.Text = "Đơn Vị";
            // 
            // lbMaterialAmount
            // 
            this.lbMaterialAmount.AutoSize = true;
            this.lbMaterialAmount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaterialAmount.Location = new System.Drawing.Point(647, 98);
            this.lbMaterialAmount.Name = "lbMaterialAmount";
            this.lbMaterialAmount.Size = new System.Drawing.Size(93, 27);
            this.lbMaterialAmount.TabIndex = 2;
            this.lbMaterialAmount.Text = "Số Lượng";
            // 
            // lbMaterialID
            // 
            this.lbMaterialID.AutoSize = true;
            this.lbMaterialID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMaterialID.Location = new System.Drawing.Point(49, 43);
            this.lbMaterialID.Name = "lbMaterialID";
            this.lbMaterialID.Size = new System.Drawing.Size(147, 27);
            this.lbMaterialID.TabIndex = 1;
            this.lbMaterialID.Text = "Mã Nguyên Liệu";
            // 
            // Rawmaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 588);
            this.Controls.Add(this.pnlManipulation);
            this.Controls.Add(this.pnlListRawmaterial);
            this.Name = "Rawmaterial";
            this.Text = "Nguyên Liệu";
            this.pnlListRawmaterial.ResumeLayout(false);
            this.pnlManipulation.ResumeLayout(false);
            this.pnlManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListRawmaterial;
        private System.Windows.Forms.Panel pnlManipulation;
        private System.Windows.Forms.ListView lsvRawmaterialList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbMaterialID;
        private System.Windows.Forms.Label lbMaterialName;
        private System.Windows.Forms.Label lbMaterialUnit;
        private System.Windows.Forms.Label lbMaterialAmount;
        private System.Windows.Forms.NumericUpDown nudMaterialAmount;
        private System.Windows.Forms.TextBox txbMaterialName;
        private System.Windows.Forms.TextBox txbMaterialUnit;
        private System.Windows.Forms.TextBox txbMaterialID;
        private System.Windows.Forms.Button btnDelect;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}