using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOTU_Window_C
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (MessageBox.Show("这里是AOTU推理游戏的C#(.Net Framework 4.5)分支。\n" +
                "因为是初学C#语言，可能在编程上有颇多不熟练之处，望多多指教。\n" , "AOTU 推理游戏 - C#分支", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                Application.Run(new Form1());
        }
    }
}
