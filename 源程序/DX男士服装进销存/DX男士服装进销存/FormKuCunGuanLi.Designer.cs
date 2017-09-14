namespace DX男士服装进销存
{
    partial class FormKuCunGuanLi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableStorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCLDataSet = new DX男士服装进销存.DBCLDataSet();
            this.table_StorTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_StorTableAdapter();
            this.Text盘点数量 = new DevExpress.XtraEditors.TextEdit();
            this.bt保存 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcJingGaoNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcDataTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.text商品名称 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.text商品编号 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text盘点数量.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // tableStorBindingSource
            // 
            this.tableStorBindingSource.DataMember = "Table_Stor";
            this.tableStorBindingSource.DataSource = this.dBCLDataSet;
            // 
            // dBCLDataSet
            // 
            this.dBCLDataSet.DataSetName = "DBCLDataSet";
            this.dBCLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_StorTableAdapter
            // 
            this.table_StorTableAdapter.ClearBeforeFill = true;
            // 
            // Text盘点数量
            // 
            this.Text盘点数量.EditValue = "";
            this.Text盘点数量.Location = new System.Drawing.Point(697, 42);
            this.Text盘点数量.Margin = new System.Windows.Forms.Padding(4);
            this.Text盘点数量.Name = "Text盘点数量";
            this.Text盘点数量.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.Text盘点数量.Properties.Appearance.Options.UseFont = true;
            this.Text盘点数量.Properties.Mask.BeepOnError = true;
            this.Text盘点数量.Properties.Mask.EditMask = "n0";
            this.Text盘点数量.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Text盘点数量.Size = new System.Drawing.Size(186, 26);
            this.Text盘点数量.TabIndex = 38;
            // 
            // bt保存
            // 
            this.bt保存.Appearance.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold);
            this.bt保存.Appearance.Options.UseFont = true;
            this.bt保存.Location = new System.Drawing.Point(889, 12);
            this.bt保存.Name = "bt保存";
            this.bt保存.Size = new System.Drawing.Size(112, 57);
            this.bt保存.TabIndex = 1;
            this.bt保存.Text = "保  存";
            this.bt保存.Click += new System.EventHandler(this.bt保存_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(594, 49);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "盘 点 数 量 ：";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.DataSource = this.tableStorBindingSource;
            this.gridControl.Location = new System.Drawing.Point(0, 75);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1075, 441);
            this.gridControl.TabIndex = 45;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKcID,
            this.colKcName,
            this.colGoodsID,
            this.colKcGoodsName,
            this.colCompanyName,
            this.colKcJingGaoNumber,
            this.colKcUnit,
            this.colKcGoodsPrice,
            this.colKcNumber,
            this.colKcGoodsSellPrice,
            this.colKcDataTime,
            this.colKcRemark});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colKcID
            // 
            this.colKcID.Caption = "仓库编号";
            this.colKcID.FieldName = "KcID";
            this.colKcID.Name = "colKcID";
            this.colKcID.OptionsColumn.AllowEdit = false;
            this.colKcID.Visible = true;
            this.colKcID.VisibleIndex = 0;
            // 
            // colKcName
            // 
            this.colKcName.Caption = "仓库名称";
            this.colKcName.FieldName = "KcName";
            this.colKcName.Name = "colKcName";
            this.colKcName.OptionsColumn.AllowEdit = false;
            this.colKcName.Visible = true;
            this.colKcName.VisibleIndex = 3;
            // 
            // colGoodsID
            // 
            this.colGoodsID.Caption = "商品编号";
            this.colGoodsID.FieldName = "GoodsID";
            this.colGoodsID.Name = "colGoodsID";
            this.colGoodsID.OptionsColumn.AllowEdit = false;
            this.colGoodsID.Visible = true;
            this.colGoodsID.VisibleIndex = 1;
            // 
            // colKcGoodsName
            // 
            this.colKcGoodsName.Caption = "商品名称";
            this.colKcGoodsName.FieldName = "KcGoodsName";
            this.colKcGoodsName.Name = "colKcGoodsName";
            this.colKcGoodsName.OptionsColumn.AllowEdit = false;
            this.colKcGoodsName.Visible = true;
            this.colKcGoodsName.VisibleIndex = 4;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "供货商信息";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            // 
            // colKcJingGaoNumber
            // 
            this.colKcJingGaoNumber.Caption = "库存警告数量";
            this.colKcJingGaoNumber.FieldName = "KcJingGaoNumber";
            this.colKcJingGaoNumber.Name = "colKcJingGaoNumber";
            this.colKcJingGaoNumber.OptionsColumn.AllowEdit = false;
            this.colKcJingGaoNumber.Visible = true;
            this.colKcJingGaoNumber.VisibleIndex = 6;
            // 
            // colKcUnit
            // 
            this.colKcUnit.Caption = "商品计量单位";
            this.colKcUnit.FieldName = "KcUnit";
            this.colKcUnit.Name = "colKcUnit";
            this.colKcUnit.OptionsColumn.AllowEdit = false;
            this.colKcUnit.Visible = true;
            this.colKcUnit.VisibleIndex = 8;
            // 
            // colKcGoodsPrice
            // 
            this.colKcGoodsPrice.Caption = "商品进价";
            this.colKcGoodsPrice.FieldName = "KcGoodsPrice";
            this.colKcGoodsPrice.Name = "colKcGoodsPrice";
            this.colKcGoodsPrice.OptionsColumn.AllowEdit = false;
            this.colKcGoodsPrice.Visible = true;
            this.colKcGoodsPrice.VisibleIndex = 9;
            // 
            // colKcNumber
            // 
            this.colKcNumber.Caption = "商品数量";
            this.colKcNumber.FieldName = "KcNumber";
            this.colKcNumber.Name = "colKcNumber";
            this.colKcNumber.OptionsColumn.AllowEdit = false;
            this.colKcNumber.Visible = true;
            this.colKcNumber.VisibleIndex = 5;
            // 
            // colKcGoodsSellPrice
            // 
            this.colKcGoodsSellPrice.Caption = "商品售价";
            this.colKcGoodsSellPrice.FieldName = "KcGoodsSellPrice";
            this.colKcGoodsSellPrice.Name = "colKcGoodsSellPrice";
            this.colKcGoodsSellPrice.OptionsColumn.AllowEdit = false;
            this.colKcGoodsSellPrice.Visible = true;
            this.colKcGoodsSellPrice.VisibleIndex = 10;
            // 
            // colKcDataTime
            // 
            this.colKcDataTime.Caption = "进货日期";
            this.colKcDataTime.FieldName = "KcDataTime";
            this.colKcDataTime.Name = "colKcDataTime";
            this.colKcDataTime.OptionsColumn.AllowEdit = false;
            this.colKcDataTime.Visible = true;
            this.colKcDataTime.VisibleIndex = 7;
            // 
            // colKcRemark
            // 
            this.colKcRemark.Caption = "备注";
            this.colKcRemark.FieldName = "KcRemark";
            this.colKcRemark.Name = "colKcRemark";
            this.colKcRemark.OptionsColumn.AllowEdit = false;
            this.colKcRemark.Visible = true;
            this.colKcRemark.VisibleIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(594, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(289, 18);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "注：盘盈请输入负数，盘亏请输入正数";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.text商品名称);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.text商品编号);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.gridControl);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.bt保存);
            this.groupControl1.Controls.Add(this.Text盘点数量);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1075, 516);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Root";
            // 
            // text商品名称
            // 
            this.text商品名称.EditValue = "";
            this.text商品名称.Location = new System.Drawing.Point(288, 7);
            this.text商品名称.Margin = new System.Windows.Forms.Padding(4);
            this.text商品名称.Name = "text商品名称";
            this.text商品名称.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品名称.Properties.Appearance.Options.UseFont = true;
            this.text商品名称.Properties.Mask.BeepOnError = true;
            this.text商品名称.Properties.Mask.EditMask = "d";
            this.text商品名称.Size = new System.Drawing.Size(274, 26);
            this.text商品名称.TabIndex = 50;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(162, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 16);
            this.labelControl2.TabIndex = 49;
            this.labelControl2.Text = "商 品 名 称 ：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(162, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 16);
            this.labelControl1.TabIndex = 48;
            this.labelControl1.Text = "商 品 编 号 ：";
            // 
            // text商品编号
            // 
            this.text商品编号.EditValue = "";
            this.text商品编号.Location = new System.Drawing.Point(288, 46);
            this.text商品编号.Margin = new System.Windows.Forms.Padding(4);
            this.text商品编号.Name = "text商品编号";
            this.text商品编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品编号.Properties.Appearance.Options.UseFont = true;
            this.text商品编号.Properties.Mask.BeepOnError = true;
            this.text商品编号.Properties.Mask.EditMask = "d";
            this.text商品编号.Size = new System.Drawing.Size(274, 26);
            this.text商品编号.TabIndex = 47;
            // 
            // FormKuCunGuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 516);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormKuCunGuanLi";
            this.Text = "库存管理页面";
            this.Load += new System.EventHandler(this.FormKuCunGuanLi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text盘点数量.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DBCLDataSet dBCLDataSet;
        private System.Windows.Forms.BindingSource tableStorBindingSource;
        private DBCLDataSetTableAdapters.Table_StorTableAdapter table_StorTableAdapter;
        private DevExpress.XtraEditors.TextEdit Text盘点数量;
        private DevExpress.XtraEditors.SimpleButton bt保存;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKcID;
        private DevExpress.XtraGrid.Columns.GridColumn colKcName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsID;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsName;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colKcJingGaoNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colKcUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKcDataTime;
        private DevExpress.XtraGrid.Columns.GridColumn colKcRemark;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit text商品编号;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit text商品名称;
    }
}