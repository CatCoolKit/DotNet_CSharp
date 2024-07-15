using Quanlysinhvien_01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlysinhvien_01.GUI
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();

            if (BLL_TaiKhoan.Instance.DangNhap(tendangnhap, matkhau) == true)
            {
                if (Hethong.LOAITAIKHOAN != "Sinh Viên")
                {
                    txbMatKhau.Clear();
                    fSinhVien f = new fSinhVien();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không được cấp quyền để vào đây!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
