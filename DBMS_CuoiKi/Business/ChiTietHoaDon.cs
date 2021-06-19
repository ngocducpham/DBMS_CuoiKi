using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_CuoiKi.Business
{
    public class ChiTietHoaDon
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadChiTietHoaDon", CommandType.StoredProcedure, null);
        }

        //sp_InsertChiTietHoaDon @mahoadon INT, @mamonan INT, @soluong INT, @ghichu NVARCHAR(200)
        public static bool Add(string maHD, string mamonan, string soluong, string ghichu)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", SqlDbType.Int);
            para1.Value = maHD;
            SqlParameter para2 = new SqlParameter("@mamonan", SqlDbType.Int);
            para2.Value = mamonan;
            SqlParameter para3 = new SqlParameter("@soluong", SqlDbType.Int);
            para3.Value = soluong;
            SqlParameter para4 = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            para4.Value = ghichu;

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertChiTietHoaDon", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Update(string maHD, string mamonan, string soluong, string ghichu)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", SqlDbType.Int);
            para1.Value = maHD;
            SqlParameter para2 = new SqlParameter("@mamonan", SqlDbType.Int);
            para2.Value = mamonan;
            SqlParameter para3 = new SqlParameter("@soluong", SqlDbType.Int);
            para3.Value = soluong;
            SqlParameter para4 = new SqlParameter("@ghichu", SqlDbType.NVarChar);
            para4.Value = ghichu;

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateChiTietHoaDon", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Delete(string maHD, string mamonan)
        {
            SqlParameter para1 = new SqlParameter("@mahoadon", SqlDbType.Int);
            para1.Value = maHD;
            SqlParameter para2 = new SqlParameter("@mamonan", SqlDbType.Int);
            para2.Value = mamonan;

            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteChiTietHoaDon", CommandType.StoredProcedure, para1, para2);
        }
    }
}
