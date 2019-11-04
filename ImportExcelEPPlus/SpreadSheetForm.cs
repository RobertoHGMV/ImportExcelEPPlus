using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ImportExcelEPPlus
{
    public partial class SpreadSheetForm : Form
    {
        public SpreadSheetForm()
        {
            InitializeComponent();
            lbQtdLines.Text = string.Empty;
            lbQtdColumns.Text = string.Empty;
            cbSheet.SelectedIndexChanged += CbSheet_SelectedIndexChanged;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            try
            {
                var fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Excel Worksheets | *.xlsx;*.xls";
                fileDialog.Title = "Selecione o arquivo";

                if (fileDialog.ShowDialog() != DialogResult.OK) return;
                txtFileName.Text = fileDialog.FileName;

                this.Cursor = Cursors.WaitCursor;

                if (!File.Exists(fileDialog.FileName))
                    throw new Exception("Arquivo não encontrado");

                var spreadsheets = GetSheetNames(fileDialog.FileName);
                FillComboSheet(spreadsheets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private List<string> GetSheetNames(string fileName)
        {
            var sheetNames = new List<string>();

            using (var package = new ExcelPackage(new FileInfo(fileName)))
            {
                foreach (var workSheet in package.Workbook.Worksheets)
                    sheetNames.Add(workSheet.Name);
                
                return sheetNames;
            }
        }

        private DataTable GetSpreadsheets(string fileName, string sheetName)
        {
            using (var package = new ExcelPackage(new FileInfo(fileName)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[sheetName];

                var table = new DataTable(workSheet.Name);

                var firstLine = true;
                for (var row = workSheet.Dimension.Start.Row + 1; row <= workSheet.Dimension.End.Row; row++)
                {
                    var newRow = table.NewRow();

                    for (var column = workSheet.Dimension.Start.Column; column <= workSheet.Dimension.End.Column; column++)
                    {
                        if (workSheet.Cells[1, column].Value is null)
                            throw new Exception($"Não foi possível acessar o valor da coluna nº {column}.");

                        var columnName = workSheet.Cells[1, column].Value.ToString();
                        var value = workSheet.Cells[row, column].Value;

                        if (firstLine && !table.Columns.Contains(columnName))
                            table.Columns.Add(columnName);

                        newRow[columnName] = value;
                    }

                    table.Rows.Add(newRow);
                    firstLine = false;
                }

                return table;
            }
        }

        private void CbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var fileName = txtFileName.Text;
                var sheetName = cbSheet.SelectedValue.ToString();
                var dataTable = GetSpreadsheets(fileName, sheetName);

                FillGrid(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillComboSheet(List<string> sheetNames)
        {
            cbSheet.DataSource = sheetNames;
        }

        private void FillGrid(DataTable table)
        {
            gridImporter.DataSource = table;
            gridImporter.AutoGenerateColumns = true;
            lbQtdLines.Text = table.Rows.Count.ToString();
            lbQtdColumns.Text = table.Columns.Count.ToString();
        }
    }
}
