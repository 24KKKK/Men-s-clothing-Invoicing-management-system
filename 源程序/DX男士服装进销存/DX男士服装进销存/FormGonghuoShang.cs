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
using DX男士服装进销存.Shar;

namespace DX男士服装进销存
{
    public partial class FormGonghuoShang : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public FormGonghuoShang()
        {
            InitializeComponent();
        }

        private void FormGonghuoShang_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_Supplier”中。您可以根据需要移动或删除它。
            this.table_SupplierTableAdapter.Fill(this.dBCLDataSet.Table_Supplier);

        }
        private void clear()
        {
           
            text公司地址.Text = "";
            text供应商编号.Text = "";
            text供应商名称.Text = "";
            text用户电话框.Text = "";
            tex联系人名称.Text = "";
            memoEdit备注.Text = "";
        }
        private void text供应商编号_Click(object sender, EventArgs e)
        {
            if (text供应商编号.Text=="")
            {
                text供应商编号.Text = Shar.IDshengcheng.GongyingshangID();
            }
        }
        public bool IsNotNULL()
        { 
            if (text公司地址.Text == "")
            {
                MessageBox.Show("公司地址不可为空！");
                this.text公司地址.Focus();
                return false;

            }
            else if (text供应商编号.Text  == "")
            {
                MessageBox.Show("供应商编号不可为空！");
                this.text供应商编号.Focus();
                return false;
            }
            else if (text用户电话框.Text==null)
            {
                MessageBox.Show("联系人电话不能为空！");
                this.text用户电话框.Focus();
                return false;
            }
            else if (text供应商名称.Text  == "")
            {
                MessageBox.Show("供应商名称不可为空！");
                this.text供应商名称.Focus();
                return false;
            }
            else if (tex联系人名称.Text  == "")
            {
                MessageBox.Show("联系人不可为空！");
                this.tex联系人名称.Focus();
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
                this.table_SupplierTableAdapter.Fill(this.dBCLDataSet.Table_Supplier);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            bt保存.Enabled = false;
            bt删除.Enabled = true;
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
               text供应商编号.Text  = dr["CompanyID"].ToString();
               text供应商名称.Text  = dr["CompanyName"].ToString();
               tex联系人名称.Text  = dr["CompanyDirector"].ToString();
               text用户电话框.Text= dr["CompanyPhone"].ToString();
               text公司地址.Text  = dr["CompanyAddress"].ToString();
               dateEdit加入日期.Text = dr["InDateTime"].ToString();
               memoEdit备注.Text = dr["CompanyReMark"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    Table_Supplier suppllier = new Table_Supplier();
                    suppllier.CompanyAddress = text公司地址.Text;
                    suppllier.CompanyDirector = tex联系人名称.Text;
                    suppllier.CompanyID = text供应商编号.Text;
                    suppllier.CompanyName = text供应商名称.Text;
                    suppllier.CompanyPhone = text用户电话框.Text;
                    suppllier.CompanyReMark = memoEdit备注.Text;
                    suppllier.InDateTime = DateTime.Parse(dateEdit加入日期.Text);
                    suppllier.IsUsed = ISuesd;
                    db.Table_Supplier.Add(suppllier);
                    db.SaveChanges();
                    MessageBox.Show("供货商录入成功！", "提示");
                    fillToolStripButton_Click(sender,e);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "踏雪温馨提示");
                }
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
                    Table_Supplier deleteneirong = db.Table_Supplier.Find(dr["CompanyID"].ToString());
                    db.Table_Supplier.Remove(deleteneirong);
                    db.SaveChanges();
                    fillToolStripButton_Click(sender, e);
                    MessageBox.Show("删除成功！");
                    fillToolStripButton_Click(sender, e);
                }
                bt保存.Enabled = true;
                bt修改.Enabled = false;
                text供应商编号.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败！\n" + ex.Message);
            }
        }
        private void bt修改_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool ISuesd = true;
                if (check启用.Checked == false)
                {
                    ISuesd = false;
                }
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var resluts = db.Table_Supplier.Find(dr["CompanyID"]);
                resluts.CompanyAddress = text公司地址.Text;
                resluts.CompanyDirector = tex联系人名称.Text;
                resluts.CompanyName = text供应商名称.Text;
                resluts.CompanyPhone = text用户电话框.Text;
                resluts.CompanyReMark = memoEdit备注.Text;
                resluts.InDateTime = DateTime.Parse(dateEdit加入日期.Text);
                resluts.IsUsed = ISuesd;
                db.SaveChanges();
                MessageBox.Show("修改成功！");
                fillToolStripButton_Click(sender, e);
                clear();
                bt保存.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败！/n" + ex.Message);
            }
        }
    }
}