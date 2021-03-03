using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS.Common.Utility
{
    public class NPOIHelper
    {
        public static void ExportExcel(DataTable dt,Dictionary<string,string> columns,string path,string sheetName)
        {
            try
            {
                IWorkbook workbook = null;
                string fileExt = Path.GetExtension(path).ToLower();
                if (fileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook();
                }
                else if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook();
                }
                else
                {
                    throw new ArgumentException("文件扩展名错误。");
                }
                ISheet sheet = workbook.CreateSheet(sheetName);//创建一个 sheet 表
                IRow rowH = sheet.CreateRow(0);//创建标题行
                int k = 0;
                foreach (var col in columns)
                {
                    sheet.AutoSizeColumn(k);
                    ICell cell = rowH.CreateCell(k);
                    cell.SetCellValue(col.Value);
                    cell.CellStyle = GetColumnHeaderStyle(workbook);
                    k++;
                }
                //for (int i = 0; i < columns.Count; i++)
                //{
                //    ICell cell= rowH.CreateCell(i);
                //    cell.SetCellValue(columns[i]);
                //    cell.CellStyle = GetColumnHeaderStyle(workbook);
                //}
                ICellStyle cellStyle= GetContentCellStyle(workbook);
                for (int i = 0; i < dt.Rows.Count; i++)//写入数据
                {
                    IRow row = sheet.CreateRow(i + 1); //跳过第一行，第一行为列名
                    int j = 0;
                    foreach (var col in columns)
                    {
                        ICell cell = row.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][col.Key].ToString());
                        cell.CellStyle = cellStyle;
                        j++;
                    }
                    //for (int j = 0; j < dt.Columns.Count; j++)
                    //{
                    //    ICell cell = row.CreateCell(j);
                    //    cell.SetCellValue(dt.Rows[i][j].ToString());
                    //    var ss= dt.Rows[i][""];
                    //    cell.CellStyle = cellStyle;
                    //}
                }
                for (int columnNum = 0; columnNum < columns.Count; columnNum++)
                {
                    int columnWidth = sheet.GetColumnWidth(columnNum) / 256;
                    for (int rowNum = 0; rowNum <= sheet.LastRowNum; rowNum++)
                    {
                        IRow currentRow = sheet.GetRow(rowNum);
                        if (currentRow.GetCell(columnNum) != null)
                        {
                            ICell currentCell = currentRow.GetCell(columnNum);
                            int length = Encoding.Default.GetBytes(currentCell.ToString()).Length;
                            if (columnWidth < length+4)
                            {
                                columnWidth = length+4;
                            }
                        }
                    }
                    sheet.SetColumnWidth(columnNum, columnWidth * 256);
                }
                MemoryStream ms = new MemoryStream();//创建一个 IO 流
                workbook.Write(ms);  //写入到流
                byte[] bytes = ms.ToArray(); //转换为字节数组
                using (FileStream file = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    file.Write(bytes, 0, bytes.Length);
                    file.Flush();
                }
                //workbook.Close();
                //sheet = null;
                //workbook = null;

                // ICell cell = null; //创建一个单元格

                ////设置列名
                //foreach (DataColumn col in dt.Columns)
                //{
                //    //创建单元格并设置单元格内容
                //    rowH.CreateCell(col.Ordinal).SetCellValue(col.Caption);

                //    //设置单元格格式
                //    rowH.Cells[col.Ordinal].CellStyle = cellStyle;
                //}
                //for (int i = 0; i < columnHeaders.Length; i++)
                //{
                //    sheet.AutoSizeColumn(i);

                //    //创建单元格并设置单元格内容
                //    rowH.CreateCell(i).SetCellValue(columnHeaders[i]);

                //    //设置单元格格式
                //    rowH.Cells[i].CellStyle = cellStyle;
                //}


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 获取标题单元格格式
        /// </summary>
        /// <param name="workbook"></param>
        /// <returns></returns>
        public static ICellStyle GetColumnHeaderStyle(IWorkbook workbook)
        {
            ICellStyle cellStyle = workbook.CreateCellStyle(); //创建单元格样式
            IDataFormat dataFormat = workbook.CreateDataFormat();  //创建格式
            cellStyle.DataFormat = dataFormat.GetFormat("@"); //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
            cellStyle.Alignment = HorizontalAlignment.Center; //水平居中
            cellStyle.VerticalAlignment = VerticalAlignment.Center; //垂直居中
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            cellStyle.BorderTop = BorderStyle.Thin;
            IFont font = workbook.CreateFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = (short)14; //设置字体大小
            font.Color = IndexedColors.Black.Index;
            cellStyle.SetFont(font);  //设置cellStyle 样式的字体
            return cellStyle;
        }
        /// <summary>
        /// 获取内容单元格格式
        /// </summary>
        /// <param name="workbook"></param>
        /// <returns></returns>
        public static ICellStyle GetContentCellStyle(IWorkbook workbook)
        {
            ICellStyle cellStyle = workbook.CreateCellStyle(); //创建单元格样式
            IDataFormat dataFormat = workbook.CreateDataFormat();  //创建格式
            cellStyle.DataFormat = dataFormat.GetFormat("@"); //设置为文本格式，也可以为 text，即 dataFormat.GetFormat("text");
            cellStyle.Alignment = HorizontalAlignment.Center; //水平居中
            cellStyle.VerticalAlignment = VerticalAlignment.Center; //垂直居中
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            cellStyle.BorderTop = BorderStyle.Thin;
            IFont font = workbook.CreateFont();
            font.FontName = "宋体";
            font.FontHeightInPoints = (short)12; //设置字体大小
            font.Color = IndexedColors.Black.Index;
            cellStyle.SetFont(font);  //设置cellStyle 样式的字体
            return cellStyle;
        }
    }
}
