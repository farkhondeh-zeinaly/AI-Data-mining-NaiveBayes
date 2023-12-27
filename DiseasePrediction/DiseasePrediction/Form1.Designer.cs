namespace DiseasePrediction
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTrainClassFile = new System.Windows.Forms.Button();
            this.textBoxTrainClassFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReadFiles = new System.Windows.Forms.Button();
            this.buttonBrowseTestFile = new System.Windows.Forms.Button();
            this.textBoxTestFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowseTrainFile = new System.Windows.Forms.Button();
            this.textBoxTrainFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTreshold = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCreateTopGenes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxTopGeneCount = new System.Windows.Forms.CheckedListBox();
            this.textBoxFoldDifference = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBrowseBestTrain = new System.Windows.Forms.Button();
            this.textBoxBestTrainFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTestGeneExtrat = new System.Windows.Forms.Button();
            this.radioButtonTop2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop4 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop6 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop8 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop10 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop12 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop15 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop20 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop25 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop30 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonTrainClassFile);
            this.groupBox1.Controls.Add(this.textBoxTrainClassFile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonReadFiles);
            this.groupBox1.Controls.Add(this.buttonBrowseTestFile);
            this.groupBox1.Controls.Add(this.textBoxTestFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonBrowseTrainFile);
            this.groupBox1.Controls.Add(this.textBoxTrainFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(540, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // buttonTrainClassFile
            // 
            this.buttonTrainClassFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTrainClassFile.Location = new System.Drawing.Point(6, 49);
            this.buttonTrainClassFile.Name = "buttonTrainClassFile";
            this.buttonTrainClassFile.Size = new System.Drawing.Size(100, 23);
            this.buttonTrainClassFile.TabIndex = 9;
            this.buttonTrainClassFile.Text = "Browse";
            this.buttonTrainClassFile.UseVisualStyleBackColor = true;
            this.buttonTrainClassFile.Click += new System.EventHandler(this.buttonTrainClassFile_Click);
            // 
            // textBoxTrainClassFile
            // 
            this.textBoxTrainClassFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrainClassFile.Location = new System.Drawing.Point(112, 51);
            this.textBoxTrainClassFile.Name = "textBoxTrainClassFile";
            this.textBoxTrainClassFile.ReadOnly = true;
            this.textBoxTrainClassFile.Size = new System.Drawing.Size(299, 21);
            this.textBoxTrainClassFile.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "فایل کلاس های آموزش:";
            // 
            // buttonReadFiles
            // 
            this.buttonReadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadFiles.Location = new System.Drawing.Point(6, 105);
            this.buttonReadFiles.Name = "buttonReadFiles";
            this.buttonReadFiles.Size = new System.Drawing.Size(100, 49);
            this.buttonReadFiles.TabIndex = 6;
            this.buttonReadFiles.Text = "خواندن فایل ها";
            this.buttonReadFiles.UseVisualStyleBackColor = true;
            this.buttonReadFiles.Click += new System.EventHandler(this.buttonReadFiles_Click);
            // 
            // buttonBrowseTestFile
            // 
            this.buttonBrowseTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseTestFile.Location = new System.Drawing.Point(6, 76);
            this.buttonBrowseTestFile.Name = "buttonBrowseTestFile";
            this.buttonBrowseTestFile.Size = new System.Drawing.Size(100, 23);
            this.buttonBrowseTestFile.TabIndex = 5;
            this.buttonBrowseTestFile.Text = "Browse";
            this.buttonBrowseTestFile.UseVisualStyleBackColor = true;
            this.buttonBrowseTestFile.Click += new System.EventHandler(this.buttonBrowseTestFile_Click);
            // 
            // textBoxTestFile
            // 
            this.textBoxTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTestFile.Location = new System.Drawing.Point(112, 78);
            this.textBoxTestFile.Name = "textBoxTestFile";
            this.textBoxTestFile.ReadOnly = true;
            this.textBoxTestFile.Size = new System.Drawing.Size(299, 21);
            this.textBoxTestFile.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "فایل تست:";
            // 
            // buttonBrowseTrainFile
            // 
            this.buttonBrowseTrainFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseTrainFile.Location = new System.Drawing.Point(6, 22);
            this.buttonBrowseTrainFile.Name = "buttonBrowseTrainFile";
            this.buttonBrowseTrainFile.Size = new System.Drawing.Size(100, 23);
            this.buttonBrowseTrainFile.TabIndex = 2;
            this.buttonBrowseTrainFile.Text = "Browse";
            this.buttonBrowseTrainFile.UseVisualStyleBackColor = true;
            this.buttonBrowseTrainFile.Click += new System.EventHandler(this.buttonBrowseTrainFile_Click);
            // 
            // textBoxTrainFile
            // 
            this.textBoxTrainFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrainFile.Location = new System.Drawing.Point(112, 24);
            this.textBoxTrainFile.Name = "textBoxTrainFile";
            this.textBoxTrainFile.ReadOnly = true;
            this.textBoxTrainFile.Size = new System.Drawing.Size(299, 21);
            this.textBoxTrainFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "فایل آموزش:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonTreshold);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownMax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownMin);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(540, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "پالایش داده ها";
            // 
            // buttonTreshold
            // 
            this.buttonTreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTreshold.Location = new System.Drawing.Point(125, 45);
            this.buttonTreshold.Name = "buttonTreshold";
            this.buttonTreshold.Size = new System.Drawing.Size(124, 21);
            this.buttonTreshold.TabIndex = 10;
            this.buttonTreshold.Text = "Treshold";
            this.buttonTreshold.UseVisualStyleBackColor = true;
            this.buttonTreshold.Click += new System.EventHandler(this.buttonTreshold_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMax.Location = new System.Drawing.Point(271, 45);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownMax.TabIndex = 5;
            this.numericUpDownMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMax.Value = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Min";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMin.Location = new System.Drawing.Point(336, 45);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownMin.TabIndex = 0;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCreateTopGenes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkedListBoxTopGeneCount);
            this.groupBox3.Controls.Add(this.textBoxFoldDifference);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(540, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "انتخاب ژن های با ارزش";
            // 
            // buttonCreateTopGenes
            // 
            this.buttonCreateTopGenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateTopGenes.Location = new System.Drawing.Point(73, 97);
            this.buttonCreateTopGenes.Name = "buttonCreateTopGenes";
            this.buttonCreateTopGenes.Size = new System.Drawing.Size(124, 38);
            this.buttonCreateTopGenes.TabIndex = 11;
            this.buttonCreateTopGenes.Text = "Create Top Gene";
            this.buttonCreateTopGenes.UseVisualStyleBackColor = true;
            this.buttonCreateTopGenes.Click += new System.EventHandler(this.buttonCreateTopGenes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Top Genes Count:";
            // 
            // checkedListBoxTopGeneCount
            // 
            this.checkedListBoxTopGeneCount.ColumnWidth = 35;
            this.checkedListBoxTopGeneCount.FormattingEnabled = true;
            this.checkedListBoxTopGeneCount.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "15",
            "20",
            "25",
            "30"});
            this.checkedListBoxTopGeneCount.Location = new System.Drawing.Point(73, 60);
            this.checkedListBoxTopGeneCount.MultiColumn = true;
            this.checkedListBoxTopGeneCount.Name = "checkedListBoxTopGeneCount";
            this.checkedListBoxTopGeneCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBoxTopGeneCount.Size = new System.Drawing.Size(358, 20);
            this.checkedListBoxTopGeneCount.TabIndex = 2;
            // 
            // textBoxFoldDifference
            // 
            this.textBoxFoldDifference.Location = new System.Drawing.Point(381, 33);
            this.textBoxFoldDifference.Name = "textBoxFoldDifference";
            this.textBoxFoldDifference.Size = new System.Drawing.Size(50, 21);
            this.textBoxFoldDifference.TabIndex = 1;
            this.textBoxFoldDifference.Text = "2";
            this.textBoxFoldDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fold Difference:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.radioButtonTop30);
            this.groupBox4.Controls.Add(this.radioButtonTop25);
            this.groupBox4.Controls.Add(this.radioButtonTop20);
            this.groupBox4.Controls.Add(this.radioButtonTop15);
            this.groupBox4.Controls.Add(this.radioButtonTop12);
            this.groupBox4.Controls.Add(this.radioButtonTop10);
            this.groupBox4.Controls.Add(this.radioButtonTop8);
            this.groupBox4.Controls.Add(this.radioButtonTop6);
            this.groupBox4.Controls.Add(this.radioButtonTop4);
            this.groupBox4.Controls.Add(this.radioButtonTop2);
            this.groupBox4.Controls.Add(this.buttonTestGeneExtrat);
            this.groupBox4.Controls.Add(this.buttonBrowseBestTrain);
            this.groupBox4.Controls.Add(this.textBoxBestTrainFile);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(540, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تطبیق ژن های تست";
            // 
            // buttonBrowseBestTrain
            // 
            this.buttonBrowseBestTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseBestTrain.Location = new System.Drawing.Point(6, 30);
            this.buttonBrowseBestTrain.Name = "buttonBrowseBestTrain";
            this.buttonBrowseBestTrain.Size = new System.Drawing.Size(100, 23);
            this.buttonBrowseBestTrain.TabIndex = 5;
            this.buttonBrowseBestTrain.Text = "Browse";
            this.buttonBrowseBestTrain.UseVisualStyleBackColor = true;
            this.buttonBrowseBestTrain.Click += new System.EventHandler(this.buttonBrowseBestTrain_Click);
            // 
            // textBoxBestTrainFile
            // 
            this.textBoxBestTrainFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBestTrainFile.Location = new System.Drawing.Point(112, 32);
            this.textBoxBestTrainFile.Name = "textBoxBestTrainFile";
            this.textBoxBestTrainFile.ReadOnly = true;
            this.textBoxBestTrainFile.Size = new System.Drawing.Size(299, 21);
            this.textBoxBestTrainFile.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "فایل آموزش انتخاب شده:";
            // 
            // buttonTestGeneExtrat
            // 
            this.buttonTestGeneExtrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTestGeneExtrat.Location = new System.Drawing.Point(6, 68);
            this.buttonTestGeneExtrat.Name = "buttonTestGeneExtrat";
            this.buttonTestGeneExtrat.Size = new System.Drawing.Size(100, 49);
            this.buttonTestGeneExtrat.TabIndex = 7;
            this.buttonTestGeneExtrat.Text = "اساخت فایل بهترین تست";
            this.buttonTestGeneExtrat.UseVisualStyleBackColor = true;
            this.buttonTestGeneExtrat.Click += new System.EventHandler(this.buttonTestGeneExtrat_Click);
            // 
            // radioButtonTop2
            // 
            this.radioButtonTop2.AutoSize = true;
            this.radioButtonTop2.Location = new System.Drawing.Point(486, 84);
            this.radioButtonTop2.Name = "radioButtonTop2";
            this.radioButtonTop2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonTop2.TabIndex = 8;
            this.radioButtonTop2.TabStop = true;
            this.radioButtonTop2.Text = "2";
            this.radioButtonTop2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop4
            // 
            this.radioButtonTop4.AutoSize = true;
            this.radioButtonTop4.Location = new System.Drawing.Point(449, 84);
            this.radioButtonTop4.Name = "radioButtonTop4";
            this.radioButtonTop4.Size = new System.Drawing.Size(31, 17);
            this.radioButtonTop4.TabIndex = 9;
            this.radioButtonTop4.TabStop = true;
            this.radioButtonTop4.Text = "4";
            this.radioButtonTop4.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop6
            // 
            this.radioButtonTop6.AutoSize = true;
            this.radioButtonTop6.Location = new System.Drawing.Point(412, 84);
            this.radioButtonTop6.Name = "radioButtonTop6";
            this.radioButtonTop6.Size = new System.Drawing.Size(31, 17);
            this.radioButtonTop6.TabIndex = 10;
            this.radioButtonTop6.TabStop = true;
            this.radioButtonTop6.Text = "6";
            this.radioButtonTop6.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop8
            // 
            this.radioButtonTop8.AutoSize = true;
            this.radioButtonTop8.Location = new System.Drawing.Point(375, 84);
            this.radioButtonTop8.Name = "radioButtonTop8";
            this.radioButtonTop8.Size = new System.Drawing.Size(31, 17);
            this.radioButtonTop8.TabIndex = 11;
            this.radioButtonTop8.TabStop = true;
            this.radioButtonTop8.Text = "8";
            this.radioButtonTop8.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop10
            // 
            this.radioButtonTop10.AutoSize = true;
            this.radioButtonTop10.Location = new System.Drawing.Point(332, 84);
            this.radioButtonTop10.Name = "radioButtonTop10";
            this.radioButtonTop10.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop10.TabIndex = 12;
            this.radioButtonTop10.TabStop = true;
            this.radioButtonTop10.Text = "10";
            this.radioButtonTop10.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop12
            // 
            this.radioButtonTop12.AutoSize = true;
            this.radioButtonTop12.Location = new System.Drawing.Point(289, 84);
            this.radioButtonTop12.Name = "radioButtonTop12";
            this.radioButtonTop12.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop12.TabIndex = 13;
            this.radioButtonTop12.TabStop = true;
            this.radioButtonTop12.Text = "12";
            this.radioButtonTop12.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop15
            // 
            this.radioButtonTop15.AutoSize = true;
            this.radioButtonTop15.Location = new System.Drawing.Point(246, 84);
            this.radioButtonTop15.Name = "radioButtonTop15";
            this.radioButtonTop15.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop15.TabIndex = 14;
            this.radioButtonTop15.TabStop = true;
            this.radioButtonTop15.Text = "15";
            this.radioButtonTop15.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop20
            // 
            this.radioButtonTop20.AutoSize = true;
            this.radioButtonTop20.Location = new System.Drawing.Point(203, 84);
            this.radioButtonTop20.Name = "radioButtonTop20";
            this.radioButtonTop20.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop20.TabIndex = 15;
            this.radioButtonTop20.TabStop = true;
            this.radioButtonTop20.Text = "20";
            this.radioButtonTop20.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop25
            // 
            this.radioButtonTop25.AutoSize = true;
            this.radioButtonTop25.Location = new System.Drawing.Point(160, 84);
            this.radioButtonTop25.Name = "radioButtonTop25";
            this.radioButtonTop25.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop25.TabIndex = 16;
            this.radioButtonTop25.TabStop = true;
            this.radioButtonTop25.Text = "25";
            this.radioButtonTop25.UseVisualStyleBackColor = true;
            // 
            // radioButtonTop30
            // 
            this.radioButtonTop30.AutoSize = true;
            this.radioButtonTop30.Location = new System.Drawing.Point(117, 84);
            this.radioButtonTop30.Name = "radioButtonTop30";
            this.radioButtonTop30.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTop30.TabIndex = 17;
            this.radioButtonTop30.TabStop = true;
            this.radioButtonTop30.Text = "30";
            this.radioButtonTop30.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "تعداد ژن انتخابی:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 601);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(580, 395);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیش بینی بیماری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrowseTestFile;
        private System.Windows.Forms.TextBox textBoxTestFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowseTrainFile;
        private System.Windows.Forms.TextBox textBoxTrainFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonReadFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonTrainClassFile;
        private System.Windows.Forms.TextBox textBoxTrainClassFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxTopGeneCount;
        private System.Windows.Forms.TextBox textBoxFoldDifference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCreateTopGenes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonTestGeneExtrat;
        private System.Windows.Forms.Button buttonBrowseBestTrain;
        private System.Windows.Forms.TextBox textBoxBestTrainFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonTop30;
        private System.Windows.Forms.RadioButton radioButtonTop25;
        private System.Windows.Forms.RadioButton radioButtonTop20;
        private System.Windows.Forms.RadioButton radioButtonTop15;
        private System.Windows.Forms.RadioButton radioButtonTop12;
        private System.Windows.Forms.RadioButton radioButtonTop10;
        private System.Windows.Forms.RadioButton radioButtonTop8;
        private System.Windows.Forms.RadioButton radioButtonTop6;
        private System.Windows.Forms.RadioButton radioButtonTop4;
        private System.Windows.Forms.RadioButton radioButtonTop2;
    }
}

