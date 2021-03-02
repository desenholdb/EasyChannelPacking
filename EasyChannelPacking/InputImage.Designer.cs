namespace EasyChannelPacking
{
    partial class InputImage
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxinvert = new System.Windows.Forms.CheckBox();
            this.comboChannel = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerProcessaImagem = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.panelHeader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InputImage";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.BackgroundImage = global::EasyChannelPacking.Properties.Resources.bkg_grid;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.buttonClear);
            this.panelHeader.Controls.Add(this.checkBoxinvert);
            this.panelHeader.Controls.Add(this.comboChannel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(3, 16);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(166, 21);
            this.panelHeader.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = global::EasyChannelPacking.Properties.Resources.delete_sign_16;
            this.buttonClear.Location = new System.Drawing.Point(144, 0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(22, 21);
            this.buttonClear.TabIndex = 28;
            this.toolTip1.SetToolTip(this.buttonClear, "Clear Image");
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxinvert
            // 
            this.checkBoxinvert.AutoSize = true;
            this.checkBoxinvert.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxinvert.Location = new System.Drawing.Point(47, 0);
            this.checkBoxinvert.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.checkBoxinvert.Name = "checkBoxinvert";
            this.checkBoxinvert.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBoxinvert.Size = new System.Drawing.Size(58, 21);
            this.checkBoxinvert.TabIndex = 27;
            this.checkBoxinvert.Text = "Invert";
            this.toolTip1.SetToolTip(this.checkBoxinvert, "Invert ");
            this.checkBoxinvert.UseVisualStyleBackColor = true;
            this.checkBoxinvert.CheckedChanged += new System.EventHandler(this.checkBoxinvert_CheckedChanged);
            // 
            // comboChannel
            // 
            this.comboChannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChannel.FormattingEnabled = true;
            this.comboChannel.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "A"});
            this.comboChannel.Location = new System.Drawing.Point(0, 0);
            this.comboChannel.Name = "comboChannel";
            this.comboChannel.Size = new System.Drawing.Size(47, 21);
            this.comboChannel.TabIndex = 26;
            this.comboChannel.SelectedIndexChanged += new System.EventHandler(this.comboChannel_SelectedIndexChanged);
            // 
            // backgroundWorkerProcessaImagem
            // 
            this.backgroundWorkerProcessaImagem.WorkerReportsProgress = true;
            this.backgroundWorkerProcessaImagem.WorkerSupportsCancellation = true;
            this.backgroundWorkerProcessaImagem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerProcessaImagem_DoWork);
            this.backgroundWorkerProcessaImagem.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerProcessaImagem_ProgressChanged);
            this.backgroundWorkerProcessaImagem.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerProcessaImagem_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(172, 5);
            this.progressBar1.TabIndex = 2;
            // 
            // InputImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "InputImage";
            this.Size = new System.Drawing.Size(172, 198);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputImage_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputImage_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.InputImage_DragOver);
            this.Resize += new System.EventHandler(this.InputImage_Resize);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.CheckBox checkBoxinvert;
        private System.Windows.Forms.ComboBox comboChannel;
        private System.ComponentModel.BackgroundWorker backgroundWorkerProcessaImagem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
