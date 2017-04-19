using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace KDTHK_MOULD_SYSTEM.output
{
    public class ExcelUtil
    {
        public static void SaveExcel(System.Data.DataTable table, string sheetName)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Sheets sheets = workbook.Worksheets;

            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.Sheets[1];
            sheet1.Name = sheetName;

            for (int i = 0; i < table.Columns.Count; i++)
                sheet1.Cells[1, i + 1] = table.Columns[i].ColumnName;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    if (table.Columns[j].ColumnName == "Vendor" || table.Columns[j].ColumnName == "Rev")
                        sheet1.Cells[i + 2, j + 1] = "'" + table.Rows[i][j].ToString();
                    else
                        sheet1.Cells[i + 2, j + 1] = table.Rows[i][j].ToString();
                }
            }

            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "xls",
                Filter = "EXCEL Files (*.xls)|*.xls",
                FilterIndex = 1
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelApp.ActiveWorkbook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8, null, null, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null, null);
                excelApp.Quit();
            }
        }
    }
}
