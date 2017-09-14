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
 //初始化工作
    public partial class Form采购货物 : DevExpress.XtraEditors.XtraForm
    {
        DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public Form采购货物()
        {
            InitializeComponent();
        }
        private void Form采购货物_Load(object sender, EventArgs e)
        {
            bt修改.Enabled = false;
            bt删除.Enabled = false;
            bt清空.Enabled = false;
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_Supplier”中。您可以根据需要移动或删除它。
            this.table_SupplierTableAdapter.Fill(this.dBCLDataSet.Table_Supplier);
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_GoodsIn”中。您可以根据需要移动或删除它。
            this.table_GoodsInTableAdapter.Fill(this.dBCLDataSet.Table_GoodsIn);

        }
   //****************************************************************************************
        //准备工作
        private void text商品编号_Enter(object sender, EventArgs e)
        {
            if (this.text商品编号.Text == "")
            {
                text商品编号.Text = IDshengcheng.GoodsIDS();
            }
        }

        private void text进货单号框_Enter(object sender, EventArgs e)
        {
            if (text进货单号框.Text == "")
            {
                text进货单号框.Text = IDshengcheng.JinhuoDan();
            }
        }
        private void Panduan()
        {
            if (text供货商名称.Text != "" || Text计量单位框.Text != "" || text进货日期.Text != "")
            {
                bt清空.Enabled = true;
            }
            if (bt删除.Enabled == true || bt修改.Enabled == true)
            {
                bt清空.Enabled = false;
            }
        }

        
        private void clear()
        {
            text应付金额框.Text = "";
            text销售单价框.Text = "";
            text所属仓库.Text = "";
            text实付金额.Text = "";
            text商品颜色.Text = "";
            text商品品牌.Text = "";
            text商品名称框.Text = "";
            text商品类别.Text = "";
            text商品尺码.Text = "";
            text商品编号.Text = "";
            text进货数量.Text = "";
            text进货日期.Text = "";
            Text进货单价框.Text = "";
            text进货单号框.Text = "";
            text季节.Text = "";
            Text计量单位框.Text = "";
            text供货商名称.Text = "";
        }
        private bool ISNotNULL()
        {
            if (text商品编号.Text == "")
            {
                MessageBox.Show("请输入商品编号","提示");
                return false ;
            }
            
                else if( text销售单价框.Text == "")
            {
                MessageBox.Show("请输入销售单价", "提示");
                    return false ;
            }
                else if(text所属仓库.Text =="")
            {
                MessageBox.Show("请输入所属仓库", "提示");
                    return false ;
            }
                else if( text实付金额.Text == "")
            {
                MessageBox.Show("请输入实付金额", "提示");
                    return false ;
            }
                else if(  text商品颜色.Text == "")
            {
                MessageBox.Show("请输入商品颜色", "提示");
                    return false ;
            }
                else if(text商品品牌.Text == "")
            {
                MessageBox.Show("请输入商品品牌", "提示");
                    return false ;
            }
                 else if(text商品名称框.Text == "")
            {
                MessageBox.Show("请输入商品名称", "提示");
                    return false ;
            }
                   else if(text商品类别.Text == "")
            {
                MessageBox.Show("请输入商品类别", "提示");
                    return false ;
            }
                 else if(text商品尺码 .Text == "")
            {
                MessageBox.Show("请输入商品尺码", "提示");
                    return false ;
            }
            else if (text进货数量.Text == "")
            {
                MessageBox.Show("请输入商品数量", "提示");
                return false;

            }
          
            else if (Text进货单价框.Text == "")
            {
                MessageBox.Show("请输入商品单价", "提示");
                return false;
            }
            else if (Text计量单位框.Text == "")
            {
                MessageBox.Show("请输入商品计量单位", "提示");
                return false;
            }
         
            else
            {
                return true;
            }
            
        }
  //*****************************************************************************************
  //事件
        private void bt添加_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISNotNULL())
                {
                    Table_GoodsIn tgoodsin = new Table_GoodsIn();//商品
                    Table_Stor tsr = new Table_Stor();//库存
                    //商品信息
                    tgoodsin.CompanyName = text供货商名称.Text;
                    tgoodsin.Flage = true;
                    tgoodsin.GoodsColor = text商品颜色.Text;
                    tgoodsin.GoodsID = text商品编号.Text;
                    tgoodsin.GoodsInDateTime = DateTime.Parse(text进货日期.Text);
                    tgoodsin.GoodsInPrice = decimal.Parse(Text进货单价框.Text);
                    tgoodsin.GoodsLeibie = text商品类别.Text;
                    tgoodsin.GoodsName = text商品名称框.Text;
                    tgoodsin.GoodsNum = Int32.Parse(text进货数量.Text);
                    tgoodsin.GoodsPinpai = text商品品牌.Text;
                    tgoodsin.GoodsRealPay = decimal.Parse(text实付金额.Text);
                    tgoodsin.GoodsRemark = memoEdit备注.Text;
                    tgoodsin.GoodsSellPrice = decimal.Parse(text销售单价框.Text);
                    tgoodsin.GoodsShouldJijie = text季节.Text;
                    tgoodsin.GoodsShouldPay = decimal.Parse(text应付金额框.Text);
                    tgoodsin.GoodsSize = text商品尺码.Text;
                    tgoodsin.GoodsUnit = Text计量单位框.Text;
                    tgoodsin.ID = text进货单号框.Text;
                    tgoodsin.StroName = text所属仓库.Text;
                    db.Table_GoodsIn.Add(tgoodsin);
                    
                    /************************************************************************************/
                    //库存
                    tsr.CompanyName = text供货商名称.Text;
                    tsr.GoodsID = text商品编号.Text;
                    tsr.KcDataTime = DateTime.Parse(text进货日期.Text);
                    tsr.KcGoodsName = text商品名称框.Text;
                    tsr.KcGoodsPrice = decimal.Parse(Text进货单价框.Text);
                    tsr.KcGoodsSellPrice = decimal.Parse(text销售单价框.Text);
                    tsr.KcID =Shar.IDshengcheng.StorID(text所属仓库.Text);
                    tsr.KcJingGaoNumber = 100;
                    tsr.KcName = text所属仓库.Text;
                    tsr.KcNumber = Int32.Parse(text进货数量.Text);
                    tsr.KcRemark = "";
                    tsr.KcUnit = Text计量单位框.Text;
                    db.Table_Stor.Add(tsr);
                    /************************************************************************************/
                    db.SaveChanges();
                    MessageBox.Show("商品信息录入成功！", "提示");
                    text商品编号.Text ="";
                    text进货单号框.Text = "";
                    fillToolStripButton_Click(sender, e);
                    bt修改.Enabled = false;
                    bt删除.Enabled = false;
                    Panduan();
                }
            }
            catch
            {
                MessageBox.Show("信息录入失败！");
            }    
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)//刷新列表
        {
            try
            {
                this.table_GoodsInTableAdapter.Fill(this.dBCLDataSet.Table_GoodsIn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bt修改_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var resluts = db.Table_GoodsIn.Find(dr["GoodsID"].ToString());
                var storchange = db.Table_Stor.Find(dr["GoodsID"].ToString());
                resluts.CompanyName = text供货商名称.Text;
                resluts.Flage = true;
                resluts.GoodsColor = text商品颜色.Text;
                resluts.GoodsID = text商品编号.Text;
                resluts.GoodsInDateTime = DateTime.Parse(text进货日期.Text);
                resluts.GoodsInPrice = decimal.Parse(Text进货单价框.Text);
                resluts.GoodsLeibie = text商品类别.Text;
                resluts.GoodsName = text商品名称框.Text;
                resluts.GoodsNum = Int16.Parse(text进货数量.Text);
                resluts.GoodsPinpai = text商品品牌.Text;
                resluts.GoodsRealPay = decimal.Parse(text实付金额.Text);
                resluts.GoodsRemark = memoEdit备注.Text;
                resluts.GoodsSellPrice = decimal.Parse(text销售单价框.Text);
                resluts.GoodsShouldJijie = text季节.Text;
                resluts.GoodsShouldPay = decimal.Parse(text应付金额框.Text);
                resluts.GoodsSize = text商品尺码.Text;
                resluts.GoodsUnit = Text计量单位框.Text;
                resluts.ID = text进货单号框.Text;
                resluts.StroName = text所属仓库.Text;
            //*********************************************************************************
            //仓库
                storchange.CompanyName = text供货商名称.Text;
                storchange.GoodsID = text商品编号.Text;
                storchange.KcDataTime = DateTime.Parse(text进货日期.Text);
                storchange.KcGoodsName = text商品名称框.Text;
                storchange.KcGoodsPrice = decimal.Parse(Text进货单价框.Text);
                storchange.KcGoodsSellPrice = decimal.Parse(text销售单价框.Text);
                storchange.KcID = Shar.IDshengcheng.StorID(text所属仓库.Text);
                storchange.KcJingGaoNumber = 100;
                storchange.KcName = text所属仓库.Text;
                storchange.KcNumber = Int32.Parse(text进货数量.Text);
                storchange.KcRemark = "";
                storchange.KcUnit = Text计量单位框.Text;
                db.SaveChanges();
                MessageBox.Show("信息修改成功");
                dr.EndEdit();
                fillToolStripButton_Click(sender, e);
                bt添加.Enabled = true;
                text进货单号框.ReadOnly = false;
                text商品编号.ReadOnly = false ;
                clear();
                bt修改.Enabled = false;
                bt删除.Enabled = false;
                Panduan();
            }
            catch(Exception  ex)
            {
                MessageBox.Show("对不起，你修改的数据有误，导致修改失败！\n"+ex.Message);
                memoEdit备注.Text = ex.Message;
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
                    Table_GoodsIn deleteneirong = db.Table_GoodsIn.Find(dr["GoodsID"].ToString());
                    Table_Stor deletestor = db.Table_Stor.Find(dr["GoodsID"].ToString());
                    db.Table_GoodsIn.Remove(deleteneirong);
                    db.Table_Stor.Remove(deletestor);
                    db.SaveChanges();
                    fillToolStripButton_Click(sender, e);
                    MessageBox.Show("删除成功!");
                    bt添加.Enabled = true;
                    bt修改.Enabled = false;
                    bt删除.Enabled = false;
                    text进货单号框.ReadOnly = false;
                    text商品编号.ReadOnly = false;
                    dr.EndEdit();
                    bt修改.Enabled = false;
                    bt删除.Enabled = false;
                    Panduan();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除失败！\n" + ex.Message);
                
            }
           
        }

        private void bt清空_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            bt删除.Enabled = true;
            bt添加.Enabled = false;
            bt修改.Enabled = true;
            text进货单号框.ReadOnly = true;
            text商品编号.ReadOnly = true;
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                text应付金额框.Text = dr["GoodsShouldPay"].ToString();
                text销售单价框.Text = dr["GoodsSellPrice"].ToString();
                text所属仓库.Text = dr["StroName"].ToString();
                text实付金额.Text = dr["GoodsRealPay"].ToString();
                text商品颜色.Text = dr["GoodsColor"].ToString();
                text商品品牌.Text = dr["GoodsPinpai"].ToString();
                text商品名称框.Text = dr["GoodsName"].ToString();
                text商品类别.Text = dr["GoodsLeibie"].ToString();
                text商品尺码.Text = dr["GoodsSize"].ToString();
                text商品编号.Text = dr["GoodsID"].ToString();
                text进货数量.Text = dr["GoodsNum"].ToString();
                text进货日期.Text = dr["GoodsInDateTime"].ToString();
                Text进货单价框.Text = dr["GoodsInPrice"].ToString();
                text进货单号框.Text = dr["ID"].ToString();
                text季节.Text = dr["GoodsShouldJijie"].ToString();
                Text计量单位框.Text = dr["GoodsUnit"].ToString();
                text供货商名称.Text = dr["CompanyName"].ToString();
                memoEdit备注.Text = dr["GoodsRemark"].ToString();
                Panduan();

            }
            catch
            {
            }
        }

        private void Text进货单价框_TextChanged(object sender, EventArgs e)
        {
           text应付金额框.Text =Caculater.Jisuan(text进货数量.Text ,Text进货单价框.Text).ToString ();
        }

        private void text进货数量_TextChanged(object sender, EventArgs e)
        {
            text应付金额框.Text = Caculater.Jisuan(text进货数量.Text, Text进货单价框.Text).ToString();
        }

       

    }
}