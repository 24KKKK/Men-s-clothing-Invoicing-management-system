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

namespace DX男士服装进销存
{
    
    public partial class FormLoginFirst : DevExpress.XtraEditors.XtraForm
    {
        public FormLoginFirst()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt登陸_Click(object sender, EventArgs e)
        {
            if (text登录框.Text=="1"&&text密码框.Text=="1")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lberromessage.Show();
                text登录框.Text = "";
                text密码框.Text = "";
                text登录框.Focus();

            }
        }

        private void text登录框_KeyPress(object sender, KeyPressEventArgs e)
        {
            lberromessage.Hide();

        }

        private void FormLoginFirst_Load(object sender, EventArgs e)
        {

        }

       
    }
}