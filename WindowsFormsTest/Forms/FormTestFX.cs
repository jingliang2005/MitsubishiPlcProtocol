using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using InControls.PLC;
using InControls.PLC.FX;
using InControls.ExamplesPLC;

namespace WindowsFormsTest.Forms
{
    public partial class FormTestFX : Form
    {
        protected SimpleTestFX currPLC { get; set; }
        public FormTestFX()
        {
            InitializeComponent();
            currPLC = new SimpleTestFX();
            

        }

        private void FormTestFX_Load(object sender, EventArgs e)
        {
            //currPLC.plcFX.Test_All();
            //currPLC.Test_ReadAllPoint();
            //currPLC.plcFX.Test_01();
        }

        private void butY00_Click(object sender, EventArgs e)
        {
            currPLC.Y00 = !currPLC.Y00;
        }

        private void butY01_Click(object sender, EventArgs e)
        {
            currPLC.Y01 = !currPLC.Y01;
        }

        private void butY02_Click(object sender, EventArgs e)
        {
            currPLC.Y02 = !currPLC.Y02;
        }

        private void butY03_Click(object sender, EventArgs e)
        {
            currPLC.Y03 = !currPLC.Y03;
        }

        private void butY04_Click(object sender, EventArgs e)
        {
            currPLC.Y04 = !currPLC.Y04;
        }

        private void butY05_Click(object sender, EventArgs e)
        {
            currPLC.Y05 = !currPLC.Y05;
        }

        private void butY06_Click(object sender, EventArgs e)
        {
            currPLC.Y06 = !currPLC.Y06;
        }

        private void butY07_Click(object sender, EventArgs e)
        {
            currPLC.Y07 = !currPLC.Y07;
        }

        private void butM00_Click(object sender, EventArgs e)
        {
            currPLC.M00 = !currPLC.M00;
        }

        private void butM01_Click(object sender, EventArgs e)
        {
            currPLC.M01 = !currPLC.M01;
        }

        private void butM02_Click(object sender, EventArgs e)
        {
            currPLC.M02 = !currPLC.M02;
        }

        private void butM03_Click(object sender, EventArgs e)
        {
            currPLC.M03 = !currPLC.M03;
        }

        private void butM04_Click(object sender, EventArgs e)
        {
            currPLC.M04 = !currPLC.M04;
        }

        private void butM05_Click(object sender, EventArgs e)
        {
            currPLC.M05 = !currPLC.M05;
        }

        private void butM06_Click(object sender, EventArgs e)
        {
            currPLC.M06 = !currPLC.M06;
        }

        private void butM07_Click(object sender, EventArgs e)
        {
            currPLC.M07 = !currPLC.M07;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelX00.BackColor = GetColor(currPLC.X00);
            labelX01.BackColor = GetColor(currPLC.X01);
            labelX02.BackColor = GetColor(currPLC.X02);
            labelX03.BackColor = GetColor(currPLC.X03);
            labelX04.BackColor = GetColor(currPLC.X04);
            labelX05.BackColor = GetColor(currPLC.X05);
            labelX06.BackColor = GetColor(currPLC.X06);
            labelX07.BackColor = GetColor(currPLC.X07);

            butY00.BackColor = GetColor(currPLC.Y00);
            butY01.BackColor = GetColor(currPLC.Y01);
            butY02.BackColor = GetColor(currPLC.Y02);
            butY03.BackColor = GetColor(currPLC.Y03);
            butY04.BackColor = GetColor(currPLC.Y04);
            butY05.BackColor = GetColor(currPLC.Y05);
            butY06.BackColor = GetColor(currPLC.Y06);
            butY07.BackColor = GetColor(currPLC.Y07);

            butM00.BackColor = GetColor(currPLC.M00);
            butM01.BackColor = GetColor(currPLC.M01);
            butM02.BackColor = GetColor(currPLC.M02);
            butM03.BackColor = GetColor(currPLC.M03);
            butM04.BackColor = GetColor(currPLC.M04);
            butM05.BackColor = GetColor(currPLC.M05);
            butM06.BackColor = GetColor(currPLC.M06);
            butM07.BackColor = GetColor(currPLC.M07);

        }

        /// <summary>
        /// 获取BOOL位状态代表的颜色。
        /// </summary>
        /// <param name="on_off"></param>
        /// <returns></returns>
        protected Color GetColor(bool on_off)
        {
            if (on_off)
                return Color.Red;
            else
                return Color.Aqua;//
        }

    }
}
