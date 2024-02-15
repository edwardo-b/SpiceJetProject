﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using excel = Microsoft.Office.Interop.Excel;
using NPOI.XSSF.UserModel;
using NPOI.SS;
using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SpiceJetProject.Variable
{
    public class ExcelFile
    {
        public String random;
       public string  value;
        public String randomAirportFromElem;
        private TimeSpan? pageLoadTimeout;

        public ExcelFile() { }
        private static readonly Lazy<Logger> LazyInstance = new Lazy<Logger>(() => new Logger());
        public static Logger Instance => LazyInstance.Value;

        public void ReadExcel()

        {
            string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            XSSFWorkbook wb = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = wb.GetSheetAt(0);
            var row = sheet.GetRow(0);
            for (int i = 1; i < row.Cells.Count; i++)
            {
              //  value = row.Cells[i].StringCellValue.Trim();
               string value = row.GetCell(i).StringCellValue.Trim();
                
                Console.WriteLine(value);
            }
        }

        public void destinationTown() 
        {
            Random ran = new Random();
            String[] b = { "DED","DEL", "DHM", "RDP","GOI","GAU", "GWL","HYD","JLR","JAI","JSA","AIP" };
            int length = 1;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(b.Length);
                random = random + b.ElementAt(a);
                Console.WriteLine(random);
            }
        }
        //Both codes work the same
        public void arrivalTown()
        {
            String[] airportsNames = { "AGR", "AMD", "KQH", "ATQ", "IXB", "IXG", "BLR", "BHU", "BHO", "IXC", "MAA", "CJB", "DBR" };
            Random rnd = new Random();
            int randAirportIdx = rnd.Next(airportsNames.Length);
            String randomAirportFromElem = airportsNames[randAirportIdx];
            Console.WriteLine(randomAirportFromElem);
        }

        public void tryToImportFromExcel()
        {
            /*string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            XSSFWorkbook wb = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = wb.GetSheetAt(0);
            var row = sheet.GetRow(0);
            for (int i = 1; i < row.Cells.Count; i++)
            {
                //  value = row.Cells[i].StringCellValue.Trim();
                var value = row.GetCell(i).StringCellValue.Trim();
            */
            string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(path);
            Worksheet worksheet = document.Workbook.Worksheets[0];
            for (int i = 1; i < 10; i++)
            {
                var value = Convert.ToString(worksheet.Cell(0, i));

                Console.WriteLine(value);

                String[] airportsNames = {value};
                Random rnd = new Random();
                int randAirportIdx = rnd.Next(airportsNames.Length);
                String randomAirportFromElem = airportsNames[randAirportIdx];
                Console.WriteLine(randomAirportFromElem);
            }
            //}
        }
        public void phoneNumber()

        {
            string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            XSSFWorkbook wb = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = wb.GetSheetAt(1);
            var row = sheet.GetRow(0);
            for (int i = 1; i < row.Cells.Count; i++)
            {
                //  value = row.Cells[i].StringCellValue.Trim();
                var value = Convert.ToString(row.GetCell(i).StringCellValue.Trim());

                Console.WriteLine(value);
            }
        }

        public void phoneNumber2()
        {
            string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(path);
            Worksheet worksheet = document.Workbook.Worksheets[1];
            var value = Convert.ToString(worksheet.Cell(1, 1));
            try
            {
                Console.WriteLine(value);
            }
            catch(Exception e) {Console.WriteLine( e.Message); }
           /* for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var value = Convert.ToString( worksheet.Cell(0, 1));
                   
                    Console.WriteLine(value);
                }
            } */
           

        }

        public void WaitForPageToLoad()
        {
            
            ConditionalWait.WaitForTrue(() => ExecuteScript<bool>("return document['readyState'] ? 'complete' === document.readyState : true;", Array.Empty<object>()), pageLoadTimeout, null, "Page loading timed out");
        }

        public static void WaitForTrue(Func<bool> condition, TimeSpan? timeout = null, TimeSpan? pollingInterval = null, string message = null)
        {
            if (condition == null)
            {
                throw new ArgumentNullException("condition", "condition cannot be null");
            }

            TimeSpan timeSpan = ResolveConditionTimeout(timeout);
            TimeSpan timeout2 = ResolvePollingInterval(pollingInterval);
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                if (condition())
                {
                    return;
                }

                if (stopwatch.Elapsed > timeSpan)
                {
                    break;
                }

                Thread.Sleep(timeout2);
            }

            DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
            defaultInterpolatedStringHandler.AppendLiteral("Timed out after ");
            defaultInterpolatedStringHandler.AppendFormatted(timeSpan.TotalSeconds);
            defaultInterpolatedStringHandler.AppendLiteral(" seconds");
            string text = defaultInterpolatedStringHandler.ToStringAndClear();
            if (!string.IsNullOrEmpty(message))
            {
                text = text + ": " + message;
            }

            throw new TimeoutException(text);
        }

        private static TimeSpan ResolvePollingInterval(TimeSpan? pollingInterval)
        {
            throw new NotImplementedException();
        }

        private static TimeSpan ResolveConditionTimeout(TimeSpan? timeout)
        {
            throw new NotImplementedException();
        }
        

        private void WaitForTrue(Func<bool> value1, object pageLoadTimeout, object value2, string v)
        {
            throw new NotImplementedException();
        }

        private T ExecuteScript<T>(string v, object[] objects)
        {
            throw new NotImplementedException();
        }
    }

    internal class ConditionalWait
    {
        internal static void WaitForTrue(Func<bool> value1, TimeSpan? pageLoadTimeout, object value2, string v)
        {
            throw new NotImplementedException();
        }
    }
}
