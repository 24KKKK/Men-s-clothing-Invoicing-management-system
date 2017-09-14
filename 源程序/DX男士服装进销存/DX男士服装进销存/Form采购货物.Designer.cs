namespace DX男士服装进销存
{
    partial class Form采购货物
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form采购货物));
            this.tableSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCLDataSet = new DX男士服装进销存.DBCLDataSet();
            this.tableGoodsInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.table_GoodsInTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_GoodsInTableAdapter();
            this.table_SupplierTableAdapter = new DX男士服装进销存.DBCLDataSetTableAdapters.Table_SupplierTableAdapter();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.bt清空 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit备注 = new DevExpress.XtraEditors.MemoEdit();
            this.bt删除 = new DevExpress.XtraEditors.SimpleButton();
            this.bt修改 = new DevExpress.XtraEditors.SimpleButton();
            this.bt添加 = new DevExpress.XtraEditors.SimpleButton();
            this.text商品编号 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.text商品颜色 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.text商品类别 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.text季节 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.text商品尺码 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.text销售单价框 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Text进货单号 = new DevExpress.XtraEditors.LabelControl();
            this.text进货单号框 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.text商品名称框 = new DevExpress.XtraEditors.TextEdit();
            this.Text计量单位框 = new DevExpress.XtraEditors.MRUEdit();
            this.text商品品牌 = new DevExpress.XtraEditors.MRUEdit();
            this.text进货日期 = new DevExpress.XtraEditors.DateEdit();
            this.Text进货单价框 = new DevExpress.XtraEditors.TextEdit();
            this.text实付金额 = new DevExpress.XtraEditors.TextEdit();
            this.text应付金额框 = new DevExpress.XtraEditors.TextEdit();
            this.text进货数量 = new DevExpress.XtraEditors.TextEdit();
            this.text所属仓库 = new DevExpress.XtraEditors.MRUEdit();
            this.text供货商名称 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGoodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStroName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsInPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsSellPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsShouldPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsRealPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsInDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsLeibie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsShouldJijie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoodsPinpai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.tableSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit备注.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品颜色.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品类别.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text季节.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品尺码.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text销售单价框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货单号框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text计量单位框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品品牌.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货日期.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货日期.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text进货单价框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text实付金额.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text应付金额框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货数量.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text所属仓库.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text供货商名称.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSupplierBindingSource
            // 
            this.tableSupplierBindingSource.DataMember = "Table_Supplier";
            this.tableSupplierBindingSource.DataSource = this.dBCLDataSet;
            // 
            // dBCLDataSet
            // 
            this.dBCLDataSet.DataSetName = "DBCLDataSet";
            this.dBCLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableGoodsInBindingSource
            // 
            this.tableGoodsInBindingSource.DataMember = "Table_GoodsIn";
            this.tableGoodsInBindingSource.DataSource = this.dBCLDataSet;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // table_GoodsInTableAdapter
            // 
            this.table_GoodsInTableAdapter.ClearBeforeFill = true;
            // 
            // table_SupplierTableAdapter
            // 
            this.table_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl
            // 
            this.groupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.groupControl.Controls.Add(this.labelControl4);
            this.groupControl.Controls.Add(this.bt清空);
            this.groupControl.Controls.Add(this.labelControl17);
            this.groupControl.Controls.Add(this.memoEdit备注);
            this.groupControl.Controls.Add(this.bt删除);
            this.groupControl.Controls.Add(this.bt修改);
            this.groupControl.Controls.Add(this.bt添加);
            this.groupControl.Controls.Add(this.text商品编号);
            this.groupControl.Controls.Add(this.labelControl16);
            this.groupControl.Controls.Add(this.labelControl32);
            this.groupControl.Controls.Add(this.text商品颜色);
            this.groupControl.Controls.Add(this.text商品类别);
            this.groupControl.Controls.Add(this.text季节);
            this.groupControl.Controls.Add(this.text商品尺码);
            this.groupControl.Controls.Add(this.labelControl15);
            this.groupControl.Controls.Add(this.labelControl14);
            this.groupControl.Controls.Add(this.labelControl13);
            this.groupControl.Controls.Add(this.labelControl11);
            this.groupControl.Controls.Add(this.labelControl9);
            this.groupControl.Controls.Add(this.labelControl1);
            this.groupControl.Controls.Add(this.labelControl2);
            this.groupControl.Controls.Add(this.labelControl3);
            this.groupControl.Controls.Add(this.labelControl5);
            this.groupControl.Controls.Add(this.labelControl6);
            this.groupControl.Controls.Add(this.text销售单价框);
            this.groupControl.Controls.Add(this.labelControl7);
            this.groupControl.Controls.Add(this.labelControl8);
            this.groupControl.Controls.Add(this.labelControl10);
            this.groupControl.Controls.Add(this.Text进货单号);
            this.groupControl.Controls.Add(this.text进货单号框);
            this.groupControl.Controls.Add(this.labelControl12);
            this.groupControl.Controls.Add(this.text商品名称框);
            this.groupControl.Controls.Add(this.Text计量单位框);
            this.groupControl.Controls.Add(this.text商品品牌);
            this.groupControl.Controls.Add(this.text进货日期);
            this.groupControl.Controls.Add(this.Text进货单价框);
            this.groupControl.Controls.Add(this.text实付金额);
            this.groupControl.Controls.Add(this.text应付金额框);
            this.groupControl.Controls.Add(this.text进货数量);
            this.groupControl.Controls.Add(this.text所属仓库);
            this.groupControl.Controls.Add(this.text供货商名称);
            this.groupControl.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("添 加", ((System.Drawing.Image)(resources.GetObject("groupControl.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, true, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("修 改", ((System.Drawing.Image)(resources.GetObject("groupControl.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, true, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("删 除", ((System.Drawing.Image)(resources.GetObject("groupControl.CustomHeaderButtons2"))))});
            this.groupControl.Location = new System.Drawing.Point(0, 249);
            this.groupControl.Name = "groupControl";
            this.groupControl.ShowCaption = false;
            this.groupControl.Size = new System.Drawing.Size(1274, 281);
            this.groupControl.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(644, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(15, 16);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "元";
            // 
            // bt清空
            // 
            this.bt清空.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.bt清空.Appearance.Options.UseFont = true;
            this.bt清空.Location = new System.Drawing.Point(55, 237);
            this.bt清空.Name = "bt清空";
            this.bt清空.Size = new System.Drawing.Size(90, 32);
            this.bt清空.TabIndex = 51;
            this.bt清空.Text = "清空文本框";
            this.bt清空.Click += new System.EventHandler(this.bt清空_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(689, 200);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(95, 16);
            this.labelControl17.TabIndex = 50;
            this.labelControl17.Text = " 商 品 备 注：";
            // 
            // memoEdit备注
            // 
            this.memoEdit备注.Location = new System.Drawing.Point(786, 186);
            this.memoEdit备注.Name = "memoEdit备注";
            this.memoEdit备注.Size = new System.Drawing.Size(204, 83);
            this.memoEdit备注.TabIndex = 49;
            // 
            // bt删除
            // 
            this.bt删除.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.bt删除.Appearance.Options.UseFont = true;
            this.bt删除.Location = new System.Drawing.Point(689, 237);
            this.bt删除.Name = "bt删除";
            this.bt删除.Size = new System.Drawing.Size(75, 32);
            this.bt删除.TabIndex = 48;
            this.bt删除.Text = "删 除";
            this.bt删除.Click += new System.EventHandler(this.bt删除_Click);
            // 
            // bt修改
            // 
            this.bt修改.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.bt修改.Appearance.Options.UseFont = true;
            this.bt修改.Location = new System.Drawing.Point(469, 237);
            this.bt修改.Name = "bt修改";
            this.bt修改.Size = new System.Drawing.Size(75, 32);
            this.bt修改.TabIndex = 47;
            this.bt修改.Text = "修 改";
            this.bt修改.Click += new System.EventHandler(this.bt修改_Click);
            // 
            // bt添加
            // 
            this.bt添加.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.bt添加.Appearance.Options.UseFont = true;
            this.bt添加.Location = new System.Drawing.Point(249, 237);
            this.bt添加.Name = "bt添加";
            this.bt添加.Size = new System.Drawing.Size(75, 32);
            this.bt添加.TabIndex = 46;
            this.bt添加.Text = "添 加";
            this.bt添加.Click += new System.EventHandler(this.bt添加_Click);
            // 
            // text商品编号
            // 
            this.text商品编号.Location = new System.Drawing.Point(120, 161);
            this.text商品编号.Margin = new System.Windows.Forms.Padding(4);
            this.text商品编号.Name = "text商品编号";
            this.text商品编号.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品编号.Properties.Appearance.Options.UseFont = true;
            this.text商品编号.Size = new System.Drawing.Size(204, 26);
            this.text商品编号.TabIndex = 45;
            this.text商品编号.Enter += new System.EventHandler(this.text商品编号_Enter);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(17, 165);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(90, 16);
            this.labelControl16.TabIndex = 44;
            this.labelControl16.Text = "商 品 编 号：";
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl32.Appearance.Options.UseFont = true;
            this.labelControl32.Location = new System.Drawing.Point(689, 161);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(90, 16);
            this.labelControl32.TabIndex = 42;
            this.labelControl32.Text = "商 品 颜 色：";
            // 
            // text商品颜色
            // 
            this.text商品颜色.Location = new System.Drawing.Point(786, 154);
            this.text商品颜色.Name = "text商品颜色";
            this.text商品颜色.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品颜色.Properties.Appearance.Options.UseFont = true;
            this.text商品颜色.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品颜色.Properties.Items.AddRange(new object[] {
            "白",
            "淡蓝",
            "淡绿",
            "粉红",
            "黑",
            "红",
            "黄",
            "灰",
            "橘黄",
            "蓝",
            "绿",
            "墨绿",
            "紫"});
            this.text商品颜色.Properties.Sorted = true;
            this.text商品颜色.Size = new System.Drawing.Size(204, 26);
            this.text商品颜色.TabIndex = 41;
            // 
            // text商品类别
            // 
            this.text商品类别.Location = new System.Drawing.Point(786, 121);
            this.text商品类别.Name = "text商品类别";
            this.text商品类别.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品类别.Properties.Appearance.Options.UseFont = true;
            this.text商品类别.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品类别.Properties.Items.AddRange(new object[] {
            "Cosplay专用",
            "背心",
            "短裤",
            "短袖",
            "风衣",
            "哈西",
            "毛衣",
            "西装",
            "休闲",
            "修身装",
            "羽绒服",
            "运动"});
            this.text商品类别.Properties.Sorted = true;
            this.text商品类别.Size = new System.Drawing.Size(204, 26);
            this.text商品类别.TabIndex = 34;
            // 
            // text季节
            // 
            this.text季节.Location = new System.Drawing.Point(786, 87);
            this.text季节.Name = "text季节";
            this.text季节.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text季节.Properties.Appearance.Options.UseFont = true;
            this.text季节.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text季节.Properties.Items.AddRange(new object[] {
            "春",
            "春秋",
            "冬",
            "秋",
            "秋冬",
            "夏",
            "夏秋"});
            this.text季节.Properties.Sorted = true;
            this.text季节.Size = new System.Drawing.Size(204, 26);
            this.text季节.TabIndex = 32;
            // 
            // text商品尺码
            // 
            this.text商品尺码.Location = new System.Drawing.Point(786, 53);
            this.text商品尺码.Name = "text商品尺码";
            this.text商品尺码.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品尺码.Properties.Appearance.Options.UseFont = true;
            this.text商品尺码.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品尺码.Properties.Items.AddRange(new object[] {
            "",
            "4XL",
            "L",
            "M",
            "S",
            "XL",
            "XXL",
            "XXXL",
            "加肥加大款XL",
            "加肥加大款XXL",
            "加肥加大款XXXL",
            "均码"});
            this.text商品尺码.Properties.Sorted = true;
            this.text商品尺码.Size = new System.Drawing.Size(204, 26);
            this.text商品尺码.TabIndex = 31;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(689, 128);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(90, 16);
            this.labelControl15.TabIndex = 28;
            this.labelControl15.Text = "商 品 类 别：";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(689, 94);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(90, 16);
            this.labelControl14.TabIndex = 27;
            this.labelControl14.Text = "季       节  ：";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(689, 64);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(90, 16);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "商 品 尺 码：";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(689, 28);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(90, 16);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "商 品 品 牌：";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(367, 171);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(95, 16);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "商 品 单 位 ：";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "供货商名称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(367, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 16);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "进 货 单 价：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "所 属 仓 库 ：";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(367, 135);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "应 付 金 额 ：";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(367, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(95, 16);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "销 售 单 价 ：";
            // 
            // text销售单价框
            // 
            this.text销售单价框.Location = new System.Drawing.Point(469, 21);
            this.text销售单价框.Name = "text销售单价框";
            this.text销售单价框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text销售单价框.Properties.Appearance.Options.UseFont = true;
            this.text销售单价框.Properties.Mask.EditMask = "c";
            this.text销售单价框.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.text销售单价框.Size = new System.Drawing.Size(195, 26);
            this.text销售单价框.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(367, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "进 货 数 量 ：";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(367, 201);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "实 付 金 额：";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(17, 94);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(90, 16);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "进 货 日 期：";
            // 
            // Text进货单号
            // 
            this.Text进货单号.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.Text进货单号.Appearance.Options.UseFont = true;
            this.Text进货单号.Location = new System.Drawing.Point(12, 201);
            this.Text进货单号.Name = "Text进货单号";
            this.Text进货单号.Size = new System.Drawing.Size(95, 16);
            this.Text进货单号.TabIndex = 20;
            this.Text进货单号.Text = "进 货 单 号 ：";
            // 
            // text进货单号框
            // 
            this.text进货单号框.Location = new System.Drawing.Point(120, 194);
            this.text进货单号框.Name = "text进货单号框";
            this.text进货单号框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text进货单号框.Properties.Appearance.Options.UseFont = true;
            this.text进货单号框.Size = new System.Drawing.Size(204, 26);
            this.text进货单号框.TabIndex = 4;
            this.text进货单号框.Enter += new System.EventHandler(this.text进货单号框_Enter);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(17, 61);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(90, 16);
            this.labelControl12.TabIndex = 21;
            this.labelControl12.Text = "商 品 名 称：";
            // 
            // text商品名称框
            // 
            this.text商品名称框.Location = new System.Drawing.Point(120, 57);
            this.text商品名称框.Margin = new System.Windows.Forms.Padding(4);
            this.text商品名称框.Name = "text商品名称框";
            this.text商品名称框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品名称框.Properties.Appearance.Options.UseFont = true;
            this.text商品名称框.Size = new System.Drawing.Size(204, 26);
            this.text商品名称框.TabIndex = 11;
            // 
            // Text计量单位框
            // 
            this.Text计量单位框.Location = new System.Drawing.Point(469, 162);
            this.Text计量单位框.Name = "Text计量单位框";
            this.Text计量单位框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.Text计量单位框.Properties.Appearance.Options.UseFont = true;
            this.Text计量单位框.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Text计量单位框.Properties.ImmediatePopup = false;
            this.Text计量单位框.Properties.Items.AddRange(new object[] {
            "件",
            "箱",
            "套",
            "条",
            "包"});
            this.Text计量单位框.Properties.PopupSizeable = true;
            this.Text计量单位框.Size = new System.Drawing.Size(195, 26);
            this.Text计量单位框.TabIndex = 2;
            // 
            // text商品品牌
            // 
            this.text商品品牌.EditValue = "";
            this.text商品品牌.Location = new System.Drawing.Point(786, 21);
            this.text商品品牌.Name = "text商品品牌";
            this.text商品品牌.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text商品品牌.Properties.Appearance.Options.UseFont = true;
            this.text商品品牌.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text商品品牌.Properties.ImmediatePopup = false;
            this.text商品品牌.Properties.Items.AddRange(new object[] {
            "BOSS",
            "海澜之家",
            "鸿星尔克",
            "九牧王男装",
            "李宁",
            "七匹狼"});
            this.text商品品牌.Properties.NullText = "[EditValue is null]";
            this.text商品品牌.Properties.PopupSizeable = true;
            this.text商品品牌.Properties.Sorted = true;
            this.text商品品牌.Properties.ValidateOnEnterKey = false;
            this.text商品品牌.Size = new System.Drawing.Size(204, 26);
            this.text商品品牌.TabIndex = 35;
            // 
            // text进货日期
            // 
            this.text进货日期.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text进货日期.Location = new System.Drawing.Point(120, 88);
            this.text进货日期.Margin = new System.Windows.Forms.Padding(4);
            this.text进货日期.Name = "text进货日期";
            this.text进货日期.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text进货日期.Properties.Appearance.Options.UseFont = true;
            this.text进货日期.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text进货日期.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text进货日期.Properties.DisplayFormat.FormatString = "";
            this.text进货日期.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.text进货日期.Properties.EditFormat.FormatString = "";
            this.text进货日期.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.text进货日期.Properties.Mask.BeepOnError = true;
            this.text进货日期.Properties.Mask.EditMask = "D";
            this.text进货日期.Size = new System.Drawing.Size(204, 26);
            this.text进货日期.TabIndex = 43;
            // 
            // Text进货单价框
            // 
            this.Text进货单价框.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Text进货单价框.Location = new System.Drawing.Point(469, 53);
            this.Text进货单价框.Margin = new System.Windows.Forms.Padding(4);
            this.Text进货单价框.Name = "Text进货单价框";
            this.Text进货单价框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.Text进货单价框.Properties.Appearance.Options.UseFont = true;
            this.Text进货单价框.Properties.Mask.BeepOnError = true;
            this.Text进货单价框.Properties.Mask.EditMask = "d";
            this.Text进货单价框.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Text进货单价框.Size = new System.Drawing.Size(168, 26);
            this.Text进货单价框.TabIndex = 24;
            this.Text进货单价框.TextChanged += new System.EventHandler(this.Text进货单价框_TextChanged);
            // 
            // text实付金额
            // 
            this.text实付金额.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text实付金额.Location = new System.Drawing.Point(469, 197);
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
            // text应付金额框
            // 
            this.text应付金额框.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text应付金额框.Enabled = false;
            this.text应付金额框.Location = new System.Drawing.Point(469, 125);
            this.text应付金额框.Margin = new System.Windows.Forms.Padding(4);
            this.text应付金额框.Name = "text应付金额框";
            this.text应付金额框.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text应付金额框.Properties.Appearance.Options.UseFont = true;
            this.text应付金额框.Properties.Mask.EditMask = "c";
            this.text应付金额框.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.text应付金额框.Size = new System.Drawing.Size(195, 26);
            this.text应付金额框.TabIndex = 5;
            // 
            // text进货数量
            // 
            this.text进货数量.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.text进货数量.Location = new System.Drawing.Point(469, 88);
            this.text进货数量.Margin = new System.Windows.Forms.Padding(4);
            this.text进货数量.Name = "text进货数量";
            this.text进货数量.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text进货数量.Properties.Appearance.Options.UseFont = true;
            this.text进货数量.Properties.Mask.BeepOnError = true;
            this.text进货数量.Properties.Mask.EditMask = "d";
            this.text进货数量.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.text进货数量.Size = new System.Drawing.Size(195, 26);
            this.text进货数量.TabIndex = 38;
            this.text进货数量.TextChanged += new System.EventHandler(this.text进货数量_TextChanged);
            // 
            // text所属仓库
            // 
            this.text所属仓库.EditValue = "";
            this.text所属仓库.Location = new System.Drawing.Point(120, 121);
            this.text所属仓库.Name = "text所属仓库";
            this.text所属仓库.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text所属仓库.Properties.Appearance.Options.UseFont = true;
            this.text所属仓库.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text所属仓库.Properties.Items.AddRange(new object[] {
            "第二仓库",
            "第三仓库",
            "第一仓库"});
            this.text所属仓库.Properties.NullText = "[EditValue is null]";
            this.text所属仓库.Properties.PopupSizeable = true;
            this.text所属仓库.Properties.Sorted = true;
            this.text所属仓库.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.text所属仓库.Properties.ValidateOnEnterKey = false;
            this.text所属仓库.Size = new System.Drawing.Size(204, 26);
            this.text所属仓库.TabIndex = 36;
            // 
            // text供货商名称
            // 
            this.text供货商名称.EditValue = "";
            this.text供货商名称.Location = new System.Drawing.Point(120, 18);
            this.text供货商名称.Name = "text供货商名称";
            this.text供货商名称.Properties.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold);
            this.text供货商名称.Properties.Appearance.Options.UseFont = true;
            this.text供货商名称.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.text供货商名称.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "供货商名称", 142, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsUsed", "可用？", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.text供货商名称.Properties.DataSource = this.tableSupplierBindingSource;
            this.text供货商名称.Properties.DisplayMember = "CompanyName";
            this.text供货商名称.Properties.ImmediatePopup = true;
            this.text供货商名称.Properties.PopupSizeable = false;
            this.text供货商名称.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.text供货商名称.Properties.ValueMember = "CompanyID";
            this.text供货商名称.Size = new System.Drawing.Size(204, 26);
            this.text供货商名称.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGoodsID,
            this.colID,
            this.colCompanyName,
            this.colStroName,
            this.colGoodsName,
            this.colGoodsNum,
            this.colGoodsUnit,
            this.colGoodsInPrice,
            this.colGoodsSellPrice,
            this.colGoodsShouldPay,
            this.colGoodsRealPay,
            this.colGoodsRemark,
            this.colGoodsInDateTime,
            this.colGoodsColor,
            this.colGoodsSize,
            this.colGoodsLeibie,
            this.colGoodsShouldJijie,
            this.colGoodsPinpai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colGoodsID
            // 
            this.colGoodsID.Caption = "商品编号";
            this.colGoodsID.FieldName = "GoodsID";
            this.colGoodsID.Name = "colGoodsID";
            this.colGoodsID.OptionsColumn.AllowEdit = false;
            this.colGoodsID.Visible = true;
            this.colGoodsID.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.Caption = "进货单号";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            // 
            // colCompanyName
            // 
            this.colCompanyName.Caption = "供货商名称";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 2;
            // 
            // colStroName
            // 
            this.colStroName.Caption = "仓库名称";
            this.colStroName.FieldName = "StroName";
            this.colStroName.Name = "colStroName";
            this.colStroName.OptionsColumn.AllowEdit = false;
            this.colStroName.Visible = true;
            this.colStroName.VisibleIndex = 3;
            // 
            // colGoodsName
            // 
            this.colGoodsName.Caption = "商品名";
            this.colGoodsName.FieldName = "GoodsName";
            this.colGoodsName.Name = "colGoodsName";
            this.colGoodsName.OptionsColumn.AllowEdit = false;
            this.colGoodsName.Visible = true;
            this.colGoodsName.VisibleIndex = 4;
            // 
            // colGoodsNum
            // 
            this.colGoodsNum.Caption = "进货数量";
            this.colGoodsNum.FieldName = "GoodsNum";
            this.colGoodsNum.Name = "colGoodsNum";
            this.colGoodsNum.OptionsColumn.AllowEdit = false;
            this.colGoodsNum.Visible = true;
            this.colGoodsNum.VisibleIndex = 5;
            // 
            // colGoodsUnit
            // 
            this.colGoodsUnit.Caption = "商品计量单位";
            this.colGoodsUnit.FieldName = "GoodsUnit";
            this.colGoodsUnit.Name = "colGoodsUnit";
            this.colGoodsUnit.OptionsColumn.AllowEdit = false;
            this.colGoodsUnit.Visible = true;
            this.colGoodsUnit.VisibleIndex = 6;
            // 
            // colGoodsInPrice
            // 
            this.colGoodsInPrice.Caption = "商品进价";
            this.colGoodsInPrice.FieldName = "GoodsInPrice";
            this.colGoodsInPrice.Name = "colGoodsInPrice";
            this.colGoodsInPrice.OptionsColumn.AllowEdit = false;
            this.colGoodsInPrice.Visible = true;
            this.colGoodsInPrice.VisibleIndex = 7;
            // 
            // colGoodsSellPrice
            // 
            this.colGoodsSellPrice.Caption = "商品售价";
            this.colGoodsSellPrice.FieldName = "GoodsSellPrice";
            this.colGoodsSellPrice.Name = "colGoodsSellPrice";
            this.colGoodsSellPrice.OptionsColumn.AllowEdit = false;
            this.colGoodsSellPrice.Visible = true;
            this.colGoodsSellPrice.VisibleIndex = 8;
            // 
            // colGoodsShouldPay
            // 
            this.colGoodsShouldPay.Caption = "进货应付金额";
            this.colGoodsShouldPay.FieldName = "GoodsShouldPay";
            this.colGoodsShouldPay.Name = "colGoodsShouldPay";
            this.colGoodsShouldPay.OptionsColumn.AllowEdit = false;
            this.colGoodsShouldPay.Visible = true;
            this.colGoodsShouldPay.VisibleIndex = 9;
            // 
            // colGoodsRealPay
            // 
            this.colGoodsRealPay.Caption = "进货实付金额";
            this.colGoodsRealPay.FieldName = "GoodsRealPay";
            this.colGoodsRealPay.Name = "colGoodsRealPay";
            this.colGoodsRealPay.OptionsColumn.AllowEdit = false;
            this.colGoodsRealPay.Visible = true;
            this.colGoodsRealPay.VisibleIndex = 10;
            // 
            // colGoodsRemark
            // 
            this.colGoodsRemark.Caption = "商品备注";
            this.colGoodsRemark.FieldName = "GoodsRemark";
            this.colGoodsRemark.Name = "colGoodsRemark";
            this.colGoodsRemark.OptionsColumn.AllowEdit = false;
            this.colGoodsRemark.Visible = true;
            this.colGoodsRemark.VisibleIndex = 11;
            // 
            // colGoodsInDateTime
            // 
            this.colGoodsInDateTime.Caption = "进货时间";
            this.colGoodsInDateTime.FieldName = "GoodsInDateTime";
            this.colGoodsInDateTime.Name = "colGoodsInDateTime";
            this.colGoodsInDateTime.OptionsColumn.AllowEdit = false;
            this.colGoodsInDateTime.Visible = true;
            this.colGoodsInDateTime.VisibleIndex = 12;
            // 
            // colGoodsColor
            // 
            this.colGoodsColor.Caption = "商品颜色";
            this.colGoodsColor.FieldName = "GoodsColor";
            this.colGoodsColor.Name = "colGoodsColor";
            this.colGoodsColor.OptionsColumn.AllowEdit = false;
            this.colGoodsColor.Visible = true;
            this.colGoodsColor.VisibleIndex = 13;
            // 
            // colGoodsSize
            // 
            this.colGoodsSize.Caption = "商品型号";
            this.colGoodsSize.FieldName = "GoodsSize";
            this.colGoodsSize.Name = "colGoodsSize";
            this.colGoodsSize.OptionsColumn.AllowEdit = false;
            this.colGoodsSize.Visible = true;
            this.colGoodsSize.VisibleIndex = 14;
            // 
            // colGoodsLeibie
            // 
            this.colGoodsLeibie.Caption = "商品类别";
            this.colGoodsLeibie.FieldName = "GoodsLeibie";
            this.colGoodsLeibie.Name = "colGoodsLeibie";
            this.colGoodsLeibie.OptionsColumn.AllowEdit = false;
            this.colGoodsLeibie.Visible = true;
            this.colGoodsLeibie.VisibleIndex = 15;
            // 
            // colGoodsShouldJijie
            // 
            this.colGoodsShouldJijie.Caption = "应用季节";
            this.colGoodsShouldJijie.FieldName = "GoodsShouldJijie";
            this.colGoodsShouldJijie.Name = "colGoodsShouldJijie";
            this.colGoodsShouldJijie.OptionsColumn.AllowEdit = false;
            this.colGoodsShouldJijie.Visible = true;
            this.colGoodsShouldJijie.VisibleIndex = 16;
            // 
            // colGoodsPinpai
            // 
            this.colGoodsPinpai.Caption = "商品品牌";
            this.colGoodsPinpai.FieldName = "GoodsPinpai";
            this.colGoodsPinpai.Name = "colGoodsPinpai";
            this.colGoodsPinpai.OptionsColumn.AllowEdit = false;
            this.colGoodsPinpai.Visible = true;
            this.colGoodsPinpai.VisibleIndex = 17;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tableGoodsInBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1274, 250);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Form采购货物
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 532);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form采购货物";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "采购货物页面";
            this.Load += new System.EventHandler(this.Form采购货物_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGoodsInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit备注.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品编号.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品颜色.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品类别.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text季节.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品尺码.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text销售单价框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货单号框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品名称框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text计量单位框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text商品品牌.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货日期.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货日期.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text进货单价框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text实付金额.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text应付金额框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text进货数量.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text所属仓库.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text供货商名称.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DBCLDataSet dBCLDataSet;
        private System.Windows.Forms.BindingSource tableGoodsInBindingSource;
        private DBCLDataSetTableAdapters.Table_GoodsInTableAdapter table_GoodsInTableAdapter;
        private System.Windows.Forms.BindingSource tableSupplierBindingSource;
        private DBCLDataSetTableAdapters.Table_SupplierTableAdapter table_SupplierTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.TextEdit text商品编号;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.ComboBoxEdit text商品颜色;
        private DevExpress.XtraEditors.ComboBoxEdit text商品类别;
        private DevExpress.XtraEditors.ComboBoxEdit text季节;
        private DevExpress.XtraEditors.ComboBoxEdit text商品尺码;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit text销售单价框;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl Text进货单号;
        private DevExpress.XtraEditors.TextEdit text进货单号框;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit text商品名称框;
        private DevExpress.XtraEditors.MRUEdit Text计量单位框;
        private DevExpress.XtraEditors.MRUEdit text商品品牌;
        private DevExpress.XtraEditors.DateEdit text进货日期;
        private DevExpress.XtraEditors.TextEdit Text进货单价框;
        private DevExpress.XtraEditors.TextEdit text实付金额;
        private DevExpress.XtraEditors.TextEdit text应付金额框;
        private DevExpress.XtraEditors.TextEdit text进货数量;
        private DevExpress.XtraEditors.MRUEdit text所属仓库;
        private DevExpress.XtraEditors.SimpleButton bt删除;
        private DevExpress.XtraEditors.SimpleButton bt修改;
        private DevExpress.XtraEditors.SimpleButton bt添加;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.MemoEdit memoEdit备注;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colStroName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsName;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsNum;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsInPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsSellPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsShouldPay;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsRealPay;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsInDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsColor;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsSize;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsLeibie;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsShouldJijie;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsPinpai;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton bt清空;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit text供货商名称;
    }
}