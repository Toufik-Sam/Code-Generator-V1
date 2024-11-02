using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDataAccessLayerGenerator
    {
        public static string GenrateClassDataGetItemInfoByKeys(string DataBaseName, string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumn = clsDataBase.GetAllColumnByTableName(TableName, DataBaseName);
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(TableName, DataBaseName);
            s.Append("public static GetItemInfoByPrimaryKey" + clsUtility.AttributesLoopWithRef(_dtColumn, PrimaryKey));
            s.Append("{\n");
            s.Append("bool isFound=false;\n");
            s.Append("using(sqlconnection connection=new sqlconnection(clsDataAccessSettings.GetDataBaseConnectionStringByName(" +
                DataBaseName + ")))\n");
            s.Append("{\n");
            s.Append("connection.Open();\n");
            s.Append("string query=Select * From " + TableName + " Where " + PrimaryKey + "=@" + PrimaryKey+";\n");
            s.Append("using(sqlcommand command=new sqlcommand(query,connection))\n");
            s.Append("{\n");
            s.Append("command.Parameters.AddWithValue(@" + PrimaryKey + "," + PrimaryKey + ");\n");
            s.Append("using(sqlReader reader=command.ExecuteReader())\n");
            s.Append("{\n");
            s.Append("if(reader.Read())\n");
            s.Append("{\n");
            s.Append("isFound=true;\n");
            s.Append(clsUtility.FillReaderStatement(_dtColumn, PrimaryKey));
            s.Append("}\n");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("return isFound\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenrateClassDataAddNew(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumn = clsDataBase.GetAllColumnByTableName(TableName, DataBaseName);
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(TableName, DataBaseName);
            s.AppendLine("public static int AddNew" + clsUtility.AttributesLoop(_dtColumn, PrimaryKey));
            s.Append("{\n");
            s.Append("int ID=-1\n");
            s.Append("using(sqlconnection connection=new sqlconnection(clsDataAccessSettings.GetDataBaseConnectionStringByName(" +
                DataBaseName + ")))\n");
            s.Append("{\n");
            s.Append("connection.Open();\n");
            s.Append("string query="+clsUtility.InsertIntoStatement(_dtColumn,PrimaryKey,TableName));
            s.Append("using(sqlcommand command=new sqlcommand(query,connection))\n");
            s.Append("{\n");
            s.Append(clsUtility.FillAddWithValueStatements(_dtColumn,PrimaryKey));
            s.Append("object result=command.ExecuteScalar();\n");
            s.Append("if(result!=null && int.TryParse(result.ToString(),out int InsertedID))\n");
            s.Append("ID=InsertedID;\n");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("return ID\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassDataUpdate(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumns = clsDataBase.GetAllColumnByTableName(TableName, DataBaseName);
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(TableName, DataBaseName);
            s.Append("public static bool Update" + clsUtility.AttributesLoop(_dtColumns, ""));
            s.Append("{\n");
            s.Append("int rowsAffected=0;\n");
            s.Append("using(sqlconnection connection=new sqlconnection(clsDataAccessSettings.GetDataBaseConnectionStringByName(" +
                DataBaseName + ")))\n");
            s.Append("{\n");
            s.Append("connection.Open();\n");
            s.Append("string query=" + clsUtility.UpdateStatement(_dtColumns, PrimaryKey, TableName));
            s.Append("using(sqlcommand=new sqlcommand(query,connection))\n");
            s.Append("{\n");
            s.Append("command.Parameters.AddWithValue(@" + PrimaryKey + "," + PrimaryKey + ");\n");
            s.Append(clsUtility.FillAddWithValueStatements(_dtColumns, PrimaryKey));
            s.Append("rowsAffected=command.ExecuteNonQuery();\n");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("return rowsAffected>0;\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassDataDelete(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(TableName, DataBaseName);
            s.Append("public static bool Delete(int " + PrimaryKey + ")\n");
            s.Append("{\n");
            s.Append("int rowsAffected=0;\n");
            s.Append("using(sqlconnection connection=new sqlconnection(clsDataAccessSettings.GetDataBaseConnectionStringByName(" +
                DataBaseName + ")))\n");
            s.Append("{\n");
            s.Append("connection.Open();\n");
            s.Append("string query=" + clsUtility.DeletStatement(PrimaryKey, TableName));
            s.Append("using(sqlcommand=new sqlcommand(query,connection))\n");
            s.Append("{\n");
            s.Append("command.Parameters.AddWithValue(@" + PrimaryKey + "," + PrimaryKey + ");\n");
            s.Append("rowsAffected=command.ExecuteNonQuery();\n");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("return rowsAffected>0;\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassDataGetAllItems(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("public static DataTable GetAllItems()\n");
            s.Append("{\n");
            s.Append("DataTable dt=new DataTable();\n");
            s.Append("using(sqlconnection connection=new sqlconnection(clsDataAccessSettings.GetDataBaseConnectionStringByName(" 
                +DataBaseName+ ")))\n");
            s.Append("{\n");
            s.Append("connection.Open();\n");
            s.Append("string query=Select * From "+TableName+";\n");
            s.Append("using(sqlcommand=new sqlcommand(query,connection))\n");
            s.Append("{\n");
            s.Append("using(sqlReader reader=command.ExecuteReader())\n");
            s.Append("{\n");
            s.Append("if(reader.HasRows)\n");
            s.Append("dt.load(reader)");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("}\n");
            s.Append("return dt;\n");
            s.Append("}\n");
            return s.ToString();
        }

    }
}
