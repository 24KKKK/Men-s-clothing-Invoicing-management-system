namespace 男士服装进销存管理系统
{
    partial class huanyuan
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
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(170, 75);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(153, 27);
            this.button15.TabIndex = 58;
            this.button15.Text = "确定";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(401, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 27);
            this.button16.TabIndex = 57;
            this.button16.Text = "打开";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(128, 24);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(267, 21);
            this.textBox31.TabIndex = 56;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 27);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(113, 12);
            this.label36.TabIndex = 55;
            this.label36.Text = "还原数据文件路径：";
            // 
            // huanyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(520, 128);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.label36);
            this.MaximizeBox = false;
            this.Name = "huanyuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据还原";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label36;
    }
}