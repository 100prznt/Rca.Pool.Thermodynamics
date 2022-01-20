using Rca.Pool.Thermodynamics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rca.Pool.Thermodynamics_TestBench
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            var calc = new Air(); // (7.5, 237.3);

            if (rb_HumidityAbs.Checked)
            {
                txt_DrewPoint.Text = calc.CalcDewPoint(double.Parse(txt_Temperature.Text), double.Parse(txt_HumidityRel.Text)).ToString();
                txt_HumidityAbs.Text = calc.CalcHumidityAbsByHumidity(double.Parse(txt_Temperature.Text), double.Parse(txt_HumidityRel.Text)).ToString();
            }
            else if (rb_HumidityRel.Checked)
            {
                txt_HumidityRel.Text = calc.CalcHumidityRelByHumidity(double.Parse(txt_Temperature.Text), double.Parse(txt_HumidityAbs.Text)).ToString();
                txt_DrewPoint.Text = calc.CalcDewPoint(double.Parse(txt_Temperature.Text), double.Parse(txt_HumidityRel.Text)).ToString();
            }
        }
    }
}
