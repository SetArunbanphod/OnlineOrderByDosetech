using Spire.Xls;
using Spire.Xls.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrderCMG.Repository
{
    public class FileRepository
    {
        public static void CreateCreateDirectory(string path)
        {
            try
            {
                //DateTime dateTime = DateTime.Now;
                //string dd = dateTime.Day.ToString();
                //string MM = dateTime.Month.ToString();
                //string yyyy = dateTime.Year.ToString();
                //string folderName = yyyy + MM + dd + "-2";
                //path += folderName;
                if (Directory.Exists(path))
                {
                    Debug.WriteLine("That path exists already.");
                    return;
                }
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            catch (Exception e)
            {
                Debug.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public static List<string> GetFileName(string path)
        {
            if (Directory.Exists(path))
            {
                List<string> fileNameList = new List<string>();
                string[] thisPath = Directory.GetFiles(path);
                foreach (string fileName in thisPath)
                {
                    fileNameList.Add(Path.GetFileName(fileName));
                }
                return fileNameList;
            }
            return new List<string>();
        }

        public static List<string> GetDirectoryName(string path)
        {
            if (Directory.Exists(path))
            {
                return (Directory.GetDirectories(path)).ToList();
            }
            return new List<string>();
        }

        public static void ReadExcelFile(string path)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(path);
            Worksheet sheet = workbook.Worksheets[0];
            int colCount = sheet.Columns.Count();
            int rowCount = 0;
            int OrderNumberIndex = -1;
            for (int i = 0; i < colCount; i++)
            {
                if (sheet.Columns[i].Cells[0].Value == "Order number")
                {
                    OrderNumberIndex = i;
                    break;
                }
            }
            if (OrderNumberIndex != -1)
            {
                while (rowCount < sheet.Rows.Count() && sheet.Columns[0].Cells[rowCount].Value != "") rowCount++;
            }



            //for (int i = 0; i < colCount; i++)
            //{
            //    string valueOfCell = sheet.Cells[i].Value;
            //    valueOfCell = valueOfCell.Replace("      ", "_");
            //    valueOfCell = valueOfCell.Replace("     ", "_");
            //    valueOfCell = valueOfCell.Replace("    ", "_");
            //    valueOfCell = valueOfCell.Replace("   ", "_");
            //    valueOfCell = valueOfCell.Replace("  ", "_");
            //    valueOfCell = valueOfCell.Replace(" ", "_");
            //    valueOfCell = valueOfCell.Replace("-", "_");
            //    //Debug.WriteLine(valueOfCell);

            //    string[] spearator = valueOfCell.Split(new char[]{ '_', ' ' },2,StringSplitOptions.None);

            //    string text = "";
            //    foreach (string str in spearator)
            //    {
            //        if(str!="") text += ((char.ToUpper(str[0])) + str.Substring(1));
            //    }
            //    text = "_" + text + " TTTTT";
            //    rowCount++;
            //    sheet.Columns[0].Cells[rowCount].Value = sheet.Cells[i].Value;
            //    sheet.Columns[1].Cells[rowCount].Value = text;
            //}

            //workbook.Save();
        }
    }
}
