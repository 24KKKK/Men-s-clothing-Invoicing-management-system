using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;
namespace DX男士服装进销存 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            FormLoginFirst f2 = new FormLoginFirst();
             f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form主窗体());
            }
            else
            {
                return;
            }
          
           
        }
    }
}