namespace MIS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonImport = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.CombBoxSelectSheet = new System.Windows.Forms.ComboBox();
            this.DataViewSheetview = new System.Windows.Forms.DataGridView();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.manage_SysDataSet = new MIS.Manage_SysDataSet();
            this.waterInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.water_InTableAdapter = new MIS.Manage_SysDataSetTableAdapters.Water_InTableAdapter();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckOut_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewSheetview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manage_SysDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonImport
            // 
            this.ButtonImport.Location = new System.Drawing.Point(352, 35);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.Size = new System.Drawing.Size(85, 35);
            this.ButtonImport.TabIndex = 0;
            this.ButtonImport.Text = "导入";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.ButtonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(450, 35);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(80, 35);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "保存";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(540, 35);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(81, 35);
            this.ButtonCalculate.TabIndex = 2;
            this.ButtonCalculate.Text = "计算";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // CombBoxSelectSheet
            // 
            this.CombBoxSelectSheet.FormattingEnabled = true;
            this.CombBoxSelectSheet.Items.AddRange(new object[] {
            "历年水库来水量",
            "水库来水量预测",
            "灌溉面积统计表",
            "灌溉制度",
            "农作物需水总量表"});
            this.CombBoxSelectSheet.Location = new System.Drawing.Point(12, 42);
            this.CombBoxSelectSheet.Name = "CombBoxSelectSheet";
            this.CombBoxSelectSheet.Size = new System.Drawing.Size(235, 23);
            this.CombBoxSelectSheet.TabIndex = 3;
            this.CombBoxSelectSheet.SelectedIndexChanged += new System.EventHandler(this.CombBoxSelectSheet_SelectedIndexChanged);
            // 
            // DataViewSheetview
            // 
            this.DataViewSheetview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataViewSheetview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataViewSheetview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataViewSheetview.Location = new System.Drawing.Point(12, 92);
            this.DataViewSheetview.Name = "DataViewSheetview";
            this.DataViewSheetview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataViewSheetview.RowTemplate.Height = 27;
            this.DataViewSheetview.Size = new System.Drawing.Size(474, 344);
            this.DataViewSheetview.TabIndex = 4;
            this.DataViewSheetview.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataViewSheetview_CellMouseDoubleClick);
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(253, 35);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(90, 35);
            this.ButtonCheck.TabIndex = 5;
            this.ButtonCheck.Text = "查看";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // manage_SysDataSet
            // 
            this.manage_SysDataSet.DataSetName = "Manage_SysDataSet";
            this.manage_SysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // waterInBindingSource
            // 
            this.waterInBindingSource.DataMember = "Water_In";
            this.waterInBindingSource.DataSource = this.manage_SysDataSet;
            // 
            // water_InTableAdapter
            // 
            this.water_InTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(629, 35);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(90, 35);
            this.ButtonPrint.TabIndex = 6;
            this.ButtonPrint.Text = "打印";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(598, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckOut_Button
            // 
            this.CheckOut_Button.Location = new System.Drawing.Point(564, 129);
            this.CheckOut_Button.Name = "CheckOut_Button";
            this.CheckOut_Button.Size = new System.Drawing.Size(75, 23);
            this.CheckOut_Button.TabIndex = 8;
            this.CheckOut_Button.Text = "查询";
            this.CheckOut_Button.UseVisualStyleBackColor = true;
            this.CheckOut_Button.Click += new System.EventHandler(this.CheckOut_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 460);
            this.Controls.Add(this.CheckOut_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.DataViewSheetview);
            this.Controls.Add(this.CombBoxSelectSheet);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonImport);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "水信息管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewSheetview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manage_SysDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterInBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonImport;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.ComboBox CombBoxSelectSheet;
        private System.Windows.Forms.DataGridView DataViewSheetview;
        private System.Windows.Forms.Button ButtonCheck;
        private Manage_SysDataSet manage_SysDataSet;
        private System.Windows.Forms.BindingSource waterInBindingSource;
        private Manage_SysDataSetTableAdapters.Water_InTableAdapter water_InTableAdapter;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CheckOut_Button;
    }
}

