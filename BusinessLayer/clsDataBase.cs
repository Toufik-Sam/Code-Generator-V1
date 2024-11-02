using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDataBase
    {
        public static DataTable GetAllDataBaseInfo()
        {
             return clsDataBaseInfo.GetAllServerDataBaseNames();
        }
        public static DataTable GetAllTablesByDataBaseName(string DataBaseName)
        {
            return clsDataBaseInfo.GetAllTablesListByDataBaseName(DataBaseName);
        }
        public static DataTable GetAllColumnByTableName(string TableName,string DataBaseName)
        {
            return clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
        }
        public static string GetTablePrimaryKeyByName(string TableName,String DataBaseName)
        {
            return clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName);
        } 
    }
}
