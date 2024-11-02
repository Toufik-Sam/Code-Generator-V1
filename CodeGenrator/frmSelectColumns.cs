using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenrator
{
    public partial class frmSelectColumns : Form
    {
        private static DataTable _dtColumnsofTable;
        private bool _Flag;
        private string _TableName;
        private string _DataBaseName;
        private List<string> _vColumns=new List<string>();
        public delegate void DataBackEvenetHandler(object sender, List<string> vSelectedColumns);
        public event DataBackEvenetHandler DataBack;
        public frmSelectColumns(string TableName,string DataBaseName)
        {
            InitializeComponent();
            _TableName = TableName;
            _DataBaseName = DataBaseName;
        }
        public frmSelectColumns(string TableName, string DataBaseName,bool flag)
        {
            InitializeComponent();
            _TableName = TableName;
            _DataBaseName = DataBaseName;
            _Flag = flag;
        }
        private void _LoadData()
        {
            _dtColumnsofTable = clsDataBase.GetAllColumnByTableName(_TableName, _DataBaseName);
            if(_dtColumnsofTable.Rows.Count>0)
            {
                foreach (DataRow dr in _dtColumnsofTable.Rows)
                    cbList.Items.Add(dr[0].ToString());
                if(_Flag==true)
                {
                    int Index = cbList.Items.IndexOf(clsDataBase.GetTablePrimaryKeyByName(_TableName, _DataBaseName));
                    cbList.Items.RemoveAt(Index);
                }
            }
        }
        private bool _FillListWithSelectedColumns()
        {
            if(cbList.Items.Count>0)
            {
                for (int i = 0; i < cbList.CheckedItems.Count; i++)
                    _vColumns.Add(cbList.CheckedItems[i].ToString());
                return true;
            }
            return false;
        }
        private void frmSelectColumns_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_FillListWithSelectedColumns())
            {
                DataBack?.Invoke(this, _vColumns);
                this.Close();
            }
        }
    }
}
