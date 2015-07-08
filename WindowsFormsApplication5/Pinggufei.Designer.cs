namespace WindowsFormsApplication5
{
    partial class Pinggufei
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFANGDICHAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFANGDICHANSIFA = new System.Windows.Forms.TextBox();
            this.textBoxJSPINGGUE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "房地产评估费";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFANGDICHAN
            // 
            this.textBoxFANGDICHAN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFANGDICHAN.Location = new System.Drawing.Point(210, 133);
            this.textBoxFANGDICHAN.Name = "textBoxFANGDICHAN";
            this.textBoxFANGDICHAN.ReadOnly = true;
            this.textBoxFANGDICHAN.Size = new System.Drawing.Size(503, 29);
            this.textBoxFANGDICHAN.TabIndex = 12;
            this.textBoxFANGDICHAN.TextChanged += new System.EventHandler(this.textBoxFANGDICHAN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "房地产司法评估费";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "评估额";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFANGDICHANSIFA
            // 
            this.textBoxFANGDICHANSIFA.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFANGDICHANSIFA.Location = new System.Drawing.Point(210, 92);
            this.textBoxFANGDICHANSIFA.Name = "textBoxFANGDICHANSIFA";
            this.textBoxFANGDICHANSIFA.ReadOnly = true;
            this.textBoxFANGDICHANSIFA.Size = new System.Drawing.Size(503, 29);
            this.textBoxFANGDICHANSIFA.TabIndex = 9;
            this.textBoxFANGDICHANSIFA.TextChanged += new System.EventHandler(this.textBoxFANGDICHANSIFA_TextChanged);
            // 
            // textBoxJSPINGGUE
            // 
            this.textBoxJSPINGGUE.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxJSPINGGUE.Location = new System.Drawing.Point(210, 45);
            this.textBoxJSPINGGUE.Name = "textBoxJSPINGGUE";
            this.textBoxJSPINGGUE.Size = new System.Drawing.Size(312, 29);
            this.textBoxJSPINGGUE.TabIndex = 8;
            this.textBoxJSPINGGUE.TextChanged += new System.EventHandler(this.textBoxJSPINGGUE_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(545, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication5.Properties.Resources.收费表_SF;
            this.pictureBox1.Location = new System.Drawing.Point(41, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 171);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication5.Properties.Resources.收费表_pg;
            this.pictureBox2.Location = new System.Drawing.Point(406, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 224);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "评估费计算过程示例：比如要计算1300万评估值的抵押评估收费\r\n收费=100万X0.005+900万X0.0025+300万X0.0015=32000元\r\n其中总" +
    "评估额1300万分成三个段，分别为100万，900万，300万\r\n这三个段根据所处的评估收费比例分别计算评估费，然后相加";
            // 
            // Pinggufei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFANGDICHAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFANGDICHANSIFA);
            this.Controls.Add(this.textBoxJSPINGGUE);
            this.Controls.Add(this.button1);
            this.Name = "Pinggufei";
            this.Text = "Pinggufei";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFANGDICHAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFANGDICHANSIFA;
        private System.Windows.Forms.TextBox textBoxJSPINGGUE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}