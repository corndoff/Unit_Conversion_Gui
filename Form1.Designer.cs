namespace Unit_Conversion_Gui
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
            this.convertButton = new System.Windows.Forms.Button();
            this.startingLabel = new System.Windows.Forms.Label();
            this.endingLabel = new System.Windows.Forms.Label();
            this.ouncesButtonIntake = new System.Windows.Forms.RadioButton();
            this.cupsButtonIntake = new System.Windows.Forms.RadioButton();
            this.pintsButtonIntake = new System.Windows.Forms.RadioButton();
            this.litersButtonIntake = new System.Windows.Forms.RadioButton();
            this.gallonsButtonIntake = new System.Windows.Forms.RadioButton();
            this.gallonsButtonExit = new System.Windows.Forms.RadioButton();
            this.litersButtonExit = new System.Windows.Forms.RadioButton();
            this.pintsButtonExit = new System.Windows.Forms.RadioButton();
            this.cupsButtonExit = new System.Windows.Forms.RadioButton();
            this.ouncesButtonExit = new System.Windows.Forms.RadioButton();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.unitAmountBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(103, 439);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(241, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Location = new System.Drawing.Point(83, 36);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(64, 13);
            this.startingLabel.TabIndex = 1;
            this.startingLabel.Text = "Covert from:";
            this.startingLabel.Click += new System.EventHandler(this.Startinglabel_Click);
            // 
            // endingLabel
            // 
            this.endingLabel.AutoSize = true;
            this.endingLabel.Location = new System.Drawing.Point(305, 36);
            this.endingLabel.Name = "endingLabel";
            this.endingLabel.Size = new System.Drawing.Size(53, 13);
            this.endingLabel.TabIndex = 2;
            this.endingLabel.Text = "Covert to:";
            // 
            // ouncesButtonIntake
            // 
            this.ouncesButtonIntake.AutoSize = true;
            this.ouncesButtonIntake.Location = new System.Drawing.Point(32, 19);
            this.ouncesButtonIntake.Name = "ouncesButtonIntake";
            this.ouncesButtonIntake.Size = new System.Drawing.Size(62, 17);
            this.ouncesButtonIntake.TabIndex = 3;
            this.ouncesButtonIntake.TabStop = true;
            this.ouncesButtonIntake.Text = "Ounces";
            this.ouncesButtonIntake.UseVisualStyleBackColor = true;
            this.ouncesButtonIntake.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cupsButtonIntake
            // 
            this.cupsButtonIntake.AutoSize = true;
            this.cupsButtonIntake.Location = new System.Drawing.Point(32, 62);
            this.cupsButtonIntake.Name = "cupsButtonIntake";
            this.cupsButtonIntake.Size = new System.Drawing.Size(49, 17);
            this.cupsButtonIntake.TabIndex = 4;
            this.cupsButtonIntake.TabStop = true;
            this.cupsButtonIntake.Text = "Cups";
            this.cupsButtonIntake.UseVisualStyleBackColor = true;
            this.cupsButtonIntake.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pintsButtonIntake
            // 
            this.pintsButtonIntake.AutoSize = true;
            this.pintsButtonIntake.Location = new System.Drawing.Point(32, 105);
            this.pintsButtonIntake.Name = "pintsButtonIntake";
            this.pintsButtonIntake.Size = new System.Drawing.Size(48, 17);
            this.pintsButtonIntake.TabIndex = 5;
            this.pintsButtonIntake.TabStop = true;
            this.pintsButtonIntake.Text = "Pints";
            this.pintsButtonIntake.UseVisualStyleBackColor = true;
            this.pintsButtonIntake.CheckedChanged += new System.EventHandler(this.pintsButtonIntake_CheckedChanged);
            // 
            // litersButtonIntake
            // 
            this.litersButtonIntake.AutoSize = true;
            this.litersButtonIntake.Location = new System.Drawing.Point(32, 150);
            this.litersButtonIntake.Name = "litersButtonIntake";
            this.litersButtonIntake.Size = new System.Drawing.Size(50, 17);
            this.litersButtonIntake.TabIndex = 6;
            this.litersButtonIntake.TabStop = true;
            this.litersButtonIntake.Text = "Liters";
            this.litersButtonIntake.UseVisualStyleBackColor = true;
            this.litersButtonIntake.CheckedChanged += new System.EventHandler(this.litersButtonIntake_CheckedChanged);
            // 
            // gallonsButtonIntake
            // 
            this.gallonsButtonIntake.AutoSize = true;
            this.gallonsButtonIntake.Location = new System.Drawing.Point(32, 194);
            this.gallonsButtonIntake.Name = "gallonsButtonIntake";
            this.gallonsButtonIntake.Size = new System.Drawing.Size(60, 17);
            this.gallonsButtonIntake.TabIndex = 7;
            this.gallonsButtonIntake.TabStop = true;
            this.gallonsButtonIntake.Text = "Gallons";
            this.gallonsButtonIntake.UseVisualStyleBackColor = true;
            this.gallonsButtonIntake.CheckedChanged += new System.EventHandler(this.gallonsButtonIntake_CheckedChanged);
            // 
            // gallonsButtonExit
            // 
            this.gallonsButtonExit.AutoSize = true;
            this.gallonsButtonExit.Location = new System.Drawing.Point(32, 196);
            this.gallonsButtonExit.Name = "gallonsButtonExit";
            this.gallonsButtonExit.Size = new System.Drawing.Size(60, 17);
            this.gallonsButtonExit.TabIndex = 12;
            this.gallonsButtonExit.TabStop = true;
            this.gallonsButtonExit.Text = "Gallons";
            this.gallonsButtonExit.UseVisualStyleBackColor = true;
            this.gallonsButtonExit.CheckedChanged += new System.EventHandler(this.gallonsButtonExit_CheckedChanged);
            // 
            // litersButtonExit
            // 
            this.litersButtonExit.AutoSize = true;
            this.litersButtonExit.Location = new System.Drawing.Point(32, 152);
            this.litersButtonExit.Name = "litersButtonExit";
            this.litersButtonExit.Size = new System.Drawing.Size(50, 17);
            this.litersButtonExit.TabIndex = 11;
            this.litersButtonExit.TabStop = true;
            this.litersButtonExit.Text = "Liters";
            this.litersButtonExit.UseVisualStyleBackColor = true;
            this.litersButtonExit.CheckedChanged += new System.EventHandler(this.litersButtonExit_CheckedChanged);
            // 
            // pintsButtonExit
            // 
            this.pintsButtonExit.AutoSize = true;
            this.pintsButtonExit.Location = new System.Drawing.Point(32, 107);
            this.pintsButtonExit.Name = "pintsButtonExit";
            this.pintsButtonExit.Size = new System.Drawing.Size(48, 17);
            this.pintsButtonExit.TabIndex = 10;
            this.pintsButtonExit.TabStop = true;
            this.pintsButtonExit.Text = "Pints";
            this.pintsButtonExit.UseVisualStyleBackColor = true;
            this.pintsButtonExit.CheckedChanged += new System.EventHandler(this.pintsButtonExit_CheckedChanged);
            // 
            // cupsButtonExit
            // 
            this.cupsButtonExit.AutoSize = true;
            this.cupsButtonExit.Location = new System.Drawing.Point(32, 64);
            this.cupsButtonExit.Name = "cupsButtonExit";
            this.cupsButtonExit.Size = new System.Drawing.Size(49, 17);
            this.cupsButtonExit.TabIndex = 9;
            this.cupsButtonExit.TabStop = true;
            this.cupsButtonExit.Text = "Cups";
            this.cupsButtonExit.UseVisualStyleBackColor = true;
            this.cupsButtonExit.CheckedChanged += new System.EventHandler(this.cupsButtonExit_CheckedChanged);
            // 
            // ouncesButtonExit
            // 
            this.ouncesButtonExit.AutoSize = true;
            this.ouncesButtonExit.Location = new System.Drawing.Point(32, 21);
            this.ouncesButtonExit.Name = "ouncesButtonExit";
            this.ouncesButtonExit.Size = new System.Drawing.Size(62, 17);
            this.ouncesButtonExit.TabIndex = 8;
            this.ouncesButtonExit.TabStop = true;
            this.ouncesButtonExit.Text = "Ounces";
            this.ouncesButtonExit.UseVisualStyleBackColor = true;
            this.ouncesButtonExit.CheckedChanged += new System.EventHandler(this.ouncesButtonExit_CheckedChanged);
            // 
            // conversionLabel
            // 
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Location = new System.Drawing.Point(174, 399);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(103, 13);
            this.conversionLabel.TabIndex = 13;
            this.conversionLabel.Text = "<convertedAmount>";
            this.conversionLabel.Click += new System.EventHandler(this.conversionLabel_Click);
            // 
            // unitAmountBox
            // 
            this.unitAmountBox.Location = new System.Drawing.Point(177, 359);
            this.unitAmountBox.Name = "unitAmountBox";
            this.unitAmountBox.Size = new System.Drawing.Size(100, 20);
            this.unitAmountBox.TabIndex = 14;
            this.unitAmountBox.TextChanged += new System.EventHandler(this.unitAmountBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ouncesButtonExit);
            this.groupBox1.Controls.Add(this.cupsButtonExit);
            this.groupBox1.Controls.Add(this.pintsButtonExit);
            this.groupBox1.Controls.Add(this.litersButtonExit);
            this.groupBox1.Controls.Add(this.gallonsButtonExit);
            this.groupBox1.Location = new System.Drawing.Point(273, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 220);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ouncesButtonIntake);
            this.groupBox2.Controls.Add(this.cupsButtonIntake);
            this.groupBox2.Controls.Add(this.pintsButtonIntake);
            this.groupBox2.Controls.Add(this.litersButtonIntake);
            this.groupBox2.Controls.Add(this.gallonsButtonIntake);
            this.groupBox2.Location = new System.Drawing.Point(52, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 220);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please enter amount of liquid you have:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unitAmountBox);
            this.Controls.Add(this.conversionLabel);
            this.Controls.Add(this.endingLabel);
            this.Controls.Add(this.startingLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label startingLabel;
        private System.Windows.Forms.Label endingLabel;
        private System.Windows.Forms.RadioButton ouncesButtonIntake;
        private System.Windows.Forms.RadioButton cupsButtonIntake;
        private System.Windows.Forms.RadioButton pintsButtonIntake;
        private System.Windows.Forms.RadioButton litersButtonIntake;
        private System.Windows.Forms.RadioButton gallonsButtonIntake;
        private System.Windows.Forms.RadioButton gallonsButtonExit;
        private System.Windows.Forms.RadioButton litersButtonExit;
        private System.Windows.Forms.RadioButton pintsButtonExit;
        private System.Windows.Forms.RadioButton cupsButtonExit;
        private System.Windows.Forms.RadioButton ouncesButtonExit;
        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.TextBox unitAmountBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

