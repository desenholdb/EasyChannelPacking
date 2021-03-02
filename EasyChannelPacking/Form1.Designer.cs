namespace EasyChannelPacking
{
    partial class FormEasyChannelPacking
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEasyChannelPacking));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImageMode = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerProcessa = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.outBox = new System.Windows.Forms.PictureBox();
            this.inputImageR = new EasyChannelPacking.InputImage();
            this.inputImageG = new EasyChannelPacking.InputImage();
            this.inputImageB = new EasyChannelPacking.InputImage();
            this.inputImageA = new EasyChannelPacking.InputImage();
            this.inputImageUnpack = new EasyChannelPacking.InputImage();
            this.viewImageR = new EasyChannelPacking.ViewImage();
            this.viewImageG = new EasyChannelPacking.ViewImage();
            this.viewImageB = new EasyChannelPacking.ViewImage();
            this.viewImageA = new EasyChannelPacking.ViewImage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 869);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ImageKey = "collect_24.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1033, 834);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pack";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(4, 736);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1025, 10);
            this.progressBar1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxImageMode);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 746);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 83);
            this.panel2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Image Mode";
            // 
            // comboBoxImageMode
            // 
            this.comboBoxImageMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImageMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxImageMode.FormattingEnabled = true;
            this.comboBoxImageMode.Items.AddRange(new object[] {
            "Normal",
            "Stretch Image",
            "Center",
            "Zoom"});
            this.comboBoxImageMode.Location = new System.Drawing.Point(6, 29);
            this.comboBoxImageMode.Name = "comboBoxImageMode";
            this.comboBoxImageMode.Size = new System.Drawing.Size(213, 29);
            this.comboBoxImageMode.TabIndex = 14;
            this.comboBoxImageMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxImageMode_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.SaveButton.FlatAppearance.BorderSize = 2;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveButton.Location = new System.Drawing.Point(803, 17);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(217, 55);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pack Images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1033, 834);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unpack";
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.Controls.Add(this.inputImageUnpack);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1025, 824);
            this.splitContainer2.SplitterDistance = 551;
            this.splitContainer2.TabIndex = 49;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.Controls.Add(this.viewImageR);
            this.flowLayoutPanel2.Controls.Add(this.viewImageG);
            this.flowLayoutPanel2.Controls.Add(this.viewImageB);
            this.flowLayoutPanel2.Controls.Add(this.viewImageA);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1025, 269);
            this.flowLayoutPanel2.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "packaging_24.png");
            this.imageList1.Images.SetKeyName(1, "collect_24.png");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(35, 7);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 21);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Matheus Dalla";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel3.Location = new System.Drawing.Point(150, 7);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(120, 21);
            this.linkLabel3.TabIndex = 36;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Rovann Linhalis";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "By:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 869);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 37);
            this.panel1.TabIndex = 2;
            // 
            // timerProcessa
            // 
            this.timerProcessa.Interval = 500;
            this.timerProcessa.Tick += new System.EventHandler(this.timerProcessa_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outBox);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 731);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 50;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.inputImageR);
            this.flowLayoutPanel1.Controls.Add(this.inputImageG);
            this.flowLayoutPanel1.Controls.Add(this.inputImageB);
            this.flowLayoutPanel1.Controls.Add(this.inputImageA);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1025, 227);
            this.flowLayoutPanel1.TabIndex = 48;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // outBox
            // 
            this.outBox.BackColor = System.Drawing.Color.Gray;
            this.outBox.BackgroundImage = global::EasyChannelPacking.Properties.Resources.bkg_grid;
            this.outBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outBox.Image = ((System.Drawing.Image)(resources.GetObject("outBox.Image")));
            this.outBox.Location = new System.Drawing.Point(0, 0);
            this.outBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(1025, 500);
            this.outBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outBox.TabIndex = 16;
            this.outBox.TabStop = false;
            // 
            // inputImageR
            // 
            this.inputImageR.AllowDrop = true;
            this.inputImageR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageR.CanInvert = false;
            this.inputImageR.Caption = "Output R";
            this.inputImageR.Channel = "R";
            this.inputImageR.ChannelVisible = false;
            this.inputImageR.ForceAlpha100 = false;
            this.inputImageR.Invert = false;
            this.inputImageR.Location = new System.Drawing.Point(4, 5);
            this.inputImageR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageR.Name = "inputImageR";
            this.inputImageR.Size = new System.Drawing.Size(230, 217);
            this.inputImageR.TabIndex = 1;
            this.inputImageR.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageR.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageG
            // 
            this.inputImageG.AllowDrop = true;
            this.inputImageG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.inputImageG.CanInvert = false;
            this.inputImageG.Caption = "Output G";
            this.inputImageG.Channel = "G";
            this.inputImageG.ChannelVisible = false;
            this.inputImageG.ForceAlpha100 = false;
            this.inputImageG.Invert = false;
            this.inputImageG.Location = new System.Drawing.Point(242, 5);
            this.inputImageG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageG.Name = "inputImageG";
            this.inputImageG.Size = new System.Drawing.Size(230, 217);
            this.inputImageG.TabIndex = 2;
            this.inputImageG.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageG.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageB
            // 
            this.inputImageB.AllowDrop = true;
            this.inputImageB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.inputImageB.CanInvert = false;
            this.inputImageB.Caption = "Output B";
            this.inputImageB.Channel = "B";
            this.inputImageB.ChannelVisible = false;
            this.inputImageB.ForceAlpha100 = false;
            this.inputImageB.Invert = false;
            this.inputImageB.Location = new System.Drawing.Point(480, 5);
            this.inputImageB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageB.Name = "inputImageB";
            this.inputImageB.Size = new System.Drawing.Size(230, 217);
            this.inputImageB.TabIndex = 3;
            this.inputImageB.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageB.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageA
            // 
            this.inputImageA.AllowDrop = true;
            this.inputImageA.BackColor = System.Drawing.Color.Gray;
            this.inputImageA.CanInvert = false;
            this.inputImageA.Caption = "Output A";
            this.inputImageA.Channel = "A";
            this.inputImageA.ChannelVisible = false;
            this.inputImageA.ForceAlpha100 = false;
            this.inputImageA.Invert = false;
            this.inputImageA.Location = new System.Drawing.Point(718, 5);
            this.inputImageA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageA.Name = "inputImageA";
            this.inputImageA.Size = new System.Drawing.Size(230, 217);
            this.inputImageA.TabIndex = 11;
            this.inputImageA.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageA.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageUnpack
            // 
            this.inputImageUnpack.AllowDrop = true;
            this.inputImageUnpack.BackColor = System.Drawing.Color.Gray;
            this.inputImageUnpack.CanInvert = false;
            this.inputImageUnpack.Caption = "Input Unpack Image";
            this.inputImageUnpack.Channel = "";
            this.inputImageUnpack.ChannelVisible = false;
            this.inputImageUnpack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputImageUnpack.ForceAlpha100 = true;
            this.inputImageUnpack.Invert = false;
            this.inputImageUnpack.Location = new System.Drawing.Point(0, 0);
            this.inputImageUnpack.Name = "inputImageUnpack";
            this.inputImageUnpack.Size = new System.Drawing.Size(1025, 551);
            this.inputImageUnpack.TabIndex = 48;
            this.inputImageUnpack.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImage_unpack_ImageProcessComplete);
            // 
            // viewImageR
            // 
            this.viewImageR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewImageR.Caption = "Channel R";
            this.viewImageR.Image = null;
            this.viewImageR.ImageDescription = "Channel_Red";
            this.viewImageR.Location = new System.Drawing.Point(6, 8);
            this.viewImageR.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewImageR.Name = "viewImageR";
            this.viewImageR.Size = new System.Drawing.Size(225, 242);
            this.viewImageR.TabIndex = 46;
            // 
            // viewImageG
            // 
            this.viewImageG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.viewImageG.Caption = "Channel G";
            this.viewImageG.Image = null;
            this.viewImageG.ImageDescription = "Channel_Green";
            this.viewImageG.Location = new System.Drawing.Point(243, 8);
            this.viewImageG.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewImageG.Name = "viewImageG";
            this.viewImageG.Size = new System.Drawing.Size(225, 242);
            this.viewImageG.TabIndex = 47;
            // 
            // viewImageB
            // 
            this.viewImageB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.viewImageB.Caption = "Channel B";
            this.viewImageB.Image = null;
            this.viewImageB.ImageDescription = "Channel_Blue";
            this.viewImageB.Location = new System.Drawing.Point(480, 8);
            this.viewImageB.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewImageB.Name = "viewImageB";
            this.viewImageB.Size = new System.Drawing.Size(225, 242);
            this.viewImageB.TabIndex = 48;
            // 
            // viewImageA
            // 
            this.viewImageA.BackColor = System.Drawing.Color.Gray;
            this.viewImageA.Caption = "Channel A";
            this.viewImageA.Image = null;
            this.viewImageA.ImageDescription = "Channel_Alpha";
            this.viewImageA.Location = new System.Drawing.Point(717, 8);
            this.viewImageA.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewImageA.Name = "viewImageA";
            this.viewImageA.Size = new System.Drawing.Size(225, 242);
            this.viewImageA.TabIndex = 49;
            // 
            // FormEasyChannelPacking
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1041, 906);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEasyChannelPacking";
            this.Text = "Easy Channel Packing";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private InputImage inputImageB;
        private InputImage inputImageG;
        private InputImage inputImageR;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
        private InputImage inputImageA;
        private System.Windows.Forms.PictureBox outBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImageMode;
        private System.Windows.Forms.Timer timerProcessa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ViewImage viewImageR;
        private ViewImage viewImageG;
        private ViewImage viewImageB;
        private ViewImage viewImageA;
        private InputImage inputImageUnpack;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

