
namespace QLTS
{
    partial class Managerment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managerment));
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnRawmaterial = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.pnlManagament = new System.Windows.Forms.Panel();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOptions.Controls.Add(this.label1);
            this.pnlOptions.Controls.Add(this.btnStaff);
            this.pnlOptions.Controls.Add(this.btnRevenue);
            this.pnlOptions.Controls.Add(this.btnRawmaterial);
            this.pnlOptions.Controls.Add(this.btnSupplier);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(250, 532);
            this.pnlOptions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStaff
            // 
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.Location = new System.Drawing.Point(49, 426);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(156, 40);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Nhân Viên";
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnRevenue
            // 
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.Location = new System.Drawing.Point(49, 125);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(156, 44);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Doanh thu";
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevenue.UseVisualStyleBackColor = true;
            // 
            // btnRawmaterial
            // 
            this.btnRawmaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnRawmaterial.Image")));
            this.btnRawmaterial.Location = new System.Drawing.Point(49, 322);
            this.btnRawmaterial.Name = "btnRawmaterial";
            this.btnRawmaterial.Size = new System.Drawing.Size(156, 43);
            this.btnRawmaterial.TabIndex = 1;
            this.btnRawmaterial.Text = "Nguyên Liệu";
            this.btnRawmaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRawmaterial.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.Location = new System.Drawing.Point(49, 217);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(156, 46);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Nhà Cung Cấp";
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // pnlManagament
            // 
            this.pnlManagament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagament.Location = new System.Drawing.Point(250, 0);
            this.pnlManagament.Name = "pnlManagament";
            this.pnlManagament.Size = new System.Drawing.Size(861, 532);
            this.pnlManagament.TabIndex = 2;
            // 
            // Managerment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 532);
            this.Controls.Add(this.pnlManagament);
            this.Controls.Add(this.pnlOptions);
            this.Name = "Managerment";
            this.Text = "Quản Lý";
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnRawmaterial;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlManagament;
    }
}