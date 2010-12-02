namespace com.echo.XT2005
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.aAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainStatusbar = new System.Windows.Forms.StatusStrip();
            this.mainToolbar = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvOrg = new System.Windows.Forms.TreeView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tvRepair = new System.Windows.Forms.TreeView();
            this.D01TableAdapter = new com.echo.XT2005.DBTableAdapters.D01TableAdapter();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepair = new System.Windows.Forms.Button();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainActionlist = new com.echo.Controls.Actions.ActionList();
            this.ac_Login = new com.echo.Controls.Actions.Action();
            this.ac_Exit = new com.echo.Controls.Actions.Action();
            this.ac_Set = new com.echo.Controls.Actions.Action();
            this.ac_SelectAll = new com.echo.Controls.Actions.Action();
            this.ac_SelectNone = new com.echo.Controls.Actions.Action();
            this.ac_Repair = new com.echo.Controls.Actions.Action();
            this.queriesTableAdapter1 = new com.echo.XT2005.DBTableAdapters.QueriesTableAdapter();
            this.mainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainActionlist)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aAToolStripMenuItem,
            this.cToolStripMenuItem1});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1115, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_MENU_SYSTEM;
            // 
            // aAToolStripMenuItem
            // 
            this.aAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cToolStripMenuItem});
            this.aAToolStripMenuItem.Name = "aAToolStripMenuItem";
            this.aAToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.aAToolStripMenuItem.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_MENU_SYSTEM;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // mainStatusbar
            // 
            this.mainStatusbar.Location = new System.Drawing.Point(0, 670);
            this.mainStatusbar.Name = "mainStatusbar";
            this.mainStatusbar.Size = new System.Drawing.Size(1115, 22);
            this.mainStatusbar.TabIndex = 1;
            this.mainStatusbar.Text = "statusStrip1";
            // 
            // mainToolbar
            // 
            this.mainToolbar.Location = new System.Drawing.Point(0, 25);
            this.mainToolbar.Name = "mainToolbar";
            this.mainToolbar.Size = new System.Drawing.Size(1115, 25);
            this.mainToolbar.TabIndex = 2;
            this.mainToolbar.Text = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 620);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_TAB_RPTCHK;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 588);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvOrg);
            this.splitContainer2.Size = new System.Drawing.Size(313, 588);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.TabIndex = 0;
            // 
            // tvOrg
            // 
            this.tvOrg.CheckBoxes = true;
            this.tvOrg.ContextMenuStrip = this.contextMenu;
            this.tvOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOrg.FullRowSelect = true;
            this.tvOrg.Location = new System.Drawing.Point(0, 0);
            this.tvOrg.Name = "tvOrg";
            this.tvOrg.ShowNodeToolTips = true;
            this.tvOrg.Size = new System.Drawing.Size(313, 321);
            this.tvOrg.TabIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(143, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_REPAIRDATA;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tvRepair);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnRepair);
            this.splitContainer3.Size = new System.Drawing.Size(1101, 588);
            this.splitContainer3.SplitterDistance = 367;
            this.splitContainer3.TabIndex = 0;
            // 
            // tvRepair
            // 
            this.tvRepair.CheckBoxes = true;
            this.tvRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRepair.FullRowSelect = true;
            this.tvRepair.Location = new System.Drawing.Point(0, 0);
            this.tvRepair.Name = "tvRepair";
            this.tvRepair.Size = new System.Drawing.Size(367, 588);
            this.tvRepair.TabIndex = 0;
            // 
            // D01TableAdapter
            // 
            this.D01TableAdapter.ClearBeforeFill = true;
            // 
            // aToolStripMenuItem
            // 
            this.mainActionlist.SetAction(this.aToolStripMenuItem, this.ac_SelectAll);
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aToolStripMenuItem.Text = "全选(&A)";
            // 
            // bToolStripMenuItem1
            // 
            this.mainActionlist.SetAction(this.bToolStripMenuItem1, this.ac_SelectNone);
            this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            this.bToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.bToolStripMenuItem1.Text = "清除全选(&N)";
            // 
            // btnRepair
            // 
            this.mainActionlist.SetAction(this.btnRepair, this.ac_Repair);
            this.btnRepair.Location = new System.Drawing.Point(82, 34);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(75, 23);
            this.btnRepair.TabIndex = 0;
            this.btnRepair.Text = "修复(&R)";
            this.btnRepair.UseVisualStyleBackColor = true;
            this.btnRepair.Click += new System.EventHandler(this.OnRepair);
            // 
            // bToolStripMenuItem
            // 
            this.mainActionlist.SetAction(this.bToolStripMenuItem, this.ac_Login);
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bToolStripMenuItem.Text = "连接数据库(&L)";
            // 
            // cToolStripMenuItem
            // 
            this.mainActionlist.SetAction(this.cToolStripMenuItem, this.ac_Exit);
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cToolStripMenuItem.Text = "退出(&X)";
            // 
            // cToolStripMenuItem1
            // 
            this.mainActionlist.SetAction(this.cToolStripMenuItem1, this.ac_Set);
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(96, 21);
            this.cToolStripMenuItem1.Text = "设置报告期(&R)";
            // 
            // mainActionlist
            // 
            this.mainActionlist.Actions.Add(this.ac_Login);
            this.mainActionlist.Actions.Add(this.ac_Exit);
            this.mainActionlist.Actions.Add(this.ac_SelectAll);
            this.mainActionlist.Actions.Add(this.ac_SelectNone);
            this.mainActionlist.Actions.Add(this.ac_Set);
            this.mainActionlist.Actions.Add(this.ac_Repair);
            this.mainActionlist.ContainerControl = this;
            // 
            // ac_Login
            // 
            this.ac_Login.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_ACL_LINK;
            this.ac_Login.AfterExecute += new System.EventHandler(this.On_LinkDB);
            // 
            // ac_Exit
            // 
            this.ac_Exit.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_ACL_EXIT;
            this.ac_Exit.Execute += new System.EventHandler(this.OnExit);
            // 
            // ac_Set
            // 
            this.ac_Set.Text = "设置报告期(&R)";
            this.ac_Set.Update += new System.EventHandler(this.ac_Set_Update);
            this.ac_Set.Execute += new System.EventHandler(this.OnSet);
            // 
            // ac_SelectAll
            // 
            this.ac_SelectAll.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_AC_SELECTALL;
            this.ac_SelectAll.Execute += new System.EventHandler(this.OnSelectAll);
            // 
            // ac_SelectNone
            // 
            this.ac_SelectNone.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_AC_SELECTNONE;
            this.ac_SelectNone.Execute += new System.EventHandler(this.OnSelectNone);
            // 
            // ac_Repair
            // 
            this.ac_Repair.Text = "修复(&R)";
            this.ac_Repair.Update += new System.EventHandler(this.OnRepairUpdate);
            this.ac_Repair.Execute += new System.EventHandler(this.OnRepair);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainToolbar);
            this.Controls.Add(this.mainStatusbar);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::com.echo.XT2005.Properties.Settings.Default.STR_TITLE;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainActionlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip mainStatusbar;
        private System.Windows.Forms.ToolStrip mainToolbar;
        private com.echo.Controls.Actions.ActionList mainActionlist;
        private System.Windows.Forms.ToolStripMenuItem aAToolStripMenuItem;
        private com.echo.Controls.Actions.Action ac_Login;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private com.echo.XT2005.DBTableAdapters.D01TableAdapter D01TableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvOrg;
        private com.echo.Controls.Actions.Action ac_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private com.echo.Controls.Actions.Action ac_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private com.echo.Controls.Actions.Action ac_SelectNone;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem1;
        private com.echo.Controls.Actions.Action ac_Set;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView tvRepair;
        private System.Windows.Forms.Button btnRepair;
        private com.echo.Controls.Actions.Action ac_Repair;
        private com.echo.XT2005.DBTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}

