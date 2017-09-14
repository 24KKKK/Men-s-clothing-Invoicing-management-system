using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Threading;
namespace DX男士服装进销存 
{
    public partial class Form主窗体 : Form
    {
        int i = 1;
        Form前台销售 form = new Form前台销售();
        Form采购货物 form采购货物 = new Form采购货物();
        FormVip管理 formVip管理 = new FormVip管理();
        Form用户管理 formUsermanger = new Form用户管理();
        FormGonghuoShang FGHS = new FormGonghuoShang();
        FormKuCunGuanLi FGCGL = new FormKuCunGuanLi();
        FormKucunTiaoZheng FKCTZ = new FormKucunTiaoZheng();
        FormTuiHuo FTH = new FormTuiHuo();
        /******************构造函数*******************************************/
        public Form主窗体()
        {
            
            InitializeComponent();

        }
        private void Form主窗体_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;     
        }
        private void i退出_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void 版本说明_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form版本 formb = new Form版本();
            formb.ShowDialog();
        }

        private void 关于我们_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormAboutUs forma = new FormAboutUs();
            forma.ShowInTaskbar = false;
            forma.ShowIcon = false;
            forma.ShowDialog();
           
        }

        private void Form主窗体_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timenow.Text = DateTime.Now.Year + "--" + DateTime.Now.Month + "--" + DateTime.Now.Day + "  " + DateTime.Now.Hour + "：" + DateTime.Now.Minute + "：" + DateTime.Now.Second ;
            if (i % 5 == 0)
            {
                this.pictureEditwelcome.Visible = false;
                i += 1;
            }
            else { i +=1;}
            if (i < 10)
            { 
                laber软件运行.Text = "0" + i + "秒"; 
            }
            else
            { 
                laber软件运行.Text = i + "秒";
            }
             
        }
        /*********************************************************************/

        //临时离开
        private void CheckItem临时离开_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int i = 0;
            FormLogin formlogin = new FormLogin();
           a: if (CheckItem临时离开.Checked == true)
            {
                this.主窗体下最大容器.Enabled = false;
            }
            else
            {
               formlogin.ShowDialog();
               if (formlogin.mark)
                {
                    this.主窗体下最大容器.Enabled = true;
                    CheckItem临时离开.Checked = false;
                    formlogin.Close();
                }
                else
                {
                    if (i >= 3)
                    {
                        MessageBox.Show("对不起，您输入的二级密码错误次数大于3次，请重新登录！", "提示");
                        this.Close();
                        return;
 
                    }
                    MessageBox.Show("对不起，您输入的二级密码错误！","提示");
                    CheckItem临时离开.Checked = false;
                    i += 1;
                    goto a;  
                   
                }
            }
        }
        /*********************************************************************/
        //各个窗体的加载
        private void 前台销售Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {  
            this.主窗体下最大容器.Panel2.Text = form.Text;
            form.TopLevel =false; //指定当前窗体为顶级Mdi窗体
            form.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            form.Dock = DockStyle.Fill;//让窗体随着panle变化
            form.FormBorderStyle = FormBorderStyle.None;//隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            form.Show();
            form采购货物.Hide();
            formUsermanger.Hide();
            formVip管理.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
            FTH.Hide();
        }

        private void 采购货物Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = form采购货物.Text;
            form采购货物.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            form采购货物.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            form采购货物.Dock = DockStyle.Fill;//让窗体随着panle变化
            form采购货物.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            form采购货物.Show();
            form.Hide();
            formUsermanger.Hide();
            formVip管理.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
            FTH.Hide();

        }

        private void VIP管理Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = formVip管理.Text;
            formVip管理.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            formVip管理.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            formVip管理.Dock = DockStyle.Fill;//让窗体随着panle变化
            formVip管理.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            formVip管理.Show();
            form采购货物.Hide();
            formUsermanger.Hide();
            form.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
            FTH.Hide();
            

        }

        private void Item用户设置_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = formUsermanger.Text;
            formUsermanger.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            formUsermanger.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            formUsermanger.Dock = DockStyle.Fill;//让窗体随着panle变化
            formUsermanger.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            formUsermanger.Show();
            form采购货物.Hide();
            formVip管理.Hide();
            form.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
            FTH.Hide();
        }

        private void Item供货商_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = FGHS.Text;
            FGHS.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            FGHS.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            FGHS.Dock = DockStyle.Fill;//让窗体随着panle变化
            FGHS.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            FGHS.Show();
            formUsermanger.Hide();
            form采购货物.Hide();
            formVip管理.Hide();
            form.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
            FTH.Hide();
        }

        private void 库存盘点Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = FGCGL.Text;
            FGCGL.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            FGCGL.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            FGCGL.Dock = DockStyle.Fill;//让窗体随着panle变化
            FGCGL.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            FGCGL.Show();
            formUsermanger.Hide();
            form采购货物.Hide();
            formVip管理.Hide();
            form.Hide();
            FGHS.Hide();
            FKCTZ.Hide();
            FTH.Hide();
        }

        private void 库存调整Item_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = FKCTZ.Text;
            FKCTZ.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            FKCTZ.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            FKCTZ.Dock = DockStyle.Fill;//让窗体随着panle变化
            FKCTZ.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            FKCTZ.Show();
            formUsermanger.Hide();
            form采购货物.Hide();
            formVip管理.Hide();
            form.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FTH.Hide();
        }

        private void Item退货管理_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.主窗体下最大容器.Panel2.Text = FTH.Text;
            FTH.TopLevel = false; //指定当前窗体为顶级Mdi窗体
            FTH.Parent = this.主窗体下最大容器.Panel2;//指定子窗体的父容器为
            FTH.Dock = DockStyle.Fill;//让窗体随着panle变化
            FTH.FormBorderStyle = FormBorderStyle.None; //隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            FTH.Show();
            formUsermanger.Hide();
            form采购货物.Hide();
            formVip管理.Hide();
            form.Hide();
            FGHS.Hide();
            FGCGL.Hide();
            FKCTZ.Hide();
        }

       
      

    }
}