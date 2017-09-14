namespace DX男士服装进销存
{
    partial class FormAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs));
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.SuspendLayout();
            // 
            // symbolBox1
            // 
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(27, 59);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(82, 78);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.TabIndex = 0;
            this.symbolBox1.Text = "关于我们";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(119, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(153, 105);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "作者：<font color=\"#ED1C24\"><u>邵文正</u></font><br></br>\r\n联系方式： <u>15226586361</u>";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Glass Oceans";
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 222);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.symbolBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 261);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 261);
            this.Name = "FormAboutUs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于我";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;


    }
}