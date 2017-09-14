namespace DX男士服装进销存
{
    partial class FormKucunTiaoZheng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKucunTiaoZheng));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.text商品编号 = new DevExpress.XtraEditors.TextEdit();
            this.bt重置 = new DevExpress.XtraEditors.SimpleButton();
            this.bt确定 = new DevExpress.XtraEditors.SimpleButton();
            this.text转移数量 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.text商品原存库编号 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableStorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCLDataSet = new DX男士服装进销存.DBCLDataSet();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableStorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcDataTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcGoodsSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKcRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableStorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_StorTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_StorTableAdapter();
            this.text商品新存库编号 = new DevExpress.XtraEditors.MRUEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text转移数量.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品原存库编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品新存库编号.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.text商品编号);
            this.groupControl1.Controls.Add(this.bt重置);
            this.groupControl1.Controls.Add(this.bt确定);
            this.groupControl1.Controls.Add(this.text转移数量);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.text商品原存库编号);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.text商品新存库编号);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(954, 164);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.LineColor = System.Drawing.Color.Indigo;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.Location = new System.Drawing.Point(448, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 22);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "商 品 编 号：";
            // 
            // text商品编号
            // 
            this.text商品编号.Location = new System.Drawing.Point(594, 78);
            this.text商品编号.Name = "text商品编号";
            this.text商品编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text商品编号.Properties.Appearance.Options.UseFont = true;
            this.text商品编号.Size = new System.Drawing.Size(187, 26);
            this.text商品编号.TabIndex = 55;
            // 
            // bt重置
            // 
            this.bt重置.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.bt重置.Appearance.Options.UseFont = true;
            this.bt重置.Image = ((System.Drawing.Image)(resources.GetObject("bt重置.Image")));
            this.bt重置.Location = new System.Drawing.Point(558, 128);
            this.bt重置.Name = "bt重置";
            this.bt重置.Size = new System.Drawing.Size(77, 31);
            this.bt重置.TabIndex = 54;
            this.bt重置.Text = "重置";
            this.bt重置.Click += new System.EventHandler(this.bt重置_Click);
            // 
            // bt确定
            // 
            this.bt确定.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.bt确定.Appearance.Options.UseFont = true;
            this.bt确定.Image = ((System.Drawing.Image)(resources.GetObject("bt确定.Image")));
            this.bt确定.Location = new System.Drawing.Point(249, 125);
            this.bt确定.Name = "bt确定";
            this.bt确定.Size = new System.Drawing.Size(87, 34);
            this.bt确定.TabIndex = 53;
            this.bt确定.Text = "确定";
            this.bt确定.Click += new System.EventHandler(this.bt确定_Click);
            // 
            // text转移数量
            // 
            this.text转移数量.Location = new System.Drawing.Point(192, 80);
            this.text转移数量.Name = "text转移数量";
            this.text转移数量.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text转移数量.Properties.Appearance.Options.UseFont = true;
            this.text转移数量.Properties.Mask.EditMask = "d";
            this.text转移数量.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.text转移数量.Size = new System.Drawing.Size(218, 26);
            this.text转移数量.TabIndex = 52;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.LineColor = System.Drawing.Color.Indigo;
            this.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl4.Location = new System.Drawing.Point(26, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(140, 22);
            this.labelControl4.TabIndex = 51;
            this.labelControl4.Text = "请输入转移数量：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.LineColor = System.Drawing.Color.Indigo;
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl3.Location = new System.Drawing.Point(448, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(140, 22);
            this.labelControl3.TabIndex = 49;
            this.labelControl3.Text = "商品新存库编号：";
            // 
            // text商品原存库编号
            // 
            this.text商品原存库编号.Location = new System.Drawing.Point(192, 23);
            this.text商品原存库编号.Name = "text商品原存库编号";
            this.text商品原存库编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text商品原存库编号.Properties.Appearance.Options.UseFont = true;
            this.text商品原存库编号.Size = new System.Drawing.Size(218, 26);
            this.text商品原存库编号.TabIndex = 48;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.LineColor = System.Drawing.Color.Indigo;
            this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl2.Location = new System.Drawing.Point(26, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 22);
            this.labelControl2.TabIndex = 47;
            this.labelControl2.Text = "商品原存库编号：";
            // 
            // tableStorBindingSource2
            // 
            this.tableStorBindingSource2.DataMember = "Table_Stor";
            this.tableStorBindingSource2.DataSource = this.dBCLDataSet;
            // 
            // dBCLDataSet
            // 
            this.dBCLDataSet.DataSetName = "DBCLDataSet";
            this.dBCLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tableStorBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(2, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 371);
            this.gridControl1.TabIndex = 55;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tableStorBindingSource1
            // 
            this.tableStorBindingSource1.DataMember = "Table_Stor";
            this.tableStorBindingSource1.DataSource = this.dBCLDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKcID,
            this.colGoodsID,
            this.colCompanyName,
            this.colKcName,
            this.colKcGoodsName,
            this.colKcNumber,
            this.colKcDataTime,
            this.colKcUnit,
            this.colKcGoodsPrice,
            this.colKcGoodsSellPrice,
            this.colKcRemark});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colKcID
            // 
            this.colKcID.Caption = "仓库编号";
            this.colKcID.FieldName = "KcID";
            this.colKcID.Name = "colKcID";
            this.colKcID.Visible = true;
            this.colKcID.VisibleIndex = 0;
            this.colKcID.Width = 93;
            // 
            // colGoodsID
            // 
            this.colGoodsID.Caption = "商品编号";
            this.colGoodsID.FieldName = "GoodsID";
            this.colGoodsID.Name = "colGoodsID";
            this.colGoodsID.Visible = true;
            this.colGoodsID.VisibleIndex = 1;
            this.colGoodsID.Width = 117;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "供货商名称";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            this.colCompanyName.Width = 96;
            // 
            // colKcName
            // 
            this.colKcName.Caption = "仓库名称";
            this.colKcName.FieldName = "KcName";
            this.colKcName.Name = "colKcName";
            this.colKcName.Visible = true;
            this.colKcName.VisibleIndex = 3;
            this.colKcName.Width = 57;
            // 
            // colKcGoodsName
            // 
            this.colKcGoodsName.Caption = "商品名";
            this.colKcGoodsName.FieldName = "KcGoodsName";
            this.colKcGoodsName.Name = "colKcGoodsName";
            this.colKcGoodsName.Visible = true;
            this.colKcGoodsName.VisibleIndex = 4;
            this.colKcGoodsName.Width = 105;
            // 
            // colKcNumber
            // 
            this.colKcNumber.Caption = "库存量";
            this.colKcNumber.FieldName = "KcNumber";
            this.colKcNumber.Name = "colKcNumber";
            this.colKcNumber.Visible = true;
            this.colKcNumber.VisibleIndex = 5;
            this.colKcNumber.Width = 72;
            // 
            // colKcDataTime
            // 
            this.colKcDataTime.Caption = "入库时间";
            this.colKcDataTime.FieldName = "KcDataTime";
            this.colKcDataTime.Name = "colKcDataTime";
            this.colKcDataTime.Visible = true;
            this.colKcDataTime.VisibleIndex = 9;
            this.colKcDataTime.Width = 72;
            // 
            // colKcUnit
            // 
            this.colKcUnit.Caption = "商品类型";
            this.colKcUnit.FieldName = "KcUnit";
            this.colKcUnit.Name = "colKcUnit";
            this.colKcUnit.Visible = true;
            this.colKcUnit.VisibleIndex = 6;
            this.colKcUnit.Width = 72;
            // 
            // colKcGoodsPrice
            // 
            this.colKcGoodsPrice.Caption = "商品进价";
            this.colKcGoodsPrice.FieldName = "KcGoodsPrice";
            this.colKcGoodsPrice.Name = "colKcGoodsPrice";
            this.colKcGoodsPrice.Visible = true;
            this.colKcGoodsPrice.VisibleIndex = 7;
            this.colKcGoodsPrice.Width = 72;
            // 
            // colKcGoodsSellPrice
            // 
            this.colKcGoodsSellPrice.Caption = "商品售价";
            this.colKcGoodsSellPrice.FieldName = "KcGoodsSellPrice";
            this.colKcGoodsSellPrice.Name = "colKcGoodsSellPrice";
            this.colKcGoodsSellPrice.Visible = true;
            this.colKcGoodsSellPrice.VisibleIndex = 8;
            this.colKcGoodsSellPrice.Width = 72;
            // 
            // colKcRemark
            // 
            this.colKcRemark.Caption = "商品备注";
            this.colKcRemark.FieldName = "KcRemark";
            this.colKcRemark.Name = "colKcRemark";
            this.colKcRemark.Visible = true;
            this.colKcRemark.VisibleIndex = 10;
            this.colKcRemark.Width = 87;
            // 
            // tableStorBindingSource
            // 
            this.tableStorBindingSource.DataMember = "Table_Stor";
            this.tableStorBindingSource.DataSource = this.dBCLDataSet;
            // 
            // table_StorTableAdapter
            // 
            this.table_StorTableAdapter.ClearBeforeFill = true;
            // 
            // text商品新存库编号
            // 
            this.text商品新存库编号.Location = new System.Drawing.Point(594, 21);
            this.text商品新存库编号.Name = "text商品新存库编号";
            this.text商品新存库编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text商品新存库编号.Properties.Appearance.Options.UseFont = true;
            this.text商品新存库编号.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品新存库编号.Properties.ImmediatePopup = false;
            this.text商品新存库编号.Properties.Items.AddRange(new object[] {
            "ST000001",
            "ST000002",
            "ST000003"});
            this.text商品新存库编号.Properties.PopupSizeable = true;
            this.text商品新存库编号.Properties.ValidateOnEnterKey = false;
            this.text商品新存库编号.Size = new System.Drawing.Size(187, 26);
            this.text商品新存库编号.TabIndex = 50;
            // 
            // FormKucunTiaoZheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.MinimizeBox = false;
            this.Name = "FormKucunTiaoZheng";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "库存调整页面";
            this.Load += new System.EventHandler(this.FormKucunTiaoZheng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text转移数量.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品原存库编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品新存库编号.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit text商品原存库编号;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit text转移数量;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton bt确定;
        private DevExpress.XtraEditors.SimpleButton bt重置;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBCLDataSet dBCLDataSet;
        private System.Windows.Forms.BindingSource tableStorBindingSource;
        private DBCLDataSetTableAdapters.Table_StorTableAdapter table_StorTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKcID;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colKcName;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsName;
        private DevExpress.XtraGrid.Columns.GridColumn colKcNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colKcDataTime;
        private DevExpress.XtraGrid.Columns.GridColumn colKcUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKcGoodsSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colKcRemark;
        private System.Windows.Forms.BindingSource tableStorBindingSource1;
        private System.Windows.Forms.BindingSource tableStorBindingSource2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit text商品编号;
        private DevExpress.XtraEditors.MRUEdit text商品新存库编号;
    }
}