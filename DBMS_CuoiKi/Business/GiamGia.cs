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
    public class GiamGia
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadGiamGia", CommandType.StoredProcedure, null);
        }

        //sp_InsertGiamGia @magiamgia VARCHAR(50), @sotiengiam FLOAT, @donvitinh NVARCHAR(50)
        public static bool Add(string maGG,string tienGiam,string donVi)
        {
            SqlParameter para1 = new SqlParameter("@magiamgia", maGG);
            SqlParameter para2 = new SqlParameter("@sotiengiam", tienGiam);
            SqlParameter para3 = new SqlParameter("@donvitinh", donVi);

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertGiamGia", CommandType.StoredProcedure, para1, para2, para3);
        }

        //sp_UpdateGiamGia @magiamgia VARCHAR(50), @sotiengiam FLOAT, @donvitinh NVARCHAR(50)
        public static bool Update(string maGG, string tienGiam, string donVi)
        {
            SqlParameter para1 = new SqlParameter("@magiamgia", maGG);
            SqlParameter para2 = new SqlParameter("@sotiengiam", tienGiam);
            SqlParameter para3 = new SqlParameter("@donvitinh", donVi);

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateGiamGia", CommandType.StoredProcedure, para1, para2, para3);
        }

        //sp_DeleteGiamGiam @magiamgia VARCHAR(50)
        public static bool Delete(string maGG)
        {
            SqlParameter para1 = new SqlParameter("@magiamgia", maGG);

            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteGiamGiam", CommandType.StoredProcedure, para1);
        }
    }
}
