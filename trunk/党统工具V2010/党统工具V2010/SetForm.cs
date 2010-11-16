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
        public SetForm()
        {
            InitializeComponent();
            rpttemplateclassTableAdapter.Fill(this.dB.RPTTEMPLATECLASS);
            t_rpt_durationTableAdapter.Fill(this.dB.T_RPT_DURATION);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings.Add("rptID",dataGridView1.SelectedRows[0].Cells[0].ToString());
            cfa.AppSettings.Settings.Add("beginTime",dataGridView2.SelectedRows[0].Cells[1].ToString());
            cfa.AppSettings.Settings.Add("endTime",dataGridView2.SelectedRows[0].Cells[2].ToString());
            cfa.Save();
        }
    }
}
