using DataAccess;
using System.Data;

namespace DBMS_CuoiKi.Business
{
    public class User
    {
        public static bool CreateUser(string loginName, string passWord,string dataBase)
        {
            return SqlHelper.ExecuteNonQuery($"CREATE LOGIN {loginName} WITH PASSWORD = '{passWord}'\nUSE {dataBase}\n" +
                $"CREATE USER {loginName} FOR LOGIN {loginName}", CommandType.Text, null);          
        }

        public static bool Grant(string user,string permission, string table, string dataBase)
        {
            return SqlHelper.ExecuteNonQuery($"USE {dataBase}\nGRANT {permission} ON {table} TO {user}", CommandType.Text, null);
        }

        public static bool Revoke(string user, string permission, string table, string dataBase)
        {
            return SqlHelper.ExecuteNonQuery($"USE {dataBase}\nREVOKE {permission} ON {table} FROM {user}", CommandType.Text, null);
        }
    }
}
