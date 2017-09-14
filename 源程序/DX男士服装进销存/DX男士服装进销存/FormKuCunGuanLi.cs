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
  
    public partial class FormKuCunGuanLi : DevExpress.XtraEditors.XtraForm
    {    DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();
        public FormKuCunGuanLi()
        {
            InitializeComponent();
        }

        private void FormKuCunGuanLi_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dBCLDataSet.Table_Stor”中。您可以根据需要移动或删除它。
            this.table_StorTableAdapter.Fill(this.dBCLDataSet.Table_Stor);

        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            text商品编号.Text = dr["GoodsID"].ToString();
            text商品名称.Text = dr["KcGoodsName"].ToString();
        }

        private void bt保存_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                var up = db.Table_Stor.Find(dr["GoodsID"].ToString());
                up.KcNumber += Int32.Parse(Text盘点数量.Text);
                up.KcRemark+= "“DATA:"+DateTime.Today.Date+"//NUMBER:"+Text盘点数量.Text+"”,\n";
                db.SaveChanges();
                MessageBox.Show("更新成功！");
                fillToolStripButton_Click(sender, e);
                Text盘点数量.Text = "";
            }
            catch(Exception  ex)
            {
                MessageBox.Show("更新出错！"+ex.Message );
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