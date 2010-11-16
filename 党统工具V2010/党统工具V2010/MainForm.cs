using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.XT2005
{
   /// <summary>
   /// 主窗体类
   /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Boolean isLinked;

        public Boolean IsLinked
        {
            get { return isLinked; }
            set { isLinked = value; }
        }
        /// <summary>
        /// 连接数据库，Xt2005
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_LinkDB(object sender, EventArgs e)
        {
            try
            {
                com.echo.XT2005.DB.D01DataTable D01 = D01TableAdapter.GetDataByTopOrg();
                com.echo.XT2005.DB.D01Row dr = (com.echo.XT2005.DB.D01Row)D01.Rows[0];

                TreeNode node = tvOrg.Nodes.Add(dr.D0107, dr.D0101);
                node.ToolTipText = dr.D0107;
                
                D01 = D01TableAdapter.GetDataBySubOrg();
                foreach (com.echo.XT2005.DB.D01Row row in D01)
                {
                    TreeNode n = node.Nodes.Add(row.D0107, "(" + row.D0107.Substring(row.D0107.Length-3,3) + ")" + row.D0101);
                    n.ToolTipText = row.D0107;
                }
                isLinked = true;
                tvOrg.Nodes[0].ExpandAll();
            }
            catch (System.Data.Odbc.OdbcException ex) 
            {
                MessageBox.Show("数据库连接错误，请检查数据库配置\n"+ex.Message);
                isLinked = false;
            }

        }

        private void OnExit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 全选所有组织
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectAll(object sender, EventArgs e)
        {
            foreach (TreeNode item in tvOrg.Nodes)
            {
                item.Checked = true;
               
                foreach (TreeNode i in item.Nodes)
                {
                    i.Checked = true;
                }
            }
        }


        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = !(tvOrg.Nodes.Count > 0);
        }

        /// <summary>
        /// 取消全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectNone(object sender, EventArgs e)
        {
            foreach (TreeNode item in tvOrg.Nodes)
            {
                item.Checked = false;
                foreach (TreeNode i in item.Nodes)
                {
                    i.Checked = false;
                }
            }
        }

        /// <summary>
        /// 设置报告期参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSet(object sender, EventArgs e)
        {
            SetForm form1 = new SetForm();
            if (form1.ShowDialog(this) == DialogResult.OK)
            {
                
                //添加读取报告期参数代码
            }
        }

        private void ac_Set_Update(object sender, EventArgs e)
        {
            ac_Set.Enabled = this.isLinked;
        }
    }
}
