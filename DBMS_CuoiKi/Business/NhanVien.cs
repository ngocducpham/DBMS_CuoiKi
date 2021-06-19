using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;

namespace DBMS_CuoiKi.Business
{
    public class NhanVien
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadNhanVien", CommandType.StoredProcedure, null);
        }

        public static bool Add(string maNV, string hoTen, string ngaySinh, string soDT)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para2 = new SqlParameter("@hoten", hoTen);
            SqlParameter para3 = new SqlParameter("@ngaysinh", ngaySinh);
            SqlParameter para4 = new SqlParameter("@sodienthoai", soDT);

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertNhanVien", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Update(string maNV, string hoTen, string ngaySinh, string soDT)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);
            SqlParameter para2 = new SqlParameter("@hoten", hoTen);
            SqlParameter para3 = new SqlParameter("@ngaysinh", ngaySinh);
            SqlParameter para4 = new SqlParameter("@sodienthoai", soDT);

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateNhanVien", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Delete(string maNV)
        {
            SqlParameter para1 = new SqlParameter("@manhanvien", maNV);

            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteNhanVien", CommandType.StoredProcedure, para1);
        }
    }
}
