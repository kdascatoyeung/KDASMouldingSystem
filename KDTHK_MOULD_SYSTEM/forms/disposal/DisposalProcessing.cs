using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.buffer;
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.forms.fixedasset;

namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    public partial class DisposalProcessing : UserControl
    {
        public event EventHandler SwitchRequestEvent;
        public event EventHandler SwitchHistoryEvent;

        public DisposalProcessing()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvDisposal, true);

            this.LoadData();
        }

        private void LoadData()
        {
            DataTable tb = new DataTable();

            string query = "select md_type as dtype, md_status as status, md_chaseno as chaseno, md_mouldno as mould, md_itemcode as partno" +
                ", md_fixedasset as asset, md_vendor as vendor, md_vendorname as name, md_2003n as p2003n, md_2003ans as p2003ans" +
                ", md_2003result as p2003result, md_2003updated as p2003updated, md_2004n as p2004n, md_2004ans as p2004ans" +
                ", md_2004result as p2004result, md_2004updated as p2004updated, md_kdcno as kdcno, md_kdcrps as kdcrps" +
                ", md_kdcseisan as kdcseisan, md_kdcissued as kdcissued, md_kdcresult as kdcresult, md_kdcupdated as kdcupdated" +
                ", md_desc as de, md_capdate as capdate, md_acquishkd as acquis, md_accumhkd as accum, md_closing as closing" +
                ", md_bookhkd as bv1, md_fy as fy, md_bookhkd2 as bv2, md_ringi as ringi, md_reportno as reportno, md_reportissued as reportissued" +
                ", md_reportreceived as reportreceived, md_vendorresult as vendorresult, md_fadate as disposaldate, md_remarks as remarks" +
                " from TB_MOULD_DISPOSAL";

            //GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            //GlobalService.Adapter.Fill(tb);

            //dgvDisposal.DataSource = tb;
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchRequestEvent != null)
                SwitchRequestEvent(this, new EventArgs());
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchHistoryEvent != null)
                SwitchHistoryEvent(this, new EventArgs());
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDisposal.Rows)
            {
                string type = row.Cells[0].Value.ToString();
                string status = row.Cells[1].Value.ToString();
                string chaseno = row.Cells[2].Value.ToString();
                string vendor = row.Cells[5].Value.ToString();
                string p2003no = row.Cells[8].Value.ToString();
                string p2003ans = row.Cells[9].Value.ToString();
                string p2003result = row.Cells[10].Value.ToString();
                string p2003updated = row.Cells[11].Value.ToString();
                string p2004no = row.Cells[12].Value.ToString();
                string p2004ans = row.Cells[13].Value.ToString();
                string p2004result = row.Cells[14].Value.ToString();
                string p2004updated = row.Cells[15].Value.ToString();
                string kdcno = row.Cells[16].Value.ToString();
                string kdcrps = row.Cells[17].Value.ToString();
                string kdcseisan = row.Cells[18].Value.ToString();
                string kdcissued = row.Cells[19].Value.ToString();
                string kdcresult = row.Cells[20].Value.ToString();
                string kdcupdated = row.Cells[21].Value.ToString();
                string desc = row.Cells[22].Value.ToString();
                string capdate = row.Cells[23].Value.ToString();
                string acquis = row.Cells[24].Value.ToString();
                string accum = row.Cells[25].Value.ToString();
                string closing = row.Cells[26].Value.ToString();
                string bv1 = row.Cells[27].Value.ToString();
                string fy = row.Cells[28].Value.ToString();
                string bv2 = row.Cells[29].Value.ToString();
                string ringi = row.Cells[30].Value.ToString();
                string reportno = row.Cells[31].Value.ToString();
                string reportissued = row.Cells[32].Value.ToString();
                string reportreceived = row.Cells[33].Value.ToString();
                string vendorresult = row.Cells[34].Value.ToString();
                string disposaldate = row.Cells[35].Value.ToString();
                string remarks = row.Cells[36].Value.ToString();

                string query = string.Format("update TB_MOULD_DISPOSAL set md_type = N'{0}', md_2003 = '{1}', md_2003ans = '{2}'" +
                    ", md_2003result = '{3}', md_2003updated = '{4}', md_2004 = '{5}', md_2004ans = '{6}', md_2004result = '{7}'" +
                    ", md_2004updated = '{8}', md_kdcno = '{9}', md_kdcrps = '{10}', md_kdcseisan = '{11}', md_kdcissued = '{12}'" +
                    ", md_kdcresult = '{13}', md_kdcupdated = '{14}', md_desc = '{15}', md_capdate = '{16}', md_acquishkd = '{17}'" +
                    ", md_accumhkd = '{18}', md_closing = '{19}', md_bookhkd = '{20}', md_fy = '{21}', md_bookhkd2 = '{22}'" +
                    ", md_ringi = '{23}', md_reportno = '{24}', md_reportissued = '{25}', md_reportreceived = '{26}', md_vendorresult = '{27}'" +
                    ", md_fadate = '{28}', md_remarks = '{29}', md_status = N'{30}' where md_chaseno = '{31}'", type, p2003no, p2003ans,
                    p2003result, p2003updated, p2004no, p2004ans, p2004result, p2004updated, kdcno, kdcrps, kdcseisan, kdcissued,
                    kdcresult, kdcupdated, desc, capdate, acquis, accum, closing, bv1, fy, bv2, ringi, reportno, reportissued, reportreceived,
                    vendorresult, disposaldate, remarks, status, chaseno);

                DataService.GetInstance().ExecuteNonQuery(query);

                string fixedAsset = row.Cells[4].Value.ToString();

                if (fixedAsset != "-" && status == "固定資産廃棄申請")
                {
                    FaDisposalForm form = new FaDisposalForm(fixedAsset, vendor, chaseno);
                    form.ShowDialog();
                }
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
