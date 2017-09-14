using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DX男士服装进销存.Models;

namespace DX男士服装进销存
{
    
    public partial class FormVip管理 : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public FormVip管理()
        {
            InitializeComponent();
        }

        private void FormVip管理_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_VIPMessage”中。您可以根据需要移动或删除它。
            this.table_VIPMessageTableAdapter.Fill(this.dBCLDataSet.Table_VIPMessage);

        }
        public bool IsNotNULL()
        {
            if (textEditVip编号框.Text == "")
            {
                MessageBox.Show("Vip编号不可为空！");
                this.textEditVip编号框.Focus();
                return false;
            }
            else if (textEditVip用户名.Text == "")
            {
                MessageBox.Show("Vip客户名不可为空！");
                this.textEditVip用户名.Focus();
                return false;
 
            }
            else if(textVIP电话.Text=="")
            {
                MessageBox.Show("Vip客户电话号不可为空！");
                this.textVIP电话.Focus();
                return false;
            }
            else if (double.Parse(textVIP折扣率.Text) <= 0)
            {
                MessageBox.Show("Vip客户折扣率输入错误！");
                this.textVIP折扣率.Focus();
                return false;
            }
            else if(textEditVip用户住址框.Text =="")
            {
                MessageBox.Show("Vip客户住址不可为空！");
                this.textVIP折扣率.Focus();
                return false;
            }

            return true;
        }
        /*********************************************************************/
        //刷新表单
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_VIPMessageTableAdapter.Fill(this.dBCLDataSet.Table_VIPMessage);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void bt保存_Click(object sender, EventArgs e)
        {
            bool ISuesd = true;
            if (check启用.Checked == false)
            {
                ISuesd = false;
            }
            if (IsNotNULL())
            {
                try
                {
                    Table_VIPMessage tvip = new Table_VIPMessage();
                    tvip.VIPID = this.textEditVip编号框.Text;
                    tvip.VIPName = textEditVip用户名.Text;
                    tvip.VIPPhone = textVIP电话.Text;
                    tvip.VIPZhekou = decimal.Parse(textVIP折扣率.Text);
                    tvip.VIPAddress = textEditVip用户住址框.Text;
                    tvip.VIPBirtheDay = DateTime.Parse(textVIP生日.Text);
                    tvip.VIPRemrk = memoEdit备注.Text;
                    tvip.Flage = ISuesd;
                    db.Table_VIPMessage.Add(tvip);
                    db.SaveChanges();
                    fillToolStripButton_Click(sender,e);
                    textEditVip编号框.Text = "";
                    textEditVip用户名.Text = "";
                    textVIP电话.Text = "";
                    textVIP折扣率.Text = "";
                    textEditVip用户住址框.Text = "";
                    textVIP生日.Text = "";
                    memoEdit备注.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现未知错误导致数据路录入失败！\n"+ex.Message,"踏雪温馨提示");
                }
            }
           

        }

        private void bt修改_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var resluts = db.Table_VIPMessage.Find(dr["VIPID"].ToString());
                resluts.VIPName = textEditVip用户名.Text;
                resluts.VIPAddress = textEditVip用户住址框.Text;
                resluts.VIPBirtheDay = DateTime.Parse(textVIP生日.Text);
                resluts.VIPPhone = textVIP电话.Text;
                resluts.VIPRemrk = memoEdit备注.Text;
                resluts.VIPZhekou =decimal.Parse(textVIP折扣率.Text);
                db.SaveChanges();
                MessageBox.Show("信息修改成功");
                fillToolStripButton_Click(sender, e);
                bt保存.Enabled = true;
                textEditVip编号框.Text = "";
                textEditVip用户名.Text = "";
                textVIP电话.Text = "";
                textVIP折扣率.Text = "";
                textEditVip用户住址框.Text = "";
                textVIP生日.Text = "";
                memoEdit备注.Text = "";
            }
            catch(Exception  ex)
            {
                MessageBox.Show("更新失败！/n"+ex.Message);
            }


        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            bt保存.Enabled = false;
            bt删除.Enabled = true;
            bt修改.Enabled = true;
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                textEditVip编号框.Text = dr["VIPID"].ToString();
                textEditVip用户名.Text = dr["VIPName"].ToString();
                textVIP电话.Text = dr["VIPPhone"].ToString();
                textVIP折扣率.Text = dr["VIPZhekou"].ToString();
                textEditVip用户住址框.Text = dr["VIPAddress"].ToString();
                textVIP生日.Text = dr["VIPBirtheDay"].ToString();
                memoEdit备注.Text = dr["VIPRemrk"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bt删除_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                    Table_VIPMessage deleteneirong = db.Table_VIPMessage.Find(dr["VIPID"].ToString());
                    db.Table_VIPMessage.Remove(deleteneirong);
                    db.SaveChanges();
                    fillToolStripButton_Click(sender, e);
                    MessageBox.Show("删除成功！");
                }
                bt保存.Enabled = true;
                bt修改.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除失败！\n"+ex.Message);
            }
           
        }
        private void textEditVip编号框_Click(object sender, EventArgs e)
        {
            if (textEditVip编号框.Text == "")
            {
                textEditVip编号框.Text = Shar.IDshengcheng.VIPID();
            }
        }
      
    }
}