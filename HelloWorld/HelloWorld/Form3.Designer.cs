namespace HelloWorld
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.checkBoxCS = new System.Windows.Forms.CheckBox();
            this.checkBoxASP = new System.Windows.Forms.CheckBox();
            this.buttonSubmitSCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Monbai",
            "Bangalore",
            "Hydrebad"});
            this.listBox1.Location = new System.Drawing.Point(23, 253);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(273, 28);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(102, 17);
            this.radioButtonMale.TabIndex = 1;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "radioButtonMale";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(273, 63);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(113, 17);
            this.radioButtonFemale.TabIndex = 2;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "radioButtonFemale";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // checkBoxCS
            // 
            this.checkBoxCS.AutoSize = true;
            this.checkBoxCS.Location = new System.Drawing.Point(273, 159);
            this.checkBoxCS.Name = "checkBoxCS";
            this.checkBoxCS.Size = new System.Drawing.Size(88, 17);
            this.checkBoxCS.TabIndex = 3;
            this.checkBoxCS.Text = "checkBoxCS";
            this.checkBoxCS.UseVisualStyleBackColor = true;
            this.checkBoxCS.CheckedChanged += new System.EventHandler(this.checkBoxCS_CheckedChanged);
            // 
            // checkBoxASP
            // 
            this.checkBoxASP.AutoSize = true;
            this.checkBoxASP.Location = new System.Drawing.Point(273, 195);
            this.checkBoxASP.Name = "checkBoxASP";
            this.checkBoxASP.Size = new System.Drawing.Size(95, 17);
            this.checkBoxASP.TabIndex = 4;
            this.checkBoxASP.Text = "checkBoxASP";
            this.checkBoxASP.UseVisualStyleBackColor = true;
            this.checkBoxASP.CheckedChanged += new System.EventHandler(this.checkBoxASP_CheckedChanged);
            // 
            // buttonSubmitSCE
            // 
            this.buttonSubmitSCE.Location = new System.Drawing.Point(310, 291);
            this.buttonSubmitSCE.Name = "buttonSubmitSCE";
            this.buttonSubmitSCE.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitSCE.TabIndex = 5;
            this.buttonSubmitSCE.Text = "buttonSubmitSCE";
            this.buttonSubmitSCE.UseVisualStyleBackColor = true;
            this.buttonSubmitSCE.Click += new System.EventHandler(this.buttonSubmitSCE_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmitSCE);
            this.Controls.Add(this.checkBoxASP);
            this.Controls.Add(this.checkBoxCS);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "String Collection Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.CheckBox checkBoxCS;
        private System.Windows.Forms.CheckBox checkBoxASP;
        private System.Windows.Forms.Button buttonSubmitSCE;
    }
}