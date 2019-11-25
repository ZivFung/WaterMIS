using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.OleDb;
using Aspose.Cells;
//using Excel = Microsoft.Office.Interop.Excel;

namespace MIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            //LogIn();
            MISDataBaseConnection = LinkDataBaseFile();
            this.TopLevel = true;
        }

        public int Authority
        {
            get;
            set;
        }

        private void LogIn()
        {
            Login logform = new Login();
            logform.Show();
            this.Enabled = false;
            logform.TopLevel = true;
           
            //this.Visible = false;
        }

        SqlConnection MISDataBaseConnection;
        DataSet MISDataSet = new DataSet();
        DataTable MISDataTable = new DataTable();

        private SqlConnection LinkDataBaseFile()
        {
            string DataBaseLinkString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\学习\大三上课件\课设\database\information.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection DataBaseConnection = new SqlConnection(DataBaseLinkString);
            try
            {
                DataBaseConnection.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("读取数据库失败!");
            }
            DataBaseConnection.Close();
            return DataBaseConnection;
        }

        private void CheckTheSelectedSheet(SqlConnection DBConnection,DataSet MisDataSet)
        {
            string OperationSql = "select * from Irrigated_area$";
            string SelectedItem = CombBoxSelectSheet.SelectedItem.ToString();
            if (SelectedItem == "历年水库来水量")
            {
                OperationSql = "select * from Water_in$";
            }
            else if (SelectedItem == "水库来水量预测")
            {
                OperationSql = "select * from Water_in_predicted$";
            }
            else if (SelectedItem == "灌溉面积统计表")
            {
                OperationSql = "select * from Irrigated_area$";
            }
            else if (SelectedItem == "灌溉制度")
            {
                OperationSql = "select * from irrigation_program$";
            }
            else if (SelectedItem == "农作物需水总量表")
            {
                OperationSql = "select * from 'Wate_supply&demand$'";
            }
            else
            {

                MessageBox.Show("请选中指定数据！");
                return;
            }
            MisDataSet.Tables.Clear();
            SqlCommand DataBaseCommand = new SqlCommand(OperationSql, DBConnection);
            SqlDataAdapter DataBaseSqlAdapter = new SqlDataAdapter(DataBaseCommand);
            DataBaseSqlAdapter.Fill(MisDataSet);
            DataBaseSqlAdapter.Fill(MISDataTable);
            BindingSource DataBind = new BindingSource();
            DataBind.DataSource = MisDataSet.Tables[0];
            DataViewSheetview.DataSource = DataBind;
            //DataViewSheetview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
        }

        private void ChangeDataBaseFromDataGridView(SqlConnection DBConnection, DataSet MisDataSet)
        {
            if (Authority == 0)
            {
                string OperationSql = "update 表1历年水库来水量$";// UPDATE Table1 SET RoleName2 = 'Ghost' WHERE ID = 1

            SqlCommand DataBaseCommand = new SqlCommand(OperationSql, DBConnection);
            SqlDataAdapter DataBaseSqlAdapter = new SqlDataAdapter(DataBaseCommand);
            SqlCommandBuilder cb = new SqlCommandBuilder(DataBaseSqlAdapter);
            DataBaseSqlAdapter.Update(MISDataTable);

                //DataBaseSqlAdapter.Fill(MisDataSet);
                //DataBaseSqlAdapter.Update(MisDataSet);
            }
            else
            {
                MessageBox.Show("更改无权限！");
            }
        }

        private void DataSetTableToExcel(DataSet dataset)
        {

                DataTable Table = dataset.Tables[0];
            //int RowNumber = Table.Rows.Count;
            //int ColumnNumber = Table.Columns.Count;

            //if (RowNumber == 0)
            //{
            //    MessageBox.Show("没有任何数据可以打印！");
            //}

            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            //excel.Application.Workbooks.Add(true);

            //excel.Visible = true;

            //for (int i = 0; i < ColumnNumber; i++)
            //{
            //    excel.Cells[1, i + 1] = dataset.Tables[0].Columns[i].ColumnName;
            //}
            //for (int c = 0; c < RowNumber; c++)
            //{
            //    for (int j = 0; j < ColumnNumber; j++)
            //    {
            //        excel.Cells[c + 2, j + 1] = Table.Rows[c].ItemArray[j];
            //    }
            //}

            //string json = value.Value;
            //DataTable dt = Utils.JsonDataTableConvert.ToDataTable(json);

            //string fileName = tableTemplate.Name + ".xls";
            //string savePath = Server.MapPath("~/Upload/TempExcelDownLoad/" + fileName);
            string FilePath = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "excel表格|*.xlsx|excel表格|*.xls|所有文件|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                
                FilePath = System.IO.Path.GetFullPath(sfd.FileName);
                Workbook book = new Workbook();
                Worksheet sheet = book.Worksheets[0];
                Cells cells = sheet.Cells;
                

                int Colnum = Table.Columns.Count;//表格列数 
                int Rownum = Table.Rows.Count;//表格行数 
                                              //生成行 列名行 
                for (int i = 0; i < Colnum; i++)
                {
                    cells[0, i].PutValue(Table.Columns[i].ColumnName);
                }
                //生成数据行 
                for (int i = 0; i < Rownum; i++)
                {
                    for (int k = 0; k < Colnum; k++)
                    {
                        cells[1 + i, k].PutValue(Table.Rows[i][k].ToString());
                    }
                }
                book.Save(FilePath);
            }
        }
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            ChangeDataBaseFromDataGridView(MISDataBaseConnection, MISDataSet);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            CheckTheSelectedSheet(MISDataBaseConnection, MISDataSet);
        }

        private void CombBoxSelectSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataViewSheetview_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            DataSetTableToExcel(MISDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileSelect = new OpenFileDialog();
            FileSelect.Filter = "excel表格|*.xls;*.xlsx|所有文件|*.*";
            FileSelect.FilterIndex = 1;

            if (FileSelect.ShowDialog() == DialogResult.OK)
            {
                string FilePath;
                FilePath = System.IO.Path.GetFullPath(FileSelect.FileName);
                TransferExcelDataToDataBase(FilePath, FileSelect.FileName,MISDataSet);
            }

            //FileSelect.ge
        }

        private void TransferExcelDataToDataBase(string SheetPath,string Sheetname,DataSet MisDataset)
        {
            // OleDbConnection ole = null;
            // OleDbDataAdapter da = null;
            // DataTable dt = null;
            // string strConn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};" + "Extended Properties='Excel 8.0;HDR=NO;IMEX=1';", Sheetname.Trim());
            // if ((System.IO.Path.GetExtension(Sheetname.Trim())).ToLower() == ".xls")
            // {
            //     strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "data source=" + Sheetname.Trim() + ";Extended Properties=Excel 5.0;Persist Security Info=False";
            // }
            //// string sTableName = "1234";
            // string strExcel = "select * from [1234$]";
            // try
            // {
            //     ole = new OleDbConnection(strConn);
            //     ole.Open();
            //     DataTable OleDataTable = ole.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            //     string SheetName = OleDataTable.Rows[0][2].ToString().Trim();

            //     strExcel = String.Format("select * from[" + SheetName + "]");
            //     da = new OleDbDataAdapter(strExcel, ole);
            //     dt = new DataTable();
            //     da.Fill(dt);
            //     this.DataViewSheetview.DataSource = dt;
            //     //因为生成Excel的时候第一行是标题，所以要做如下操作：  
            //     //1.修改DataGridView列头的名字，  
            //     //2.数据列表中删除第一行  
            //     for (int i = 0; i < dt.Columns.Count; i++)
            //     {
            //         DataViewSheetview.Columns[i].HeaderCell.Value = dt.Rows[0][i].ToString();//c# winform 用代码修改DataGridView列头的名字，设置列名,修改列名  
            //     }
            //     //DataGridView删除行  
            //     DataViewSheetview.Rows.Remove(DataViewSheetview.Rows[0]);//删除第一行  
            //     ole.Close();
            // }
            // catch (Exception ex)
            // {
            //     MessageBox.Show(ex.Message);
            // }
            // finally
            // {
            //     if (ole != null)
            //         ole.Close();
            // }
           // DataSet ds = new DataSet();
            Workbook workBook = new Workbook(SheetPath);
            //string SheetName = workBook.Worksheets[0].Name;      
            //Worksheet workSheet = workBook.Worksheets[Sheetname];
            Worksheet workSheet = workBook.Worksheets[0];
            Cells cell = workSheet.Cells;
            DataTable dt = new DataTable();
            int count = cell.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                string str = cell.GetRow(0)[i].StringValue;
                dt.Columns.Add(new DataColumn(str));
            }
            for (int i = 1; i < cell.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < count; j++)
                {
                    dr[j] = cell[i, j].StringValue;
                }
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
            this.DataViewSheetview.DataSource = dt;
            MisDataset.Tables.Add(dt);
           // return ds;                                                                                     

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int row_count = this.DataViewSheetview.SelectedRows.Count;
                //DataViewSheetview.Rows.RemoveAt(row_count + 1);
                MISDataSet.Tables[0].Rows.RemoveAt(row_count - 1);
            }
            catch
            {
                MessageBox.Show("请选中要删除的行！");
            }

        }

        private void CheckOut_Button_Click(object sender, EventArgs e)
        {
            CheckOut checkoutform = new CheckOut(this.DataViewSheetview);
            checkoutform.Show();
            //checkoutform.CheckOutSheetName = this.CombBoxSelectSheet.SelectedItem.ToString();

        }
    }
}
