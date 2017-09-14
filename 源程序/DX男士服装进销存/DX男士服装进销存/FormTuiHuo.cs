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
    public partial class FormTuiHuo : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public FormTuiHuo()
        {
            InitializeComponent();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var BaGoods = from u in db.Table_GoodsSell where u.SellID == textBACKDANSHAO.Text select u;
                Table_GoodsBack gb = new Table_GoodsBack();
                gb.GoodsID = textGOODSID.Text;
                gb.ID = text操作员框.Text;
                gb.KcID = BaGoods.Single().KcID;
                gb.SellID = BaGoods.Single().SellID;
                gb.ThGoodsID = textGOODSID.Text;
                gb.ThGoodsName = textGOODSNAME.Text;
                gb.ThGoodsNumber = int.Parse(textBAKNUMBER.Text);
                gb.ThGoodsPrice = BaGoods.Single().SellPrice;
                gb.ThGoodsTime = DateTime.Parse(textBACKDATA.Text);
                gb.ThRealPay = decimal.Parse(TEXTREALPAY.Text);
                gb.ThRemark = textBACKRESONE.Text;
                db.Table_GoodsBack.Add(gb);
                db.SaveChanges();
                MessageBox.Show("退货成功！");
                fillToolStripButton_Click(sender, e);
                clear();
            }
            catch
            {
                MessageBox.Show("出现未知错误！");
                return;
            }
            
            

        }
        private  void  clear()
        {
            textBACKDANSHAO.Text = "";
            textBACKDATA.Text = "";
            textBACKRESONE.Text = "";
            textBAKNUMBER.Text = "";
            textDATA.Text = "";
            textGOODSID.Text = "";
            textGOODSNAME.Text = "";
            TEXTREALPAY.Text = "";
            textSELLPRICE.Text = "";
            text操作员框.Text = "";
            text退货单号框.Text = "";
            Text退货金额框.Text = "";
            text应付金额框.Text = "";

        }

        private void FormTuiHuo_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_GoodsBack”中。您可以根据需要移动或删除它。
            this.table_GoodsBackTableAdapter.Fill(this.dBCLDataSet.Table_GoodsBack);
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_GoodsSell”中。您可以根据需要移动或删除它。
            this.table_GoodsSellTableAdapter.Fill(this.dBCLDataSet.Table_GoodsSell);

        }

        private void textBACKDANSHAO_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var BaGoods = from u in db.Table_GoodsSell where u.SellID == textBACKDANSHAO.Text select u;
                if (BaGoods == null)
                {
                    MessageBox.Show("无结果！");
                    return;
                }
                textGOODSNAME.Text = BaGoods.Single().GoodsName;
                TEXTREALPAY.Text = BaGoods.Single().SellRealPay.ToString();
                text操作员框.Text = BaGoods.Single().ID;
                textGOODSID.Text  = BaGoods.Single().GoodsID;
                text应付金额框.Text = BaGoods.Single().SellShouldPay.ToString();
                textDATA.Text = BaGoods.Single().SellGoodsTime.ToString();
                textSELLPRICE.Text = BaGoods.Single().SellPrice.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text退货单号框_Click(object sender, EventArgs e)
        {
            if (text退货单号框.Text == "")
            { 
                text退货单号框.Text = Shar.IDshengcheng.TuihuoDan();
            }
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_GoodsBackTableAdapter.Fill(this.dBCLDataSet.Table_GoodsBack);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}