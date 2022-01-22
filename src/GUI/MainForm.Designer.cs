namespace GUI
{
    partial class LinkPinPlugin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkPinPlugin));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeadRadius = new System.Windows.Forms.TextBox();
            this.textBoxRodRadius = new System.Windows.Forms.TextBox();
            this.textBoxHoleDistance = new System.Windows.Forms.TextBox();
            this.textBoxHoleRadius = new System.Windows.Forms.TextBox();
            this.textBoxHeadLength = new System.Windows.Forms.TextBox();
            this.textBoxRodLength = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDepthParameter = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxHeadAngleDepth = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxRodAngleDepth = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxHeadChamferDepth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxRodChamferDepth = new System.Windows.Forms.TextBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxDepthParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(459, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(458, 429);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.label12);
            this.groupBoxMain.Controls.Add(this.label11);
            this.groupBoxMain.Controls.Add(this.label10);
            this.groupBoxMain.Controls.Add(this.label9);
            this.groupBoxMain.Controls.Add(this.label8);
            this.groupBoxMain.Controls.Add(this.label7);
            this.groupBoxMain.Controls.Add(this.label6);
            this.groupBoxMain.Controls.Add(this.label5);
            this.groupBoxMain.Controls.Add(this.label4);
            this.groupBoxMain.Controls.Add(this.label3);
            this.groupBoxMain.Controls.Add(this.label2);
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.Controls.Add(this.textBoxHeadRadius);
            this.groupBoxMain.Controls.Add(this.textBoxRodRadius);
            this.groupBoxMain.Controls.Add(this.textBoxHoleDistance);
            this.groupBoxMain.Controls.Add(this.textBoxHoleRadius);
            this.groupBoxMain.Controls.Add(this.textBoxHeadLength);
            this.groupBoxMain.Controls.Add(this.textBoxRodLength);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(441, 206);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Основные параметры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(282, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "(от 5 до 25 см)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(282, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "(от 4 до 20 см)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(282, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "(от 4 до 9 см)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(282, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "(от 1 до 6 см)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(282, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "(от 2.4 до 12 см)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(282, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "(от 12 до 60 см)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.MinimumSize = new System.Drawing.Size(154, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Радиус шляпки (J):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.MinimumSize = new System.Drawing.Size(154, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Радиус стержня (I):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.MinimumSize = new System.Drawing.Size(154, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Расстояние до отверстия (F):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.MinimumSize = new System.Drawing.Size(154, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Радиус отверстия (C):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.MinimumSize = new System.Drawing.Size(154, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Длина шляпки (B):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.MinimumSize = new System.Drawing.Size(154, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина стержня (A):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHeadRadius
            // 
            this.textBoxHeadRadius.BackColor = System.Drawing.Color.White;
            this.textBoxHeadRadius.Location = new System.Drawing.Point(176, 173);
            this.textBoxHeadRadius.Name = "textBoxHeadRadius";
            this.textBoxHeadRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeadRadius.TabIndex = 5;
            this.textBoxHeadRadius.Text = "5";
            this.textBoxHeadRadius.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxRodRadius
            // 
            this.textBoxRodRadius.BackColor = System.Drawing.Color.White;
            this.textBoxRodRadius.Location = new System.Drawing.Point(176, 145);
            this.textBoxRodRadius.Name = "textBoxRodRadius";
            this.textBoxRodRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxRodRadius.TabIndex = 4;
            this.textBoxRodRadius.Text = "4";
            this.textBoxRodRadius.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxHoleDistance
            // 
            this.textBoxHoleDistance.BackColor = System.Drawing.Color.White;
            this.textBoxHoleDistance.Location = new System.Drawing.Point(176, 117);
            this.textBoxHoleDistance.Name = "textBoxHoleDistance";
            this.textBoxHoleDistance.Size = new System.Drawing.Size(100, 22);
            this.textBoxHoleDistance.TabIndex = 3;
            this.textBoxHoleDistance.Text = "4";
            this.textBoxHoleDistance.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxHoleRadius
            // 
            this.textBoxHoleRadius.BackColor = System.Drawing.Color.White;
            this.textBoxHoleRadius.Location = new System.Drawing.Point(176, 89);
            this.textBoxHoleRadius.Name = "textBoxHoleRadius";
            this.textBoxHoleRadius.Size = new System.Drawing.Size(100, 22);
            this.textBoxHoleRadius.TabIndex = 2;
            this.textBoxHoleRadius.Text = "1";
            this.textBoxHoleRadius.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxHeadLength
            // 
            this.textBoxHeadLength.BackColor = System.Drawing.Color.White;
            this.textBoxHeadLength.Location = new System.Drawing.Point(176, 61);
            this.textBoxHeadLength.Name = "textBoxHeadLength";
            this.textBoxHeadLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeadLength.TabIndex = 1;
            this.textBoxHeadLength.Text = "4";
            this.toolTip.SetToolTip(this.textBoxHeadLength, "\r\n\r\n");
            this.textBoxHeadLength.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // textBoxRodLength
            // 
            this.textBoxRodLength.BackColor = System.Drawing.Color.White;
            this.textBoxRodLength.Location = new System.Drawing.Point(176, 33);
            this.textBoxRodLength.Name = "textBoxRodLength";
            this.textBoxRodLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxRodLength.TabIndex = 0;
            this.textBoxRodLength.Text = "20";
            this.textBoxRodLength.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 50;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "ВНИМАНИЕ: ";
            // 
            // groupBoxDepthParameter
            // 
            this.groupBoxDepthParameter.Controls.Add(this.label17);
            this.groupBoxDepthParameter.Controls.Add(this.label13);
            this.groupBoxDepthParameter.Controls.Add(this.label18);
            this.groupBoxDepthParameter.Controls.Add(this.textBoxHeadAngleDepth);
            this.groupBoxDepthParameter.Controls.Add(this.label19);
            this.groupBoxDepthParameter.Controls.Add(this.label14);
            this.groupBoxDepthParameter.Controls.Add(this.label20);
            this.groupBoxDepthParameter.Controls.Add(this.textBoxRodAngleDepth);
            this.groupBoxDepthParameter.Controls.Add(this.label15);
            this.groupBoxDepthParameter.Controls.Add(this.textBoxHeadChamferDepth);
            this.groupBoxDepthParameter.Controls.Add(this.label16);
            this.groupBoxDepthParameter.Controls.Add(this.textBoxRodChamferDepth);
            this.groupBoxDepthParameter.Location = new System.Drawing.Point(12, 224);
            this.groupBoxDepthParameter.Name = "groupBoxDepthParameter";
            this.groupBoxDepthParameter.Size = new System.Drawing.Size(441, 151);
            this.groupBoxDepthParameter.TabIndex = 2;
            this.groupBoxDepthParameter.TabStop = false;
            this.groupBoxDepthParameter.Text = "Параметры фасок";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label17.Location = new System.Drawing.Point(282, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "(не превышает 45 градусов)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 116);
            this.label13.MinimumSize = new System.Drawing.Size(164, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Угол фаски на стержне (H):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(282, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "(не превышает 30 градусов)";
            // 
            // textBoxHeadAngleDepth
            // 
            this.textBoxHeadAngleDepth.Location = new System.Drawing.Point(176, 116);
            this.textBoxHeadAngleDepth.Name = "textBoxHeadAngleDepth";
            this.textBoxHeadAngleDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeadAngleDepth.TabIndex = 3;
            this.textBoxHeadAngleDepth.Text = "15";
            this.textBoxHeadAngleDepth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(282, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "(от 0.1 до 1.2 см)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 88);
            this.label14.MinimumSize = new System.Drawing.Size(164, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Угол фаски на стержне (G):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label20.Location = new System.Drawing.Point(282, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "(от 0.2 до 2 см)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRodAngleDepth
            // 
            this.textBoxRodAngleDepth.Location = new System.Drawing.Point(176, 88);
            this.textBoxRodAngleDepth.Name = "textBoxRodAngleDepth";
            this.textBoxRodAngleDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxRodAngleDepth.TabIndex = 2;
            this.textBoxRodAngleDepth.Text = "15";
            this.textBoxRodAngleDepth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 60);
            this.label15.MinimumSize = new System.Drawing.Size(164, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Глубина фаски на шляпке (E):";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHeadChamferDepth
            // 
            this.textBoxHeadChamferDepth.Location = new System.Drawing.Point(176, 60);
            this.textBoxHeadChamferDepth.Name = "textBoxHeadChamferDepth";
            this.textBoxHeadChamferDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeadChamferDepth.TabIndex = 1;
            this.textBoxHeadChamferDepth.Text = "0,5";
            this.textBoxHeadChamferDepth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.MinimumSize = new System.Drawing.Size(164, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(215, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Глубина фаски на стержне (D):";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxRodChamferDepth
            // 
            this.textBoxRodChamferDepth.Location = new System.Drawing.Point(176, 32);
            this.textBoxRodChamferDepth.Name = "textBoxRodChamferDepth";
            this.textBoxRodChamferDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxRodChamferDepth.TabIndex = 0;
            this.textBoxRodChamferDepth.Text = "0,5";
            this.textBoxRodChamferDepth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(12, 411);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(100, 30);
            this.buttonBuild.TabIndex = 3;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(118, 411);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(13, 382);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(147, 21);
            this.checkBox.TabIndex = 5;
            this.checkBox.Text = "Выполнить вырез";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // LinkPinPlugin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(929, 461);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.groupBoxDepthParameter);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(947, 508);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(947, 508);
            this.Name = "LinkPinPlugin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkPinPlugin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxDepthParameter.ResumeLayout(false);
            this.groupBoxDepthParameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeadRadius;
        private System.Windows.Forms.TextBox textBoxRodRadius;
        private System.Windows.Forms.TextBox textBoxHoleDistance;
        private System.Windows.Forms.TextBox textBoxHoleRadius;
        private System.Windows.Forms.TextBox textBoxHeadLength;
        private System.Windows.Forms.TextBox textBoxRodLength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxDepthParameter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxHeadAngleDepth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxRodAngleDepth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxHeadChamferDepth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxRodChamferDepth;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

