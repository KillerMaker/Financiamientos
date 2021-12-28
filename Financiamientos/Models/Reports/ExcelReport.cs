
using System.Threading.Tasks;
using System.IO;
using OfficeOpenXml;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;

namespace Financiamientos.Models.Reports
{
    public class ExcelReport:Report
    {
        private FileInfo file;
        private ExcelPackage package;

        public ExcelReport(ReportMetaData metaData,string path=null):base(metaData,path)
        {
            file = new FileInfo(this.path + $@"\{this.metaData.creatorName}-{DateTime.Now.ToString("yyy-MM-dd hh-mm-ss")}.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public async Task CreateAndSaveFile(Action<ExcelWorksheet, ExcelRangeBase> setStyles=null)
        {
            if (file.Exists)
                throw new Exception($"Ya se encuentra un archivo con el nombre {file.Name} en la ruta {file.FullName}");

            package = new ExcelPackage(file);

            if (metaData is not null)
                AddMetaDataWorkSheet(setStyles);

            await package.SaveAsAsync(file);
        }

        public async Task AddWorkSheet(DataTable table, string workSheetName="Hoja Principal", Action<ExcelWorksheet, ExcelRangeBase> setStyles = null)
        {
            var workSheet = package.Workbook.Worksheets.Add(workSheetName);
            var range = workSheet.Cells["A2"].LoadFromDataTable(table, true);

            if (setStyles is not null)
                setStyles(workSheet, range);
      
            else
                AddDefaultStyle(workSheet, range);

            range.AutoFitColumns();

            //Workbook
            await package.SaveAsAsync(file);
        }

        public async Task AddWorkSheet(IEnumerable<DataTable>tables,Action<ExcelWorksheet, ExcelRangeBase> setStyles = null)
        {
            int i = 0;
            foreach(var table in tables)
            {
                if(table.Rows.Count>1)
                    await AddWorkSheet(table, $"Hoja {i++}", setStyles);
                continue;
            }
        }
        private void AddMetaDataWorkSheet(Action<ExcelWorksheet, ExcelRangeBase> setStyles = null)
        {
            var workSheet = package.Workbook.Worksheets.Add("Hoja de Cabecera");

            workSheet.Cells["A2"].Value = "Creado Por";
            workSheet.Cells["B2"].Value = metaData.creatorName;

            workSheet.Cells["A3"].Value = "Fecha de Creacion";
            workSheet.Cells["B3"].Value = metaData.dateOfCreation.ToString("yyy-MM-dd");

            workSheet.Cells["A4"].Value = "Origen de Datos";
            workSheet.Cells["B4"].Value = metaData.dataOrigin;

            workSheet.Cells["A5"].Value = "Descripcion";
            workSheet.Cells["B5"].Value = metaData.description;

            if (setStyles is not null)
                setStyles(workSheet, null);

            workSheet.Cells["A2:B5"].AutoFitColumns();
        }

        private void AddDefaultStyle(ExcelWorksheet ws, ExcelRangeBase rb)
        {
            //Titulo
            ws.Cells["A1"].Value = $"Reporte";
            ws.Cells["A1:Z1"].Merge = true;
            ws.Cells["A1:Z1"].Style.Font.Size = int.Parse(settings["default-report-title-font-size"].ToString());

            //Header
            ws.Row(2).Style.Font.Bold = (settings["default-report-header-font-bold"].ToString().Equals("1")) ? true : false;
            ws.Row(2).Style.Fill.SetBackground(Color.FromName(settings["default-report-header-backgound-color"]));
            ws.Row(2).Style.Font.Size = int.Parse(settings["default-report-header-font-size"].ToString());
        }

        public override void Dispose()
        {
            base.Dispose();

            package.Dispose();
            file = default;
        }
    }
}
