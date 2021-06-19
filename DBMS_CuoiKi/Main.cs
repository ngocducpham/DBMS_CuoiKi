using DBMS_CuoiKi.Business;
using System;
using System.Windows.Forms;

namespace DBMS_CuoiKi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = HoaDon.Load();
                dgvNhanVien.DataSource = NhanVien.Load();
                dgvGiamGia.DataSource = GiamGia.Load();
                dgvAccount.DataSource = Account.Load();
            }
            catch { }
        }

        #region Tab NhanVien

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nv_txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            nv_txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            nv_txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            nv_txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void nv_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien.Add(nv_txtMaNV.Text, nv_txtHoTen.Text, nv_txtNgaySinh.Text, nv_txtSDT.Text);
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch { }
        }

        private void nv_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien.Update(nv_txtMaNV.Text, nv_txtHoTen.Text, nv_txtNgaySinh.Text, nv_txtSDT.Text);
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void nv_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien.Delete(nv_txtMaNV.Text);
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch { }
        }

        private void nv_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch { }
        }

        #endregion 

        #region Tab HoaDon

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hd_txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            hd_txtMaNV.Text = dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            hd_txtNgayLapHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
            hd_txtTongGiaTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            hd_txtMaGiamGia.Text = dgvHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void hd_btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.ThanhToan(hd_txtMaHD.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch { }
        }

        private void hd_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Add(hd_txtMaHD.Text, hd_txtMaNV.Text, hd_txtMaGiamGia.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch { }
        }

        private void hd_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Update(hd_txtMaHD.Text, hd_txtMaNV.Text, hd_txtMaGiamGia.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch { }
        }

        private void hd_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Delete(hd_txtMaHD.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch { }
        }

        private void hd_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch { }
        }

        #endregion

        #region Tab GiamGia

        private void dgvGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gg_txtMaGG.Text = dgvGiamGia.Rows[e.RowIndex].Cells[0].Value.ToString();
            gg_txtTienGiam.Text = dgvGiamGia.Rows[e.RowIndex].Cells[1].Value.ToString();
            gg_cbxDonVi.Text = dgvGiamGia.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void gg_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia.Add(gg_txtMaGG.Text, gg_txtTienGiam.Text, gg_cbxDonVi.Text);
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch { }
        }

        private void gg_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia.Update(gg_txtMaGG.Text, gg_txtTienGiam.Text, gg_cbxDonVi.Text);
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch { }
        }

        private void gg_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia.Delete(gg_txtMaGG.Text);
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch { }
        }

        private void gg_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch { }
        }

        #endregion 

        #region Tab KhachHang

        private void kh_btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void kh_btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void kh_btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void kh_btnReload_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Tab User

        private void user_btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                User.CreateUser(user_txtLoginName.Text, user_txtPassword.Text);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void user_btnGrant_Click(object sender, EventArgs e)
        {
            try
            {
                User.Grant(user_txtUser.Text, user_cbxPermission.Text, user_cbxObject.Text);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void user_btnRevoke_Click(object sender, EventArgs e)
        {
            try
            {
                User.Revoke(user_txtUser.Text, user_cbxPermission.Text, user_cbxObject.Text);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
