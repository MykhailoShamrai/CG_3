namespace GK_3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBoxSelectedImage = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonSeparateChannels = new Button();
            buttonLoadImage = new Button();
            groupBoxLabSettings = new GroupBox();
            comboBoxIlluminant = new ComboBox();
            comboBoxColorProfile = new ComboBox();
            numericUpDownGamma = new NumericUpDown();
            numericUpDownYW = new NumericUpDown();
            numericUpDownYB = new NumericUpDown();
            numericUpDownYG = new NumericUpDown();
            numericUpDownYR = new NumericUpDown();
            numericUpDownXW = new NumericUpDown();
            numericUpDownXB = new NumericUpDown();
            numericUpDownXG = new NumericUpDown();
            numericUpDownXR = new NumericUpDown();
            labelGamma = new Label();
            labelWhitePoint = new Label();
            labelBluePrimary = new Label();
            labelGreenPrimary = new Label();
            labelRedPrimary = new Label();
            labelY = new Label();
            labelX = new Label();
            labelCromaticity = new Label();
            labelPredefindedIlluminant = new Label();
            labelPredefinedColorProfile = new Label();
            comboBoxMode = new ComboBox();
            buttonSaveOutput = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelFirst = new Label();
            labelSecond = new Label();
            labelThird = new Label();
            pictureBoxFirst = new PictureBox();
            pictureBoxSecond = new PictureBox();
            pictureBoxThird = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBoxLabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGamma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXW).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXR).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThird).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1282, 853);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 700F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel2.Controls.Add(pictureBoxSelectedImage, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1276, 494);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxSelectedImage
            // 
            pictureBoxSelectedImage.Dock = DockStyle.Fill;
            pictureBoxSelectedImage.Location = new Point(3, 3);
            pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            pictureBoxSelectedImage.Size = new Size(694, 488);
            pictureBoxSelectedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSelectedImage.TabIndex = 0;
            pictureBoxSelectedImage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonSaveOutput, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(703, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(570, 488);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(buttonSeparateChannels, 0, 2);
            tableLayoutPanel4.Controls.Add(buttonLoadImage, 0, 0);
            tableLayoutPanel4.Controls.Add(groupBoxLabSettings, 0, 3);
            tableLayoutPanel4.Controls.Add(comboBoxMode, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 360F));
            tableLayoutPanel4.Size = new Size(408, 482);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // buttonSeparateChannels
            // 
            buttonSeparateChannels.Location = new Point(3, 87);
            buttonSeparateChannels.Name = "buttonSeparateChannels";
            buttonSeparateChannels.Size = new Size(191, 29);
            buttonSeparateChannels.TabIndex = 1;
            buttonSeparateChannels.Text = "Separate Channels";
            buttonSeparateChannels.UseVisualStyleBackColor = true;
            buttonSeparateChannels.Click += buttonSeparateChannels_Click;
            // 
            // buttonLoadImage
            // 
            buttonLoadImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonLoadImage.Location = new Point(3, 16);
            buttonLoadImage.Name = "buttonLoadImage";
            buttonLoadImage.Size = new Size(191, 29);
            buttonLoadImage.TabIndex = 1;
            buttonLoadImage.Text = "Load Image";
            buttonLoadImage.UseVisualStyleBackColor = true;
            buttonLoadImage.Click += buttonLoadImage_Click;
            // 
            // groupBoxLabSettings
            // 
            groupBoxLabSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxLabSettings.Controls.Add(comboBoxIlluminant);
            groupBoxLabSettings.Controls.Add(comboBoxColorProfile);
            groupBoxLabSettings.Controls.Add(numericUpDownGamma);
            groupBoxLabSettings.Controls.Add(numericUpDownYW);
            groupBoxLabSettings.Controls.Add(numericUpDownYB);
            groupBoxLabSettings.Controls.Add(numericUpDownYG);
            groupBoxLabSettings.Controls.Add(numericUpDownYR);
            groupBoxLabSettings.Controls.Add(numericUpDownXW);
            groupBoxLabSettings.Controls.Add(numericUpDownXB);
            groupBoxLabSettings.Controls.Add(numericUpDownXG);
            groupBoxLabSettings.Controls.Add(numericUpDownXR);
            groupBoxLabSettings.Controls.Add(labelGamma);
            groupBoxLabSettings.Controls.Add(labelWhitePoint);
            groupBoxLabSettings.Controls.Add(labelBluePrimary);
            groupBoxLabSettings.Controls.Add(labelGreenPrimary);
            groupBoxLabSettings.Controls.Add(labelRedPrimary);
            groupBoxLabSettings.Controls.Add(labelY);
            groupBoxLabSettings.Controls.Add(labelX);
            groupBoxLabSettings.Controls.Add(labelCromaticity);
            groupBoxLabSettings.Controls.Add(labelPredefindedIlluminant);
            groupBoxLabSettings.Controls.Add(labelPredefinedColorProfile);
            groupBoxLabSettings.Location = new Point(3, 124);
            groupBoxLabSettings.Name = "groupBoxLabSettings";
            groupBoxLabSettings.Size = new Size(357, 355);
            groupBoxLabSettings.TabIndex = 0;
            groupBoxLabSettings.TabStop = false;
            groupBoxLabSettings.Text = "Lab Settings";
            // 
            // comboBoxIlluminant
            // 
            comboBoxIlluminant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIlluminant.FormattingEnabled = true;
            comboBoxIlluminant.Location = new Point(188, 69);
            comboBoxIlluminant.Name = "comboBoxIlluminant";
            comboBoxIlluminant.Size = new Size(151, 28);
            comboBoxIlluminant.TabIndex = 20;
            comboBoxIlluminant.SelectedIndexChanged += comboBoxIlluminant_SelectedIndexChanged;
            // 
            // comboBoxColorProfile
            // 
            comboBoxColorProfile.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColorProfile.FormattingEnabled = true;
            comboBoxColorProfile.Location = new Point(188, 33);
            comboBoxColorProfile.Name = "comboBoxColorProfile";
            comboBoxColorProfile.Size = new Size(151, 28);
            comboBoxColorProfile.TabIndex = 19;
            comboBoxColorProfile.SelectedIndexChanged += comboBoxColorProfile_SelectedIndexChanged;
            // 
            // numericUpDownGamma
            // 
            numericUpDownGamma.DecimalPlaces = 2;
            numericUpDownGamma.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownGamma.Location = new Point(235, 320);
            numericUpDownGamma.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownGamma.Name = "numericUpDownGamma";
            numericUpDownGamma.Size = new Size(83, 27);
            numericUpDownGamma.TabIndex = 18;
            numericUpDownGamma.ValueChanged += numericUpDownGamma_ValueChanged;
            // 
            // numericUpDownYW
            // 
            numericUpDownYW.DecimalPlaces = 6;
            numericUpDownYW.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownYW.Location = new Point(235, 277);
            numericUpDownYW.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
            numericUpDownYW.Name = "numericUpDownYW";
            numericUpDownYW.Size = new Size(83, 27);
            numericUpDownYW.TabIndex = 17;
            numericUpDownYW.ValueChanged += numericUpDownYW_ValueChanged;
            // 
            // numericUpDownYB
            // 
            numericUpDownYB.DecimalPlaces = 6;
            numericUpDownYB.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownYB.Location = new Point(235, 239);
            numericUpDownYB.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
            numericUpDownYB.Name = "numericUpDownYB";
            numericUpDownYB.Size = new Size(83, 27);
            numericUpDownYB.TabIndex = 16;
            numericUpDownYB.ValueChanged += numericUpDownYB_ValueChanged;
            // 
            // numericUpDownYG
            // 
            numericUpDownYG.DecimalPlaces = 6;
            numericUpDownYG.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownYG.Location = new Point(235, 198);
            numericUpDownYG.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
            numericUpDownYG.Name = "numericUpDownYG";
            numericUpDownYG.Size = new Size(83, 27);
            numericUpDownYG.TabIndex = 15;
            numericUpDownYG.ValueChanged += numericUpDownYG_ValueChanged;
            // 
            // numericUpDownYR
            // 
            numericUpDownYR.DecimalPlaces = 6;
            numericUpDownYR.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownYR.Location = new Point(235, 158);
            numericUpDownYR.Maximum = new decimal(new int[] { 9, 0, 0, 65536 });
            numericUpDownYR.Name = "numericUpDownYR";
            numericUpDownYR.Size = new Size(83, 27);
            numericUpDownYR.TabIndex = 14;
            numericUpDownYR.ValueChanged += numericUpDownYR_ValueChanged;
            // 
            // numericUpDownXW
            // 
            numericUpDownXW.DecimalPlaces = 6;
            numericUpDownXW.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownXW.Location = new Point(119, 277);
            numericUpDownXW.Maximum = new decimal(new int[] { 735, 0, 0, 196608 });
            numericUpDownXW.Name = "numericUpDownXW";
            numericUpDownXW.Size = new Size(83, 27);
            numericUpDownXW.TabIndex = 13;
            numericUpDownXW.ValueChanged += numericUpDownXW_ValueChanged;
            // 
            // numericUpDownXB
            // 
            numericUpDownXB.DecimalPlaces = 6;
            numericUpDownXB.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownXB.Location = new Point(119, 239);
            numericUpDownXB.Maximum = new decimal(new int[] { 735, 0, 0, 196608 });
            numericUpDownXB.Name = "numericUpDownXB";
            numericUpDownXB.Size = new Size(83, 27);
            numericUpDownXB.TabIndex = 12;
            numericUpDownXB.ValueChanged += numericUpDownXB_ValueChanged;
            // 
            // numericUpDownXG
            // 
            numericUpDownXG.DecimalPlaces = 6;
            numericUpDownXG.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownXG.Location = new Point(119, 198);
            numericUpDownXG.Maximum = new decimal(new int[] { 735, 0, 0, 196608 });
            numericUpDownXG.Name = "numericUpDownXG";
            numericUpDownXG.Size = new Size(83, 27);
            numericUpDownXG.TabIndex = 11;
            numericUpDownXG.ValueChanged += numericUpDownXG_ValueChanged;
            // 
            // numericUpDownXR
            // 
            numericUpDownXR.DecimalPlaces = 6;
            numericUpDownXR.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownXR.Location = new Point(119, 158);
            numericUpDownXR.Maximum = new decimal(new int[] { 735, 0, 0, 196608 });
            numericUpDownXR.Name = "numericUpDownXR";
            numericUpDownXR.Size = new Size(83, 27);
            numericUpDownXR.TabIndex = 10;
            numericUpDownXR.ValueChanged += numericUpDownXR_ValueChanged;
            // 
            // labelGamma
            // 
            labelGamma.AutoSize = true;
            labelGamma.Location = new Point(160, 322);
            labelGamma.Name = "labelGamma";
            labelGamma.Size = new Size(61, 20);
            labelGamma.TabIndex = 9;
            labelGamma.Text = "Gamma";
            // 
            // labelWhitePoint
            // 
            labelWhitePoint.AutoSize = true;
            labelWhitePoint.Location = new Point(7, 277);
            labelWhitePoint.Name = "labelWhitePoint";
            labelWhitePoint.Size = new Size(87, 20);
            labelWhitePoint.TabIndex = 8;
            labelWhitePoint.Text = "White point";
            // 
            // labelBluePrimary
            // 
            labelBluePrimary.AutoSize = true;
            labelBluePrimary.Location = new Point(7, 239);
            labelBluePrimary.Name = "labelBluePrimary";
            labelBluePrimary.Size = new Size(93, 20);
            labelBluePrimary.TabIndex = 7;
            labelBluePrimary.Text = "Blue primary";
            // 
            // labelGreenPrimary
            // 
            labelGreenPrimary.AutoSize = true;
            labelGreenPrimary.Location = new Point(7, 198);
            labelGreenPrimary.Name = "labelGreenPrimary";
            labelGreenPrimary.Size = new Size(103, 20);
            labelGreenPrimary.TabIndex = 6;
            labelGreenPrimary.Text = "Green primary";
            // 
            // labelRedPrimary
            // 
            labelRedPrimary.AutoSize = true;
            labelRedPrimary.Location = new Point(7, 158);
            labelRedPrimary.Name = "labelRedPrimary";
            labelRedPrimary.Size = new Size(90, 20);
            labelRedPrimary.TabIndex = 5;
            labelRedPrimary.Text = "Red primary";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(235, 117);
            labelY.Name = "labelY";
            labelY.Size = new Size(16, 20);
            labelY.TabIndex = 4;
            labelY.Text = "y";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(119, 117);
            labelX.Name = "labelX";
            labelX.Size = new Size(16, 20);
            labelX.TabIndex = 3;
            labelX.Text = "x";
            // 
            // labelCromaticity
            // 
            labelCromaticity.AutoSize = true;
            labelCromaticity.Location = new Point(7, 117);
            labelCromaticity.Name = "labelCromaticity";
            labelCromaticity.Size = new Size(93, 20);
            labelCromaticity.TabIndex = 2;
            labelCromaticity.Text = "Chromaticity";
            // 
            // labelPredefindedIlluminant
            // 
            labelPredefindedIlluminant.AutoSize = true;
            labelPredefindedIlluminant.Location = new Point(6, 69);
            labelPredefindedIlluminant.Name = "labelPredefindedIlluminant";
            labelPredefindedIlluminant.Size = new Size(151, 20);
            labelPredefindedIlluminant.TabIndex = 1;
            labelPredefindedIlluminant.Text = "Predefined illuminant";
            // 
            // labelPredefinedColorProfile
            // 
            labelPredefinedColorProfile.AutoSize = true;
            labelPredefinedColorProfile.Location = new Point(6, 36);
            labelPredefinedColorProfile.Name = "labelPredefinedColorProfile";
            labelPredefinedColorProfile.Size = new Size(167, 20);
            labelPredefinedColorProfile.TabIndex = 0;
            labelPredefinedColorProfile.Text = "Predefined color profile";
            // 
            // comboBoxMode
            // 
            comboBoxMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMode.FormattingEnabled = true;
            comboBoxMode.Location = new Point(3, 51);
            comboBoxMode.Name = "comboBoxMode";
            comboBoxMode.Size = new Size(191, 28);
            comboBoxMode.TabIndex = 2;
            comboBoxMode.SelectedIndexChanged += comboBoxMode_SelectedIndexChanged;
            // 
            // buttonSaveOutput
            // 
            buttonSaveOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveOutput.Location = new Point(439, 456);
            buttonSaveOutput.Name = "buttonSaveOutput";
            buttonSaveOutput.Size = new Size(128, 29);
            buttonSaveOutput.TabIndex = 1;
            buttonSaveOutput.Text = "Save Output";
            buttonSaveOutput.UseVisualStyleBackColor = true;
            buttonSaveOutput.Click += buttonSaveOutput_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 433F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 433F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 433F));
            tableLayoutPanel5.Controls.Add(labelFirst, 0, 0);
            tableLayoutPanel5.Controls.Add(labelSecond, 1, 0);
            tableLayoutPanel5.Controls.Add(labelThird, 2, 0);
            tableLayoutPanel5.Controls.Add(pictureBoxFirst, 0, 1);
            tableLayoutPanel5.Controls.Add(pictureBoxSecond, 1, 1);
            tableLayoutPanel5.Controls.Add(pictureBoxThird, 2, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 503);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 307F));
            tableLayoutPanel5.Size = new Size(1276, 347);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // labelFirst
            // 
            labelFirst.AutoSize = true;
            labelFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFirst.Location = new Point(3, 0);
            labelFirst.Name = "labelFirst";
            labelFirst.Size = new Size(18, 20);
            labelFirst.TabIndex = 0;
            labelFirst.Text = "Y";
            // 
            // labelSecond
            // 
            labelSecond.AutoSize = true;
            labelSecond.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSecond.Location = new Point(436, 0);
            labelSecond.Name = "labelSecond";
            labelSecond.Size = new Size(27, 20);
            labelSecond.TabIndex = 1;
            labelSecond.Text = "Cb";
            // 
            // labelThird
            // 
            labelThird.AutoSize = true;
            labelThird.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelThird.Location = new Point(869, 0);
            labelThird.Name = "labelThird";
            labelThird.Size = new Size(24, 20);
            labelThird.TabIndex = 2;
            labelThird.Text = "Cr";
            // 
            // pictureBoxFirst
            // 
            pictureBoxFirst.Dock = DockStyle.Fill;
            pictureBoxFirst.Location = new Point(3, 43);
            pictureBoxFirst.Name = "pictureBoxFirst";
            pictureBoxFirst.Size = new Size(427, 301);
            pictureBoxFirst.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFirst.TabIndex = 3;
            pictureBoxFirst.TabStop = false;
            // 
            // pictureBoxSecond
            // 
            pictureBoxSecond.Dock = DockStyle.Fill;
            pictureBoxSecond.Location = new Point(436, 43);
            pictureBoxSecond.Name = "pictureBoxSecond";
            pictureBoxSecond.Size = new Size(427, 301);
            pictureBoxSecond.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSecond.TabIndex = 4;
            pictureBoxSecond.TabStop = false;
            // 
            // pictureBoxThird
            // 
            pictureBoxThird.Dock = DockStyle.Fill;
            pictureBoxThird.Location = new Point(869, 43);
            pictureBoxThird.Name = "pictureBoxThird";
            pictureBoxThird.Size = new Size(427, 301);
            pictureBoxThird.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxThird.TabIndex = 5;
            pictureBoxThird.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 853);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Color Extractor";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBoxLabSettings.ResumeLayout(false);
            groupBoxLabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGamma).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYW).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYR).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXW).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownXR).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBoxSelectedImage;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBoxLabSettings;
        private Button buttonLoadImage;
        private Button buttonSeparateChannels;
        private Button buttonSaveOutput;
        private Label labelGamma;
        private Label labelWhitePoint;
        private Label labelBluePrimary;
        private Label labelGreenPrimary;
        private Label labelRedPrimary;
        private Label labelY;
        private Label labelX;
        private Label labelCromaticity;
        private Label labelPredefindedIlluminant;
        private Label labelPredefinedColorProfile;
        private NumericUpDown numericUpDownGamma;
        private NumericUpDown numericUpDownYW;
        private NumericUpDown numericUpDownYB;
        private NumericUpDown numericUpDownYG;
        private NumericUpDown numericUpDownYR;
        private NumericUpDown numericUpDownXW;
        private NumericUpDown numericUpDownXB;
        private NumericUpDown numericUpDownXG;
        private NumericUpDown numericUpDownXR;
        private TableLayoutPanel tableLayoutPanel5;
        private Label labelFirst;
        private Label labelSecond;
        private Label labelThird;
        private PictureBox pictureBoxFirst;
        private PictureBox pictureBoxSecond;
        private PictureBox pictureBoxThird;
        private ComboBox comboBoxMode;
        private ComboBox comboBoxIlluminant;
        private ComboBox comboBoxColorProfile;
    }
}
