using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DBMS_CuoiKi.Business
{
    public class Account
    {
        public static DataTable Load()
        {
            return SqlHelper.Execute("dbo.sp_LoadAccount", CommandType.StoredProcedure, null);
        }


        //sp_InsertAccount @userID VARCHAR(50), @pass nVARCHAR(50), @role VARCHAR(50), @manhanvien int
        public static bool Add(string userID, string pass, string role, string manhanvien)
        {
            SqlParameter para1 = new SqlParameter("@userID", userID);
            SqlParameter para2 = new SqlParameter("@pass", pass);
            SqlParameter para3 = new SqlParameter("@role", role);
            SqlParameter para4 = new SqlParameter("@manhanvien", manhanvien);

            return SqlHelper.ExecuteNonQuery("dbo.sp_InsertAccount", CommandType.StoredProcedure, para1, para2, para3,para4);
        }

        public static bool Update(string userID, string pass, string role, string manhanvien)
        {
            SqlParameter para1 = new SqlParameter("@userID", userID);
            SqlParameter para2 = new SqlParameter("@pass", pass);
            SqlParameter para3 = new SqlParameter("@role", role);
            SqlParameter para4 = new SqlParameter("@manhanvien", manhanvien);

            return SqlHelper.ExecuteNonQuery("dbo.sp_UpdateAccount", CommandType.StoredProcedure, para1, para2, para3, para4);
        }

        public static bool Delete(string userID)
        {
            SqlParameter para1 = new SqlParameter("@userID", userID);
            return SqlHelper.ExecuteNonQuery("dbo.sp_DeleteAccount", CommandType.StoredProcedure, para1);
        }
    }
}
