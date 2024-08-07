using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ManagementCars.GlobalClasses
{
    public class clsConvertDgvToExcel
    {
        public clsConvertDgvToExcel()
        {
            
        }

        public static bool ExportDataGridViewToExcel(DataGridView dgv, string filePath, bool TableRightToLeft, bool StyleLikeDgv, bool AutoFitColumns)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                // Ensure the file path ends with .xlsx
                if (!filePath.EndsWith(".xlsx"))
                {
                    filePath += ".xlsx";
                }
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    // Get visible columns
                    var visibleColumns = dgv.Columns.Cast<DataGridViewColumn>().Where(col => col.Visible).ToList();
                    int visibleColumnCount = visibleColumns.Count;

                    // Set headers
                    var headers = new object[visibleColumnCount];
                    var headerCells = worksheet.Cells[1, 1, 1, visibleColumnCount];

                    for (int i = 0; i < visibleColumnCount; i++)
                    {
                        headers[i] = visibleColumns[i].HeaderText;
                    }
                    headerCells.LoadFromArrays(new[] { headers });

                    // Set header styles
                    if (StyleLikeDgv)
                    {
                        headerCells.Style.Font.Bold = true;
                        headerCells.Style.Font.Name = dgv.Font.FontFamily.Name;
                        headerCells.Style.Font.Size = dgv.Font.Size;
                        headerCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        headerCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    }

                    // Set data
                    var data = new object[dgv.Rows.Count, visibleColumnCount];
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < visibleColumnCount; j++)
                        {
                            data[i, j] = dgv.Rows[i].Cells[visibleColumns[j].Index].Value?.ToString();
                        }
                    }
                    var dataRange = worksheet.Cells[2, 1, dgv.Rows.Count + 1, visibleColumnCount];
                    dataRange.LoadFromArrays(ToJaggedArray(data));

                    // Set data styles
                    if (TableRightToLeft)
                    {
                        dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                        worksheet.View.RightToLeft = true;
                    }
                    else
                    {
                        dataRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        worksheet.View.RightToLeft = false;
                    }

                    if (StyleLikeDgv)
                    {
                        dataRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        dataRange.Style.Font.Name = dgv.Font.FontFamily.Name;
                        dataRange.Style.Font.Size = dgv.Font.Size;
                    }

                    // Adjust column widths
                    if (AutoFitColumns)
                    {
                        worksheet.Cells.AutoFitColumns();
                    }

                    // Save the Excel package to the specified file
                    //FileInfo file = new FileInfo(filePath);

                    package.SaveAs(filePath);


                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static object[][] ToJaggedArray(object[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            var jaggedArray = new object[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new object[columns];
                for (int j = 0; j < columns; j++)
                {
                    jaggedArray[i][j] = array[i, j];
                }
            }

            return jaggedArray;
        }
    }
}

