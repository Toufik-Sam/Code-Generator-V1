using DataAccessLayer;
using System.Data;
using System.Text;

namespace BusinessLayer
{
    public class clsBusinessLayerGenerator
    {
        public static string GenerateClassAttributes(string DataBaseName,string TableName,bool WithAddNew)
        {
            StringBuilder s = new StringBuilder();
            if(WithAddNew)
            {
                s.Append("public enum enMode{AddNew=0,Update=1};\n");
                s.Append("private enMode _Mode=enMode.AddNew;\n");
            }
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
            for(int i=0;i<_dtColumns.Rows.Count;i++)
            {
                s.Append("public ");
                switch(_dtColumns.Rows[i][1])
                {
                    case "int":
                        s.Append("int " + _dtColumns.Rows[i][0] +" {set;get;}\n");
                        break;
                    case "tinyint":
                        s.Append("int " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "smallint":
                        s.Append("int " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "smallmoney":
                        s.Append("float " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "float":
                        s.Append("float " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "real":
                        s.Append("float " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "datetime":
                        s.Append("DateTime " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "bit":
                        s.Append("bool " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "nvarchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "varchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                    case "text":
                        s.Append("string " + _dtColumns.Rows[i][0] + " {set;get;}\n");
                        break;
                }
            }
            return s.ToString();
        }
        public static string GenerateClassPublicConstructor(string DataBaseName,string TableName,bool WithAddNew)
        {
            StringBuilder s = new StringBuilder();
            s.Append("public cls" + TableName + "()\n");
            s.Append("{\n");
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
            for(int i=0;i<_dtColumns.Rows.Count;i++)
            {
                s.Append("this." + _dtColumns.Rows[i][0] + "=");
                switch (_dtColumns.Rows[i][1])
                {
                    case "int":
                        s.Append("-1\n");
                        break;
                    case "tinyint":
                        s.Append("-1\n");
                        break;
                    case "smallint":
                        s.Append("-1\n");
                        break;
                    case "smallmoney":
                        s.Append("-1\n");
                        break;
                    case "float":
                        s.Append("-1\n");
                        break;
                    case "real":
                        s.Append("-1\n");
                        break;
                    case "datetime":
                        s.Append("DateTime.Now\n");
                        break;
                    case "bit":
                        s.Append("false\n");
                        break;
                    case "nvarchar":
                        s.Append("string.Empty\n");
                        break;
                    case "varchar":
                        s.Append("string.Empty\n");
                        break;
                    case "text":
                        s.Append("string.Empty\n");
                        break;
                } 
            }
            if(WithAddNew)
                s.Append("_Mode=enMode.AddNew\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassPrivateConstrutor(string DataBaseName,string TableName,bool WithAddNew)
        {
            StringBuilder s = new StringBuilder();
            s.Append("private cls" + TableName);
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
            s.Append(clsUtility.AttributesLoop(_dtColumns,""));
            s.Append("{\n");                                                                                                                    
            for (int i = 0; i < _dtColumns.Rows.Count; i++)
            {
                s.Append("this." + _dtColumns.Rows[i][0] + "=" + _dtColumns.Rows[i][0]+"\n");
            }
            if(WithAddNew)
                s.Append("_Mode=enMode.Update\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenrateClassAddNewFunction(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName,DataBaseName);
            string PrimaryKey =clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName);
            s.Append("private bool _AddNew()\n");
            s.Append("{\n");
            s.Append("this." + clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName) + "=");
            s.Append("cls" + TableName + "Data" + ".AddNew");
            s.Append(clsUtility.AttributesLoopWithThis(_dtColumns,PrimaryKey));
            s.Append("return " + "this." + clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName) + "!=-1\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassUpdateFunction(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
            s.Append("private bool _Update()\n");
            s.Append("{\n");
            s.Append("return cls"+ TableName + "Data.Update" + clsUtility.AttributesLoopWithThis(_dtColumns, ""));
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassDeleteFunction(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("public static bool Delete("+clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName,DataBaseName)+")\n");
            s.Append("{\n");
            s.Append("return cls" + TableName + "Data" + ".Delete(int " + clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName) +
                ");\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenerateClassFindFunction(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            DataTable _dtColumns = clsDataBaseInfo.GetAllColumnsByTableName(TableName, DataBaseName);
            string PrimaryKey = clsDataBaseInfo.GetTablePrimaryKeyByTableName(TableName, DataBaseName);
            s.Append("public static cls" + TableName + "Find(int " + PrimaryKey + ")\n");
            s.Append("{\n");
            s.Append(clsUtility.AttributeForFindFunction(_dtColumns, PrimaryKey));
            s.Append("return cls" + TableName + "Data" + "." + "GetItemInfoByPrimaryKey");
            s.Append(clsUtility.AttributesLoopWithRef(_dtColumns,PrimaryKey));
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenrateClassSaveFunction(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("public bool Save()\n");
            s.Append("{\n");
            s.Append("switch(_Mode)\n");
            s.Append("{\n");
            s.Append("case enMode.AddNew:\n");
            s.Append("if(_AddNew())\n");
            s.Append("{\n");
            s.Append("_Mode=enMode.Update;\n");
            s.Append("return true;\n");
            s.Append("}\n");
            s.Append("case enMode.Update:\n");
            s.Append("return _Update();\n");
            s.Append("default:\n");
            s.Append("return false   ;\n");
            s.Append("}\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string GenrateClassGetAllItems(string DataBaseName,string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("public static DataTable GetAllItems()\n");
            s.Append("{\n");
            s.Append("return cls" + TableName + "Data.GetAllItems();\n");
            s.Append("}\n");
            return s.ToString();
        }
        public static string UsingLibrariesHeader(string DataBaseName, string TableName, bool BusinessOrDataAccessLayer)
        {
            StringBuilder s = new StringBuilder();
            s.Append("using System;\n");
            s.Append("using System.Collections.Generic;\n");
            s.Append("using System.Data;\n");
            if (!BusinessOrDataAccessLayer)
                s.Append("using System.Data.SqlClient;\n");
            s.Append("using System.Linq;\n");
            s.Append("using System.Net;\n");
            s.Append("using System.Security.Policy;\n");
            s.Append("using System.Text;\n");
            s.Append("using System.Threading.Tasks;\n");
            if(!BusinessOrDataAccessLayer)
                s.Append("namespace " + DataBaseName.ToString() + "DataAccessLayer\n");
            else
                s.Append("namespace " + DataBaseName.ToString() + "BusinessLayer\n");

            s.Append("{\n");
            if (!BusinessOrDataAccessLayer)
                s.Append("public class cls" + TableName + "Data\n");
            else
                s.Append("public class cls" + TableName + "\n");
            s.Append("{\n");
            return s.ToString();
        }

    }
}
