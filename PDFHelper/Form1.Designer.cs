namespace PDFHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.img_show = new System.Windows.Forms.PictureBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radio_pic = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_text = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ShowText = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_outputFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prgbar_print = new System.Windows.Forms.ProgressBar();
            this.btn_ChoiceFolder = new System.Windows.Forms.Button();
            this.txt_inputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_show)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_run
            // 
            this.Btn_run.Location = new System.Drawing.Point(558, 19);
            this.Btn_run.Name = "Btn_run";
            this.Btn_run.Size = new System.Drawing.Size(75, 51);
            this.Btn_run.TabIndex = 0;
            this.Btn_run.Text = "运行";
            this.Btn_run.UseVisualStyleBackColor = true;
            this.Btn_run.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_outputFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prgbar_print);
            this.groupBox1.Controls.Add(this.btn_ChoiceFolder);
            this.groupBox1.Controls.Add(this.txt_inputFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_run);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(492, 89);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(41, 25);
            this.btn_open.TabIndex = 16;
            this.btn_open.Text = "...";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_size);
            this.groupBox2.Controls.Add(this.img_show);
            this.groupBox2.Controls.Add(this.btn_img);
            this.groupBox2.Controls.Add(this.txt_img);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.radio_pic);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_jd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radio_text);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_ShowText);
            this.groupBox2.Controls.Add(this.txt_y);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_x);
            this.groupBox2.Location = new System.Drawing.Point(27, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 253);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水印设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(4, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "字体大小";
            // 
            // txt_size
            // 
            this.txt_size.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_size.ForeColor = System.Drawing.Color.Red;
            this.txt_size.Location = new System.Drawing.Point(96, 99);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(169, 23);
            this.txt_size.TabIndex = 20;
            this.txt_size.Text = "80";
            // 
            // img_show
            // 
            this.img_show.Location = new System.Drawing.Point(454, 20);
            this.img_show.Name = "img_show";
            this.img_show.Size = new System.Drawing.Size(146, 71);
            this.img_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_show.TabIndex = 18;
            this.img_show.TabStop = false;
            // 
            // btn_img
            // 
            this.btn_img.Location = new System.Drawing.Point(367, 139);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(41, 25);
            this.btn_img.TabIndex = 17;
            this.btn_img.Text = "...";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // txt_img
            // 
            this.txt_img.Enabled = false;
            this.txt_img.Location = new System.Drawing.Point(96, 142);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(261, 20);
            this.txt_img.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "水印图片";
            // 
            // radio_pic
            // 
            this.radio_pic.AutoSize = true;
            this.radio_pic.Location = new System.Drawing.Point(135, 20);
            this.radio_pic.Name = "radio_pic";
            this.radio_pic.Size = new System.Drawing.Size(73, 17);
            this.radio_pic.TabIndex = 1;
            this.radio_pic.Text = "图片水印";
            this.radio_pic.UseVisualStyleBackColor = true;
            this.radio_pic.CheckedChanged += new System.EventHandler(this.radio_pic_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(380, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "相对居中位置，x,y,角度";
            // 
            // txt_jd
            // 
            this.txt_jd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_jd.Location = new System.Drawing.Point(275, 193);
            this.txt_jd.Name = "txt_jd";
            this.txt_jd.Size = new System.Drawing.Size(82, 23);
            this.txt_jd.TabIndex = 12;
            this.txt_jd.Text = "-54";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(271, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "红色字体";
            // 
            // radio_text
            // 
            this.radio_text.AutoSize = true;
            this.radio_text.Checked = true;
            this.radio_text.Location = new System.Drawing.Point(25, 20);
            this.radio_text.Name = "radio_text";
            this.radio_text.Size = new System.Drawing.Size(73, 17);
            this.radio_text.TabIndex = 0;
            this.radio_text.TabStop = true;
            this.radio_text.Text = "文字水印";
            this.radio_text.UseVisualStyleBackColor = true;
            this.radio_text.CheckedChanged += new System.EventHandler(this.radio_text_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "水印文本";
            // 
            // txt_ShowText
            // 
            this.txt_ShowText.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ShowText.ForeColor = System.Drawing.Color.Red;
            this.txt_ShowText.Location = new System.Drawing.Point(96, 59);
            this.txt_ShowText.Name = "txt_ShowText";
            this.txt_ShowText.Size = new System.Drawing.Size(169, 23);
            this.txt_ShowText.TabIndex = 5;
            this.txt_ShowText.Text = "ZN SHINE CONFIDENTIAL";
            // 
            // txt_y
            // 
            this.txt_y.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_y.Location = new System.Drawing.Point(187, 193);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(82, 23);
            this.txt_y.TabIndex = 8;
            this.txt_y.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "水印位置";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_x.Location = new System.Drawing.Point(99, 193);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(82, 23);
            this.txt_x.TabIndex = 7;
            this.txt_x.Text = "0";
            // 
            // txt_outputFolder
            // 
            this.txt_outputFolder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_outputFolder.Location = new System.Drawing.Point(114, 89);
            this.txt_outputFolder.Name = "txt_outputFolder";
            this.txt_outputFolder.Size = new System.Drawing.Size(372, 23);
            this.txt_outputFolder.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "输出目录";
            // 
            // prgbar_print
            // 
            this.prgbar_print.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgbar_print.Location = new System.Drawing.Point(3, 393);
            this.prgbar_print.Name = "prgbar_print";
            this.prgbar_print.Size = new System.Drawing.Size(647, 25);
            this.prgbar_print.TabIndex = 9;
            // 
            // btn_ChoiceFolder
            // 
            this.btn_ChoiceFolder.Location = new System.Drawing.Point(492, 35);
            this.btn_ChoiceFolder.Name = "btn_ChoiceFolder";
            this.btn_ChoiceFolder.Size = new System.Drawing.Size(41, 25);
            this.btn_ChoiceFolder.TabIndex = 3;
            this.btn_ChoiceFolder.Text = "...";
            this.btn_ChoiceFolder.UseVisualStyleBackColor = true;
            this.btn_ChoiceFolder.Click += new System.EventHandler(this.btn_ChoiceFolder_Click);
            // 
            // txt_inputFolder
            // 
            this.txt_inputFolder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_inputFolder.Location = new System.Drawing.Point(114, 37);
            this.txt_inputFolder.Name = "txt_inputFolder";
            this.txt_inputFolder.Size = new System.Drawing.Size(372, 23);
            this.txt_inputFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件目录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 421);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF 设置水印";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChoiceFolder;
        private System.Windows.Forms.TextBox txt_inputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_outputFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar prgbar_print;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ShowText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_jd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_pic;
        private System.Windows.Forms.RadioButton radio_text;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox img_show;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_size;
    }
}

