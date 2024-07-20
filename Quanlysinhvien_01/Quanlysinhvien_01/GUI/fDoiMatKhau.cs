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
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tk = txbTenDangNhap.Text.Trim();
            string mkcu = txbMKCu.Text.Trim();
            string mkmoi = txbMKMoi.Text.Trim();
            string xnmkmoi = txbXNMKMoi.Text.Trim();

            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mkcu) || string.IsNullOrEmpty(mkmoi)
                || string.IsNullOrEmpty(xnmkmoi))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mkmoi != xnmkmoi)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool isUpdated = BLL_TaiKhoan.Instance.DoiMatKhau(tk, mkmoi, mkcu);
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
