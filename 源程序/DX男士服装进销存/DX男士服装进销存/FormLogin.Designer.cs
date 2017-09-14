namespace DX男士服装进销存
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureEditWelconback = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.Bt解锁 = new DevExpress.XtraEditors.SimpleButton();
            this.FormLogin二级密码文本框 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWelconback.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormLogin二级密码文本框.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEditWelconback
            // 
            this.pictureEditWelconback.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditWelconback.EditValue = ((object)(resources.GetObject("pictureEditWelconback.EditValue")));
            this.pictureEditWelconback.Location = new System.Drawing.Point(-12, 0);
            this.pictureEditWelconback.Name = "pictureEditWelconback";
            this.pictureEditWelconback.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditWelconback.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditWelconback.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditWelconback.Size = new System.Drawing.Size(423, 171);
            this.pictureEditWelconback.TabIndex = 1;
            // 
            // labelControl
            // 
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl.LineLocation = DevExpress.XtraEditors.LineLocation.Left;
            this.labelControl.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.labelControl.LineVisible = true;
            this.labelControl.Location = new System.Drawing.Point(35, 192);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(100, 14);
            this.labelControl.TabIndex = 2;
            this.labelControl.Text = "请输入二级密码：";
            this.labelControl.Click += new System.EventHandler(this.labelControl_Click);
            // 
            // Bt解锁
            // 
            this.Bt解锁.Location = new System.Drawing.Point(97, 232);
            this.Bt解锁.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.Bt解锁.Name = "Bt解锁";
            this.Bt解锁.Size = new System.Drawing.Size(174, 44);
            this.Bt解锁.TabIndex = 0;
            this.Bt解锁.Text = "确定";
            this.Bt解锁.Click += new System.EventHandler(this.Bt解锁_Click);
            // 
            // FormLogin二级密码文本框
            // 
            this.FormLogin二级密码文本框.Location = new System.Drawing.Point(156, 189);
            this.FormLogin二级密码文本框.Name = "FormLogin二级密码文本框";
            this.FormLogin二级密码文本框.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.FormLogin二级密码文本框.Properties.Appearance.Options.UseBackColor = true;
            this.FormLogin二级密码文本框.Properties.PasswordChar = '*';
            this.FormLogin二级密码文本框.Properties.UseSystemPasswordChar = true;
            this.FormLogin二级密码文本框.Size = new System.Drawing.Size(173, 20);
            this.FormLogin二级密码文本框.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.Bt解锁;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(397, 302);
            this.Controls.Add(this.Bt解锁);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.FormLogin二级密码文本框);
            this.Controls.Add(this.pictureEditWelconback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 341);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 341);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "输入密码解锁";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditWelconback.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormLogin二级密码文本框.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEditWelconback;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraEditors.SimpleButton Bt解锁;
        public DevExpress.XtraEditors.TextEdit FormLogin二级密码文本框;

    }
}