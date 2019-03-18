namespace ImageProcessingSample
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterSmooth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterSmoothBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterSmoothGaussianBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterSmoothMedianBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterThresholdBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.mnuFilterThresholdOtsu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterEdgeSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterEdgeCanny = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterMorphologyDilate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterMorphologyErode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterMorphologyOpening = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilterMorphologyClosing = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBright = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblImageInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFilter});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(530, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSaveAs,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 22);
            this.mnuFile.Text = "File(&F)";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(173, 22);
            this.mnuFileOpen.Text = "Open(&O)";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(173, 22);
            this.mnuFileSaveAs.Text = "Save as(&S)";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(173, 22);
            this.mnuFileExit.Text = "Exit(&X)";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuFilter
            // 
            this.mnuFilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterSmooth,
            this.mnuFilterThreshold,
            this.mnuFilterEdge,
            this.mnuFilterMorphology});
            this.mnuFilter.Name = "mnuFilter";
            this.mnuFilter.Size = new System.Drawing.Size(50, 22);
            this.mnuFilter.Text = "Filter";
            // 
            // mnuFilterSmooth
            // 
            this.mnuFilterSmooth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterSmoothBlur,
            this.mnuFilterSmoothGaussianBlur,
            this.mnuFilterSmoothMedianBlur});
            this.mnuFilterSmooth.Name = "mnuFilterSmooth";
            this.mnuFilterSmooth.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterSmooth.Text = "Smooth";
            // 
            // mnuFilterSmoothBlur
            // 
            this.mnuFilterSmoothBlur.Name = "mnuFilterSmoothBlur";
            this.mnuFilterSmoothBlur.Size = new System.Drawing.Size(151, 22);
            this.mnuFilterSmoothBlur.Text = "Blur";
            this.mnuFilterSmoothBlur.Click += new System.EventHandler(this.mnuFilterSmoothBlur_Click);
            // 
            // mnuFilterSmoothGaussianBlur
            // 
            this.mnuFilterSmoothGaussianBlur.Name = "mnuFilterSmoothGaussianBlur";
            this.mnuFilterSmoothGaussianBlur.Size = new System.Drawing.Size(151, 22);
            this.mnuFilterSmoothGaussianBlur.Text = "GaussianBlur";
            this.mnuFilterSmoothGaussianBlur.Click += new System.EventHandler(this.mnuFilterSmoothGaussianBlur_Click);
            // 
            // mnuFilterSmoothMedianBlur
            // 
            this.mnuFilterSmoothMedianBlur.Name = "mnuFilterSmoothMedianBlur";
            this.mnuFilterSmoothMedianBlur.Size = new System.Drawing.Size(151, 22);
            this.mnuFilterSmoothMedianBlur.Text = "Median";
            this.mnuFilterSmoothMedianBlur.Click += new System.EventHandler(this.mnuFilterSmoothMedianBlur_Click);
            // 
            // mnuFilterThreshold
            // 
            this.mnuFilterThreshold.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterThresholdBinary,
            this.mnuFilterThresholdOtsu});
            this.mnuFilterThreshold.Name = "mnuFilterThreshold";
            this.mnuFilterThreshold.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterThreshold.Text = "Threshold";
            // 
            // mnuFilterThresholdBinary
            // 
            this.mnuFilterThresholdBinary.Name = "mnuFilterThresholdBinary";
            this.mnuFilterThresholdBinary.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterThresholdBinary.Text = "Binary";
            this.mnuFilterThresholdBinary.Click += new System.EventHandler(this.mnuFilterThresholdBinary_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBright,
            this.lblSpring,
            this.lblImageInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(530, 23);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(230, 182);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            this.picImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImage_MouseMove);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.picImage);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 26);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(530, 370);
            this.panel.TabIndex = 3;
            // 
            // mnuFilterThresholdOtsu
            // 
            this.mnuFilterThresholdOtsu.Name = "mnuFilterThresholdOtsu";
            this.mnuFilterThresholdOtsu.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterThresholdOtsu.Text = "Otsu";
            this.mnuFilterThresholdOtsu.Click += new System.EventHandler(this.mnuFilterThresholdOtsu_Click);
            // 
            // mnuFilterEdge
            // 
            this.mnuFilterEdge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterEdgeSobel,
            this.mnuFilterEdgeCanny});
            this.mnuFilterEdge.Name = "mnuFilterEdge";
            this.mnuFilterEdge.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterEdge.Text = "Edge";
            // 
            // mnuFilterEdgeSobel
            // 
            this.mnuFilterEdgeSobel.Name = "mnuFilterEdgeSobel";
            this.mnuFilterEdgeSobel.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterEdgeSobel.Text = "Sobel";
            this.mnuFilterEdgeSobel.Click += new System.EventHandler(this.mnuFilterEdgeSobel_Click);
            // 
            // mnuFilterEdgeCanny
            // 
            this.mnuFilterEdgeCanny.Name = "mnuFilterEdgeCanny";
            this.mnuFilterEdgeCanny.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterEdgeCanny.Text = "Canny";
            this.mnuFilterEdgeCanny.Click += new System.EventHandler(this.mnuFilterEdgeCanny_Click);
            // 
            // mnuFilterMorphology
            // 
            this.mnuFilterMorphology.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilterMorphologyDilate,
            this.mnuFilterMorphologyErode,
            this.mnuFilterMorphologyOpening,
            this.mnuFilterMorphologyClosing});
            this.mnuFilterMorphology.Name = "mnuFilterMorphology";
            this.mnuFilterMorphology.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterMorphology.Text = "Morphology";
            // 
            // mnuFilterMorphologyDilate
            // 
            this.mnuFilterMorphologyDilate.Name = "mnuFilterMorphologyDilate";
            this.mnuFilterMorphologyDilate.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterMorphologyDilate.Text = "Dilate";
            this.mnuFilterMorphologyDilate.Click += new System.EventHandler(this.mnuFilterMorphologyDilate_Click);
            // 
            // mnuFilterMorphologyErode
            // 
            this.mnuFilterMorphologyErode.Name = "mnuFilterMorphologyErode";
            this.mnuFilterMorphologyErode.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterMorphologyErode.Text = "Erode";
            this.mnuFilterMorphologyErode.Click += new System.EventHandler(this.mnuFilterMorphologyErode_Click);
            // 
            // mnuFilterMorphologyOpening
            // 
            this.mnuFilterMorphologyOpening.Name = "mnuFilterMorphologyOpening";
            this.mnuFilterMorphologyOpening.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterMorphologyOpening.Text = "Opening";
            this.mnuFilterMorphologyOpening.Click += new System.EventHandler(this.mnuFilterMorphologyOpening_Click);
            // 
            // mnuFilterMorphologyClosing
            // 
            this.mnuFilterMorphologyClosing.Name = "mnuFilterMorphologyClosing";
            this.mnuFilterMorphologyClosing.Size = new System.Drawing.Size(152, 22);
            this.mnuFilterMorphologyClosing.Text = "Closing";
            this.mnuFilterMorphologyClosing.Click += new System.EventHandler(this.mnuFilterMorphologyClosing_Click);
            // 
            // lblBright
            // 
            this.lblBright.Name = "lblBright";
            this.lblBright.Size = new System.Drawing.Size(43, 18);
            this.lblBright.Text = "Bright";
            // 
            // lblSpring
            // 
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(403, 18);
            this.lblSpring.Spring = true;
            this.lblSpring.Text = "　";
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(69, 18);
            this.lblImageInfo.Text = "ImageInfo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 419);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Image Processing Sample(OpenCvSharp)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem mnuFilter;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterSmooth;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterSmoothBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterSmoothGaussianBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterSmoothMedianBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterThreshold;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterThresholdBinary;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterThresholdOtsu;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterEdge;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterEdgeSobel;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterEdgeCanny;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterMorphology;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterMorphologyDilate;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterMorphologyErode;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterMorphologyOpening;
        private System.Windows.Forms.ToolStripMenuItem mnuFilterMorphologyClosing;
        private System.Windows.Forms.ToolStripStatusLabel lblBright;
        private System.Windows.Forms.ToolStripStatusLabel lblSpring;
        private System.Windows.Forms.ToolStripStatusLabel lblImageInfo;
    }
}