using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpDemo
{
    public partial class UctWheelInfo : UserControl
    {
        private Wheel Wheel { get; set; }


        public UctWheelInfo()
        {
            InitializeComponent();

        }

        public UctWheelInfo(Wheel wheel) : this()
        {
            Wheel = wheel;
            Lbl_WheelNo.Text = wheel.Number +"#";
            Lbl_WheelNo.BackColor = Color.Tomato;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Wheel != null)
            {
                Lbl_State.Text = Wheel.AppChecked == 1 ? "停用中" : "启用中";
                Lbl_State.BackColor = Wheel.AppChecked == 1 ? Color.OrangeRed : Color.LightGreen;
                Lbl_Height.Text = $"当前高度:{Convert.ToDecimal(Wheel.MonitorAppHeight) / 100}mm";
                Lbl_Life.Text = $"剩余寿命:{Convert.ToDecimal(Wheel.MonitorAppLeftTime)}H";
                lblWeight.Text = $"油漆消耗:{Convert.ToDecimal(Wheel.tubuWeight) / 100}Kg";
                //lblUsed.Text = $"油漆消耗:{Wheel.tubuWeight / PublicValue.TotalArea}g/㎡";
                lblUsed.Text = $"油漆消耗:15.3 g/㎡";
            }
        }
    }
}
