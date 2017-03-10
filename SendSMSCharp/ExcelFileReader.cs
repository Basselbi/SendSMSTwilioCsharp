using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System.Runtime.InteropServices;
using Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace SendSMSCharp
{
    class ExcelFileReader
    {
     
        protected List<string> numberListFormatted = new List<string>();
        public List<string> NumberListFormatted
        {
            get { return numberListFormatted; }
            set { numberListFormatted = value; }
        }

      
        public ExcelFileReader(List<string> numberListFormatted)
        {
            this.numberListFormatted = numberListFormatted;
        }

        public ExcelFileReader()
        {
            
        }

    

    public IExcelDataReader readExcelFile(string filePath,char column)
        {
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            string ext = Path.GetExtension(filePath);
            IExcelDataReader excelReader = null;

            switch (ext)
            {
                case ".xls":
                    //1. Reading from a binary Excel file ('97-2003 format; *.xls)
                     excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    //...
                    break;
                case ".xlsx":
                    //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    break;
                default:
                    break;
            }
            //3. DataSet - The result of each spreadsheet will be created in the result.Tables
            DataSet allResult = excelReader.AsDataSet();
            //...111111111111111
            //4. DataSet - Create column names from first row
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            //5. Data Reader methods
             string str="";
           int index= indexColumnExcel(column);
            while (excelReader.Read())
            {
                str = excelReader.GetString(index);
                if (!string.IsNullOrEmpty(str))
                {   
                    NumberListFormatted.Add(str);     
                }
            }

            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
            return excelReader;
        }

       
        private int indexColumnExcel(char alphabet)

        {

            int index = ((int)char.ToUpper(alphabet)) - 65;
            return index;

        }

    }
}
