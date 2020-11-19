namespace Watermarker
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
            this.textSource = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.buttonImage = new System.Windows.Forms.Button();
            this.textImage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackAlpha = new System.Windows.Forms.TrackBar();
            this.buttonColor = new System.Windows.Forms.Button();
            this.checkResize = new System.Windows.Forms.CheckBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textShadowOffset = new System.Windows.Forms.TextBox();
            this.checkShadow = new System.Windows.Forms.CheckBox();
            this.checkAlign9 = new System.Windows.Forms.RadioButton();
            this.checkAlign8 = new System.Windows.Forms.RadioButton();
            this.textOffsetX = new System.Windows.Forms.TextBox();
            this.checkAlign7 = new System.Windows.Forms.RadioButton();
            this.textOffsetY = new System.Windows.Forms.TextBox();
            this.checkAlign6 = new System.Windows.Forms.RadioButton();
            this.checkAlign1 = new System.Windows.Forms.RadioButton();
            this.checkAlign5 = new System.Windows.Forms.RadioButton();
            this.checkAlign2 = new System.Windows.Forms.RadioButton();
            this.checkAlign4 = new System.Windows.Forms.RadioButton();
            this.checkAlign3 = new System.Windows.Forms.RadioButton();
            this.textWatermark = new System.Windows.Forms.TextBox();
            this.radioImage = new System.Windows.Forms.RadioButton();
            this.textSuffix = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // textSource
            // 
            this.textSource.Location = new System.Drawing.Point(64, 19);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(258, 20);
            this.textSource.TabIndex = 0;
            this.textSource.TextChanged += new System.EventHandler(this.textSource_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Select source image";
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(328, 19);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(38, 20);
            this.buttonSource.TabIndex = 1;
            this.buttonSource.Text = "...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(304, 480);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Source :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Alpha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Offset X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Offset Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 39;
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(10, 48);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(39, 13);
            this.labelSuffix.TabIndex = 41;
            this.labelSuffix.Text = "Suffix :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Shadow Offset:";
            // 
            // labelAlpha
            // 
            this.labelAlpha.Location = new System.Drawing.Point(325, 47);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(41, 22);
            this.labelAlpha.TabIndex = 44;
            this.labelAlpha.Text = "255";
            this.labelAlpha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(328, 24);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(38, 20);
            this.buttonFont.TabIndex = 45;
            this.buttonFont.Text = "...";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click_1);
            // 
            // radioText
            // 
            this.radioText.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioText.Location = new System.Drawing.Point(9, 21);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(70, 24);
            this.radioText.TabIndex = 46;
            this.radioText.Text = "Text :";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.CheckedChanged += new System.EventHandler(this.radioText_CheckedChanged);
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(328, 78);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(38, 20);
            this.buttonImage.TabIndex = 49;
            this.buttonImage.Text = "...";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(85, 78);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(237, 20);
            this.textImage.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSource);
            this.groupBox1.Controls.Add(this.textSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textSuffix);
            this.groupBox1.Controls.Add(this.labelSuffix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 79);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textWatermark);
            this.groupBox2.Controls.Add(this.buttonImage);
            this.groupBox2.Controls.Add(this.buttonFont);
            this.groupBox2.Controls.Add(this.textImage);
            this.groupBox2.Controls.Add(this.radioText);
            this.groupBox2.Controls.Add(this.radioImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 113);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watermark Type : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.trackAlpha);
            this.groupBox3.Controls.Add(this.buttonColor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.checkResize);
            this.groupBox3.Controls.Add(this.labelAlpha);
            this.groupBox3.Controls.Add(this.textWidth);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textHeight);
            this.groupBox3.Controls.Add(this.textShadowOffset);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.checkShadow);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.checkAlign9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkAlign8);
            this.groupBox3.Controls.Add(this.textOffsetX);
            this.groupBox3.Controls.Add(this.checkAlign7);
            this.groupBox3.Controls.Add(this.textOffsetY);
            this.groupBox3.Controls.Add(this.checkAlign6);
            this.groupBox3.Controls.Add(this.checkAlign1);
            this.groupBox3.Controls.Add(this.checkAlign5);
            this.groupBox3.Controls.Add(this.checkAlign2);
            this.groupBox3.Controls.Add(this.checkAlign4);
            this.groupBox3.Controls.Add(this.checkAlign3);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 258);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attributes : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Color :";
            // 
            // trackAlpha
            // 
            this.trackAlpha.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Watermarker.Properties.Settings.Default, "Alpha", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackAlpha.Location = new System.Drawing.Point(57, 47);
            this.trackAlpha.Maximum = 255;
            this.trackAlpha.Name = "trackAlpha";
            this.trackAlpha.Size = new System.Drawing.Size(277, 42);
            this.trackAlpha.TabIndex = 22;
            this.trackAlpha.TickFrequency = 10;
            this.trackAlpha.Value = global::Watermarker.Properties.Settings.Default.Alpha;
            this.trackAlpha.Scroll += new System.EventHandler(this.trackAlpha_Scroll);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = global::Watermarker.Properties.Settings.Default.Color;
            this.buttonColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Watermarker.Properties.Settings.Default, "Color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonColor.Location = new System.Drawing.Point(64, 19);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(39, 20);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // checkResize
            // 
            this.checkResize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkResize.Checked = global::Watermarker.Properties.Settings.Default.Resize;
            this.checkResize.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Resize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkResize.Location = new System.Drawing.Point(9, 194);
            this.checkResize.Name = "checkResize";
            this.checkResize.Size = new System.Drawing.Size(68, 24);
            this.checkResize.TabIndex = 18;
            this.checkResize.Text = "Resize:";
            this.checkResize.UseVisualStyleBackColor = true;
            this.checkResize.CheckedChanged += new System.EventHandler(this.checkResize_CheckedChanged);
            // 
            // textWidth
            // 
            this.textWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "Width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textWidth.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Watermarker.Properties.Settings.Default, "Resize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textWidth.Enabled = global::Watermarker.Properties.Settings.Default.Resize;
            this.textWidth.Location = new System.Drawing.Point(197, 196);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(46, 20);
            this.textWidth.TabIndex = 19;
            this.textWidth.Text = global::Watermarker.Properties.Settings.Default.Width;
            this.textWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textHeight
            // 
            this.textHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textHeight.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Watermarker.Properties.Settings.Default, "Resize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textHeight.Enabled = global::Watermarker.Properties.Settings.Default.Resize;
            this.textHeight.Location = new System.Drawing.Point(267, 196);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(46, 20);
            this.textHeight.TabIndex = 20;
            this.textHeight.Text = global::Watermarker.Properties.Settings.Default.Height;
            this.textHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textShadowOffset
            // 
            this.textShadowOffset.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "ShadowOffset", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textShadowOffset.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::Watermarker.Properties.Settings.Default, "Shadow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textShadowOffset.Enabled = global::Watermarker.Properties.Settings.Default.Shadow;
            this.textShadowOffset.Location = new System.Drawing.Point(197, 227);
            this.textShadowOffset.Name = "textShadowOffset";
            this.textShadowOffset.Size = new System.Drawing.Size(46, 20);
            this.textShadowOffset.TabIndex = 42;
            this.textShadowOffset.Text = global::Watermarker.Properties.Settings.Default.ShadowOffset;
            this.textShadowOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkShadow
            // 
            this.checkShadow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkShadow.Checked = global::Watermarker.Properties.Settings.Default.Shadow;
            this.checkShadow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Shadow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkShadow.Location = new System.Drawing.Point(9, 225);
            this.checkShadow.Name = "checkShadow";
            this.checkShadow.Size = new System.Drawing.Size(68, 24);
            this.checkShadow.TabIndex = 37;
            this.checkShadow.Text = "Shadow:";
            this.checkShadow.UseVisualStyleBackColor = true;
            this.checkShadow.CheckedChanged += new System.EventHandler(this.checkShadow_CheckedChanged);
            // 
            // checkAlign9
            // 
            this.checkAlign9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign9.Checked = global::Watermarker.Properties.Settings.Default.Align9;
            this.checkAlign9.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align9", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign9.Location = new System.Drawing.Point(126, 157);
            this.checkAlign9.Name = "checkAlign9";
            this.checkAlign9.Size = new System.Drawing.Size(25, 25);
            this.checkAlign9.TabIndex = 36;
            this.checkAlign9.UseVisualStyleBackColor = true;
            // 
            // checkAlign8
            // 
            this.checkAlign8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign8.Checked = global::Watermarker.Properties.Settings.Default.Align8;
            this.checkAlign8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align8", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign8.Location = new System.Drawing.Point(95, 157);
            this.checkAlign8.Name = "checkAlign8";
            this.checkAlign8.Size = new System.Drawing.Size(25, 25);
            this.checkAlign8.TabIndex = 35;
            this.checkAlign8.UseVisualStyleBackColor = true;
            // 
            // textOffsetX
            // 
            this.textOffsetX.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "OffsetX", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textOffsetX.Location = new System.Drawing.Point(221, 95);
            this.textOffsetX.Name = "textOffsetX";
            this.textOffsetX.Size = new System.Drawing.Size(46, 20);
            this.textOffsetX.TabIndex = 26;
            this.textOffsetX.Text = global::Watermarker.Properties.Settings.Default.OffsetX;
            this.textOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkAlign7
            // 
            this.checkAlign7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign7.Checked = global::Watermarker.Properties.Settings.Default.Align7;
            this.checkAlign7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align7", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign7.Location = new System.Drawing.Point(64, 157);
            this.checkAlign7.Name = "checkAlign7";
            this.checkAlign7.Size = new System.Drawing.Size(25, 25);
            this.checkAlign7.TabIndex = 34;
            this.checkAlign7.UseVisualStyleBackColor = true;
            // 
            // textOffsetY
            // 
            this.textOffsetY.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "OffsetY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textOffsetY.Location = new System.Drawing.Point(221, 121);
            this.textOffsetY.Name = "textOffsetY";
            this.textOffsetY.Size = new System.Drawing.Size(46, 20);
            this.textOffsetY.TabIndex = 27;
            this.textOffsetY.Text = global::Watermarker.Properties.Settings.Default.OffsetY;
            this.textOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkAlign6
            // 
            this.checkAlign6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign6.Checked = global::Watermarker.Properties.Settings.Default.Align6;
            this.checkAlign6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align6", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign6.Location = new System.Drawing.Point(126, 126);
            this.checkAlign6.Name = "checkAlign6";
            this.checkAlign6.Size = new System.Drawing.Size(25, 25);
            this.checkAlign6.TabIndex = 33;
            this.checkAlign6.UseVisualStyleBackColor = true;
            // 
            // checkAlign1
            // 
            this.checkAlign1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign1.Checked = global::Watermarker.Properties.Settings.Default.Align1;
            this.checkAlign1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign1.Location = new System.Drawing.Point(64, 95);
            this.checkAlign1.Name = "checkAlign1";
            this.checkAlign1.Size = new System.Drawing.Size(25, 25);
            this.checkAlign1.TabIndex = 28;
            this.checkAlign1.UseVisualStyleBackColor = true;
            // 
            // checkAlign5
            // 
            this.checkAlign5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign5.Checked = global::Watermarker.Properties.Settings.Default.Align5;
            this.checkAlign5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign5.Location = new System.Drawing.Point(95, 126);
            this.checkAlign5.Name = "checkAlign5";
            this.checkAlign5.Size = new System.Drawing.Size(25, 25);
            this.checkAlign5.TabIndex = 32;
            this.checkAlign5.UseVisualStyleBackColor = true;
            // 
            // checkAlign2
            // 
            this.checkAlign2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign2.Checked = global::Watermarker.Properties.Settings.Default.Align2;
            this.checkAlign2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign2.Location = new System.Drawing.Point(95, 95);
            this.checkAlign2.Name = "checkAlign2";
            this.checkAlign2.Size = new System.Drawing.Size(25, 25);
            this.checkAlign2.TabIndex = 29;
            this.checkAlign2.UseVisualStyleBackColor = true;
            // 
            // checkAlign4
            // 
            this.checkAlign4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign4.Checked = global::Watermarker.Properties.Settings.Default.Align4;
            this.checkAlign4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign4.Location = new System.Drawing.Point(64, 126);
            this.checkAlign4.Name = "checkAlign4";
            this.checkAlign4.Size = new System.Drawing.Size(25, 25);
            this.checkAlign4.TabIndex = 31;
            this.checkAlign4.UseVisualStyleBackColor = true;
            // 
            // checkAlign3
            // 
            this.checkAlign3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAlign3.Checked = global::Watermarker.Properties.Settings.Default.Align3;
            this.checkAlign3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "Align3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkAlign3.Location = new System.Drawing.Point(126, 95);
            this.checkAlign3.Name = "checkAlign3";
            this.checkAlign3.Size = new System.Drawing.Size(25, 25);
            this.checkAlign3.TabIndex = 30;
            this.checkAlign3.UseVisualStyleBackColor = true;
            // 
            // textWatermark
            // 
            this.textWatermark.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "Watermark", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textWatermark.Location = new System.Drawing.Point(85, 24);
            this.textWatermark.Multiline = true;
            this.textWatermark.Name = "textWatermark";
            this.textWatermark.Size = new System.Drawing.Size(237, 41);
            this.textWatermark.TabIndex = 3;
            this.textWatermark.Text = global::Watermarker.Properties.Settings.Default.Watermark;
            // 
            // radioImage
            // 
            this.radioImage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioImage.Checked = global::Watermarker.Properties.Settings.Default.WatermarkImage;
            this.radioImage.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Watermarker.Properties.Settings.Default, "WatermarkImage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioImage.Location = new System.Drawing.Point(9, 75);
            this.radioImage.Name = "radioImage";
            this.radioImage.Size = new System.Drawing.Size(70, 24);
            this.radioImage.TabIndex = 47;
            this.radioImage.TabStop = true;
            this.radioImage.Text = "Image :";
            this.radioImage.UseVisualStyleBackColor = true;
            this.radioImage.CheckedChanged += new System.EventHandler(this.radioImage_CheckedChanged);
            // 
            // textSuffix
            // 
            this.textSuffix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Watermarker.Properties.Settings.Default, "Suffix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textSuffix.Location = new System.Drawing.Point(64, 45);
            this.textSuffix.Name = "textSuffix";
            this.textSuffix.Size = new System.Drawing.Size(258, 20);
            this.textSuffix.TabIndex = 40;
            this.textSuffix.Text = global::Watermarker.Properties.Settings.Default.Suffix;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = global::Watermarker.Properties.Settings.Default.Color;
            // 
            // fontDialog1
            // 
            this.fontDialog1.AllowSimulations = false;
            this.fontDialog1.Font = global::Watermarker.Properties.Settings.Default.Font;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(112, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 20);
            this.button1.TabIndex = 46;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Resize Dimensions:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAlpha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textWatermark;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkResize;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackAlpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textOffsetY;
        private System.Windows.Forms.TextBox textOffsetX;
        private System.Windows.Forms.RadioButton checkAlign1;
        private System.Windows.Forms.RadioButton checkAlign2;
        private System.Windows.Forms.RadioButton checkAlign3;
        private System.Windows.Forms.RadioButton checkAlign4;
        private System.Windows.Forms.RadioButton checkAlign5;
        private System.Windows.Forms.RadioButton checkAlign6;
        private System.Windows.Forms.RadioButton checkAlign7;
        private System.Windows.Forms.RadioButton checkAlign8;
        private System.Windows.Forms.RadioButton checkAlign9;
        private System.Windows.Forms.CheckBox checkShadow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.TextBox textSuffix;
        private System.Windows.Forms.TextBox textShadowOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.RadioButton radioText;
        private System.Windows.Forms.RadioButton radioImage;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.TextBox textImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
    }
}

