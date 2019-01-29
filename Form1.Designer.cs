namespace CheckCards
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCustomColour = new System.Windows.Forms.ComboBox();
            this.comboCustomValue = new System.Windows.Forms.ComboBox();
            this.comboComparedColour = new System.Windows.Forms.ComboBox();
            this.comboComparedValue = new System.Windows.Forms.ComboBox();
            this.lstCardDeckOne = new System.Windows.Forms.ListBox();
            this.lstCardDeckTwo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toFirst = new System.Windows.Forms.Button();
            this.toSecond = new System.Windows.Forms.Button();
            this.btnSortOne = new System.Windows.Forms.Button();
            this.btnResetOne = new System.Windows.Forms.Button();
            this.btnResetTwo = new System.Windows.Forms.Button();
            this.btnSortTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(149, 167);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 0;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compared Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Colour";
            // 
            // comboCustomColour
            // 
            this.comboCustomColour.FormattingEnabled = true;
            this.comboCustomColour.Location = new System.Drawing.Point(26, 67);
            this.comboCustomColour.Name = "comboCustomColour";
            this.comboCustomColour.Size = new System.Drawing.Size(121, 21);
            this.comboCustomColour.TabIndex = 11;
            // 
            // comboCustomValue
            // 
            this.comboCustomValue.FormattingEnabled = true;
            this.comboCustomValue.Location = new System.Drawing.Point(26, 118);
            this.comboCustomValue.Name = "comboCustomValue";
            this.comboCustomValue.Size = new System.Drawing.Size(121, 21);
            this.comboCustomValue.TabIndex = 12;
            // 
            // comboComparedColour
            // 
            this.comboComparedColour.FormattingEnabled = true;
            this.comboComparedColour.Location = new System.Drawing.Point(228, 67);
            this.comboComparedColour.Name = "comboComparedColour";
            this.comboComparedColour.Size = new System.Drawing.Size(121, 21);
            this.comboComparedColour.TabIndex = 13;
            // 
            // comboComparedValue
            // 
            this.comboComparedValue.FormattingEnabled = true;
            this.comboComparedValue.Location = new System.Drawing.Point(228, 118);
            this.comboComparedValue.Name = "comboComparedValue";
            this.comboComparedValue.Size = new System.Drawing.Size(121, 21);
            this.comboComparedValue.TabIndex = 14;
            // 
            // lstCardDeckOne
            // 
            this.lstCardDeckOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCardDeckOne.FormattingEnabled = true;
            this.lstCardDeckOne.Location = new System.Drawing.Point(497, 51);
            this.lstCardDeckOne.Name = "lstCardDeckOne";
            this.lstCardDeckOne.Size = new System.Drawing.Size(120, 316);
            this.lstCardDeckOne.TabIndex = 15;
            // 
            // lstCardDeckTwo
            // 
            this.lstCardDeckTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCardDeckTwo.FormattingEnabled = true;
            this.lstCardDeckTwo.Location = new System.Drawing.Point(662, 51);
            this.lstCardDeckTwo.Name = "lstCardDeckTwo";
            this.lstCardDeckTwo.Size = new System.Drawing.Size(120, 316);
            this.lstCardDeckTwo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Card Deck 1";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Card Deck 2";
            // 
            // toFirst
            // 
            this.toFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toFirst.Location = new System.Drawing.Point(623, 138);
            this.toFirst.Name = "toFirst";
            this.toFirst.Size = new System.Drawing.Size(33, 23);
            this.toFirst.TabIndex = 19;
            this.toFirst.Text = "<<";
            this.toFirst.UseVisualStyleBackColor = true;
            this.toFirst.Click += new System.EventHandler(this.toFirst_Click);
            // 
            // toSecond
            // 
            this.toSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toSecond.Location = new System.Drawing.Point(623, 167);
            this.toSecond.Name = "toSecond";
            this.toSecond.Size = new System.Drawing.Size(33, 23);
            this.toSecond.TabIndex = 20;
            this.toSecond.Text = ">>";
            this.toSecond.UseVisualStyleBackColor = true;
            this.toSecond.Click += new System.EventHandler(this.toSecond_Click);
            // 
            // btnSortOne
            // 
            this.btnSortOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortOne.Location = new System.Drawing.Point(518, 373);
            this.btnSortOne.Name = "btnSortOne";
            this.btnSortOne.Size = new System.Drawing.Size(75, 23);
            this.btnSortOne.TabIndex = 21;
            this.btnSortOne.Text = "Sort";
            this.btnSortOne.UseVisualStyleBackColor = true;
            this.btnSortOne.Click += new System.EventHandler(this.btnSortOne_Click);
            // 
            // btnResetOne
            // 
            this.btnResetOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetOne.Location = new System.Drawing.Point(518, 402);
            this.btnResetOne.Name = "btnResetOne";
            this.btnResetOne.Size = new System.Drawing.Size(75, 23);
            this.btnResetOne.TabIndex = 22;
            this.btnResetOne.Text = "Reset";
            this.btnResetOne.UseVisualStyleBackColor = true;
            this.btnResetOne.Click += new System.EventHandler(this.btnResetOne_Click);
            // 
            // btnResetTwo
            // 
            this.btnResetTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetTwo.Location = new System.Drawing.Point(688, 402);
            this.btnResetTwo.Name = "btnResetTwo";
            this.btnResetTwo.Size = new System.Drawing.Size(75, 23);
            this.btnResetTwo.TabIndex = 24;
            this.btnResetTwo.Text = "Reset";
            this.btnResetTwo.UseVisualStyleBackColor = true;
            this.btnResetTwo.Click += new System.EventHandler(this.btnResetTwo_Click);
            // 
            // btnSortTwo
            // 
            this.btnSortTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortTwo.Location = new System.Drawing.Point(688, 373);
            this.btnSortTwo.Name = "btnSortTwo";
            this.btnSortTwo.Size = new System.Drawing.Size(75, 23);
            this.btnSortTwo.TabIndex = 23;
            this.btnSortTwo.Text = "Sort";
            this.btnSortTwo.UseVisualStyleBackColor = true;
            this.btnSortTwo.Click += new System.EventHandler(this.btnSortTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.btnResetTwo);
            this.Controls.Add(this.btnSortTwo);
            this.Controls.Add(this.btnResetOne);
            this.Controls.Add(this.btnSortOne);
            this.Controls.Add(this.toSecond);
            this.Controls.Add(this.toFirst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstCardDeckTwo);
            this.Controls.Add(this.lstCardDeckOne);
            this.Controls.Add(this.comboComparedValue);
            this.Controls.Add(this.comboComparedColour);
            this.Controls.Add(this.comboCustomValue);
            this.Controls.Add(this.comboCustomColour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboCustomColour;
        private System.Windows.Forms.ComboBox comboCustomValue;
        private System.Windows.Forms.ComboBox comboComparedColour;
        private System.Windows.Forms.ComboBox comboComparedValue;
        private System.Windows.Forms.ListBox lstCardDeckOne;
        private System.Windows.Forms.ListBox lstCardDeckTwo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button toFirst;
        private System.Windows.Forms.Button toSecond;
        private System.Windows.Forms.Button btnSortOne;
        private System.Windows.Forms.Button btnResetOne;
        private System.Windows.Forms.Button btnResetTwo;
        private System.Windows.Forms.Button btnSortTwo;
    }
}

