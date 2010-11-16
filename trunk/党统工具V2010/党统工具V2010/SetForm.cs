using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace com.echo.XT2005
{
    public partial class SetForm : Form
    {
        string rptID;

        public string RptID
        {
            get { return rptID; }
            set { rptID = value; }
        }

        string beginTime;

        public string BeginTime
        {
            get { return beginTime; }
            set { beginTime = value; }
        }
        string endTime;

        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public SetForm()
        {
            InitializeComponent();
            
            GetDataSet();
            
        }

        private void GetDataSet()
        {
            rpttemplateclassTableAdapter.Fill(this.dB.RPTTEMPLATECLASS);
            t_rpt_durationTableAdapter.Fill(this.dB.T_RPT_DURATION);
        }

        /// <summary>
        /// 读取报告期参数
        /// </summary>
        private void GetConfig()
        {
            try
            {
                Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                RptID = cf.AppSettings.Settings["rptID"].Value;
                BeginTime = cf.AppSettings.Settings["beginTime"].Value;
                EndTime = cf.AppSettings.Settings["endTime"].Value;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == RptID)
                    {
                        row.Selected = true;
                        break;
                    }
                }

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value.ToString() == BeginTime && row.Cells[2].Value.ToString() == EndTime)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
        }

        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SetConfig();
            Close();
        }

        /// <summary>
        /// 写入报告期参数
        /// </summary>
        private void SetConfig()
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings.Clear();
            cfa.AppSettings.Settings.Add("rptID", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cfa.AppSettings.Settings.Add("beginTime", dataGridView2.SelectedRows[0].Cells[1].Value.ToString());
            cfa.AppSettings.Settings.Add("endTime", dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
            cfa.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetForm_Activated(object sender, EventArgs e)
        {
            GetConfig();
        }
    }
}
