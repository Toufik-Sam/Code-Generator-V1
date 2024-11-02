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
    public partial class Form1 : Form
    {
        private static DataTable _dtDataBasesInTheServer;
        private static DataTable _dtTablesInTheDataBase;
        private bool _FlagConditionForSelectSatatment = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void _FillTablesCombobox()
        {
            cmbTables.Items.Clear();
            _dtTablesInTheDataBase = clsDataBase.GetAllTablesByDataBaseName(cmbDataBases.SelectedItem.ToString());
            if (_dtTablesInTheDataBase.Rows.Count > 0)
            {
                foreach (DataRow dr in _dtTablesInTheDataBase.Rows)
                    cmbTables.Items.Add(dr[0].ToString());
                cmbTables.SelectedIndex = 0;
            }
             
        }
        private void _FillCombobox()
        {
            for(int i=4;i< _dtDataBasesInTheServer.Rows.Count;i++)
            {
                cmbDataBases.Items.Add(_dtDataBasesInTheServer.Rows[i][0].ToString());
            }
            cmbDataBases.SelectedIndex = 0;
        }
        private void _LoadData()
        {
            _dtDataBasesInTheServer = clsDataBase.GetAllDataBaseInfo();
            if (_dtDataBasesInTheServer.Rows.Count > 0)
                _FillCombobox();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void allColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxStatment.Text = "Select * From " + cmbTables.SelectedItem.ToString();
        }

        private void cmbDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillTablesCombobox();
        }

        private void specificColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FlagConditionForSelectSatatment = false;
            frmSelectColumns frm = new frmSelectColumns(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            frm.DataBack += FrmSelectedItems_DataBack;
            frm.ShowDialog();

        }

        private void FrmSelectedItems_DataBack(object sender,List<string>vSelectedColumns)
        {
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            
            rtxStatment.Text = clsUtility.SelectItemsStatment(vSelectedColumns,PrimaryKey,cmbTables.SelectedItem.ToString(),
                _FlagConditionForSelectSatatment);

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable _dtTableColumns = clsDataBase.GetAllColumnByTableName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
           
            rtxStatment.Text = clsUtility.InsertIntoStatement(_dtTableColumns,PrimaryKey, cmbTables.SelectedItem.ToString());
        }

        private void conditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FlagConditionForSelectSatatment = true;
            frmSelectColumns frm = new frmSelectColumns(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            frm.DataBack += FrmSelectedItems_DataBack;
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable _dtTableColumns = clsDataBase.GetAllColumnByTableName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());

            rtxStatment.Text = clsUtility.UpdateStatement(_dtTableColumns, PrimaryKey, cmbTables.SelectedItem.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PrimaryKey = clsDataBase.GetTablePrimaryKeyByName(cmbTables.SelectedItem.ToString(), cmbDataBases.SelectedItem.ToString());
            rtxStatment.Text = clsUtility.DeletStatement(PrimaryKey, cmbTables.SelectedItem.ToString());
        }
        private void classByTableNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsBusinessLayerGenerator.UsingLibrariesHeader(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(), true));
            s.Append(clsBusinessLayerGenerator.GenerateClassAttributes(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(),true));
            s.Append(clsBusinessLayerGenerator.GenerateClassPublicConstructor(cmbDataBases.SelectedItem.ToString(),
                cmbTables.SelectedItem.ToString(),true));
            s.Append(clsBusinessLayerGenerator.GenerateClassPrivateConstrutor(cmbDataBases.SelectedItem.ToString(),
                cmbTables.SelectedItem.ToString(),true));
            s.Append(clsBusinessLayerGenerator.GenerateClassFindFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenrateClassGetAllItems(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenrateClassAddNewFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenerateClassUpdateFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenerateClassDeleteFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenrateClassSaveFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append("}\n");
            s.Append("}\n");
            rtxStatment.Text = s.ToString();
        }

        private void classWithoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsBusinessLayerGenerator.UsingLibrariesHeader(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(), true));
            s.Append(clsBusinessLayerGenerator.GenerateClassAttributes(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(),false));
            s.Append(clsBusinessLayerGenerator.GenerateClassPublicConstructor(cmbDataBases.SelectedItem.ToString(),
               cmbTables.SelectedItem.ToString(),false));
            s.Append(clsBusinessLayerGenerator.GenerateClassPrivateConstrutor(cmbDataBases.SelectedItem.ToString(),
                cmbTables.SelectedItem.ToString(),false));
            s.Append(clsBusinessLayerGenerator.GenerateClassFindFunction(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsBusinessLayerGenerator.GenrateClassGetAllItems(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append("}\n");
            s.Append("}\n");
            rtxStatment.Text = s.ToString();
    
        }

        private void classByTableNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsBusinessLayerGenerator.UsingLibrariesHeader(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(), false));
         
            s.Append(clsDataAccessLayerGenerator.GenrateClassDataAddNew(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataUpdate(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataDelete(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataGetAllItems(cmbDataBases.SelectedItem.ToString(), 
                cmbTables.SelectedItem.ToString()));
            s.Append("}\n");
            s.Append("}\n");
            rtxStatment.Text = s.ToString();
        }

        private void classWithoutAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsBusinessLayerGenerator.UsingLibrariesHeader(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString(), false));
            
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataGetAllItems(cmbDataBases.SelectedItem.ToString(),
              cmbTables.SelectedItem.ToString()));
            s.Append("}\n");
            s.Append("}\n");
            rtxStatment.Text = s.ToString();
        }

        private void addNewFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsDataAccessLayerGenerator.GenrateClassDataAddNew(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            rtxStatment.Text = s.ToString();
        }

        private void updateFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataUpdate(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            rtxStatment.Text = s.ToString();
        }

        private void deleteFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataDelete(cmbDataBases.SelectedItem.ToString(), cmbTables.SelectedItem.ToString()));
            rtxStatment.Text = s.ToString();
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();
            s.Append(clsDataAccessLayerGenerator.GenerateClassDataGetAllItems(cmbDataBases.SelectedItem.ToString(),
                cmbTables.SelectedItem.ToString()));
            rtxStatment.Text = s.ToString();
        }
    }
}
