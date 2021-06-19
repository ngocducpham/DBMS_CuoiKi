using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace DBMS_CuoiKi.DataAccess
{
    class Example
    {
        private void CallProcedure()
        {
            // procedure @para varchar(100)
            // nap value vo paramenter @para
            SqlParameter parameter1 = new SqlParameter("@para", "value");

            // resutl la 1 table
            SqlHelper.Execute("procedure", CommandType.StoredProcedure, parameter1);
            // result chi co 1 gia tri
            SqlHelper.ExecuteScalar("procedure", CommandType.StoredProcedure, parameter1);

            // khong paramenter
            SqlHelper.Execute("procedure", CommandType.StoredProcedure, null);
        }

        private void CallFunction()
        {
            // function(@para varchar(100)) => return varchar
            SqlParameter parameter1 = new SqlParameter("@para", "value");

            // tao 1 bien chua ket qua
            SqlParameter res = new SqlParameter("@res", SqlDbType.VarChar);
            res.Direction = ParameterDirection.ReturnValue;

            // lay ket qua, gia tri nhan duoc o trong bien res
            SqlHelper.ExecuteScalar("function", CommandType.StoredProcedure, parameter1, res);
            // ep khieu bien res phu hop voi kieu tra ve
            // return (string)res
        }

        private void Query()
        {
            // query tra ve bang nhieu qua tri
            SqlHelper.Execute("select * from table", CommandType.Text, null);
        }
    }
}
