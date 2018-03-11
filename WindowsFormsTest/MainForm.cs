using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开FX PLC测试窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butTestFX_Click(object sender, EventArgs e)
        {
            Forms.FormTestFX f = new Forms.FormTestFX();
            f.ShowDialog();
        }
    }
}
