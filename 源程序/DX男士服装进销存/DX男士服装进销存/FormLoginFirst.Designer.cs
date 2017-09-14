namespace DX男士服装进销存
{
    partial class FormLoginFirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginFirst));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.text密码框 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb登陆 = new DevExpress.XtraEditors.LabelControl();
            this.text登录框 = new DevExpress.XtraEditors.TextEdit();
            this.bt登陸 = new DevExpress.XtraEditors.SimpleButton();
            this.bt退出 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lberromessage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text密码框.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text登录框.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.text密码框);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lb登陆);
            this.panelControl1.Controls.Add(this.text登录框);
            this.panelControl1.Location = new System.Drawing.Point(66, 66);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(392, 161);
            this.panelControl1.TabIndex = 0;
            // 
            // text密码框
            // 
            this.text密码框.Location = new System.Drawing.Point(168, 87);
            this.text密码框.Name = "text密码框";
            this.text密码框.Properties.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text密码框.Properties.Appearance.Options.UseFont = true;
            this.text密码框.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.text密码框.Properties.PasswordChar = '*';
            this.text密码框.Size = new System.Drawing.Size(194, 22);
            this.text密码框.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "密   码：";
            // 
            // lb登陆
            // 
            this.lb登陆.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb登陆.Appearance.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb登陆.Appearance.Options.UseFont = true;
            this.lb登陆.Location = new System.Drawing.Point(48, 35);
            this.lb登陆.Name = "lb登陆";
            this.lb登陆.Size = new System.Drawing.Size(84, 22);
            this.lb登陆.TabIndex = 1;
            this.lb登陆.Text = "登录名：";
            // 
            // text登录框
            // 
            this.text登录框.Location = new System.Drawing.Point(168, 37);
            this.text登录框.Name = "text登录框";
            this.text登录框.Properties.Appearance.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text登录框.Properties.Appearance.Options.UseFont = true;
            this.text登录框.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.text登录框.Size = new System.Drawing.Size(194, 22);
            this.text登录框.TabIndex = 0;
            this.text登录框.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text登录框_KeyPress);
            // 
            // bt登陸
            // 
            this.bt登陸.Location = new System.Drawing.Point(66, 275);
            this.bt登陸.Name = "bt登陸";
            this.bt登陸.Size = new System.Drawing.Size(93, 46);
            this.bt登陸.TabIndex = 1;
            this.bt登陸.Text = "登   陆";
            this.bt登陸.Click += new System.EventHandler(this.bt登陸_Click);
            // 
            // bt退出
            // 
            this.bt退出.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt退出.Location = new System.Drawing.Point(376, 275);
            this.bt退出.Name = "bt退出";
            this.bt退出.Size = new System.Drawing.Size(82, 46);
            this.bt退出.TabIndex = 2;
            this.bt退出.Text = "退    出";
            this.bt退出.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // lberromessage
            // 
            this.lberromessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lberromessage.Appearance.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lberromessage.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lberromessage.Appearance.Options.UseFont = true;
            this.lberromessage.Appearance.Options.UseForeColor = true;
            this.lberromessage.Location = new System.Drawing.Point(102, 233);
            this.lberromessage.Name = "lberromessage";
            this.lberromessage.Size = new System.Drawing.Size(305, 22);
            this.lberromessage.TabIndex = 3;
            this.lberromessage.Text = "对不起，您输入的账号/密码错误";
            this.lberromessage.Visible = false;
            // 
            // FormLoginFirst
            // 
            this.AcceptButton = this.bt登陸;
            this.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScrollMargin = new System.Drawing.Size(550, 331);
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.CancelButton = this.bt退出;
            this.ClientSize = new System.Drawing.Size(550, 333);
            this.ControlBox = false;
            this.Controls.Add(this.lberromessage);
            this.Controls.Add(this.bt退出);
            this.Controls.Add(this.bt登陸);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用踏雪服装进销存系统，请登录";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FormLoginFirst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text密码框.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text登录框.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lb登陆;
        private DevExpress.XtraEditors.TextEdit text登录框;
        private DevExpress.XtraEditors.SimpleButton bt登陸;
        private DevExpress.XtraEditors.SimpleButton bt退出;
        private DevExpress.XtraEditors.TextEdit text密码框;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lberromessage;
    }
}