using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskModel
{
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
        }

        private double StrConvertDouble(string str)
        {
            double d = 0.00;
            double.TryParse(str, out d);
            return d;
        }

        public AssetInfo IResult
        {
            get;
            set;
        }

        private void CalAll()
        {
            this.textBox_e1.Text = (StrConvertDouble(this.textBox_m1.Text) * StrConvertDouble(this.textBox_p1.Text)).ToString();
            this.textBox_e2.Text = (StrConvertDouble(this.textBox_m2.Text) * StrConvertDouble(this.textBox_p2.Text)).ToString();

            this.textBox_e3.Text = (StrConvertDouble(this.textBox_m3.Text) * StrConvertDouble(this.textBox_p3.Text)).ToString();
            this.textBox_e4.Text = (StrConvertDouble(this.textBox_m4.Text) * StrConvertDouble(this.textBox_p4.Text)).ToString();

            this.textBox_Er.Text = (StrConvertDouble(this.textBox_e1.Text) + StrConvertDouble(this.textBox_e2.Text) +
                StrConvertDouble(this.textBox_e3.Text) + StrConvertDouble(this.textBox_e4.Text) ).ToString();


            double variance = 0;

            if(this.textBox_m1.Text != "" && this.textBox_p1.Text != "" && this.textBox_e1.Text !="")
            {
                variance += Math.Pow(StrConvertDouble(this.textBox_e1.Text) - StrConvertDouble(this.textBox_Er.Text), 2);
            }

            if (this.textBox_m2.Text != "" && this.textBox_p2.Text != "" && this.textBox_e2.Text != "")
            {
                variance += Math.Pow(StrConvertDouble(this.textBox_e2.Text) - StrConvertDouble(this.textBox_Er.Text), 2);
            }

            if (this.textBox_m3.Text != "" && this.textBox_p3.Text != "" && this.textBox_e3.Text != "")
            {
                variance += Math.Pow(StrConvertDouble(this.textBox_e3.Text) - StrConvertDouble(this.textBox_Er.Text), 2);
            }

            if (this.textBox_m4.Text != "" && this.textBox_p4.Text != "" && this.textBox_e4.Text != "")
            {
                variance += Math.Pow(StrConvertDouble(this.textBox_e4.Text) - StrConvertDouble(this.textBox_Er.Text), 2);
            }

            double sd = Math.Pow(variance, 0.5);//求标准差

            this.textBox_Dr.Text = sd.ToString();
        }


        private void textBox_m1_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_m2_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_p1_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_p2_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_m3_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_m4_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_p3_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void textBox_p4_TextChanged(object sender, EventArgs e)
        {
            CalAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssetInfo info = new AssetInfo()
            {
                AssetName = this.textBox_AssetName.Text,
                Er = StrConvertDouble(this.textBox_Er.Text),
                SD = StrConvertDouble(this.textBox_Dr.Text)
            };

            this.IResult = info;

            this.Close();
        }
    }
}
