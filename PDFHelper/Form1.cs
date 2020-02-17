using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDFHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Directory.Exists(this.txt_inputFolder.Text))
            {
                MessageBox.Show("请选择包含pdf文件的目录", "PDF Helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.txt_ShowText.Text.Trim().Equals("") && this.radio_text.Checked == true)
            {
                MessageBox.Show("水印文字不能为空");
                return;
            }

            if (this.txt_img.Text.Trim().Equals("") && this.radio_pic.Checked == true)
            {
                MessageBox.Show("水印图片不能为空");
                return;
            }

            int parseInt;

            if (!Int32.TryParse(this.txt_x.Text, out parseInt))
            {
                MessageBox.Show("x相对位置不合法。");
                return;
            }

            if (!Int32.TryParse(this.txt_y.Text, out parseInt))
            {
                MessageBox.Show("y相对位置不合法。");
                return;
            }

            if (!Int32.TryParse(this.txt_jd.Text, out parseInt))
            {
                MessageBox.Show("角度不合法。");
                return;
            }

            if (!Int32.TryParse(this.txt_size.Text, out parseInt))
            {
                MessageBox.Show("字体大小不合法。");
                return;
            }

            string[] fileNames = Directory.GetFiles(this.txt_inputFolder.Text, "*.pdf");
            if (fileNames.Length > 0)
            {
                this.prgbar_print.Maximum = fileNames.Length;
                this.prgbar_print.Value = 0;
                this.prgbar_print.Step = 1;
                for (int i = 0; i < fileNames.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(fileNames[i]);

                    if (this.radio_text.Checked == true)
                    {
                        PDFHelper.AddWordWatermark2PDF(fileNames[i], this.txt_outputFolder.Text + "\\" + fileInfo.Name
                        , this.txt_ShowText.Text, Convert.ToInt32(this.txt_x.Text)
                        , Convert.ToInt32(this.txt_y.Text), Convert.ToInt32(this.txt_jd.Text), Convert.ToInt32(this.txt_size.Text));
                    }
                    else if (this.radio_pic.Checked)
                    {
                        PDFHelper.AddImageWatermarkPDF(fileNames[i], this.txt_outputFolder.Text + "\\" + fileInfo.Name, this.txt_img.Text, Convert.ToInt32(this.txt_x.Text)
                        , Convert.ToInt32(this.txt_y.Text), Convert.ToInt32(this.txt_jd.Text));
                    }
                    

                    this.prgbar_print.Value = this.prgbar_print.Value + this.prgbar_print.Step;
                }
            }
            //PDFHelper.AddImageWatermarkPDF(path, "D://my.pdf", Server.MapPath("/HtmlToPdf/Tools/sy.bmp"), 0, 0);
            //string temp = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
            //Guid guid = new Guid();
            //guid = Guid.NewGuid();

            //string tempGUID = guid.ToString();
            //File.Copy("C:\\Users\\lori_\\Desktop\\1.pdf", "C:\\Users\\lori_\\Desktop\\123.pdf", true);
            //PDFHelper.AddWordWatermark2PDF("C:\\Users\\lori_\\Desktop\\test\\031B  计量管理制度.pdf", "C:\\Users\\lori_\\Desktop\\test\\4567.pdf", "严禁打印");
            //PDFSetWaterMark.setWatermark("D://my.pdf", "D://my2.pdf", "TEST", "", "", 1);

            //PDFHelper.AddImageWatermarkPDF("C:\\Users\\lori_\\Desktop\\test\\031B  计量管理制度.pdf", "C:\\Users\\lori_\\Desktop\\test\\my.pdf", "C:\\Users\\lori_\\Desktop\\test\\control_1.jpg", 0, 0);
        }

        private void btn_ChoiceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            this.txt_inputFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txt_outputFolder.Text = Application.StartupPath + "\\output";

            //System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("fontName");
            //dt.Columns.Add("fontUrl");
            //foreach (System.Drawing.FontFamily family in fonts.Families)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["fontName"] = family.Name;
            //    //dr["fontUrl"]=family.
            //    this.drop_font.Items.Add(family.Name);
            //}

        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = "C:\\";    //打开对话框后的初始目录
            ofg.Filter = "图像文件(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            ofg.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            if (ofg.ShowDialog() == DialogResult.OK) {
                this.txt_img.Text = ofg.FileName;
                img_show.Image = Image.FromFile(ofg.FileName);
            }
        }

        private void radio_text_CheckedChanged(object sender, EventArgs e)
        {
            this.radio_pic.Checked = !this.radio_text.Checked;
        }

        private void radio_pic_CheckedChanged(object sender, EventArgs e)
        {
            this.radio_text.Checked = !this.radio_pic.Checked;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.txt_outputFolder.Text);
        }
    }
}
