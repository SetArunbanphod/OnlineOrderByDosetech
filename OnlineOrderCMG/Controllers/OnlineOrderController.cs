using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineOrderCMG.Repository;
using Spire.Xls;

namespace OnlineOrderCMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineOrderController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            string path = @"C:\Users\Dosetech\source\repos\OnlineOrderCMG\OnlineOrderCMG\Files\MIRAKL\";
            //CreateCreateDirectory(path);

            List<string> directories = FileRepository.GetDirectoryName(path);
            List<string> files = FileRepository.GetFileName(path);
            foreach (string directoryName in directories)
            {
                string brandName = new DirectoryInfo(directoryName).Name;

                string subDirectory = @"\Excel\";
                string directoryPath = directoryName + subDirectory;

                List<string> excelList = FileRepository.GetFileName(directoryPath);
                foreach (string excelFile in excelList)
                {
                    Debug.WriteLine(brandName);
                    Debug.WriteLine("Excel file : " + excelFile);
                    if (!excelFile.Contains("~$"))
                    {
                        FileRepository.ReadExcelFile(directoryPath + excelFile);
                    }
                }
            }
            return Ok(1);
        }
    }
}