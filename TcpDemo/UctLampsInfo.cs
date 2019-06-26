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
    public partial class UctLampsInfo : UserControl
    {
        private Lamps Lamps { get; set; }
        public UctLampsInfo()
        {
            InitializeComponent();
        }
        public UctLampsInfo(Lamps lamps) : this()
        {
            Lamps = lamps;
            Lbl_LampsNo.Text = lamps.Name + " 状态";
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Lamps != null)
            {
                labStatus.Text = Lamps.UVPower == 0 ? "停用中" : "启用中";
                labStatus.BackColor = Lamps.UVPower == 0 ? Color.OrangeRed : Color. LightGreen;
                Lbl_Power.Text = $"当前功率:{Convert.ToDecimal(Lamps.UVPower) / 10}Kw";
                Lbl_Life.Text = $"剩余寿命:{Lamps.UVLeftTime}H";
            }
        }
    }
}
