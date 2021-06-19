using DBMS_CuoiKi.Business;
using System;
using System.Windows.Forms;

namespace DBMS_CuoiKi
{
    public partial class Main : Form
    {
        private string DataBase;
        public Main(string dataBase)
        {
            InitializeComponent();
            DataBase = dataBase;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = HoaDon.Load();
                dgvNhanVien.DataSource = NhanVien.Load();
                dgvGiamGia.DataSource = GiamGia.Load();
                dgvAccount.DataSource = Account.Load();
                dgvMonAn.DataSource = MonAn.Load();
                dgvChiTietHD.DataSource = ChiTietHoaDon.Load();
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
            nv_txtGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            nv_txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void nv_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien.Add(nv_txtMaNV.Text, nv_txtHoTen.Text, nv_txtNgaySinh.Text, nv_txtSDT.Text, nv_txtGioiTinh.Text, nv_txtLuong.Text);
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void nv_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien.Update(nv_txtMaNV.Text, nv_txtHoTen.Text, nv_txtNgaySinh.Text, nv_txtSDT.Text, nv_txtGioiTinh.Text, nv_txtLuong.Text);
                dgvNhanVien.DataSource = NhanVien.Load();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hd_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Add(hd_txtMaHD.Text, hd_txtMaNV.Text, hd_txtMaGiamGia.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hd_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Update(hd_txtMaHD.Text, hd_txtMaNV.Text, hd_txtMaGiamGia.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hd_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon.Delete(hd_txtMaHD.Text);
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hd_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = HoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gg_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia.Update(gg_txtMaGG.Text, gg_txtTienGiam.Text, gg_cbxDonVi.Text);
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gg_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GiamGia.Delete(gg_txtMaGG.Text);
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gg_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvGiamGia.DataSource = GiamGia.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Tab MonAn

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma_txtMaMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells[0].Value.ToString();
            ma_txtTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells[1].Value.ToString();
            ma_txtDonGia.Text = dgvMonAn.Rows[e.RowIndex].Cells[2].Value.ToString();
            ma_txtDonVi.Text = dgvMonAn.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ma_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn.Add(ma_txtMaMonAn.Text, ma_txtTenMonAn.Text, ma_txtDonGia.Text, ma_txtDonVi.Text);
                dgvMonAn.DataSource = MonAn.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ma_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn.Update(ma_txtMaMonAn.Text, ma_txtTenMonAn.Text, ma_txtDonGia.Text, ma_txtDonVi.Text);
                dgvMonAn.DataSource = MonAn.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ma_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn.Delelte(ma_txtMaMonAn.Text);
                dgvMonAn.DataSource = MonAn.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ma_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMonAn.DataSource = MonAn.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Tab CTHD
        private void dgvChiTietHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cthd_txtMaHD.Text = dgvChiTietHD.Rows[e.RowIndex].Cells[0].Value.ToString();
            cthd_txtMaMonAn.Text = dgvChiTietHD.Rows[e.RowIndex].Cells[1].Value.ToString();
            cthd_txtSoLuong.Text = dgvChiTietHD.Rows[e.RowIndex].Cells[2].Value.ToString();
            cthd_txtGhiChu.Text = dgvChiTietHD.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void cthd_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon.Add(cthd_txtMaHD.Text, cthd_txtMaMonAn.Text, cthd_txtSoLuong.Text, cthd_txtGhiChu.Text);
                dgvChiTietHD.DataSource = ChiTietHoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cthd_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon.Update(cthd_txtMaHD.Text, cthd_txtMaMonAn.Text, cthd_txtSoLuong.Text, cthd_txtGhiChu.Text);
                dgvChiTietHD.DataSource = ChiTietHoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cthd_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDon.Delete(cthd_txtMaHD.Text, cthd_txtMaMonAn.Text);
                dgvChiTietHD.DataSource = ChiTietHoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cthd_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvChiTietHD.DataSource = ChiTietHoaDon.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                User.CreateUser(user_txtLoginName.Text, user_txtPassword.Text, DataBase);
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
                User.Grant(user_txtUser.Text, user_cbxPermission.Text, user_cbxObject.Text, DataBase);
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
                User.Revoke(user_txtUser.Text, user_cbxPermission.Text, user_cbxObject.Text, DataBase);
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        #endregion

        #region Tab Account

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ac_txtUserID.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            ac_txtPass.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            ac_txtRole.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            ac_txtMaNV.Text = dgvAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void ac_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Account.Add(ac_txtUserID.Text, ac_txtPass.Text, ac_txtRole.Text, ac_txtMaNV.Text);
                dgvAccount.DataSource = Account.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ac_btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Account.Update(ac_txtUserID.Text, ac_txtPass.Text, ac_txtRole.Text, ac_txtMaNV.Text);
                dgvAccount.DataSource = Account.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ac_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Account.Delete(ac_txtUserID.Text);
                dgvAccount.DataSource = Account.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ac_btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = Account.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }
}
