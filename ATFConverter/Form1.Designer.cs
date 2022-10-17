namespace ATFConverter {
    partial class MainForm {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.mipMapCheckBox = new System.Windows.Forms.CheckBox();
            this.checkJPEGLZMA = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stack = new System.Windows.Forms.FlowLayoutPanel();
            this.radioIOS = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkSETC2 = new System.Windows.Forms.CheckBox();
            this.textIOS = new System.Windows.Forms.TextBox();
            this.textAndroid = new System.Windows.Forms.TextBox();
            this.textWinMac = new System.Windows.Forms.TextBox();
            this.checkSPVRTC = new System.Windows.Forms.CheckBox();
            this.checkSETC1 = new System.Windows.Forms.CheckBox();
            this.checkSDXT1 = new System.Windows.Forms.CheckBox();
            this.radioAllPlatforms = new System.Windows.Forms.RadioButton();
            this.radioAndroidETC1 = new System.Windows.Forms.RadioButton();
            this.radioWinMac = new System.Windows.Forms.RadioButton();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioAndroidETC2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQuantization = new System.Windows.Forms.TextBox();
            this.checkBoxQuantization = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxTrim = new System.Windows.Forms.CheckBox();
            this.textBoxTrim = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "drop space";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mipMapCheckBox
            // 
            this.mipMapCheckBox.AutoSize = true;
            this.mipMapCheckBox.BackColor = System.Drawing.Color.DarkGray;
            this.mipMapCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mipMapCheckBox.Location = new System.Drawing.Point(0, 151);
            this.mipMapCheckBox.Name = "mipMapCheckBox";
            this.mipMapCheckBox.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.mipMapCheckBox.Size = new System.Drawing.Size(469, 19);
            this.mipMapCheckBox.TabIndex = 2;
            this.mipMapCheckBox.Text = "Mip map";
            this.mipMapCheckBox.UseVisualStyleBackColor = false;
            // 
            // checkJPEGLZMA
            // 
            this.checkJPEGLZMA.AutoSize = true;
            this.checkJPEGLZMA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.checkJPEGLZMA.Checked = true;
            this.checkJPEGLZMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkJPEGLZMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkJPEGLZMA.Enabled = false;
            this.checkJPEGLZMA.Location = new System.Drawing.Point(0, 320);
            this.checkJPEGLZMA.Name = "checkJPEGLZMA";
            this.checkJPEGLZMA.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.checkJPEGLZMA.Size = new System.Drawing.Size(469, 19);
            this.checkJPEGLZMA.TabIndex = 6;
            this.checkJPEGLZMA.Text = "JPEG-XR+LZMA";
            this.checkJPEGLZMA.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(469, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Block compressed (PVRTC, ETC1, DXT1)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(0, 128);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(469, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Use mip mapping";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(0, 294);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(469, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Compress block compressed textures using JPEG-XR+LZMA to reduce file size";
            // 
            // stack
            // 
            this.stack.AutoScroll = true;
            this.stack.BackColor = System.Drawing.Color.Silver;
            this.stack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.stack.Location = new System.Drawing.Point(0, 426);
            this.stack.Name = "stack";
            this.stack.Size = new System.Drawing.Size(469, 155);
            this.stack.TabIndex = 10;
            this.stack.WrapContents = false;
            this.stack.Resize += new System.EventHandler(this.OnResizeStack);
            // 
            // radioIOS
            // 
            this.radioIOS.AutoSize = true;
            this.radioIOS.BackColor = System.Drawing.Color.DarkGray;
            this.radioIOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioIOS.Location = new System.Drawing.Point(0, 60);
            this.radioIOS.Name = "radioIOS";
            this.radioIOS.Size = new System.Drawing.Size(469, 17);
            this.radioIOS.TabIndex = 0;
            this.radioIOS.Text = "iOS                                    PVRTC4bpp";
            this.radioIOS.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(0, 400);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(469, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stack";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Silver;
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.checkSETC2);
            this.groupBox.Controls.Add(this.textIOS);
            this.groupBox.Controls.Add(this.textAndroid);
            this.groupBox.Controls.Add(this.textWinMac);
            this.groupBox.Controls.Add(this.checkSPVRTC);
            this.groupBox.Controls.Add(this.checkSETC1);
            this.groupBox.Controls.Add(this.checkSDXT1);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 339);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(469, 61);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "separate conversion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "_etc2";
            this.textBox1.WordWrap = false;
            // 
            // checkSETC2
            // 
            this.checkSETC2.AutoSize = true;
            this.checkSETC2.Location = new System.Drawing.Point(335, 15);
            this.checkSETC2.Name = "checkSETC2";
            this.checkSETC2.Size = new System.Drawing.Size(53, 17);
            this.checkSETC2.TabIndex = 6;
            this.checkSETC2.Text = "ETC2";
            this.checkSETC2.UseVisualStyleBackColor = true;
            // 
            // textIOS
            // 
            this.textIOS.Location = new System.Drawing.Point(228, 32);
            this.textIOS.Name = "textIOS";
            this.textIOS.Size = new System.Drawing.Size(100, 20);
            this.textIOS.TabIndex = 5;
            this.textIOS.Text = "_pvrtc";
            this.textIOS.WordWrap = false;
            // 
            // textAndroid
            // 
            this.textAndroid.Location = new System.Drawing.Point(116, 32);
            this.textAndroid.Name = "textAndroid";
            this.textAndroid.Size = new System.Drawing.Size(100, 20);
            this.textAndroid.TabIndex = 4;
            this.textAndroid.Text = "_etc1";
            this.textAndroid.WordWrap = false;
            // 
            // textWinMac
            // 
            this.textWinMac.Location = new System.Drawing.Point(3, 32);
            this.textWinMac.Name = "textWinMac";
            this.textWinMac.Size = new System.Drawing.Size(100, 20);
            this.textWinMac.TabIndex = 3;
            this.textWinMac.Text = "_browser";
            this.textWinMac.WordWrap = false;
            // 
            // checkSPVRTC
            // 
            this.checkSPVRTC.AutoSize = true;
            this.checkSPVRTC.Location = new System.Drawing.Point(228, 15);
            this.checkSPVRTC.Name = "checkSPVRTC";
            this.checkSPVRTC.Size = new System.Drawing.Size(86, 17);
            this.checkSPVRTC.TabIndex = 2;
            this.checkSPVRTC.Text = "PVRTC4bpp";
            this.checkSPVRTC.UseVisualStyleBackColor = true;
            // 
            // checkSETC1
            // 
            this.checkSETC1.AutoSize = true;
            this.checkSETC1.Location = new System.Drawing.Point(116, 15);
            this.checkSETC1.Name = "checkSETC1";
            this.checkSETC1.Size = new System.Drawing.Size(53, 17);
            this.checkSETC1.TabIndex = 1;
            this.checkSETC1.Text = "ETC1";
            this.checkSETC1.UseVisualStyleBackColor = true;
            // 
            // checkSDXT1
            // 
            this.checkSDXT1.AutoSize = true;
            this.checkSDXT1.Location = new System.Drawing.Point(3, 15);
            this.checkSDXT1.Name = "checkSDXT1";
            this.checkSDXT1.Size = new System.Drawing.Size(54, 17);
            this.checkSDXT1.TabIndex = 0;
            this.checkSDXT1.Text = "DXT1";
            this.checkSDXT1.UseVisualStyleBackColor = true;
            // 
            // radioAllPlatforms
            // 
            this.radioAllPlatforms.AutoSize = true;
            this.radioAllPlatforms.BackColor = System.Drawing.Color.DarkGray;
            this.radioAllPlatforms.Checked = true;
            this.radioAllPlatforms.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAllPlatforms.Location = new System.Drawing.Point(0, 26);
            this.radioAllPlatforms.Name = "radioAllPlatforms";
            this.radioAllPlatforms.Size = new System.Drawing.Size(469, 17);
            this.radioAllPlatforms.TabIndex = 13;
            this.radioAllPlatforms.TabStop = true;
            this.radioAllPlatforms.Text = "All Platforms";
            this.radioAllPlatforms.UseVisualStyleBackColor = false;
            this.radioAllPlatforms.CheckedChanged += new System.EventHandler(this.OnChangeNone);
            // 
            // radioAndroidETC1
            // 
            this.radioAndroidETC1.AutoSize = true;
            this.radioAndroidETC1.BackColor = System.Drawing.Color.Silver;
            this.radioAndroidETC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAndroidETC1.Location = new System.Drawing.Point(0, 77);
            this.radioAndroidETC1.Name = "radioAndroidETC1";
            this.radioAndroidETC1.Size = new System.Drawing.Size(469, 17);
            this.radioAndroidETC1.TabIndex = 14;
            this.radioAndroidETC1.Text = "Android                              ETC1";
            this.radioAndroidETC1.UseVisualStyleBackColor = false;
            // 
            // radioWinMac
            // 
            this.radioWinMac.AutoSize = true;
            this.radioWinMac.BackColor = System.Drawing.Color.Silver;
            this.radioWinMac.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioWinMac.Location = new System.Drawing.Point(0, 111);
            this.radioWinMac.Name = "radioWinMac";
            this.radioWinMac.Size = new System.Drawing.Size(469, 17);
            this.radioWinMac.TabIndex = 17;
            this.radioWinMac.Text = "Win/Mac OS                     DXT1";
            this.radioWinMac.UseVisualStyleBackColor = false;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.BackColor = System.Drawing.Color.Silver;
            this.radioNone.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioNone.Location = new System.Drawing.Point(0, 43);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(469, 17);
            this.radioNone.TabIndex = 18;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = false;
            this.radioNone.CheckedChanged += new System.EventHandler(this.OnChangeNone);
            // 
            // radioAndroidETC2
            // 
            this.radioAndroidETC2.AutoSize = true;
            this.radioAndroidETC2.BackColor = System.Drawing.Color.DarkGray;
            this.radioAndroidETC2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioAndroidETC2.Location = new System.Drawing.Point(0, 94);
            this.radioAndroidETC2.Name = "radioAndroidETC2";
            this.radioAndroidETC2.Size = new System.Drawing.Size(469, 17);
            this.radioAndroidETC2.TabIndex = 19;
            this.radioAndroidETC2.Text = "Android                              ETC2";
            this.radioAndroidETC2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(0, 170);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(469, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantization level. 0 == lossless. (default is 30 for standard textures and 0 for" +
    " block compressed textures)";
            // 
            // textBoxQuantization
            // 
            this.textBoxQuantization.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxQuantization.Location = new System.Drawing.Point(0, 212);
            this.textBoxQuantization.Name = "textBoxQuantization";
            this.textBoxQuantization.Size = new System.Drawing.Size(469, 20);
            this.textBoxQuantization.TabIndex = 8;
            this.textBoxQuantization.Text = "30";
            this.textBoxQuantization.WordWrap = false;
            // 
            // checkBoxQuantization
            // 
            this.checkBoxQuantization.AutoSize = true;
            this.checkBoxQuantization.BackColor = System.Drawing.Color.DarkGray;
            this.checkBoxQuantization.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxQuantization.Location = new System.Drawing.Point(0, 193);
            this.checkBoxQuantization.Name = "checkBoxQuantization";
            this.checkBoxQuantization.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.checkBoxQuantization.Size = new System.Drawing.Size(469, 19);
            this.checkBoxQuantization.TabIndex = 20;
            this.checkBoxQuantization.Text = "Quantization";
            this.checkBoxQuantization.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(0, 232);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(469, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Trim flex bits. 0 == lossless. (default is 0)";
            // 
            // checkBoxTrim
            // 
            this.checkBoxTrim.AutoSize = true;
            this.checkBoxTrim.BackColor = System.Drawing.Color.DarkGray;
            this.checkBoxTrim.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxTrim.Location = new System.Drawing.Point(0, 255);
            this.checkBoxTrim.Name = "checkBoxTrim";
            this.checkBoxTrim.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.checkBoxTrim.Size = new System.Drawing.Size(469, 19);
            this.checkBoxTrim.TabIndex = 23;
            this.checkBoxTrim.Text = "Trim";
            this.checkBoxTrim.UseVisualStyleBackColor = false;
            // 
            // textBoxTrim
            // 
            this.textBoxTrim.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTrim.Location = new System.Drawing.Point(0, 274);
            this.textBoxTrim.Name = "textBoxTrim";
            this.textBoxTrim.Size = new System.Drawing.Size(469, 20);
            this.textBoxTrim.TabIndex = 24;
            this.textBoxTrim.Text = "0";
            this.textBoxTrim.WordWrap = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(469, 581);
            this.Controls.Add(this.stack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.checkJPEGLZMA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTrim);
            this.Controls.Add(this.checkBoxTrim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantization);
            this.Controls.Add(this.checkBoxQuantization);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mipMapCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioWinMac);
            this.Controls.Add(this.radioAndroidETC2);
            this.Controls.Add(this.radioAndroidETC1);
            this.Controls.Add(this.radioIOS);
            this.Controls.Add(this.radioNone);
            this.Controls.Add(this.radioAllPlatforms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ATF";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFormDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFormDragEnter);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox mipMapCheckBox;
        private System.Windows.Forms.CheckBox checkJPEGLZMA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel stack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkSPVRTC;
        private System.Windows.Forms.CheckBox checkSETC1;
        private System.Windows.Forms.CheckBox checkSDXT1;
        private System.Windows.Forms.TextBox textIOS;
        private System.Windows.Forms.TextBox textAndroid;
        private System.Windows.Forms.TextBox textWinMac;
        private System.Windows.Forms.RadioButton radioIOS;
        private System.Windows.Forms.RadioButton radioAllPlatforms;
        private System.Windows.Forms.RadioButton radioAndroidETC1;
        private System.Windows.Forms.RadioButton radioWinMac;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioAndroidETC2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkSETC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxQuantization;
        private System.Windows.Forms.CheckBox checkBoxQuantization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxTrim;
        private System.Windows.Forms.TextBox textBoxTrim;
    }
}

