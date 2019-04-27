namespace RiskModel
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.markWoziControl1 = new RiskModel.MarkWoziControl();
            this.kallyControl1 = new RiskModel.KallyControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1309, 549);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.markWoziControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1301, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "马科维茨模型";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.kallyControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1301, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "凯利(几何增长模型)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // markWoziControl1
            // 
            this.markWoziControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markWoziControl1.Location = new System.Drawing.Point(3, 3);
            this.markWoziControl1.Name = "markWoziControl1";
            this.markWoziControl1.Size = new System.Drawing.Size(1295, 511);
            this.markWoziControl1.TabIndex = 0;
            // 
            // kallyControl1
            // 
            this.kallyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kallyControl1.Location = new System.Drawing.Point(3, 3);
            this.kallyControl1.Name = "kallyControl1";
            this.kallyControl1.Size = new System.Drawing.Size(1295, 511);
            this.kallyControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "投资组合理论模型实验室";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MarkWoziControl markWoziControl1;
        private KallyControl kallyControl1;
    }
}

