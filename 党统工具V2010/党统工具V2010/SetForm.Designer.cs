namespace com.echo.XT2005
{
    partial class SetForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLASSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rPTTEMPLATECLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new com.echo.XT2005.DB();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEGINTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRPTDURATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_rpt_durationTableAdapter = new com.echo.XT2005.DBTableAdapters.T_RPT_DURATIONTableAdapter();
            this.rpttemplateclassTableAdapter = new com.echo.XT2005.DBTableAdapters.RPTTEMPLATECLASSTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTEMPLATECLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPTDURATIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_RPTTEMPLATE;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLASSIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rPTTEMPLATECLASSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(273, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // cLASSIDDataGridViewTextBoxColumn
            // 
            this.cLASSIDDataGridViewTextBoxColumn.DataPropertyName = "CLASSID";
            this.cLASSIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.cLASSIDDataGridViewTextBoxColumn.Name = "cLASSIDDataGridViewTextBoxColumn";
            this.cLASSIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLASSIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // rPTTEMPLATECLASSBindingSource
            // 
            this.rPTTEMPLATECLASSBindingSource.DataMember = "RPTTEMPLATECLASS";
            this.rPTTEMPLATECLASSBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(297, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_RPTDURATION;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dURNAMEDataGridViewTextBoxColumn,
            this.bEGINTIMEDataGridViewTextBoxColumn,
            this.eNDTIMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tRPTDURATIONBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(287, 227);
            this.dataGridView2.TabIndex = 0;
            // 
            // dURNAMEDataGridViewTextBoxColumn
            // 
            this.dURNAMEDataGridViewTextBoxColumn.DataPropertyName = "DURNAME";
            this.dURNAMEDataGridViewTextBoxColumn.HeaderText = "报告期";
            this.dURNAMEDataGridViewTextBoxColumn.Name = "dURNAMEDataGridViewTextBoxColumn";
            this.dURNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dURNAMEDataGridViewTextBoxColumn.Width = 66;
            // 
            // bEGINTIMEDataGridViewTextBoxColumn
            // 
            this.bEGINTIMEDataGridViewTextBoxColumn.DataPropertyName = "BEGINTIME";
            this.bEGINTIMEDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.bEGINTIMEDataGridViewTextBoxColumn.Name = "bEGINTIMEDataGridViewTextBoxColumn";
            this.bEGINTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bEGINTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // eNDTIMEDataGridViewTextBoxColumn
            // 
            this.eNDTIMEDataGridViewTextBoxColumn.DataPropertyName = "ENDTIME";
            this.eNDTIMEDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.eNDTIMEDataGridViewTextBoxColumn.Name = "eNDTIMEDataGridViewTextBoxColumn";
            this.eNDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNDTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // tRPTDURATIONBindingSource
            // 
            this.tRPTDURATIONBindingSource.DataMember = "T_RPT_DURATION";
            this.tRPTDURATIONBindingSource.DataSource = this.dB;
            // 
            // t_rpt_durationTableAdapter
            // 
            this.t_rpt_durationTableAdapter.ClearBeforeFill = true;
            // 
            // rpttemplateclassTableAdapter
            // 
            this.rpttemplateclassTableAdapter.ClearBeforeFill = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(213, 266);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_OK;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_CANCEL;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 300);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_SETRPT;
            this.Activated += new System.EventHandler(this.SetForm_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTEMPLATECLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPTDURATIONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rPTTEMPLATECLASSBindingSource;
        private DB dB;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tRPTDURATIONBindingSource;
        private com.echo.XT2005.DBTableAdapters.T_RPT_DURATIONTableAdapter t_rpt_durationTableAdapter;
        private com.echo.XT2005.DBTableAdapters.RPTTEMPLATECLASSTableAdapter rpttemplateclassTableAdapter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEGINTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDTIMEDataGridViewTextBoxColumn;
    }
}