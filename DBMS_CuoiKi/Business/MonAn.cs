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
    public class MonAn
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadMonAn", CommandType.StoredProcedure, null);
        }

        //sp_InsertMonAn @mamonan INT, @tenmonan NVARCHAR(100), @dongia FLOAT, @donvitinh VARCHAR(10)
        public static bool Add(string maMonAn, string tenMonAn, string donGia, string donvi)
        {
            SqlParameter para1 = new SqlParameter("@mamonan", SqlDbType.Int);
            para1.Value = maMonAn;
            SqlParameter para2 = new SqlParameter("@tenmonan", SqlDbType.VarChar);
            para2.Value = tenMonAn;
            SqlParameter para3 = new SqlParameter("@dongia", SqlDbType.Float);
            para3.Value = donGia;
            SqlParameter para4 = new SqlParameter("@donvitinh", SqlDbType.VarChar);
            para4.Value = donvi;

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertMonAn", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Update(string maMonAn, string tenMonAn, string donGia, string donvi)
        {
            SqlParameter para1 = new SqlParameter("@mamonan", SqlDbType.Int);
            para1.Value = maMonAn;
            SqlParameter para2 = new SqlParameter("@tenmonan", SqlDbType.VarChar);
            para2.Value = tenMonAn;
            SqlParameter para3 = new SqlParameter("@dongia", SqlDbType.Float);
            para3.Value = donGia;
            SqlParameter para4 = new SqlParameter("@donvitinh",SqlDbType.VarChar);
            para4.Value = donvi;

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateMonAn", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Delelte(string maMonAn)
        {
            SqlParameter para1 = new SqlParameter("@mamonan", maMonAn);

            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteMonAn", CommandType.StoredProcedure, para1);
        }
    }
}
