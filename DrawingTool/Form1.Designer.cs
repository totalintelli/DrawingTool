namespace DrawingTool
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDrawType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picMainColor = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPenStart = new System.Windows.Forms.ComboBox();
            this.cmbPenDash = new System.Windows.Forms.ComboBox();
            this.cmbPenWidth = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPenEnd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBruGradient = new System.Windows.Forms.ComboBox();
            this.cmbBruTexture = new System.Windows.Forms.ComboBox();
            this.cmbBruHatch = new System.Windows.Forms.ComboBox();
            this.picBruColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picBruTexture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainColor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBruColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBruTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMain.Location = new System.Drawing.Point(13, 13);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(387, 208);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Paint += new System.Windows.Forms.PaintEventHandler(this.picMain_Paint);
            this.picMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMain_MouseDown);
            this.picMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMain_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "그리기 종류";
            // 
            // cmbDrawType
            // 
            this.cmbDrawType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrawType.FormattingEnabled = true;
            this.cmbDrawType.Location = new System.Drawing.Point(408, 29);
            this.cmbDrawType.Name = "cmbDrawType";
            this.cmbDrawType.Size = new System.Drawing.Size(121, 20);
            this.cmbDrawType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "배경색";
            // 
            // picMainColor
            // 
            this.picMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMainColor.Location = new System.Drawing.Point(410, 94);
            this.picMainColor.Name = "picMainColor";
            this.picMainColor.Size = new System.Drawing.Size(119, 16);
            this.picMainColor.TabIndex = 4;
            this.picMainColor.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(410, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "지우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(410, 201);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "간단히 <<";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbPenEnd);
            this.groupBox1.Controls.Add(this.cmbPenStart);
            this.groupBox1.Controls.Add(this.cmbPenDash);
            this.groupBox1.Controls.Add(this.cmbPenWidth);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen 설정";
            // 
            // cmbPenStart
            // 
            this.cmbPenStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenStart.FormattingEnabled = true;
            this.cmbPenStart.Location = new System.Drawing.Point(77, 111);
            this.cmbPenStart.Name = "cmbPenStart";
            this.cmbPenStart.Size = new System.Drawing.Size(121, 20);
            this.cmbPenStart.TabIndex = 7;
            // 
            // cmbPenDash
            // 
            this.cmbPenDash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenDash.FormattingEnabled = true;
            this.cmbPenDash.Location = new System.Drawing.Point(77, 85);
            this.cmbPenDash.Name = "cmbPenDash";
            this.cmbPenDash.Size = new System.Drawing.Size(121, 20);
            this.cmbPenDash.TabIndex = 6;
            // 
            // cmbPenWidth
            // 
            this.cmbPenWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenWidth.FormattingEnabled = true;
            this.cmbPenWidth.Location = new System.Drawing.Point(77, 59);
            this.cmbPenWidth.Name = "cmbPenWidth";
            this.cmbPenWidth.Size = new System.Drawing.Size(121, 20);
            this.cmbPenWidth.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(77, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 19);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "시작 캡 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "대쉬종류 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "펜 두께 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "펜 칼라 :";
            // 
            // cmbPenEnd
            // 
            this.cmbPenEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenEnd.FormattingEnabled = true;
            this.cmbPenEnd.Location = new System.Drawing.Point(77, 137);
            this.cmbPenEnd.Name = "cmbPenEnd";
            this.cmbPenEnd.Size = new System.Drawing.Size(121, 20);
            this.cmbPenEnd.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "끝 캡 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBruTexture);
            this.groupBox2.Controls.Add(this.cmbBruGradient);
            this.groupBox2.Controls.Add(this.cmbBruTexture);
            this.groupBox2.Controls.Add(this.cmbBruHatch);
            this.groupBox2.Controls.Add(this.picBruColor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(267, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 174);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush 설정";
            // 
            // cmbBruGradient
            // 
            this.cmbBruGradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBruGradient.FormattingEnabled = true;
            this.cmbBruGradient.Location = new System.Drawing.Point(77, 135);
            this.cmbBruGradient.Name = "cmbBruGradient";
            this.cmbBruGradient.Size = new System.Drawing.Size(121, 20);
            this.cmbBruGradient.TabIndex = 7;
            // 
            // cmbBruTexture
            // 
            this.cmbBruTexture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBruTexture.FormattingEnabled = true;
            this.cmbBruTexture.Location = new System.Drawing.Point(122, 104);
            this.cmbBruTexture.Name = "cmbBruTexture";
            this.cmbBruTexture.Size = new System.Drawing.Size(76, 20);
            this.cmbBruTexture.TabIndex = 6;
            // 
            // cmbBruHatch
            // 
            this.cmbBruHatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBruHatch.FormattingEnabled = true;
            this.cmbBruHatch.Location = new System.Drawing.Point(77, 59);
            this.cmbBruHatch.Name = "cmbBruHatch";
            this.cmbBruHatch.Size = new System.Drawing.Size(121, 20);
            this.cmbBruHatch.TabIndex = 5;
            // 
            // picBruColor
            // 
            this.picBruColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBruColor.Location = new System.Drawing.Point(77, 33);
            this.picBruColor.Name = "picBruColor";
            this.picBruColor.Size = new System.Drawing.Size(121, 19);
            this.picBruColor.TabIndex = 4;
            this.picBruColor.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "Gradient :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Texture : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Hatch : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "Solid :";
            // 
            // picBruTexture
            // 
            this.picBruTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBruTexture.Location = new System.Drawing.Point(77, 102);
            this.picBruTexture.Name = "picBruTexture";
            this.picBruTexture.Size = new System.Drawing.Size(39, 22);
            this.picBruTexture.TabIndex = 10;
            this.picBruTexture.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picMainColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDrawType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "드로잉 툴";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainColor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBruColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBruTexture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrawType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picMainColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPenStart;
        private System.Windows.Forms.ComboBox cmbPenDash;
        private System.Windows.Forms.ComboBox cmbPenWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPenEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBruGradient;
        private System.Windows.Forms.ComboBox cmbBruTexture;
        private System.Windows.Forms.ComboBox cmbBruHatch;
        private System.Windows.Forms.PictureBox picBruColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picBruTexture;
    }
}

