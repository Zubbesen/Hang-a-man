namespace Hang_a_man
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Quit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skrivord = new System.Windows.Forms.Label();
            this.guesswordbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.txtWholeWord = new System.Windows.Forms.TextBox();
            this.pcbHangMan = new System.Windows.Forms.PictureBox();
            this.Wordbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHangMan)).BeginInit();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(924, 490);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(188, 72);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(749, 490);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(169, 72);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start/Restart";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(556, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 73);
            this.title.TabIndex = 5;
            this.title.Text = "Hang a Man";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.skrivord);
            this.panel1.Controls.Add(this.guesswordbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtWholeWord);
            this.panel1.Location = new System.Drawing.Point(566, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 380);
            this.panel1.TabIndex = 6;
            // 
            // skrivord
            // 
            this.skrivord.AutoSize = true;
            this.skrivord.Location = new System.Drawing.Point(21, 246);
            this.skrivord.Name = "skrivord";
            this.skrivord.Size = new System.Drawing.Size(135, 20);
            this.skrivord.TabIndex = 12;
            this.skrivord.Text = "Write the full word";
            // 
            // guesswordbtn
            // 
            this.guesswordbtn.Location = new System.Drawing.Point(346, 269);
            this.guesswordbtn.Name = "guesswordbtn";
            this.guesswordbtn.Size = new System.Drawing.Size(115, 34);
            this.guesswordbtn.TabIndex = 10;
            this.guesswordbtn.Text = "Guess Word";
            this.guesswordbtn.UseVisualStyleBackColor = true;
            this.guesswordbtn.Click += new System.EventHandler(this.guesswordbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnZ);
            this.panel2.Controls.Add(this.btnY);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Controls.Add(this.btnV);
            this.panel2.Controls.Add(this.btnW);
            this.panel2.Controls.Add(this.btnU);
            this.panel2.Controls.Add(this.btnT);
            this.panel2.Controls.Add(this.btnP);
            this.panel2.Controls.Add(this.btnO);
            this.panel2.Controls.Add(this.btnM);
            this.panel2.Controls.Add(this.btnN);
            this.panel2.Controls.Add(this.btnS);
            this.panel2.Controls.Add(this.btnQ);
            this.panel2.Controls.Add(this.btnR);
            this.panel2.Controls.Add(this.btnL);
            this.panel2.Controls.Add(this.btnK);
            this.panel2.Controls.Add(this.btnI);
            this.panel2.Controls.Add(this.btnH);
            this.panel2.Controls.Add(this.btnJ);
            this.panel2.Controls.Add(this.btnG);
            this.panel2.Controls.Add(this.btnF);
            this.panel2.Controls.Add(this.btnE);
            this.panel2.Controls.Add(this.btnB);
            this.panel2.Controls.Add(this.btnD);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnA);
            this.panel2.Location = new System.Drawing.Point(25, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 196);
            this.panel2.TabIndex = 9;
            // 
            // btnZ
            // 
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.Location = new System.Drawing.Point(69, 153);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(48, 37);
            this.btnZ.TabIndex = 25;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // btnY
            // 
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(15, 153);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(48, 37);
            this.btnY.TabIndex = 24;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(393, 110);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(48, 37);
            this.btnX.TabIndex = 23;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnV
            // 
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(285, 110);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(48, 37);
            this.btnV.TabIndex = 22;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnW
            // 
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(339, 110);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(48, 37);
            this.btnW.TabIndex = 21;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnU
            // 
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(231, 110);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(48, 37);
            this.btnU.TabIndex = 20;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnT
            // 
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(177, 110);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(48, 37);
            this.btnT.TabIndex = 19;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnP
            // 
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(393, 67);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(48, 37);
            this.btnP.TabIndex = 18;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnO
            // 
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(339, 67);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(48, 37);
            this.btnO.TabIndex = 17;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(231, 67);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(48, 37);
            this.btnM.TabIndex = 16;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(285, 67);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(48, 37);
            this.btnN.TabIndex = 15;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnS
            // 
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(123, 110);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(48, 37);
            this.btnS.TabIndex = 14;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnQ
            // 
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(15, 110);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(48, 37);
            this.btnQ.TabIndex = 13;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(69, 110);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(48, 37);
            this.btnR.TabIndex = 12;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnL
            // 
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(177, 67);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(48, 37);
            this.btnL.TabIndex = 11;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnK
            // 
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(123, 69);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(48, 37);
            this.btnK.TabIndex = 10;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnI
            // 
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(15, 69);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(48, 37);
            this.btnI.TabIndex = 9;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnH
            // 
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(393, 26);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(48, 37);
            this.btnH.TabIndex = 8;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnJ
            // 
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(69, 69);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(48, 37);
            this.btnJ.TabIndex = 7;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(339, 26);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(48, 37);
            this.btnG.TabIndex = 6;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnF
            // 
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(285, 26);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(48, 37);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(231, 26);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(48, 37);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(69, 26);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(48, 37);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(177, 26);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(48, 37);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(123, 26);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(48, 37);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(15, 26);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(48, 37);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // txtWholeWord
            // 
            this.txtWholeWord.Location = new System.Drawing.Point(25, 269);
            this.txtWholeWord.Name = "txtWholeWord";
            this.txtWholeWord.Size = new System.Drawing.Size(315, 26);
            this.txtWholeWord.TabIndex = 8;
            // 
            // pcbHangMan
            // 
            this.pcbHangMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbHangMan.Image = ((System.Drawing.Image)(resources.GetObject("pcbHangMan.Image")));
            this.pcbHangMan.Location = new System.Drawing.Point(12, 19);
            this.pcbHangMan.Name = "pcbHangMan";
            this.pcbHangMan.Size = new System.Drawing.Size(522, 488);
            this.pcbHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHangMan.TabIndex = 7;
            this.pcbHangMan.TabStop = false;
            // 
            // Wordbox
            // 
            this.Wordbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.Wordbox.Font = new System.Drawing.Font("Playbill", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wordbox.ForeColor = System.Drawing.SystemColors.Window;
            this.Wordbox.Location = new System.Drawing.Point(12, 513);
            this.Wordbox.Name = "Wordbox";
            this.Wordbox.Size = new System.Drawing.Size(522, 52);
            this.Wordbox.TabIndex = 11;
            this.Wordbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1124, 604);
            this.Controls.Add(this.Wordbox);
            this.Controls.Add(this.pcbHangMan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Quit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHangMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.PictureBox pcbHangMan;
        private System.Windows.Forms.TextBox txtWholeWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label skrivord;
        private System.Windows.Forms.Button guesswordbtn;
        private System.Windows.Forms.TextBox Wordbox;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnX;
    }
}

