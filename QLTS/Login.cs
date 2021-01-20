using QLTS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.ToString();
            string password = txbPassword.Text.ToString();

            if (!String.IsNullOrEmpty(username) || !String.IsNullOrEmpty(password))
            {
                if (Login(username, password))
                {
                    int positionID = LoginDAO.Instance.GetPositionID(username);
                    MainForm f = new MainForm();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }
    }   
}
