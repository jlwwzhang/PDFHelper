using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PDFHelper
{
    public static class PDFHelper
    {
        /// <summary>
        /// 加图片水印
        /// </summary>
        /// <param name="inputfilepath">文件地址</param>
        /// <param name="outputfilepath">输出目录</param>
        /// <param name="ModelPicName">图片地址</param>
        /// <param name="x">x偏移</param>
        /// <param name="y">y偏移</param>
        /// <param name="rotation">角度</param>
        /// <returns>true or false</returns>
        #region 加图片水印
        public static bool AddImageWatermarkPDF(string inputfilepath, string outputfilepath, string ModelPicName, float x, float y,float rotation)
        {
            //throw new NotImplementedException();
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);

                int numberOfPages = pdfReader.NumberOfPages;
                iTextSharp.text.Rectangle psize = pdfReader.GetPageSize(1);

                float width = psize.Width;

                float height = psize.Height;

                pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));
                
                PdfContentByte waterMarkContent;

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ModelPicName);
                image.GrayFill = 20;//透明度，灰色填充
                                    //image.Rotation//旋转
                image.RotationDegrees = rotation;//旋转角度
                                                 //image.RotationDegrees//旋转角度
                                                 //水印的位置
                
                //if (left < 0)
                //{
                //    left = width / 2 - image.Width + left;
                //}

                //image.SetAbsolutePosition(left, height / 2 + y);

                //image.SetAbsolutePosition(left, (height - image.Height) - top);
                image.SetAbsolutePosition(width / 2 + x, height / 2 + y);


                //每一页加水印,也可以设置某一页加水印
                for (int i = 1; i <= numberOfPages; i++)
                {
                    //waterMarkContent = pdfStamper.GetUnderContent(i);//内容下层加水印
                    waterMarkContent = pdfStamper.GetOverContent(i);//内容上层加水印

                    waterMarkContent.AddImage(image);
                }
                //strMsg = "success";
                return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
            }
        }
        #endregion

        /// <summary>
        /// 添加普通偏转角度文字水印
        /// </summary>
        /// <param name="inputfilepath">文件地址</param>
        /// <param name="outputfilepath">输出目录</param>
        /// <param name="waterMarkName">水印文本</param>
        /// <param name="x">x偏移</param>
        /// <param name="y">y偏移</param>
        /// <param name="rotation">角度</param>
        /// <return>true or false</return>
        #region 添加普通偏转角度文字水印
        public static void AddWordWatermark2PDF(string inputfilepath, string outputfilepath, string waterMarkName,int x , int y , int rotation , int fontsize)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);
                pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));
                int total = pdfReader.NumberOfPages + 1;
                iTextSharp.text.Rectangle psize = pdfReader.GetPageSize(1);
                float width = psize.Width;
                float height = psize.Height;
                PdfContentByte content;
                //PRIndirectReference pRIndirectReference = new PRIndirectReference(pdfReader, 1);
                BaseFont font = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\SIMFANG.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                
                PdfGState gs = new PdfGState();
                for (int i = 1; i < total; i++)
                {
                    content = pdfStamper.GetOverContent(i);//在内容上方加水印
                    //content = pdfStamper.GetUnderContent(i);//在内容下方加水印
                    //透明度
                    gs.FillOpacity = 0.5f;
                    content.SetGState(gs);
                    content.SetGrayFill(0.5f);
                    //开始写入文本
                    content.BeginText();
                    //content.SetColorFill(BaseColor.LIGHT_GRAY);
                    //content.SetFontAndSize(font, 100);
                    //content.SetTextMatrix(0, 0);
                    //content.ShowTextAligned(Element.ALIGN_CENTER, waterMarkName, width / 2 - 50, height / 2 - 50, 55);
                    content.SetColorFill(BaseColor.RED);
                    content.SetFontAndSize(font, fontsize);
                    content.ShowTextAligned(Element.ALIGN_CENTER, waterMarkName, width / 2 + x, height / 2 +y, rotation);
                    //content.ShowTextAligned(Element.ALIGN_CENTER, waterMarkName, width, height, rotation);
                    content.EndText();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
            }
        }
        #endregion


        /// <summary>
        /// 添加倾斜水印
        /// </summary>
        /// <param name="inputfilepath"></param>
        /// <param name="outputfilepath"></param>
        /// <param name="waterMarkName"></param>
        /// <param name="userPassWord"></param>
        /// <param name="ownerPassWord"></param>
        /// <param name="permission"></param>
        public static void setWatermark(string inputfilepath, string outputfilepath, string waterMarkName, string userPassWord, string ownerPassWord, int permission)
        {
            PdfReader pdfReader = null;
            PdfStamper pdfStamper = null;
            try
            {
                pdfReader = new PdfReader(inputfilepath);
                pdfStamper = new PdfStamper(pdfReader, new FileStream(outputfilepath, FileMode.Create));
                // 设置密码  
                //pdfStamper.SetEncryption(false,userPassWord, ownerPassWord, permission);

                int total = pdfReader.NumberOfPages + 1;
                PdfContentByte content;
                BaseFont font = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\SIMFANG.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                PdfGState gs = new PdfGState();
                gs.FillOpacity = 0.2f;//透明度

                int j = waterMarkName.Length;
                char c;
                int rise = 0;
                for (int i = 1; i < total; i++)
                {
                    rise = 500;
                    content = pdfStamper.GetOverContent(i);//在内容上方加水印
                                                           //content = pdfStamper.GetUnderContent(i);//在内容下方加水印

                    content.BeginText();
                    content.SetColorFill(BaseColor.DARK_GRAY);
                    content.SetFontAndSize(font, 50);
                    // 设置水印文字字体倾斜 开始
                    if (j >= 15)
                    {
                        content.SetTextMatrix(200, 120);
                        for (int k = 0; k < j; k++)
                        {
                            content.SetTextRise(rise);
                            c = waterMarkName[k];
                            content.ShowText(c + "");
                            rise -= 20;
                        }
                    }
                    else
                    {
                        content.SetTextMatrix(180, 100);
                        for (int k = 0; k < j; k++)
                        {
                            content.SetTextRise(rise);
                            c = waterMarkName[k];
                            content.ShowText(c + "");
                            rise -= 18;
                        }
                    }
                    // 字体设置结束
                    content.EndText();
                    // 画一个圆
                    //content.Ellipse(250, 450, 350, 550);
                    //content.SetLineWidth(1f);
                    //content.Stroke();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (pdfStamper != null)
                    pdfStamper.Close();

                if (pdfReader != null)
                    pdfReader.Close();
            }
        }
    }
}
