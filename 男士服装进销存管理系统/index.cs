using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 男士服装进销存管理系统
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void Form_index_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
        }

        private void 进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage1);
            this.tabControl1.SelectedTab = this.tabPage1;
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage3);
            this.tabControl1.SelectedTab = this.tabPage3;
        }

        private void 销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage2);
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void 销售查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage4);
            this.tabControl1.SelectedTab = this.tabPage4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("添加成功！");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改成功！");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除成功！");
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beifen bei=new beifen();
            bei.Show();
        }

        private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            huanyuan huan = new huanyuan();
            huan.Show();
        }

        private void 添加员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Addyuangong())).Start();
        }

        private void 供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Addgys())).Start();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new Editpassword())).Start();
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage5);
            this.tabControl1.SelectedTab = this.tabPage5;
        }

        private void 库存报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage8);
            this.tabControl1.SelectedTab = this.tabPage8;
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage6);
            this.tabControl1.SelectedTab = this.tabPage6;
        }

        private void 编辑供应商信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPage7);
            this.tabControl1.SelectedTab = this.tabPage7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new about())).Start();
        }
    }
}
