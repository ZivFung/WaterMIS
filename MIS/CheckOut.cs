using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS
{
    public partial class CheckOut : Form
    {
        DataGridView DataViewSheetview;
        public CheckOut(DataGridView datagridview)
        {
            InitializeComponent();
            DataViewSheetview = datagridview;
            this.Conotent_TextBox.Focus();
        }

        public string CheckOutSheetName
        {
            get;
            set;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string CheckContent
        {
            get;
            set;
        }
        public bool exsist
        {
            get;
            set;
        }
        bool Finded = false;

        int last_colunm_num = -1;
        int last_row_num = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            CheckContent = this.Conotent_TextBox.Text.ToString();
            //this.Hide();
            int colum_num = this.DataViewSheetview.ColumnCount;
            int row_num = this.DataViewSheetview.RowCount;

            for (int j = last_colunm_num + 1; j < colum_num; j++)
            {
                if (this.DataViewSheetview.Rows[last_row_num].Cells[j].Value.ToString().Contains(CheckContent))
                {
                    this.DataViewSheetview.CurrentCell = this.DataViewSheetview.Rows[last_row_num].Cells[j];
                    Finded = true;
                    if (j == colum_num)
                    {
                        last_colunm_num = -1;
                        last_row_num = last_row_num + 1;
                    }
                    else
                    {
                        last_colunm_num = j;
                        last_row_num = last_row_num;
                    }
                }
                if (Finded) break;
            }
            if (!Finded)
            {
                for (int i = last_row_num + 1; i < row_num - 1; i++)
                {
                    for (int j = 0; j < colum_num; j++)
                    {
                        if (this.DataViewSheetview.Rows[i].Cells[j].Value.ToString().Contains(CheckContent))
                        {
                            this.DataViewSheetview.CurrentCell = this.DataViewSheetview.Rows[i].Cells[j];
                            Finded = true;
                            if (j == colum_num)
                            {
                                last_colunm_num = -1;
                                last_row_num = i + 1;
                            }
                            else
                            {
                                last_colunm_num = j;
                                last_row_num = i;
                            }
                        }
                        if (Finded) break;
                    }
                    if (Finded) break;
                }

                if (Finded)
                {
                    Finded = false;
                }
                else
                {
                    if (last_colunm_num > -1)
                    {
                        last_colunm_num = -1;
                        last_row_num = 0;
                        for (int i = 0; i < row_num - 1; i++)
                        {
                            for (int j = 0; j < colum_num; j++)
                            {
                                if (this.DataViewSheetview.Rows[i].Cells[j].Value.ToString() == CheckContent)
                                {
                                    this.DataViewSheetview.CurrentCell = this.DataViewSheetview.Rows[i].Cells[j];
                                    Finded = true;
                                    last_colunm_num = j;
                                    last_row_num = i;
                                }
                                if (Finded) break;
                            }
                            if (Finded) break;
                        }
                        Finded = false;
                    }
                    else
                    {
                        MessageBox.Show("未找到该内容！");
                    }
                }

            }
            Finded = false;
            this.Conotent_TextBox.SelectAll();
            
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {

        }

        private void CheckOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
