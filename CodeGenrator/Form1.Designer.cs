namespace CodeGenrator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataAccessLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classByTableNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classWithoutAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classByTableNameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classWithoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbDataBases = new System.Windows.Forms.ComboBox();
            this.rtxStatment = new System.Windows.Forms.RichTextBox();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genratorToolStripMenuItem
            // 
            this.genratorToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.genratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLQueryToolStripMenuItem,
            this.dataAccessLayerToolStripMenuItem,
            this.businessLayerToolStripMenuItem});
            this.genratorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genratorToolStripMenuItem.Name = "genratorToolStripMenuItem";
            this.genratorToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.genratorToolStripMenuItem.Text = "Generator";
            // 
            // sQLQueryToolStripMenuItem
            // 
            this.sQLQueryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectStatementToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.sQLQueryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sQLQueryToolStripMenuItem.Name = "sQLQueryToolStripMenuItem";
            this.sQLQueryToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.sQLQueryToolStripMenuItem.Text = "SQL Query";
            // 
            // selectStatementToolStripMenuItem
            // 
            this.selectStatementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allColumnsToolStripMenuItem,
            this.specificColumnsToolStripMenuItem});
            this.selectStatementToolStripMenuItem.Name = "selectStatementToolStripMenuItem";
            this.selectStatementToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.selectStatementToolStripMenuItem.Text = "Select Statement";
            // 
            // allColumnsToolStripMenuItem
            // 
            this.allColumnsToolStripMenuItem.Name = "allColumnsToolStripMenuItem";
            this.allColumnsToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.allColumnsToolStripMenuItem.Text = "All Columns";
            this.allColumnsToolStripMenuItem.Click += new System.EventHandler(this.allColumnsToolStripMenuItem_Click);
            // 
            // specificColumnsToolStripMenuItem
            // 
            this.specificColumnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conditionToolStripMenuItem});
            this.specificColumnsToolStripMenuItem.Name = "specificColumnsToolStripMenuItem";
            this.specificColumnsToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.specificColumnsToolStripMenuItem.Text = "Specific Columns ";
            this.specificColumnsToolStripMenuItem.Click += new System.EventHandler(this.specificColumnsToolStripMenuItem_Click);
            // 
            // conditionToolStripMenuItem
            // 
            this.conditionToolStripMenuItem.Name = "conditionToolStripMenuItem";
            this.conditionToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.conditionToolStripMenuItem.Text = "Condition";
            this.conditionToolStripMenuItem.Click += new System.EventHandler(this.conditionToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.addNewToolStripMenuItem.Text = "Add New (Insert Into)";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.updateToolStripMenuItem.Text = "Update ";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.deleteToolStripMenuItem.Text = "Delete ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataAccessLayerToolStripMenuItem
            // 
            this.dataAccessLayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classByTableNameToolStripMenuItem,
            this.classWithoutAddToolStripMenuItem,
            this.addNewFunctionToolStripMenuItem,
            this.updateFunctionToolStripMenuItem,
            this.deleteFunctionToolStripMenuItem,
            this.gToolStripMenuItem});
            this.dataAccessLayerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAccessLayerToolStripMenuItem.Name = "dataAccessLayerToolStripMenuItem";
            this.dataAccessLayerToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.dataAccessLayerToolStripMenuItem.Text = "Data Access Layer";
            // 
            // classByTableNameToolStripMenuItem
            // 
            this.classByTableNameToolStripMenuItem.Name = "classByTableNameToolStripMenuItem";
            this.classByTableNameToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.classByTableNameToolStripMenuItem.Text = "Class For Add";
            this.classByTableNameToolStripMenuItem.Click += new System.EventHandler(this.classByTableNameToolStripMenuItem_Click);
            // 
            // classWithoutAddToolStripMenuItem
            // 
            this.classWithoutAddToolStripMenuItem.Name = "classWithoutAddToolStripMenuItem";
            this.classWithoutAddToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.classWithoutAddToolStripMenuItem.Text = "Class Without Add";
            this.classWithoutAddToolStripMenuItem.Click += new System.EventHandler(this.classWithoutAddToolStripMenuItem_Click);
            // 
            // addNewFunctionToolStripMenuItem
            // 
            this.addNewFunctionToolStripMenuItem.Name = "addNewFunctionToolStripMenuItem";
            this.addNewFunctionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.addNewFunctionToolStripMenuItem.Text = "Add New Function";
            this.addNewFunctionToolStripMenuItem.Click += new System.EventHandler(this.addNewFunctionToolStripMenuItem_Click);
            // 
            // updateFunctionToolStripMenuItem
            // 
            this.updateFunctionToolStripMenuItem.Name = "updateFunctionToolStripMenuItem";
            this.updateFunctionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.updateFunctionToolStripMenuItem.Text = "Update Function";
            this.updateFunctionToolStripMenuItem.Click += new System.EventHandler(this.updateFunctionToolStripMenuItem_Click);
            // 
            // deleteFunctionToolStripMenuItem
            // 
            this.deleteFunctionToolStripMenuItem.Name = "deleteFunctionToolStripMenuItem";
            this.deleteFunctionToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.deleteFunctionToolStripMenuItem.Text = "Delete Function";
            this.deleteFunctionToolStripMenuItem.Click += new System.EventHandler(this.deleteFunctionToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.gToolStripMenuItem.Text = "Get All Items";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // businessLayerToolStripMenuItem
            // 
            this.businessLayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classByTableNameToolStripMenuItem1,
            this.classWithoutToolStripMenuItem});
            this.businessLayerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessLayerToolStripMenuItem.Name = "businessLayerToolStripMenuItem";
            this.businessLayerToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.businessLayerToolStripMenuItem.Text = "Business Layer";
            // 
            // classByTableNameToolStripMenuItem1
            // 
            this.classByTableNameToolStripMenuItem1.Name = "classByTableNameToolStripMenuItem1";
            this.classByTableNameToolStripMenuItem1.Size = new System.Drawing.Size(200, 24);
            this.classByTableNameToolStripMenuItem1.Text = "Class With Add";
            this.classByTableNameToolStripMenuItem1.Click += new System.EventHandler(this.classByTableNameToolStripMenuItem1_Click);
            // 
            // classWithoutToolStripMenuItem
            // 
            this.classWithoutToolStripMenuItem.Name = "classWithoutToolStripMenuItem";
            this.classWithoutToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.classWithoutToolStripMenuItem.Text = "Class Without Add";
            this.classWithoutToolStripMenuItem.Click += new System.EventHandler(this.classWithoutToolStripMenuItem_Click);
            // 
            // cmbDataBases
            // 
            this.cmbDataBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataBases.FormattingEnabled = true;
            this.cmbDataBases.Location = new System.Drawing.Point(747, 80);
            this.cmbDataBases.Name = "cmbDataBases";
            this.cmbDataBases.Size = new System.Drawing.Size(169, 24);
            this.cmbDataBases.TabIndex = 1;
            this.cmbDataBases.SelectedIndexChanged += new System.EventHandler(this.cmbDataBases_SelectedIndexChanged);
            // 
            // rtxStatment
            // 
            this.rtxStatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxStatment.Location = new System.Drawing.Point(109, 123);
            this.rtxStatment.Name = "rtxStatment";
            this.rtxStatment.Size = new System.Drawing.Size(807, 488);
            this.rtxStatment.TabIndex = 2;
            this.rtxStatment.Text = "";
            // 
            // cmbTables
            // 
            this.cmbTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(547, 80);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(169, 24);
            this.cmbTables.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(745, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DataBase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTables);
            this.Controls.Add(this.rtxStatment);
            this.Controls.Add(this.cmbDataBases);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataAccessLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessLayerToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDataBases;
        private System.Windows.Forms.ToolStripMenuItem selectStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificColumnsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxStatment;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem conditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classByTableNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classByTableNameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classWithoutAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classWithoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
    }
}

