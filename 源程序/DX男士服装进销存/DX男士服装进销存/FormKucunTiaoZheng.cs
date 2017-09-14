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
    public partial class FormKucunTiaoZheng : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public FormKucunTiaoZheng()
        {
            InitializeComponent();
        }
        private void bt确定_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISnotnull())
                {
                    var res = db.Table_Stor.Find(text商品编号.Text .Trim());
                    if (res.KcNumber >= int.Parse(text转移数量.Text))
                    {
                        res.KcNumber -= int.Parse(text转移数量.Text);
                        Table_Stor ts = new Table_Stor();
                        ts.CompanyName = res.CompanyName;
                        ts.GoodsID = Shar.IDshengcheng.GoodsIDS();
                        ts.KcDataTime = res.KcDataTime;
                        ts.KcGoodsName = res.KcGoodsName;
                        ts.KcGoodsPrice = res.KcGoodsPrice;
                        ts.KcGoodsSellPrice = res.KcGoodsSellPrice;
                        ts.KcID = text商品新存库编号.Text;
                        ts.KcJingGaoNumber = res.KcJingGaoNumber;
                        ts.KcName = res.KcName;
                        ts.KcNumber = int.Parse(text转移数量.Text);
                        ts.KcRemark = res.KcUnit;
                        db.SaveChanges();
                        fillToolStripButton_Click(sender,e);
                        MessageBox.Show("调整成功！");
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("对不起出现了未知错误\n\r"+ex.Message );
            }
        }

        private void bt重置_Click(object sender, EventArgs e)
        {
            text转移数量.Text = "";
            text商品原存库编号.Text = "";
            text商品新存库编号.Text = "";
            text商品编号.Text = "";
            fillToolStripButton_Click(sender, e);
        } 


        private void FormKucunTiaoZheng_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_Stor”中。您可以根据需要移动或删除它。
            this.table_StorTableAdapter.Fill(this.dBCLDataSet.Table_Stor);

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            text商品原存库编号.ReadOnly = true;
            text商品编号.ReadOnly = true;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            text商品原存库编号.Text = dr["KcID"].ToString();
            text商品编号.Text = dr["GoodsID"].ToString();
        }
        bool ISnotnull()
        {
            if (text转移数量.Text == null)
            {
                MessageBox.Show("对不起，转移数量不可为空");
                return false;
            }
            if (int.Parse(text转移数量.Text) <= 0)
            {
                MessageBox.Show("转移数量必须为正数！");
                return false;
            }
            if (text商品原存库编号.Text == null)
            {
                MessageBox.Show("请输入正确的新库存编号！");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_StorTableAdapter.Fill(this.dBCLDataSet.Table_Stor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}