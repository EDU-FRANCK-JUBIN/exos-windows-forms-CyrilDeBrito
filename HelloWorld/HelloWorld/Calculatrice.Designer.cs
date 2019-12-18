namespace HelloWorld
{
    partial class Calculatrice
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_Calc = new System.Windows.Forms.GroupBox();
            this.buttonCalcCE = new System.Windows.Forms.Button();
            this.buttonCalcEquals = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonheight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonLoreLess = new System.Windows.Forms.Button();
            this.groupBox_Calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(323, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox_Calc);
            // 
            // groupBox_Calc
            // 
            this.groupBox_Calc.Controls.Add(this.buttonC);
            this.groupBox_Calc.Controls.Add(this.buttonComma);
            this.groupBox_Calc.Controls.Add(this.buttonZero);
            this.groupBox_Calc.Controls.Add(this.buttonLoreLess);
            this.groupBox_Calc.Controls.Add(this.buttonPlus);
            this.groupBox_Calc.Controls.Add(this.buttonThree);
            this.groupBox_Calc.Controls.Add(this.buttonTwo);
            this.groupBox_Calc.Controls.Add(this.buttonOne);
            this.groupBox_Calc.Controls.Add(this.buttonMinus);
            this.groupBox_Calc.Controls.Add(this.buttonSix);
            this.groupBox_Calc.Controls.Add(this.buttonFive);
            this.groupBox_Calc.Controls.Add(this.buttonFour);
            this.groupBox_Calc.Controls.Add(this.buttonMult);
            this.groupBox_Calc.Controls.Add(this.buttonNine);
            this.groupBox_Calc.Controls.Add(this.buttonheight);
            this.groupBox_Calc.Controls.Add(this.buttonSeven);
            this.groupBox_Calc.Controls.Add(this.buttonDevide);
            this.groupBox_Calc.Controls.Add(this.buttonBack);
            this.groupBox_Calc.Controls.Add(this.buttonCalcEquals);
            this.groupBox_Calc.Controls.Add(this.buttonCalcCE);
            this.groupBox_Calc.Location = new System.Drawing.Point(26, 129);
            this.groupBox_Calc.Name = "groupBox_Calc";
            this.groupBox_Calc.Size = new System.Drawing.Size(323, 353);
            this.groupBox_Calc.TabIndex = 1;
            this.groupBox_Calc.TabStop = false;
            this.groupBox_Calc.Enter += new System.EventHandler(this.groupBox_Calc_Enter);
            // 
            // buttonCalcCE
            // 
            this.buttonCalcCE.Location = new System.Drawing.Point(6, 10);
            this.buttonCalcCE.Name = "buttonCalcCE";
            this.buttonCalcCE.Size = new System.Drawing.Size(62, 63);
            this.buttonCalcCE.TabIndex = 0;
            this.buttonCalcCE.Text = "CE";
            this.buttonCalcCE.UseVisualStyleBackColor = true;
            this.buttonCalcCE.Click += new System.EventHandler(this.buttonCalcCE_Click);
            // 
            // buttonCalcEquals
            // 
            this.buttonCalcEquals.Location = new System.Drawing.Point(255, 284);
            this.buttonCalcEquals.Name = "buttonCalcEquals";
            this.buttonCalcEquals.Size = new System.Drawing.Size(62, 63);
            this.buttonCalcEquals.TabIndex = 1;
            this.buttonCalcEquals.Text = "=";
            this.buttonCalcEquals.UseVisualStyleBackColor = true;
            this.buttonCalcEquals.Click += new System.EventHandler(this.buttonCalcEquals_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(175, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 63);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(255, 10);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(62, 63);
            this.buttonDevide.TabIndex = 4;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.buttonDevide_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(255, 79);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(62, 63);
            this.buttonMult.TabIndex = 8;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(175, 79);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(62, 63);
            this.buttonNine.TabIndex = 7;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonheight
            // 
            this.buttonheight.Location = new System.Drawing.Point(89, 79);
            this.buttonheight.Name = "buttonheight";
            this.buttonheight.Size = new System.Drawing.Size(62, 63);
            this.buttonheight.TabIndex = 6;
            this.buttonheight.Text = "8";
            this.buttonheight.UseVisualStyleBackColor = true;
            this.buttonheight.Click += new System.EventHandler(this.buttonheight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(6, 79);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(62, 63);
            this.buttonSeven.TabIndex = 5;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(255, 148);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(62, 63);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(175, 148);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(62, 63);
            this.buttonSix.TabIndex = 11;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(89, 148);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(62, 63);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(6, 148);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(62, 63);
            this.buttonFour.TabIndex = 9;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(255, 217);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(62, 63);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(175, 217);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(62, 63);
            this.buttonThree.TabIndex = 15;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(89, 217);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(62, 63);
            this.buttonTwo.TabIndex = 14;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(6, 217);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(62, 63);
            this.buttonOne.TabIndex = 13;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(89, 10);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(62, 63);
            this.buttonC.TabIndex = 20;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Location = new System.Drawing.Point(175, 286);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(62, 63);
            this.buttonComma.TabIndex = 19;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonComma_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(89, 286);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(62, 63);
            this.buttonZero.TabIndex = 0;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonLoreLess
            // 
            this.buttonLoreLess.Location = new System.Drawing.Point(6, 286);
            this.buttonLoreLess.Name = "buttonLoreLess";
            this.buttonLoreLess.Size = new System.Drawing.Size(62, 63);
            this.buttonLoreLess.TabIndex = 17;
            this.buttonLoreLess.Text = "+-";
            this.buttonLoreLess.UseVisualStyleBackColor = true;
            this.buttonLoreLess.Click += new System.EventHandler(this.buttonLoreLess_Click);
            // 
            // Calculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 489);
            this.Controls.Add(this.groupBox_Calc);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Calculatrice";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Calculatrice_Load);
            this.groupBox_Calc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox_Calc;
        private System.Windows.Forms.Button buttonCalcCE;
        private System.Windows.Forms.Button buttonCalcEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonheight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonLoreLess;
    }
}