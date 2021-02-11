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
            this.outBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxImageMode = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unpackOutA = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.saveA = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unpackOutB = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.saveB = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.unpackOutG = new System.Windows.Forms.PictureBox();
            this.saveG = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unpackOutR = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveR = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonUnpack = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerProcessa = new System.Windows.Forms.Timer(this.components);
            this.inputImageR = new EasyChannelPacking.InputImage();
            this.inputImageG = new EasyChannelPacking.InputImage();
            this.inputImageB = new EasyChannelPacking.InputImage();
            this.inputImageA = new EasyChannelPacking.InputImage();
            this.inputImageUnpack = new EasyChannelPacking.InputImage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.outBox);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.ImageKey = "collect_24.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1033, 834);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pack";
            // 
            // outBox
            // 
            this.outBox.BackColor = System.Drawing.Color.Gray;
            this.outBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outBox.Image = ((System.Drawing.Image)(resources.GetObject("outBox.Image")));
            this.outBox.Location = new System.Drawing.Point(4, 280);
            this.outBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(1025, 456);
            this.outBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outBox.TabIndex = 16;
            this.outBox.TabStop = false;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.inputImageR);
            this.flowLayoutPanel1.Controls.Add(this.inputImageG);
            this.flowLayoutPanel1.Controls.Add(this.inputImageB);
            this.flowLayoutPanel1.Controls.Add(this.inputImageA);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1025, 275);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.groupBox9);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.buttonUnpack);
            this.tabPage2.Controls.Add(this.inputImageUnpack);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1033, 834);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unpack";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.unpackOutA);
            this.groupBox9.Controls.Add(this.pictureBox4);
            this.groupBox9.Controls.Add(this.saveA);
            this.groupBox9.ForeColor = System.Drawing.Color.Black;
            this.groupBox9.Location = new System.Drawing.Point(796, 404);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(250, 391);
            this.groupBox9.TabIndex = 44;
            this.groupBox9.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "A";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unpackOutA
            // 
            this.unpackOutA.Image = ((System.Drawing.Image)(resources.GetObject("unpackOutA.Image")));
            this.unpackOutA.Location = new System.Drawing.Point(14, 69);
            this.unpackOutA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unpackOutA.Name = "unpackOutA";
            this.unpackOutA.Size = new System.Drawing.Size(225, 242);
            this.unpackOutA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpackOutA.TabIndex = 29;
            this.unpackOutA.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 69);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 242);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // saveA
            // 
            this.saveA.Location = new System.Drawing.Point(14, 321);
            this.saveA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveA.Name = "saveA";
            this.saveA.Size = new System.Drawing.Size(225, 58);
            this.saveA.TabIndex = 42;
            this.saveA.Text = "Save";
            this.saveA.UseVisualStyleBackColor = true;
            this.saveA.Visible = false;
            this.saveA.Click += new System.EventHandler(this.saveA_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.unpackOutB);
            this.groupBox8.Controls.Add(this.pictureBox3);
            this.groupBox8.Controls.Add(this.saveB);
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(537, 404);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(250, 391);
            this.groupBox8.TabIndex = 45;
            this.groupBox8.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unpackOutB
            // 
            this.unpackOutB.Image = ((System.Drawing.Image)(resources.GetObject("unpackOutB.Image")));
            this.unpackOutB.Location = new System.Drawing.Point(14, 69);
            this.unpackOutB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unpackOutB.Name = "unpackOutB";
            this.unpackOutB.Size = new System.Drawing.Size(225, 242);
            this.unpackOutB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpackOutB.TabIndex = 29;
            this.unpackOutB.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 69);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 242);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(14, 321);
            this.saveB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(225, 58);
            this.saveB.TabIndex = 42;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Visible = false;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.unpackOutG);
            this.groupBox7.Controls.Add(this.saveG);
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.ForeColor = System.Drawing.Color.Black;
            this.groupBox7.Location = new System.Drawing.Point(278, 404);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(250, 391);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGreen;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "G";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unpackOutG
            // 
            this.unpackOutG.Image = ((System.Drawing.Image)(resources.GetObject("unpackOutG.Image")));
            this.unpackOutG.Location = new System.Drawing.Point(14, 69);
            this.unpackOutG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unpackOutG.Name = "unpackOutG";
            this.unpackOutG.Size = new System.Drawing.Size(225, 242);
            this.unpackOutG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpackOutG.TabIndex = 29;
            this.unpackOutG.TabStop = false;
            // 
            // saveG
            // 
            this.saveG.Location = new System.Drawing.Point(14, 321);
            this.saveG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveG.Name = "saveG";
            this.saveG.Size = new System.Drawing.Size(225, 58);
            this.saveG.TabIndex = 42;
            this.saveG.Text = "Save";
            this.saveG.UseVisualStyleBackColor = true;
            this.saveG.Visible = false;
            this.saveG.Click += new System.EventHandler(this.saveG_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.unpackOutR);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.saveR);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(18, 404);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(250, 391);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "R";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unpackOutR
            // 
            this.unpackOutR.Image = ((System.Drawing.Image)(resources.GetObject("unpackOutR.Image")));
            this.unpackOutR.Location = new System.Drawing.Point(14, 69);
            this.unpackOutR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unpackOutR.Name = "unpackOutR";
            this.unpackOutR.Size = new System.Drawing.Size(225, 242);
            this.unpackOutR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpackOutR.TabIndex = 29;
            this.unpackOutR.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // saveR
            // 
            this.saveR.Location = new System.Drawing.Point(14, 321);
            this.saveR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveR.Name = "saveR";
            this.saveR.Size = new System.Drawing.Size(225, 58);
            this.saveR.TabIndex = 42;
            this.saveR.Text = "Save";
            this.saveR.UseVisualStyleBackColor = true;
            this.saveR.Visible = false;
            this.saveR.Click += new System.EventHandler(this.saveR_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(380, 181);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(668, 29);
            this.progressBar2.TabIndex = 41;
            // 
            // buttonUnpack
            // 
            this.buttonUnpack.Location = new System.Drawing.Point(380, 92);
            this.buttonUnpack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUnpack.Name = "buttonUnpack";
            this.buttonUnpack.Size = new System.Drawing.Size(668, 79);
            this.buttonUnpack.TabIndex = 40;
            this.buttonUnpack.Text = "Unpack Image";
            this.buttonUnpack.UseVisualStyleBackColor = true;
            this.buttonUnpack.Click += new System.EventHandler(this.button6_Click);
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
            this.linkLabel3.Location = new System.Drawing.Point(350, 7);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(120, 21);
            this.linkLabel3.TabIndex = 36;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Rovann Linhalis";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "Special thanks to:";
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
            this.panel1.Controls.Add(this.label11);
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
            // inputImageR
            // 
            this.inputImageR.AllowDrop = true;
            this.inputImageR.BackColor = System.Drawing.Color.Red;
            this.inputImageR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputImageR.Caption = "InputImage";
            this.inputImageR.Channel = "R";
            this.inputImageR.ChannelVisible = true;
            this.inputImageR.Invert = false;
            this.inputImageR.Location = new System.Drawing.Point(4, 5);
            this.inputImageR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageR.Name = "inputImageR";
            this.inputImageR.Size = new System.Drawing.Size(240, 260);
            this.inputImageR.TabIndex = 1;
            this.inputImageR.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageR.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageG
            // 
            this.inputImageG.AllowDrop = true;
            this.inputImageG.BackColor = System.Drawing.Color.ForestGreen;
            this.inputImageG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputImageG.BackgroundImage")));
            this.inputImageG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputImageG.Caption = "Output G";
            this.inputImageG.Channel = "G";
            this.inputImageG.ChannelVisible = true;
            this.inputImageG.Invert = false;
            this.inputImageG.Location = new System.Drawing.Point(252, 5);
            this.inputImageG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageG.Name = "inputImageG";
            this.inputImageG.Size = new System.Drawing.Size(240, 260);
            this.inputImageG.TabIndex = 2;
            this.inputImageG.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageG.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageB
            // 
            this.inputImageB.AllowDrop = true;
            this.inputImageB.BackColor = System.Drawing.Color.Blue;
            this.inputImageB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputImageB.BackgroundImage")));
            this.inputImageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputImageB.Caption = "InputImage";
            this.inputImageB.Channel = "B";
            this.inputImageB.ChannelVisible = true;
            this.inputImageB.Invert = false;
            this.inputImageB.Location = new System.Drawing.Point(500, 5);
            this.inputImageB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageB.Name = "inputImageB";
            this.inputImageB.Size = new System.Drawing.Size(240, 260);
            this.inputImageB.TabIndex = 3;
            this.inputImageB.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageB.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageA
            // 
            this.inputImageA.AllowDrop = true;
            this.inputImageA.BackColor = System.Drawing.Color.White;
            this.inputImageA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inputImageA.BackgroundImage")));
            this.inputImageA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inputImageA.Caption = "InputImage";
            this.inputImageA.Channel = "A";
            this.inputImageA.ChannelVisible = true;
            this.inputImageA.Invert = false;
            this.inputImageA.Location = new System.Drawing.Point(748, 5);
            this.inputImageA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageA.Name = "inputImageA";
            this.inputImageA.Size = new System.Drawing.Size(240, 260);
            this.inputImageA.TabIndex = 11;
            this.inputImageA.ImageProcessComplete += new EasyChannelPacking.InputImage.ImageProcessCompleteEventHandler(this.inputImageR_ImageProcessComplete);
            this.inputImageA.ChannelChanged += new EasyChannelPacking.InputImage.ChannelChangedEventHandler(this.inputImageR_ChannelChanged);
            // 
            // inputImageUnpack
            // 
            this.inputImageUnpack.Caption = "InputImage";
            this.inputImageUnpack.Channel = "";
            this.inputImageUnpack.ChannelVisible = false;
            this.inputImageUnpack.Invert = false;
            this.inputImageUnpack.Location = new System.Drawing.Point(0, 0);
            this.inputImageUnpack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputImageUnpack.Name = "inputImageUnpack";
            this.inputImageUnpack.Size = new System.Drawing.Size(315, 339);
            this.inputImageUnpack.TabIndex = 0;
            // 
            // FormEasyChannelPacking
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
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
            ((System.ComponentModel.ISupportInitialize)(this.outBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unpackOutR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private InputImage inputImageUnpack;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button buttonUnpack;
        private System.Windows.Forms.PictureBox unpackOutR;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox unpackOutA;
        private System.Windows.Forms.Button saveA;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox unpackOutB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox unpackOutG;
        private System.Windows.Forms.Button saveG;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveR;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxImageMode;
        private System.Windows.Forms.Timer timerProcessa;
        private System.Windows.Forms.ImageList imageList1;
    }
}

