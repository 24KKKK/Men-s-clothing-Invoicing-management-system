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
    
    public partial class Form用户管理 : DevExpress.XtraEditors.XtraForm
    {

         DX_男士服装进销存数据库Context db = new DX_男士服装进销存数据库Context();

        
        public Form用户管理()
        {
            InitializeComponent();

        }

        private void Form用户管理_Load(object sender, EventArgs e)
        {
            bt修改.Enabled = false;
            bt删除.Enabled = false;
        }

        private void textEdit确认登录密码框_Leave(object sender, EventArgs e)
        {
            if (textEdit登录密码框.Text != textEdit确认登录密码框.Text)
            {
                lbShowError.Text = "两次密码输入不一致，请重新输入";
                textEdit登录密码框.Focus();
                textEdit登录密码框.Text = "";
                textEdit确认登录密码框.Text = "";
                return;
            }
        }

        private void textEdit登录密码框_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbShowError.Text = "               ";
        }

        private void textEdit确认二级密码框_Leave(object sender, EventArgs e)
        {
            if (textEdit二级密码框.Text != textEdit确认二级密码框.Text)
            {
                lbShowError.Text = "两次二级密码输入不一致，请重新输入";
                textEdit二级密码框.Focus();
                textEdit确认二级密码框.Text = "";
                textEdit二级密码框.Text = "";
                return;

            }
        }

        private void textEdit二级密码框_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbShowError.Text = "   ";
        }
        private void bt保存_Click(object sender, EventArgs e)
        {
            Table_UserMessage user = new Table_UserMessage();
            //*******************************************************
            //添加信息
            bool ISuesd = true;
            if (check启用.Checked == false)
            {
                ISuesd = false;
            }
            try 
            {
                user.Table_UserMessage1.Address = textEdit用户住址框.Text;
                user.Table_UserMessage1.IsCanuse = ISuesd;
                user.Table_UserMessage1.ID = Shar.Time.Get_rili();
                user.Table_UserMessage1.Level = text用户等级框.Text;
                user.Table_UserMessage1.LoginName = textEdit用户登录名框.Text;
                user.Table_UserMessage1.LoginPassWord = textEdit登录密码框.Text;
                user.Table_UserMessage1.LoginPassWord2 = textEdit二级密码框.Text;
                user.Table_UserMessage1.PhoneNumber = textEdit用户电话框.Text;
                user.Table_UserMessage1.RealName = textEdit用户真实姓名框.Text;
                user.Table_UserMessage1.ReMark = memoEdit备注.Text;
                db.Table_UserMessage.Add(user.Table_UserMessage1);
                db.SaveChanges();
                text用户等级框.Text = "";
                textEdit用户登录名框.Text = "";
                textEdit登录密码框.Text = "";
                textEdit二级密码框.Text="";
                textEdit用户真实姓名框.Text = "";
                memoEdit备注.Text = "";
                textEdit确认登录密码框.Text = "";
                textEdit确认二级密码框.Text = "";


            }
            
            //*******************************************************
            catch(Exception ex)
            {
                MessageBox.Show("对不起，由于您的操作错误导致数据库录入失败！"   , "踏雪温馨提示");
                memoEdit备注.Text = ex.Message;
                return;
            }

             MessageBox.Show("管理员数据录入成功！\n", "踏雪温馨提示");
        }
    }
     
}