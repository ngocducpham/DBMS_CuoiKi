using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_CuoiKi.Business
{
    public class NhanVien
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadNhanVien", CommandType.StoredProcedure, null);
        }

        public static bool Add(string maNV, string hoTen, string ngaySinh, string soDT, string gioiTinh, string luong)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para2 = new SqlParameter("@hoten", hoTen);
            SqlParameter para3 = new SqlParameter("@ngaysinh", ngaySinh);
            SqlParameter para4 = new SqlParameter("@sodienthoai", soDT);
            SqlParameter para5 = new SqlParameter("@gioitinh", gioiTinh);
            SqlParameter para6 = new SqlParameter("@luong", luong);

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertNhanVien", CommandType.StoredProcedure, para1, para2, para3, para4, para5, para6);
        }

        public static bool Update(string maNV, string hoTen, string ngaySinh, string soDT, string gioiTinh, string luong)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para2 = new SqlParameter("@hoten", hoTen);
            SqlParameter para3 = new SqlParameter("@ngaysinh", ngaySinh);
            SqlParameter para4 = new SqlParameter("@sodienthoai", soDT);
            SqlParameter para5 = new SqlParameter("@gioitinh", SqlDbType.NVarChar);
            para5.Value = gioiTinh;
            SqlParameter para6 = new SqlParameter("@luong", SqlDbType.Int);
            para6.Value = luong;

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateNhanVien", CommandType.StoredProcedure, para1, para2, para3, para4, para5, para6);
        }

        public static bool Delete(string maNV)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);

            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteNhanVien", CommandType.StoredProcedure, para1);
        }
    }
}
