using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
