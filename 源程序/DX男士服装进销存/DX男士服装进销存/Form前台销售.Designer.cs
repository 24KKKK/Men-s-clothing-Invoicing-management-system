namespace DX男士服装进销存
{
    partial class Form前台销售
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.text商品编号 = new DevExpress.XtraEditors.LookUpEdit();
            this.tableStorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCLDataSet = new DX男士服装进销存.DBCLDataSet();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.text数量 = new DevExpress.XtraEditors.SpinEdit();
            this.Text单价框 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.text操作员框 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Text进货单号 = new DevExpress.XtraEditors.LabelControl();
            this.btSell = new DevExpress.XtraEditors.SimpleButton();
            this.Btclear = new DevExpress.XtraEditors.SimpleButton();
            this.text应付金额框 = new DevExpress.XtraEditors.TextEdit();
            this.text实付金额 = new DevExpress.XtraEditors.TextEdit();
            this.text商品名称 = new DevExpress.XtraEditors.TextEdit();
            this.text销售单号 = new DevExpress.XtraEditors.TextEdit();
            this.textVIP折扣率 = new DevExpress.XtraEditors.LookUpEdit();
            this.tableVIPMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableGoodsSellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_StorTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_StorTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellGoodsNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellGoodsTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellRealPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellShouldPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableGoodsInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_GoodsInTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_GoodsInTableAdapter();
            this.table_GoodsSellTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_GoodsSellTableAdapter();
            this.table_VIPMessageTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_VIPMessageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text数量.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text单价框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text操作员框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text应付金额框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text实付金额.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text销售单号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textVIP折扣率.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVIPMessageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsSellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.text商品编号);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.text数量);
            this.groupControl1.Controls.Add(this.Text单价框);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.text操作员框);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.Text进货单号);
            this.groupControl1.Controls.Add(this.btSell);
            this.groupControl1.Controls.Add(this.Btclear);
            this.groupControl1.Controls.Add(this.text应付金额框);
            this.groupControl1.Controls.Add(this.text实付金额);
            this.groupControl1.Controls.Add(this.text商品名称);
            this.groupControl1.Controls.Add(this.text销售单号);
            this.groupControl1.Controls.Add(this.textVIP折扣率);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1225, 197);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Root";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(365, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 16);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Vip折扣率：";
            // 
            // text商品编号
            // 
            this.text商品编号.Location = new System.Drawing.Point(120, 60);
            this.text商品编号.Name = "text商品编号";
            this.text商品编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品编号.Properties.Appearance.Options.UseFont = true;
            this.text商品编号.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品编号.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GoodsID", "商品编号", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KcGoodsName", "商品名称", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KcNumber", "库存量", 50, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.text商品编号.Properties.DataSource = this.tableStorBindingSource;
            this.text商品编号.Properties.DisplayMember = "GoodsID";
            this.text商品编号.Properties.DropDownRows = 10;
            this.text商品编号.Properties.PopupSizeable = false;
            this.text商品编号.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.text商品编号.Properties.ValueMember = "GoodsID";
            this.text商品编号.Size = new System.Drawing.Size(204, 26);
            this.text商品编号.TabIndex = 45;
            this.text商品编号.EditValueChanged += new System.EventHandler(this.text商品编号_EditValueChanged);
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
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(680, 112);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(90, 16);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "商 品 名 称：";
            // 
            // text数量
            // 
            this.text数量.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text数量.Location = new System.Drawing.Point(120, 152);
            this.text数量.Margin = new System.Windows.Forms.Padding(4);
            this.text数量.Name = "text数量";
            this.text数量.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text数量.Properties.Appearance.Options.UseFont = true;
            this.text数量.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text数量.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.text数量.Properties.Mask.BeepOnError = true;
            this.text数量.Properties.Mask.EditMask = "d";
            this.text数量.Properties.MaxValue = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.text数量.Size = new System.Drawing.Size(204, 26);
            this.text数量.TabIndex = 38;
            this.text数量.EditValueChanged += new System.EventHandler(this.text数量_EditValueChanged);
            // 
            // Text单价框
            // 
            this.Text单价框.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Text单价框.Location = new System.Drawing.Point(120, 109);
            this.Text单价框.Margin = new System.Windows.Forms.Padding(4);
            this.Text单价框.Name = "Text单价框";
            this.Text单价框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.Text单价框.Properties.Appearance.Options.UseFont = true;
            this.Text单价框.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Text单价框.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.Text单价框.Properties.Mask.BeepOnError = true;
            this.Text单价框.Properties.Mask.EditMask = "c";
            this.Text单价框.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.Text单价框.Size = new System.Drawing.Size(204, 26);
            this.Text单价框.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "销 售 单 价：";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(680, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 16);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "操   作   员 ：";
            // 
            // text操作员框
            // 
            this.text操作员框.Location = new System.Drawing.Point(786, 152);
            this.text操作员框.Name = "text操作员框";
            this.text操作员框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text操作员框.Properties.Appearance.Options.UseFont = true;
            this.text操作员框.Size = new System.Drawing.Size(204, 26);
            this.text操作员框.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(360, 112);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "应 付 金 额 ：";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(12, 159);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "销 售 数 量 ：";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(360, 159);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "实 付 金 额：";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 64);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(90, 16);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "商 品 编 号：";
            // 
            // Text进货单号
            // 
            this.Text进货单号.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.Text进货单号.Appearance.Options.UseFont = true;
            this.Text进货单号.Location = new System.Drawing.Point(675, 67);
            this.Text进货单号.Name = "Text进货单号";
            this.Text进货单号.Size = new System.Drawing.Size(95, 16);
            this.Text进货单号.TabIndex = 20;
            this.Text进货单号.Text = "销 售 单 号 ：";
            // 
            // btSell
            // 
            this.btSell.Appearance.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold);
            this.btSell.Appearance.Options.UseFont = true;
            this.btSell.Location = new System.Drawing.Point(233, 7);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(91, 40);
            this.btSell.TabIndex = 2;
            this.btSell.Text = "出  售";
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // Btclear
            // 
            this.Btclear.Appearance.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold);
            this.Btclear.Appearance.Options.UseFont = true;
            this.Btclear.Location = new System.Drawing.Point(786, 7);
            this.Btclear.Name = "Btclear";
            this.Btclear.Size = new System.Drawing.Size(92, 40);
            this.Btclear.TabIndex = 2;
            this.Btclear.Text = "清  空";
            this.Btclear.Click += new System.EventHandler(this.Btclear_Click);
            // 
            // text应付金额框
            // 
            this.text应付金额框.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text应付金额框.Location = new System.Drawing.Point(468, 112);
            this.text应付金额框.Margin = new System.Windows.Forms.Padding(4);
            this.text应付金额框.Name = "text应付金额框";
            this.text应付金额框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text应付金额框.Properties.Appearance.Options.UseFont = true;
            this.text应付金额框.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?";
            this.text应付金额框.Size = new System.Drawing.Size(195, 26);
            this.text应付金额框.TabIndex = 5;
            // 
            // text实付金额
            // 
            this.text实付金额.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text实付金额.Location = new System.Drawing.Point(468, 152);
            this.text实付金额.Margin = new System.Windows.Forms.Padding(4);
            this.text实付金额.Name = "text实付金额";
            this.text实付金额.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text实付金额.Properties.Appearance.Options.UseFont = true;
            this.text实付金额.Properties.Mask.BeepOnError = true;
            this.text实付金额.Properties.Mask.EditMask = "c";
            this.text实付金额.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.text实付金额.Size = new System.Drawing.Size(195, 26);
            this.text实付金额.TabIndex = 37;
            // 
            // text商品名称
            // 
            this.text商品名称.EditValue = "";
            this.text商品名称.Location = new System.Drawing.Point(786, 105);
            this.text商品名称.Name = "text商品名称";
            this.text商品名称.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品名称.Properties.Appearance.Options.UseFont = true;
            this.text商品名称.Properties.NullText = "[EditValue is null]";
            this.text商品名称.Size = new System.Drawing.Size(204, 26);
            this.text商品名称.TabIndex = 42;
            // 
            // text销售单号
            // 
            this.text销售单号.Location = new System.Drawing.Point(786, 60);
            this.text销售单号.Name = "text销售单号";
            this.text销售单号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text销售单号.Properties.Appearance.Options.UseFont = true;
            this.text销售单号.Size = new System.Drawing.Size(204, 26);
            this.text销售单号.TabIndex = 4;
            this.text销售单号.Click += new System.EventHandler(this.text销售单号_Click);
            this.text销售单号.Enter += new System.EventHandler(this.text进货销售单号_Enter);
            // 
            // textVIP折扣率
            // 
            this.textVIP折扣率.Location = new System.Drawing.Point(467, 64);
            this.textVIP折扣率.Margin = new System.Windows.Forms.Padding(4);
            this.textVIP折扣率.Name = "textVIP折扣率";
            this.textVIP折扣率.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.textVIP折扣率.Properties.Appearance.Options.UseFont = true;
            this.textVIP折扣率.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textVIP折扣率.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VIPName", "VIP姓名", 200, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VIPZhekou", "VIP折扣率", 100, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.textVIP折扣率.Properties.DataSource = this.tableVIPMessageBindingSource;
            this.textVIP折扣率.Properties.DisplayMember = "VIPZhekou";
            this.textVIP折扣率.Properties.NullText = "";
            this.textVIP折扣率.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.textVIP折扣率.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.textVIP折扣率.Properties.ValueMember = "VIPID";
            this.textVIP折扣率.Size = new System.Drawing.Size(195, 26);
            this.textVIP折扣率.TabIndex = 46;
            this.textVIP折扣率.EditValueChanged += new System.EventHandler(this.textVIP折扣率_EditValueChanged);
            // 
            // tableVIPMessageBindingSource
            // 
            this.tableVIPMessageBindingSource.DataMember = "Table_VIPMessage";
            this.tableVIPMessageBindingSource.DataSource = this.dBCLDataSet;
            // 
            // tableGoodsSellBindingSource
            // 
            this.tableGoodsSellBindingSource.DataMember = "Table_GoodsSell";
            this.tableGoodsSellBindingSource.DataSource = this.dBCLDataSet;
            // 
            // table_StorTableAdapter
            // 
            this.table_StorTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tableGoodsSellBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 198);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1225, 321);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKcID,
            this.colSellGoodsNumber,
            this.colSellGoodsTime,
            this.colSellID,
            this.colSellPrice,
            this.colSellRealPay,
            this.colSellRemark,
            this.colSellShouldPay,
            this.colGoodsName,
            this.colGoodsID,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // colSellGoodsNumber
            // 
            this.colSellGoodsNumber.Caption = "销售数量";
            this.colSellGoodsNumber.FieldName = "SellGoodsNumber";
            this.colSellGoodsNumber.Name = "colSellGoodsNumber";
            this.colSellGoodsNumber.OptionsColumn.AllowEdit = false;
            this.colSellGoodsNumber.Visible = true;
            this.colSellGoodsNumber.VisibleIndex = 5;
            // 
            // colSellGoodsTime
            // 
            this.colSellGoodsTime.Caption = "销售日期";
            this.colSellGoodsTime.FieldName = "SellGoodsTime";
            this.colSellGoodsTime.Name = "colSellGoodsTime";
            this.colSellGoodsTime.OptionsColumn.AllowEdit = false;
            this.colSellGoodsTime.Visible = true;
            this.colSellGoodsTime.VisibleIndex = 9;
            // 
            // colSellID
            // 
            this.colSellID.Caption = "销售编号";
            this.colSellID.FieldName = "SellID";
            this.colSellID.Name = "colSellID";
            this.colSellID.OptionsColumn.AllowEdit = false;
            this.colSellID.Visible = true;
            this.colSellID.VisibleIndex = 1;
            // 
            // colSellPrice
            // 
            this.colSellPrice.Caption = "售价";
            this.colSellPrice.FieldName = "SellPrice";
            this.colSellPrice.Name = "colSellPrice";
            this.colSellPrice.OptionsColumn.AllowEdit = false;
            this.colSellPrice.Visible = true;
            this.colSellPrice.VisibleIndex = 6;
            // 
            // colSellRealPay
            // 
            this.colSellRealPay.Caption = "实付金额";
            this.colSellRealPay.FieldName = "SellRealPay";
            this.colSellRealPay.Name = "colSellRealPay";
            this.colSellRealPay.OptionsColumn.AllowEdit = false;
            this.colSellRealPay.Visible = true;
            this.colSellRealPay.VisibleIndex = 8;
            // 
            // colSellRemark
            // 
            this.colSellRemark.Caption = "备注";
            this.colSellRemark.FieldName = "SellRemark";
            this.colSellRemark.Name = "colSellRemark";
            this.colSellRemark.OptionsColumn.AllowEdit = false;
            this.colSellRemark.Visible = true;
            this.colSellRemark.VisibleIndex = 10;
            // 
            // colSellShouldPay
            // 
            this.colSellShouldPay.Caption = "应付金额";
            this.colSellShouldPay.FieldName = "SellShouldPay";
            this.colSellShouldPay.Name = "colSellShouldPay";
            this.colSellShouldPay.OptionsColumn.AllowEdit = false;
            this.colSellShouldPay.Visible = true;
            this.colSellShouldPay.VisibleIndex = 7;
            // 
            // colGoodsName
            // 
            this.colGoodsName.Caption = "商品名称";
            this.colGoodsName.FieldName = "GoodsName";
            this.colGoodsName.Name = "colGoodsName";
            this.colGoodsName.OptionsColumn.AllowEdit = false;
            this.colGoodsName.Visible = true;
            this.colGoodsName.VisibleIndex = 3;
            // 
            // colGoodsID
            // 
            this.colGoodsID.Caption = "商品编号";
            this.colGoodsID.FieldName = "GoodsID";
            this.colGoodsID.Name = "colGoodsID";
            this.colGoodsID.OptionsColumn.AllowEdit = false;
            this.colGoodsID.Visible = true;
            this.colGoodsID.VisibleIndex = 2;
            // 
            // colID
            // 
            this.colID.Caption = "售货员编号";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 4;
            // 
            // tableGoodsInBindingSource
            // 
            this.tableGoodsInBindingSource.DataMember = "Table_GoodsIn";
            this.tableGoodsInBindingSource.DataSource = this.dBCLDataSet;
            // 
            // table_GoodsInTableAdapter
            // 
            this.table_GoodsInTableAdapter.ClearBeforeFill = true;
            // 
            // table_GoodsSellTableAdapter
            // 
            this.table_GoodsSellTableAdapter.ClearBeforeFill = true;
            // 
            // table_VIPMessageTableAdapter
            // 
            this.table_VIPMessageTableAdapter.ClearBeforeFill = true;
            // 
            // Form前台销售
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 519);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "Form前台销售";
            this.Text = "前台销售页面";
            this.Load += new System.EventHandler(this.Form前台销售_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text数量.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text单价框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text操作员框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text应付金额框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text实付金额.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text销售单号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textVIP折扣率.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableVIPMessageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsSellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsInBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit text数量;
        private DevExpress.XtraEditors.SpinEdit Text单价框;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit text操作员框;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl Text进货单号;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btSell;
        private DevExpress.XtraEditors.SimpleButton Btclear;
        private DevExpress.XtraEditors.TextEdit text应付金额框;
        private DevExpress.XtraEditors.TextEdit text实付金额;
        private DBCLDataSet dBCLDataSet;
        private System.Windows.Forms.BindingSource tableStorBindingSource;
        private DBCLDataSetTableAdapters.Table_StorTableAdapter table_StorTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit text商品编号;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tableGoodsInBindingSource;
        private DBCLDataSetTableAdapters.Table_GoodsInTableAdapter table_GoodsInTableAdapter;
        private System.Windows.Forms.BindingSource tableGoodsSellBindingSource;
        private DBCLDataSetTableAdapters.Table_GoodsSellTableAdapter table_GoodsSellTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKcID;
        private DevExpress.XtraGrid.Columns.GridColumn colSellGoodsNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSellGoodsTime;
        private DevExpress.XtraGrid.Columns.GridColumn colSellID;
        private DevExpress.XtraGrid.Columns.GridColumn colSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSellRealPay;
        private DevExpress.XtraGrid.Columns.GridColumn colSellRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colSellShouldPay;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.TextEdit text商品名称;
        private DevExpress.XtraEditors.TextEdit text销售单号;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit textVIP折扣率;
        private System.Windows.Forms.BindingSource tableVIPMessageBindingSource;
        private DBCLDataSetTableAdapters.Table_VIPMessageTableAdapter table_VIPMessageTableAdapter;

    }
}