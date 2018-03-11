using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InControls.ExamplesPLC
{
    public class SimpleTestFX
    {
        /// <summary>
        /// FX PLC .
        /// </summary>
        public PLC.FX.Fx_Test plcFX { get; set; }

        public bool[] X00_X16 = new bool[16];
        public bool X00 {get; protected set; }
        public bool X01 {  get; protected set; }
        public bool X02 {  get; protected set; }
        public bool X03 {  get; protected set; }
        public bool X04 {  get; protected set; }
        public bool X05 {  get; protected set; }
        public bool X06 {  get; protected set; }
        public bool X07 {  get; protected set; }

        public bool[] Y00_Y16 = new bool[16];
        public bool Y00
        {
             get
            {
                return Y00_Y16[0];
            }
            set
            {
                plcFX.SetBit("Y00", value);
            }
        }
        public bool Y01
        {
            get
            {
                return Y00_Y16[1];
            }
            set
            {
                plcFX.SetBit("Y01", value);
            }
        }
        public bool Y02
        {
            get
            {
                return Y00_Y16[1];
            }
            set
            {
                plcFX.SetBit("Y02", value);
            }
        }
        public bool Y03
        {
             get
            {
                return Y00_Y16[3];
            }
            set
            {
                plcFX.SetBit("Y03", value);
            }
        }
        public bool Y04
        {
            get
            {
                return Y00_Y16[4];
            }
            set
            {
                plcFX.SetBit("Y04", value);
            }
        }
        public bool Y05
        {
             get
            {
                return Y00_Y16[5];
            }
            set
            {
                plcFX.SetBit("Y05", value);
            }
        }
        public bool Y06
        {
             get
            {
                return Y00_Y16[6];
            }
            set
            {
                plcFX.SetBit("Y06", value);
            }
        }
        public bool Y07
        {
             get
            {
                return Y00_Y16[7];
            }
            set
            {
                plcFX.SetBit("Y07", value);
            }
        }

        public bool[] M00_M16 = new bool[16];
        public bool M00
        {
             get
            {
                return M00_M16[0];
            }
            set
            {
                plcFX.SetBit("M00", value);
            }
        }
        public bool M01
        {
             get
            {
                return M00_M16[1];
            }
            set
            {
                plcFX.SetBit("M01", value);
            }
        }
        public bool M02
        {
            get
            {
                return M00_M16[2];
            }
            set
            {
                plcFX.SetBit("M02", value);
            }
        }
        public bool M03
        {
            get
            {
                return M00_M16[3];
            }
            set
            {
                plcFX.SetBit("M03", value);
            }
        }
        public bool M04
        {
             get
            {
                return M00_M16[4];
            }
            set
            {
                plcFX.SetBit("M04", value);
            }
        }
        public bool M05
        {
             get
            {
                return M00_M16[5];
            }
            set
            {
                plcFX.SetBit("M05", value);
            }
        }
        public bool M06
        {
             get
            {
                return M00_M16[6];
            }
            set
            {
                plcFX.SetBit("M06", value);
            }
        }
        public bool M07
        {
             get
            {
                return M00_M16[7];
            }
            set
            {
                plcFX.SetBit("M07", value);
            }
        }

        /// <summary>
        /// 运行线程，更新数据。
        /// </summary>
        protected Thread RunThread;

        protected bool ThreadRun = true;

        public SimpleTestFX()
        {
            plcFX = new PLC.FX.Fx_Test();
            plcFX.OpenPort();

            RunThread = new Thread(new ThreadStart(RunFor));
            RunThread.IsBackground = true;
            RunThread.Start();
        }

        protected void RunFor()
        {
            while (ThreadRun)
            {
                IntToBool(Y00_Y16, plcFX.ReadBits("Y00"));
                IntToBool(M00_M16, plcFX.ReadBits("M00"));
                IntToBool(X00_X16, plcFX.ReadBits("X00"));
                Thread.Sleep(100);
            }
        }

        public void Exit()
        {
            ThreadRun = false;

            plcFX.ClosePort();
        }
         
        public void IntToBool(bool[] bools,int retu)
        {
            int i = 0;
            while (retu > 0)
            {
                if (retu % 2 == 0)
                    bools[i] = false;
                else
                    bools[i] = true;
                retu = retu / 2;
                i++;
            }
        }
    }
}
