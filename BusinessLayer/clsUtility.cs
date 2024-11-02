using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUtility
    {
        public static string AttributesLoop(DataTable _dtColumns,string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            s.Append("(");
            for (int i = 0; i < _dtColumns.Rows.Count; i++)
            {
                if (PrimaryKey == _dtColumns.Rows[i][0].ToString())
                    continue;
                switch (_dtColumns.Rows[i][1])
                {
                    case "int":
                        s.Append("int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "tinyint":
                        s.Append("int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "smallint":
                        s.Append("int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "smallmoney":
                        s.Append("float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "float":
                        s.Append("float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "real":
                        s.Append("float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "datetime":
                        s.Append("DateTime " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "bit":
                        s.Append("bool " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "nvarchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "varchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "text":
                        s.Append("string " + _dtColumns.Rows[i][0] + ",");
                        break;
                }
            }
            s.Length--;
            s.Append(")\n");
            return s.ToString();
        }
        public static string AttributesLoopWithRef(DataTable _dtColumns, string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            s.Append("(");
            s.Append("int " + PrimaryKey + ",");
            for (int i = 0; i < _dtColumns.Rows.Count; i++)
            {
                if (PrimaryKey == _dtColumns.Rows[i][0].ToString())
                    continue;
                switch (_dtColumns.Rows[i][1])
                {
                    case "int":
                        s.Append("ref int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "tinyint":
                        s.Append("ref int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "smallint":
                        s.Append("ref int " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "smallmoney":
                        s.Append("ref float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "float":
                        s.Append("ref float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "real":
                        s.Append("ref float " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "datetime":
                        s.Append("ref DateTime " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "bit":
                        s.Append("ref bool " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "nvarchar":
                        s.Append("ref string " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "varchar":
                        s.Append("ref string " + _dtColumns.Rows[i][0] + ",");
                        break;
                    case "text":
                        s.Append("ref string " + _dtColumns.Rows[i][0] + ",");
                        break;
                }
            }
            s.Length--;
            s.Append(");\n");
            return s.ToString();
        }
        public static string AttributesLoopWithThis(DataTable _dtColumns, string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            s.Append("(");
            for (int i = 0; i < _dtColumns.Rows.Count; i++)
            {
                if (PrimaryKey == _dtColumns.Rows[i][0].ToString())
                    continue;
                s.Append("this." + _dtColumns.Rows[i][0] + ",");
            }
            s.Length--;
            s.Append(");\n");
            return s.ToString();
        }
        public static string AttributeForFindFunction(DataTable _dtColumns, string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < _dtColumns.Rows.Count; i++)
            {
                if (_dtColumns.Rows[i][0].ToString() == PrimaryKey)
                    continue;
                switch (_dtColumns.Rows[i][1])
                {
                    case "int":
                        s.Append("int " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "tinyint":
                        s.Append("int " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "smallint":
                        s.Append("int " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "smallmoney":
                        s.Append("float " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "float":
                        s.Append("float " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "real":
                        s.Append("float " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "datetime":
                        s.Append("DateTime " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "bit":
                        s.Append("bool " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "nvarchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "varchar":
                        s.Append("string " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                    case "text":
                        s.Append("string " + _dtColumns.Rows[i][0] + ";\n");
                        break;
                }
            }
            return s.ToString();
        }
        public static string SelectItemsStatment(List<string> vSelectedColumns, string PrimaryKey, string TableName, bool Condition)
        {
            StringBuilder s = new StringBuilder();
            s.Append("Select ");
            foreach (string item in vSelectedColumns)
            {
                s.Append(item);
                s.Append(",");
            }
            s.Length--;
            s.Append(" From ");
            s.Append(TableName);
            if (Condition == true)
            {
                s.Append(" Where ");
                s.Append(PrimaryKey);
                s.Append(" =@");
                s.Append(PrimaryKey);
            }
            return s.ToString();
        }
        public static string InsertIntoStatement(DataTable _dtTableColumns, string PrimaryKey, string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("INSERT INTO "+TableName+" (");
            for (int i = 0; i < _dtTableColumns.Rows.Count; i++)
            {
                if (_dtTableColumns.Rows[i][0].ToString() == PrimaryKey)
                    continue;
                s.Append(_dtTableColumns.Rows[i][0].ToString());
                s.Append(",");
            }
            s.Length--;
            s.Append(") VALUES(");
            for (int i = 0; i < _dtTableColumns.Rows.Count; i++)
            {
                if (_dtTableColumns.Rows[i][0].ToString() == PrimaryKey)
                    continue;
                s.Append("@");
                s.Append(_dtTableColumns.Rows[i][0].ToString());
                s.Append(",");
            }
            s.Length--;
            s.Append(");SELECT SCOPE_IDENTITY();\n");
            return s.ToString();
        }
        public static string UpdateStatement(DataTable _dtTableColumns, string PrimaryKey, string TableName)
        {
            StringBuilder s = new StringBuilder();
            s.Append("UPDATE ");
            s.Append(TableName);
            s.Append(" Set ");
            for (int i = 0; i < _dtTableColumns.Rows.Count; i++)
            {
                if (_dtTableColumns.Rows[i][0].ToString() == PrimaryKey)
                    continue;
                s.Append(_dtTableColumns.Rows[i][0].ToString()+ "=@"+_dtTableColumns.Rows[i][0].ToString()+",\n");
            }
            s.Length--;
            s.Append(" Where ");
            s.Append(PrimaryKey);
            s.Append(" =@");
            s.Append(PrimaryKey+";\n");
            return s.ToString();
        }
        public static string DeletStatement(string PrimaryKey, string TableName)
        {
            return "Delete From " + TableName + " Where " + PrimaryKey + "=@" + PrimaryKey;
        }
        private static string _GetElementType(string DataBaseType)
        {
            switch (DataBaseType)
            {
                case "int":
                    return "int";
                case "tinyint":
                    return "int";
                case "smallint":
                    return "int";
                case "smallmoney":
                    return "float";
                case "float":
                    return "float";
                case "real":
                    return "float";
                case "datetime":
                    return "DateTime";
                case "bit":
                    return "bool";
                case "nvarchar":
                    return "string";
                case "varchar":
                    return "string";
                case "text":
                    return "string";
                default:
                    return "";
            }
        }
        public static string FillReaderStatement(DataTable _dtColumns,string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            for(int i=0;i<_dtColumns.Rows.Count;i++)
            {
                if ((bool)_dtColumns.Rows[i][2]==true && PrimaryKey != _dtColumns.Rows[i][0].ToString())
                {
                    s.Append("if(reader["+ "\"" + _dtColumns.Rows[i][0]+ "\"" + "]!=DBNull.Value)\n");
                    s.Append(_dtColumns.Rows[i][0] + "=" + "(" + _GetElementType(_dtColumns.Rows[i][1].ToString()) + ")" + "reader["+ "\"" +
                        _dtColumns.Rows[i][0] + "\"" + "];\n");
                    s.Append("else\n");
                    s.Append(_dtColumns.Rows[i][0] + "=" + "\"" + "\""+"\n");
                }
                else
                    s.Append(_dtColumns.Rows[i][0] + "=" + "(" + _GetElementType(_dtColumns.Rows[i][1].ToString()) + ")" + "reader[" + "\"" +
                        _dtColumns.Rows[i][0] + "\"" + "];\n");

            }
            return s.ToString();
        }
        public static string FillAddWithValueStatements(DataTable _dtColumns,string PrimaryKey)
        {
            StringBuilder s = new StringBuilder();
            for(int i=0;i<_dtColumns.Rows.Count;i++)
            {
                if (PrimaryKey == _dtColumns.Rows[i][0].ToString())
                    continue;
                else if ((bool)_dtColumns.Rows[i][2]==true)
                {
                    s.Append("if(" + _dtColumns.Rows[i][0] + "!=" + "\"" + "\"" + " && " + _dtColumns.Rows[i][0] + "!=null)\n");
                    s.Append("command.Parameters.AddWithValue(@" + _dtColumns.Rows[i][0] + "," + _dtColumns.Rows[i][0] + ");\n");
                    s.Append("else\n");
                    s.Append("command.Parameters.AddWithValue(@" + _dtColumns.Rows[i][0] + "," + "System.DBNull.Value);\n");
                }
                else
                    s.Append("command.Parameters.AddWithValue(@" + _dtColumns.Rows[i][0] + "," + _dtColumns.Rows[i][0]+");\n");
            }
            return s.ToString();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              