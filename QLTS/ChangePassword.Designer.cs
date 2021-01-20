
namespace QLTS
{
    partial class ChangePassword
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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.tbxReEnter = new System.Windows.Forms.TextBox();
            this.tbxOrdPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbReEnter = new System.Windows.Forms.Label();
            this.lbOldPass = new System.Windows.Forms.Label();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOptions.Controls.Add(this.btnCancel);
            this.pnlOptions.Controls.Add(this.btnSave);
            this.pnlOptions.Controls.Add(this.tbxNewPass);
            this.pnlOptions.Controls.Add(this.tbxReEnter);
            this.pnlOptions.Controls.Add(this.tbxOrdPass);
            this.pnlOptions.Controls.Add(this.lbNewPass);
            this.pnlOptions.Controls.Add(this.lbReEnter);
            this.pnlOptions.Controls.Add(this.lbOldPass);
            this.pnlOptions.Location = new System.Drawing.Point(132, 68);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(604, 351);
            this.pnlOptions.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(377, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 39);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(55, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Location = new System.Drawing.Point(184, 124);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(358, 27);
            this.tbxNewPass.TabIndex = 16;
            this.tbxNewPass.UseSystemPasswordChar = true;
            // 
            // tbxReEnter
            // 
            this.tbxReEnter.Location = new System.Drawing.Point(184, 192);
            this.tbxReEnter.Name = "tbxReEnter";
            this.tbxReEnter.Size = new System.Drawing.Size(358, 27);
            this.tbxReEnter.TabIndex = 15;
            this.tbxReEnter.UseSystemPasswordChar = true;
            // 
            // tbxOrdPass
            // 
            this.tbxOrdPass.Location = new System.Drawing.Point(184, 52);
            this.tbxOrdPass.Name = "tbxOrdPass";
            this.tbxOrdPass.Size = new System.Drawing.Size(358, 27);
            this.tbxOrdPass.TabIndex = 14;
            this.tbxOrdPass.UseSystemPasswordChar = true;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoEllipsis = true;
            this.lbNewPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNewPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNewPass.Location = new System.Drawing.Point(26, 118);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(179, 37);
            this.lbNewPass.TabIndex = 5;
            this.lbNewPass.Text = "Mật Khẩu Mới:";
            // 
            // lbReEnter
            // 
            this.lbReEnter.AutoEllipsis = true;
            this.lbReEnter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbReEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbReEnter.Location = new System.Drawing.Point(26, 192);
            this.lbReEnter.Name = "lbReEnter";
            this.lbReEnter.Size = new System.Drawing.Size(152, 37);
            this.lbReEnter.TabIndex = 4;
            this.lbReEnter.Text = "Nhập Lại:";
            // 
            // lbOldPass
            // 
            this.lbOldPass.AutoEllipsis = true;
            this.lbOldPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOldPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbOldPass.Location = new System.Drawing.Point(26, 46);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(179, 37);
            this.lbOldPass.TabIndex = 3;
            this.lbOldPass.Text = "Mật Khẩu Cũ:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 581);
            this.Controls.Add(this.pnlOptions);
            this.Name = "ChangePassword";
            this.Text = "Đổi Mật Khẩu";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbReEnter;
        private System.Windows.Forms.Label lbOldPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.TextBox tbxReEnter;
        private System.Windows.Forms.TextBox tbxOrdPass;
    }
}