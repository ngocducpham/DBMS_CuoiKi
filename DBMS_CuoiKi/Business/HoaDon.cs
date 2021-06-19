using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_CuoiKi.Business
{
    public class HoaDon
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadHoaDon", CommandType.StoredProcedure, null);
        }

        public static bool ThanhToan(string maHD)
        {
            SqlParameter para = new SqlParameter("@mahoadon", maHD);
            return SqlHelper.ExecuteNonQuery("dbo.sp_ThanhToanHoaDon", CommandType.StoredProcedure, para);
        }

        //sp_InsertHoaDon @mahoadon VARCHAR(50), @manhanvien VARCHAR(50), @magiamgia VARCHAR(50)
        public static bool Add(string maHD, string maNV, string maGG)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", maHD);
            SqlParameter para2 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para3 = new SqlParameter("@magiamgia", maGG);

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertHoaDon", CommandType.StoredProcedure, para1, para2, para3);
        }

        public static bool Update(string maHD, string maNV, string maGG)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", maHD);
            SqlParameter para2 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para3 = new SqlParameter("@magiamgia", maGG);

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateHoaDon", CommandType.StoredProcedure, para1, para2, para3);
        }

        public static bool Delete(string maHD)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", maHD);
            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteHoaDon", CommandType.StoredProcedure, para1);
        }
    }
}
