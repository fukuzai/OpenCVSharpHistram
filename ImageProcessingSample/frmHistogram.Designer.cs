namespace ImageProcessingSample
{
    partial class frmHistogram
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // chtHistogram
            // 
            this.chtHistogram.BorderlineColor = System.Drawing.Color.Empty;
            this.chtHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtHistogram.Legends.Add(legend1);
            this.chtHistogram.Location = new System.Drawing.Point(0, 0);
            this.chtHistogram.Name = "chtHistogram";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtHistogram.Series.Add(series1);
            this.chtHistogram.Size = new System.Drawing.Size(295, 206);
            this.chtHistogram.TabIndex = 0;
            this.chtHistogram.Text = "Histogram";
            // 
            // frmHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 206);
            this.Controls.Add(this.chtHistogram);
            this.Name = "frmHistogram";
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.frmHistogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtHistogram;
    }
}