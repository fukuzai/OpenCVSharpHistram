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
    public partial class frmHistogram : Form
    {
        public frmHistogram()
        {
            InitializeComponent();
        }

        private void frmHistogram_Load(object sender, EventArgs e)
        {
            chtHistogram.Series.Clear();
            
            // Chartの目盛りの設定
            chtHistogram.ChartAreas.Clear();
            chtHistogram.ChartAreas.Add("Histogram");
            // X軸
            chtHistogram.ChartAreas["Histogram"].AxisX.Title = "Brightness";
            chtHistogram.ChartAreas["Histogram"].AxisX.Minimum = 0;
            chtHistogram.ChartAreas["Histogram"].AxisX.Maximum = 255;
            chtHistogram.ChartAreas["Histogram"].AxisX.Interval = 50;
            // Y軸
            chtHistogram.ChartAreas["Histogram"].AxisY.Title = "Count";
            chtHistogram.ChartAreas["Histogram"].AxisY.Minimum = 0;
        }

        /// <summary>
        /// ヒストグラムの初期化
        /// </summary>
        /// <param name="channels">チャンネル数</param>
        private void RefreshHistogramArea(int channels)
        {
            chtHistogram.Series.Clear();

            if (channels == 1)
            {
                // モノクロの場合
                // グラフの追加
                chtHistogram.Series.Add("Gray");
                // グラフの種類の設定
                chtHistogram.Series["Gray"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                // グラフの色の設定
                chtHistogram.Series["Gray"].Color = Color.FromArgb(150, Color.Blue);
                // 凡例の非表示
                chtHistogram.Series["Gray"].IsVisibleInLegend = false;
            }
            else
            {
                // カラーの場合

                // グラフの追加
                chtHistogram.Series.Add("R");
                chtHistogram.Series.Add("G");
                chtHistogram.Series.Add("B");

                // グラフの種類の設定
                chtHistogram.Series["R"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                chtHistogram.Series["G"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
                chtHistogram.Series["B"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

                // グラフの色の設定
                chtHistogram.Series["R"].Color = Color.FromArgb(150, Color.Red);
                chtHistogram.Series["G"].Color = Color.FromArgb(150, Color.Green);
                chtHistogram.Series["B"].Color = Color.FromArgb(150, Color.Blue);

                // 凡例の非表示
                chtHistogram.Series["R"].IsVisibleInLegend = false;
                chtHistogram.Series["G"].IsVisibleInLegend = false;
                chtHistogram.Series["B"].IsVisibleInLegend = false;
            }
        }

        /// <summary>
        /// ヒストグラムの描画
        /// </summary>
        /// <param name="mat">ヒストグラムを描画するMat</param>
        public void DrawHistogram(Mat mat)
        {
            int c;

            // 画像のチャンネル数
            int channelNum = mat.Channels();
            if (channelNum > 3) channelNum = 3; // alpha成分は無視する

            // ヒストグラムの初期化
            RefreshHistogramArea(channelNum);

            var matChannel = new Mat[channelNum];

            // ラベル
            string[] axisName = { "B", "G", "R" };

            if (channelNum == 1)
            {
                // モノクロの場合
                axisName[0] = "Gray";
            }

            // 各チャンネルのbin数
            int[] hdims = { 256 };
            OpenCvSharp.CPlusPlus.Rangef[] ranges = { new OpenCvSharp.CPlusPlus.Rangef(0, 256), };

            var histogram = new Mat[channelNum];

            for (c = 0; c < channelNum; c++)
            {
                histogram[c] = new Mat();

                // ヒストグラムの取得
                Cv2.CalcHist(
                    new Mat[] { mat },
                    new int[] { c },
                    null,
                    histogram[c],
                    1,
                    hdims,
                    ranges
                    );

                // ヒストグラムをChartへ描画
                for (int i = 0; i < 256; i++)
                {
                    chtHistogram.Series[axisName[c]].Points.AddXY(i, histogram[c].At<float>(i, 0));
                }
            }
        }
    }
}
