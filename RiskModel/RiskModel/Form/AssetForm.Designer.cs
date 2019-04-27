namespace RiskModel
{
    partial class AssetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_m1 = new System.Windows.Forms.TextBox();
            this.textBox_p1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_e1 = new System.Windows.Forms.TextBox();
            this.textBox_e2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_p2 = new System.Windows.Forms.TextBox();
            this.textBox_m2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_e3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_p3 = new System.Windows.Forms.TextBox();
            this.textBox_m3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_e4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_p4 = new System.Windows.Forms.TextBox();
            this.textBox_m4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_Er = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_Dr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_AssetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "%假定投资者已经测算了在该投资期限内的收益的概率分布，任何投资资产的预期收益率等于\r\n概率的加权(各个收益率*对应概率的乘积之和),以下只是列出几个，也可以是一个" +
    "标准分布\r\n\r\n\r\n期望收益率 E(r) = p1*r1 + p2*r2 + p3*r3 + .....\r\n收益率的标准差(各个可能的收益率分布相对于期望收益率" +
    "的分布的集中程度)D(r)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "收益1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "概率";
            // 
            // textBox_m1
            // 
            this.textBox_m1.Location = new System.Drawing.Point(106, 11);
            this.textBox_m1.Name = "textBox_m1";
            this.textBox_m1.Size = new System.Drawing.Size(100, 28);
            this.textBox_m1.TabIndex = 3;
            this.textBox_m1.TextChanged += new System.EventHandler(this.textBox_m1_TextChanged);
            // 
            // textBox_p1
            // 
            this.textBox_p1.Location = new System.Drawing.Point(288, 13);
            this.textBox_p1.Name = "textBox_p1";
            this.textBox_p1.Size = new System.Drawing.Size(100, 28);
            this.textBox_p1.TabIndex = 4;
            this.textBox_p1.TextChanged += new System.EventHandler(this.textBox_p1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "=";
            // 
            // textBox_e1
            // 
            this.textBox_e1.Location = new System.Drawing.Point(417, 12);
            this.textBox_e1.Name = "textBox_e1";
            this.textBox_e1.Size = new System.Drawing.Size(100, 28);
            this.textBox_e1.TabIndex = 7;
            // 
            // textBox_e2
            // 
            this.textBox_e2.Location = new System.Drawing.Point(417, 63);
            this.textBox_e2.Name = "textBox_e2";
            this.textBox_e2.Size = new System.Drawing.Size(100, 28);
            this.textBox_e2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "*";
            // 
            // textBox_p2
            // 
            this.textBox_p2.Location = new System.Drawing.Point(288, 64);
            this.textBox_p2.Name = "textBox_p2";
            this.textBox_p2.Size = new System.Drawing.Size(100, 28);
            this.textBox_p2.TabIndex = 11;
            this.textBox_p2.TextChanged += new System.EventHandler(this.textBox_p2_TextChanged);
            // 
            // textBox_m2
            // 
            this.textBox_m2.Location = new System.Drawing.Point(106, 62);
            this.textBox_m2.Name = "textBox_m2";
            this.textBox_m2.Size = new System.Drawing.Size(100, 28);
            this.textBox_m2.TabIndex = 10;
            this.textBox_m2.TextChanged += new System.EventHandler(this.textBox_m2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "概率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "收益2:";
            // 
            // textBox_e3
            // 
            this.textBox_e3.Location = new System.Drawing.Point(417, 121);
            this.textBox_e3.Name = "textBox_e3";
            this.textBox_e3.Size = new System.Drawing.Size(100, 28);
            this.textBox_e3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "*";
            // 
            // textBox_p3
            // 
            this.textBox_p3.Location = new System.Drawing.Point(288, 122);
            this.textBox_p3.Name = "textBox_p3";
            this.textBox_p3.Size = new System.Drawing.Size(100, 28);
            this.textBox_p3.TabIndex = 18;
            this.textBox_p3.TextChanged += new System.EventHandler(this.textBox_p3_TextChanged);
            // 
            // textBox_m3
            // 
            this.textBox_m3.Location = new System.Drawing.Point(106, 120);
            this.textBox_m3.Name = "textBox_m3";
            this.textBox_m3.Size = new System.Drawing.Size(100, 28);
            this.textBox_m3.TabIndex = 17;
            this.textBox_m3.TextChanged += new System.EventHandler(this.textBox_m3_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "概率";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "收益3:";
            // 
            // textBox_e4
            // 
            this.textBox_e4.Location = new System.Drawing.Point(417, 174);
            this.textBox_e4.Name = "textBox_e4";
            this.textBox_e4.Size = new System.Drawing.Size(100, 28);
            this.textBox_e4.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 18);
            this.label14.TabIndex = 27;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 18);
            this.label15.TabIndex = 26;
            this.label15.Text = "*";
            // 
            // textBox_p4
            // 
            this.textBox_p4.Location = new System.Drawing.Point(288, 175);
            this.textBox_p4.Name = "textBox_p4";
            this.textBox_p4.Size = new System.Drawing.Size(100, 28);
            this.textBox_p4.TabIndex = 25;
            this.textBox_p4.TextChanged += new System.EventHandler(this.textBox_p4_TextChanged);
            // 
            // textBox_m4
            // 
            this.textBox_m4.Location = new System.Drawing.Point(106, 173);
            this.textBox_m4.Name = "textBox_m4";
            this.textBox_m4.Size = new System.Drawing.Size(100, 28);
            this.textBox_m4.TabIndex = 24;
            this.textBox_m4.TextChanged += new System.EventHandler(this.textBox_m4_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(238, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = "概率";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 18);
            this.label17.TabIndex = 22;
            this.label17.Text = "收益4:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 18);
            this.label18.TabIndex = 29;
            this.label18.Text = ".....";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(437, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 18);
            this.label19.TabIndex = 30;
            this.label19.Text = "+";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(437, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 18);
            this.label20.TabIndex = 31;
            this.label20.Text = "+";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(437, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 18);
            this.label21.TabIndex = 32;
            this.label21.Text = "+";
            // 
            // textBox_Er
            // 
            this.textBox_Er.Location = new System.Drawing.Point(417, 244);
            this.textBox_Er.Name = "textBox_Er";
            this.textBox_Er.Size = new System.Drawing.Size(100, 28);
            this.textBox_Er.TabIndex = 33;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(357, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 18);
            this.label22.TabIndex = 34;
            this.label22.Text = "E(r)=";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(539, 249);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 18);
            this.label23.TabIndex = 36;
            this.label23.Text = "D(r)=";
            // 
            // textBox_Dr
            // 
            this.textBox_Dr.Location = new System.Drawing.Point(599, 244);
            this.textBox_Dr.Name = "textBox_Dr";
            this.textBox_Dr.Size = new System.Drawing.Size(100, 28);
            this.textBox_Dr.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 47);
            this.button1.TabIndex = 37;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(135, 249);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 18);
            this.label24.TabIndex = 39;
            this.label24.Text = "资产名=";
            // 
            // textBox_AssetName
            // 
            this.textBox_AssetName.Location = new System.Drawing.Point(223, 244);
            this.textBox_AssetName.Name = "textBox_AssetName";
            this.textBox_AssetName.Size = new System.Drawing.Size(100, 28);
            this.textBox_AssetName.TabIndex = 38;
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 509);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textBox_AssetName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox_Dr);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox_Er);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_e4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_p4);
            this.Controls.Add(this.textBox_m4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_e3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_p3);
            this.Controls.Add(this.textBox_m3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_e2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_p2);
            this.Controls.Add(this.textBox_m2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_e1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_p1);
            this.Controls.Add(this.textBox_m1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssetForm";
            this.Text = "资产收益率的概率估算(数学期望收益)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_m1;
        private System.Windows.Forms.TextBox textBox_p1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_e1;
        private System.Windows.Forms.TextBox textBox_e2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_p2;
        private System.Windows.Forms.TextBox textBox_m2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_e3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_p3;
        private System.Windows.Forms.TextBox textBox_m3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_e4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_p4;
        private System.Windows.Forms.TextBox textBox_m4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_Er;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_Dr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_AssetName;
    }
}