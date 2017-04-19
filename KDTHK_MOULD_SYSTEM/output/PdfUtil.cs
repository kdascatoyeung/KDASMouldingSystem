using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iTextSharp.text;
using KDTHK_MOULD_SYSTEM.services;
using iTextSharp.text.pdf;
using System.IO;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.output
{
    public class PdfUtil
    {
        public static void ExportPdf(DataTable table)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 50, 50, 50, 50);

            string tm = DateTime.Today.ToString("yy/MM");
            int id = 0;

            string query = string.Format("select top 1 d_seqid from TB_FA_RECORD where d_month = '{0}' order by d_id desc", tm);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (!GlobalService.Reader.HasRows)
                    id = 0;
                else
                {
                    while (GlobalService.Reader.Read())
                        id = GlobalService.Reader.GetInt32(0);
                }
            }

            string year = string.Format("{0:yy}", DateTime.Today);
            string month = string.Format("{0:MM}", DateTime.Today);
            id += 1;

            string strId = id.ToString("D3");

            string filename = "FA" + year + month + "_" + strId + ".pdf";
            string storedPath = @"\\kdthk-dm1\MOSS$\CM\FixedAssets\test\" + filename;

            string insertText = string.Format("insert into TB_FA_RECORD (d_filename, d_datetime, d_month, d_seqid)" +
                " values ('{0}', '{1}', '{2}', '{3}')", filename, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), tm, id);

            DataService.GetInstance().ExecuteNonQuery(insertText);

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(storedPath, FileMode.Create));
            doc.Open();

            System.Drawing.Bitmap bmp = System.Drawing.Image.FromHbitmap(Properties.Resources.img_kyocera.GetHbitmap());

            var converter = new System.Drawing.ImageConverter();
            Image img = Image.GetInstance((byte[])converter.ConvertTo(bmp, typeof(byte[])));
            img.SetAbsolutePosition(0, doc.PageSize.Height - img.Height);
            doc.Add(img);

            PdfPTable ptb = null;
            Font headerFont = FontFactory.GetFont("Calibri", 13);
            Font cellFont = FontFactory.GetFont("Calibri", 10);

            string title = filename.Substring(0, filename.LastIndexOf("."));

            PdfPCell hTitle = new PdfPCell(new Phrase("Mgt No : " +title  + "\nDownload Datetime : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), headerFont));
            PdfPCell hChaseNo = new PdfPCell(new Phrase("Chase No.", headerFont));
            PdfPCell hItemText = new PdfPCell(new Phrase("Item Text", headerFont));
            PdfPCell hPartNo = new PdfPCell(new Phrase("Part No.", headerFont));
            PdfPCell hRingi = new PdfPCell(new Phrase("Ringi", headerFont));
            PdfPCell hVendor = new PdfPCell(new Phrase("Vendor", headerFont));

            ptb = new PdfPTable(5);
            ptb.SpacingBefore = 0;

            float width = PageSize.A4.Rotate().Width / 5;
            float[] headerWidths = { width - 50, width + 50, width - 50, width - 50, width + 100 };
            ptb.SetWidths(headerWidths);
            ptb.WidthPercentage = 100;

            hTitle.HorizontalAlignment = Element.ALIGN_LEFT;
            hTitle.Colspan = 5;
            hTitle.Border = iTextSharp.text.Rectangle.NO_BORDER;

            ptb.DefaultCell.BorderWidth = 2;
            ptb.DefaultCell.HorizontalAlignment = 1;

            hChaseNo.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);
            hItemText.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);
            hPartNo.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);
            hRingi.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);
            hVendor.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);

            ptb.AddCell(hTitle);
            ptb.AddCell(hChaseNo);
            ptb.AddCell(hItemText);
            ptb.AddCell(hPartNo);
            ptb.AddCell(hRingi);
            ptb.AddCell(hVendor);

            foreach (DataRow row in table.Rows)
            {
                string chaseNo = row.ItemArray[0].ToString();
                string itemText = row.ItemArray[1].ToString();

                PdfPCell cChaseNo = new PdfPCell(new Phrase(chaseNo, cellFont));
                PdfPCell cItemText = new PdfPCell(new Phrase(itemText, cellFont));
                PdfPCell cPartNo = new PdfPCell(new Phrase(row.ItemArray[2].ToString(), cellFont));
                PdfPCell cRingi = new PdfPCell(new Phrase(row.ItemArray[3].ToString(), cellFont));
                PdfPCell cVendor = new PdfPCell(new Phrase(row.ItemArray[4].ToString(), cellFont));

                ptb.AddCell(cChaseNo);
                ptb.AddCell(cItemText);
                ptb.AddCell(cPartNo);
                ptb.AddCell(cRingi);
                ptb.AddCell(cVendor);

                string updateText = string.Format("update TB_MOULD_MAIN set mm_pdfid = '{0}', mm_status_code = 'A' where mm_chaseno = '{1}'", title, chaseNo);
                DataService.GetInstance().ExecuteNonQuery(updateText);

                string mpa = Mould.GetMpa(chaseNo);
                string vendor = Mould.GetVendor(chaseNo);

                //string faText = string.Format("insert into TB_FA_APPROVAL (f_chaseno, f_pdfid, f_status, f_desc, f_mpa, f_vendor)" +
                   // " values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", chaseNo, title, "IPO 1st Approval", cItemText, mpa, vendor);
                string faText = string.Format("insert into TB_FA_APPROVAL (f_applicant, f_type, f_chaseno, f_pdfid, f_status, f_desc, f_mpa" +
                    ", f_vendor, f_mould) values (N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", GlobalService.Owner, "Acquisition", chaseNo,
                    title, itemText, DataUtil.GetMpa(chaseNo), DataUtil.GetVendor(chaseNo), DataUtil.GetMouldNo(chaseNo));
                DataService.GetInstance().ExecuteNonQuery(faText);
            }
            doc.Add(ptb);
            doc.Close();
        }
    }
}
