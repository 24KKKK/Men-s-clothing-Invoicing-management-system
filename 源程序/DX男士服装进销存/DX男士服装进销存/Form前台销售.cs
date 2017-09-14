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
    public partial class Form前台销售 : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public Form前台销售()
        {
            InitializeComponent();    
        }
        private void Form前台销售_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_VIPMessage”中。您可以根据需要移动或删除它。
            this.table_VIPMessageTableAdapter.Fill(this.dBCLDataSet.Table_VIPMessage);
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_GoodsSell”中。您可以根据需要移动或删除它。
            this.table_GoodsSellTableAdapter.Fill(this.dBCLDataSet.Table_GoodsSell);
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_GoodsIn”中。您可以根据需要移动或删除它。
            this.table_GoodsInTableAdapter.Fill(this.dBCLDataSet.Table_GoodsIn);
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_Stor”中。您可以根据需要移动或删除它。
            this.table_StorTableAdapter.Fill(this.dBCLDataSet.Table_Stor);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_GoodsSellTableAdapter.Fill(this.dBCLDataSet.Table_GoodsSell);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void text进货销售单号_Enter(object sender, EventArgs e)
        {
          text销售单号.Text = Shar.IDshengcheng.ShouHuoDan();
        }

        private void text商品编号_EditValueChanged(object sender, EventArgs e)
        {
            fillToolStripButton_Click_2(sender,e);
            try
            {
                var Goods = db.Table_Stor.Find(text商品编号.Text);
                text商品名称.Text = Goods.KcGoodsName;
                Text单价框.Text = Goods.KcGoodsSellPrice.ToString();
                if (Goods.KcNumber <= 0)
                {
                    MessageBox.Show("库存中已经没有此商品！", "警告");
                }
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private bool Isnotnull()
        {
            if (text操作员框.Text == null)
            {
                return false;
            }
            else if (Text单价框.Text == null)
            {
                return false;

            }
            else if(text商品编号.Text ==null)
            {
                return false;
            }
            else if(text商品名称.Text ==null)
            {
                return false;
            }
            else if (text实付金额.Text == null)
            {
                return false;
            }
            else if (text数量.Text == null)
            {
                return false;
            }
            else if (text销售单号.Text == null)
            {
                return false;
            }
            else if (text应付金额框.Text == null)
            {
                return false;
            }
            else
            {
                return true; 
            }
           

        }

        private void btSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (Isnotnull())
                {
                    Table_GoodsSell gs = new Table_GoodsSell();
                    var find = db.Table_Stor.Find(text商品编号.Text);
                    gs.GoodsID = text商品编号.Text;
                    gs.GoodsName = text商品名称.Text;
                    gs.ID = " ";
                    gs.KcID = find.KcID;
                    gs.Sellflage = true;
                    gs.SellGoodsNumber = int.Parse(text数量.Text);
                    gs.SellGoodsTime = DateTime.Now;
                    gs.SellID = text销售单号.Text;
                    gs.SellPrice = find.KcGoodsSellPrice;
                    gs.SellRealPay = decimal.Parse(text实付金额.Text);
                    gs.SellRemark = "";
                    gs.SellShouldPay = decimal.Parse(text应付金额框.Text);
                    find.KcNumber = find.KcNumber - gs.SellGoodsNumber;
                    db.Table_GoodsSell.Add(gs);
                    db.SaveChanges();
                    MessageBox.Show("操作完成！");
                    fillToolStripButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("请输入完整的信息！","提示！");
                }
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("由于操作问题，导致系统出错,请重试！"+ex.Message );
            }
           
        }

        private void text数量_EditValueChanged(object sender, EventArgs e)
        {
         
           text应付金额框.Text =Shar.Caculater.Jisuan(text数量.Text, Text单价框.Text).ToString ();
        }


        private void Btclear_Click(object sender, EventArgs e)
        {
            text销售单号.Text = "";
            text实付金额.Text = "";
            text数量.Text = "";
            text数量.Text = "0";
            textVIP折扣率.Text = null;

        }

        private void text销售单号_Click(object sender, EventArgs e)
        {
            if (text销售单号.Text == null)
            { 
                text销售单号.Text = Shar.IDshengcheng.ShouHuoDan();
            }
           
        }

        private void textVIP折扣率_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 fillToolStripButton_Click_1(sender, e);
                if (text应付金额框.Text != null&&textVIP折扣率.Text !=null)
                {
                    text应付金额框.Text = (decimal.Parse(text应付金额框.Text) * decimal.Parse(textVIP折扣率.Text)).ToString();
                }
                else
                {
                    return;
                }

            }
            catch
            {
 
            }
            
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
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

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
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