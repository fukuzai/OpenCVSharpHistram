using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// OpenCvSharpの名前空間
using OpenCvSharp.CPlusPlus;

namespace ImageProcessingSample
{
    public partial class MainForm : Form
    {

        private Bitmap _srcBmp;
        private Graphics _srcGraphics;
        private frmHistogram _frmHistogram;

        // 表示用Mat
        Mat _matDisp = new Mat();

        public MainForm()
        {
            InitializeComponent();

            // 自動的にスクロールバーを表示する
            this.AutoScroll = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _frmHistogram = new frmHistogram();
            _frmHistogram.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////

        #region ファイルメニュー

        /// <summary>
        /// 画像ファイルを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            //ファイルを開くダイアログの作成 
            var ofd = new OpenFileDialog();
            //ファイルフィルタ 
            ofd.Filter = "画像ﾌｧｲﾙ(*.bmp,*.jpg,*.png,*.tif)|*.bmp;*.jpg;*.png;*.tif";
            //ダイアログの表示 
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            //ビットマップファイルから、Bitmapを作成 
            _matDisp = new Mat(ofd.FileName, OpenCvSharp.LoadMode.Unchanged);

            ResizePictureBox(_matDisp);

            // ビットマップをピクチャボックスへ表示
            DrawMatImage(_matDisp);

        }

        /// <summary>
        /// 名前を付けて保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            if (_matDisp == null) return;

            //ファイルを開くダイアログの作成 
            var sfd = new SaveFileDialog();
            //ファイルフィルタ 
            sfd.Filter = "Jpeg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png|Tiff(*.tif)|*.tif|CSV(*.csv)|*.csv";

            //ダイアログの表示 
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // 拡張子
                if (System.IO.Path.GetExtension(sfd.FileName).ToLower() == ".csv")
                {
                    // CSVファイルに画像の輝度値を保存
                    SaveCSVImage(sfd.FileName, _matDisp);
                }
                else
                {
                    // 名前を付けて保存
                    _matDisp.SaveImage(sfd.FileName);
                }
            }
        }

        /// <summary>
        /// 終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////////////////

        #region フィルタ処理

        private void mnuFilterSmoothBlur_Click(object sender, EventArgs e)
        {
            // 平滑化フィルタ(5x5サイズ)
            Cv2.Blur(_matDisp, _matDisp, new OpenCvSharp.CPlusPlus.Size(5, 5));
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterSmoothGaussianBlur_Click(object sender, EventArgs e)
        {
            // ガウシアンフィルタ(5x5サイズ)
            Cv2.GaussianBlur(_matDisp, _matDisp, new OpenCvSharp.CPlusPlus.Size(5, 5), 0);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterSmoothMedianBlur_Click(object sender, EventArgs e)
        {
            // メディアンフィルタ(5x5サイズ)
            Cv2.MedianBlur(_matDisp, _matDisp, 5);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterThresholdBinary_Click(object sender, EventArgs e)
        {
            // 二値化(しきい値127)
            Cv2.Threshold(_matDisp, _matDisp, 127, 255, OpenCvSharp.ThresholdType.Binary);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterThresholdOtsu_Click(object sender, EventArgs e)
        {
            // 大津の二値化

            // 大津の二値化はカラーに対応していないため、カラー画像の場合はモノクロへ変換する。
            ColorToGray(_matDisp, _matDisp);

            // 大津の二値化
            Cv2.Threshold(_matDisp, _matDisp, 127, 255, OpenCvSharp.ThresholdType.Otsu);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterEdgeSobel_Click(object sender, EventArgs e)
        {
            // ソーベルフィルタ

            using (var xSobel = new Mat(_matDisp.Size(), MatType.CV_16S))
            using (var ySobel = new Mat(_matDisp.Size(), MatType.CV_16S))
            {
                // X方向の微分
                Cv2.Sobel(_matDisp, xSobel, MatType.CV_16S, 1, 0);
                // Y方向の微分
                Cv2.Sobel(_matDisp, ySobel, MatType.CV_16S, 0, 1);
                // X方向とY方向を足し合わせる
                Cv2.ConvertScaleAbs((xSobel + ySobel), _matDisp);
            }
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterEdgeCanny_Click(object sender, EventArgs e)
        {
            // Canny Edge
            Cv2.Canny(_matDisp, _matDisp, 100.0, 150.0);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterMorphologyDilate_Click(object sender, EventArgs e)
        {
            // 膨張
            Cv2.Dilate(_matDisp, _matDisp, null);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterMorphologyErode_Click(object sender, EventArgs e)
        {
            // 収縮
            Cv2.Erode(_matDisp, _matDisp, null);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterMorphologyOpening_Click(object sender, EventArgs e)
        {
            // オープニング
            Cv2.MorphologyEx(_matDisp, _matDisp, OpenCvSharp.MorphologyOperation.Open, null);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        private void mnuFilterMorphologyClosing_Click(object sender, EventArgs e)
        {
            // クロージング
            Cv2.MorphologyEx(_matDisp, _matDisp, OpenCvSharp.MorphologyOperation.Close, null);
            // 画像の描画
            DrawMatImage(_matDisp);
        }

        #endregion

        private void picImage_MouseMove(object sender, MouseEventArgs e)
        {
            DrawBrightValue(_matDisp, e.X, e.Y);

        }

        ///////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Matの画像を表示する。
        /// </summary>
        /// <param name="mat"></param>
        private void DrawMatImage(Mat mat)
        {
            // 画像データが無い場合は何もしない
            if (mat == null) return;
            if (mat.Data == IntPtr.Zero) return;

            if ((_matDisp.Width != mat.Width) || (_matDisp.Height != mat.Height))
            {
                // 画像サイズが異なる場合は、PictureBoxをリサイズする
                ResizePictureBox(mat);
            }

            // ビットマップをピクチャボックスへ表示
            using (var bmp = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat))
            {
                // 変換後の画像を描画
                _srcGraphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
                picImage.Refresh();
            }

            // ヒストグラムの描画
            _frmHistogram.DrawHistogram(mat);

            _matDisp = mat;

            // 画像情報の表示
            lblImageInfo.Text = _matDisp.Width.ToString() + " x " +
                                _matDisp.Height.ToString() + " x " +
                                _matDisp.Channels().ToString() + "ch";
                                
        }

        /// <summary>
        /// カラー⇒モノクロ変換
        /// </summary>
        /// <param name="src">変換前のMat(カラー)</param>
        /// <param name="dst">変換後のMat(モノクロ)</param>
        private void ColorToGray(Mat srcColor, Mat dstMono)
        {
            if (srcColor.Channels() == 1) return;    // モノクロの場合は何もしない

            // カラー⇒モノクロ変換
            Cv2.CvtColor(srcColor, dstMono, OpenCvSharp.ColorConversion.BgrToGray);
        }
        
        /// <summary>
        /// ピクチャボックスをMatの大きさに合わせて変更する
        /// </summary>
        /// <param name="mat"></param>
        private void ResizePictureBox(Mat mat)
        {
            picImage.Width = mat.Width;
            picImage.Height = mat.Height;

            if (_srcBmp != null) _srcBmp.Dispose();
            _srcBmp = new Bitmap(picImage.Width, picImage.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            picImage.Image = _srcBmp;
            _srcGraphics = Graphics.FromImage(_srcBmp);
        }

        /// <summary>
        /// 輝度値をステータスバーへ表示
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="X">画像のX座標</param>
        /// <param name="Y">画像のY座標</param>
        private void DrawBrightValue(Mat mat, int X, int Y)
        {
            // 画像データが無い場合は何もしない
            if (mat == null) return;
            if (mat.Data == IntPtr.Zero) return;        

            string lblText;

            lblText = "(" + X.ToString() + ", " + Y.ToString() + ") = ";

            if (mat.Channels() == 1)
            {
                // モノクロの場合
                lblText += mat.At<byte>(Y, X).ToString();
            }
            else
            {
                // カラーの場合
                lblText += "(" +
                           mat.At<OpenCvSharp.CPlusPlus.Vec3b>(Y, X)[2].ToString() + ", " +
                           mat.At<OpenCvSharp.CPlusPlus.Vec3b>(Y, X)[1].ToString() + ", " +
                           mat.At<OpenCvSharp.CPlusPlus.Vec3b>(Y, X)[0].ToString() + ")";
            }
            lblBright.Text = lblText;
        }

        /// <summary>
        /// 画像データをCSVファイルに保存
        /// 保存されるデータは B, G, R, B, G, R…の順番
        /// </summary>
        /// <param name="fileName">保存するCSVファイル名</param>
        /// <param name="mat">保存する画像のMat</param>
        private void SaveCSVImage(string fileName, Mat mat)
        {
            var width = mat.Width;      // 画像の幅
            var height = mat.Height;    // 画像の高さ
            var ch = mat.Channels();    // チャンネル数

            int i, j, c;

            try
            {
                using (var sw = new System.IO.StreamWriter(fileName, false))
                {
                    for (j = 0; j < height; j++)
                    {
                        for (i = 0; i < width - 1; i++)
                        {
                            for (c = 0; c < ch; c++)
                            {
                                sw.Write(mat.At<Vec3b>(j, i)[c].ToString() + ", ");
                            }
                        }
                        // 最後の値はカンマなし
                        for (c = 0; c < ch - 1; c++)
                        {
                            sw.Write(mat.At<Vec3b>(j, width - 1)[c].ToString() + ", ");
                        }
                        sw.WriteLine(mat.At<Vec3b>(j, width - 1)[ch - 1].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                // エラーの場合（fileNameと同じファイルを開いている場合などにエラー）
                MessageBox.Show(ex.Message);
            }
        }
    }
}
