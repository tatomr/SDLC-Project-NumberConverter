namespace DecToRom
{
    partial class DecToRom
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
            this.components = new System.ComponentModel.Container();
            this.decToRomGroupBox = new System.Windows.Forms.GroupBox();
            this.referenceRadioButton = new System.Windows.Forms.RadioButton();
            this.romToDecRadioButton = new System.Windows.Forms.RadioButton();
            this.decToRomRadioButton = new System.Windows.Forms.RadioButton();
            this.arabicEnterLB = new System.Windows.Forms.Label();
            this.romanEnterLB = new System.Windows.Forms.Label();
            this.convertBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.decToRomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // decToRomGroupBox
            // 
            this.decToRomGroupBox.Controls.Add(this.referenceRadioButton);
            this.decToRomGroupBox.Controls.Add(this.romToDecRadioButton);
            this.decToRomGroupBox.Controls.Add(this.decToRomRadioButton);
            this.decToRomGroupBox.Location = new System.Drawing.Point(48, 49);
            this.decToRomGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decToRomGroupBox.Name = "decToRomGroupBox";
            this.decToRomGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decToRomGroupBox.Size = new System.Drawing.Size(446, 143);
            this.decToRomGroupBox.TabIndex = 0;
            this.decToRomGroupBox.TabStop = false;
            this.decToRomGroupBox.Text = "Select Conversion Type";
            // 
            // referenceRadioButton
            // 
            this.referenceRadioButton.AutoSize = true;
            this.referenceRadioButton.Location = new System.Drawing.Point(26, 99);
            this.referenceRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.referenceRadioButton.Name = "referenceRadioButton";
            this.referenceRadioButton.Size = new System.Drawing.Size(200, 24);
            this.referenceRadioButton.TabIndex = 2;
            this.referenceRadioButton.TabStop = true;
            this.referenceRadioButton.Text = "Roman Numerals Chart";
            this.referenceRadioButton.UseVisualStyleBackColor = true;
            this.referenceRadioButton.CheckedChanged += new System.EventHandler(this.referenceRadioButton_CheckedChanged);
            // 
            // romToDecRadioButton
            // 
            this.romToDecRadioButton.AutoSize = true;
            this.romToDecRadioButton.Location = new System.Drawing.Point(26, 65);
            this.romToDecRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.romToDecRadioButton.Name = "romToDecRadioButton";
            this.romToDecRadioButton.Size = new System.Drawing.Size(284, 24);
            this.romToDecRadioButton.TabIndex = 1;
            this.romToDecRadioButton.TabStop = true;
            this.romToDecRadioButton.Text = "Roman Numerals to Arabic Number";
            this.romToDecRadioButton.UseVisualStyleBackColor = true;
            this.romToDecRadioButton.CheckedChanged += new System.EventHandler(this.romToDecRadioButton_CheckedChanged);
            // 
            // decToRomRadioButton
            // 
            this.decToRomRadioButton.AutoSize = true;
            this.decToRomRadioButton.Location = new System.Drawing.Point(26, 29);
            this.decToRomRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decToRomRadioButton.Name = "decToRomRadioButton";
            this.decToRomRadioButton.Size = new System.Drawing.Size(284, 24);
            this.decToRomRadioButton.TabIndex = 0;
            this.decToRomRadioButton.TabStop = true;
            this.decToRomRadioButton.Text = "Arabic Number to Roman Numerals";
            this.decToRomRadioButton.UseVisualStyleBackColor = true;
            this.decToRomRadioButton.CheckedChanged += new System.EventHandler(this.decToRomRadioButton_CheckedChanged);
            // 
            // arabicEnterLB
            // 
            this.arabicEnterLB.AutoSize = true;
            this.arabicEnterLB.Location = new System.Drawing.Point(44, 240);
            this.arabicEnterLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arabicEnterLB.Name = "arabicEnterLB";
            this.arabicEnterLB.Size = new System.Drawing.Size(268, 20);
            this.arabicEnterLB.TabIndex = 3;
            this.arabicEnterLB.Text = "Enter a number between 1 and 3999";
            // 
            // romanEnterLB
            // 
            this.romanEnterLB.AutoSize = true;
            this.romanEnterLB.Location = new System.Drawing.Point(44, 340);
            this.romanEnterLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.romanEnterLB.Name = "romanEnterLB";
            this.romanEnterLB.Size = new System.Drawing.Size(202, 20);
            this.romanEnterLB.TabIndex = 4;
            this.romanEnterLB.Text = "Roman Numeral Equivalent";
            this.romanEnterLB.Click += new System.EventHandler(this.romanEnterLB_Click);
            // 
            // convertBTN
            // 
            this.convertBTN.Location = new System.Drawing.Point(48, 752);
            this.convertBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.convertBTN.Name = "convertBTN";
            this.convertBTN.Size = new System.Drawing.Size(112, 35);
            this.convertBTN.TabIndex = 5;
            this.convertBTN.Text = "Con&vert";
            this.convertBTN.UseVisualStyleBackColor = true;
            this.convertBTN.Click += new System.EventHandler(this.convertBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(381, 752);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(112, 35);
            this.exitBTN.TabIndex = 6;
            this.exitBTN.Text = "E&xit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(48, 289);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(444, 26);
            this.inputTextBox.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 389);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 324);
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 752);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DecToRom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.convertBTN);
            this.Controls.Add(this.romanEnterLB);
            this.Controls.Add(this.arabicEnterLB);
            this.Controls.Add(this.decToRomGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DecToRom";
            this.Text = "Roman Converter";
            this.Load += new System.EventHandler(this.DecToRom_Load);
            this.decToRomGroupBox.ResumeLayout(false);
            this.decToRomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox decToRomGroupBox;
        private System.Windows.Forms.RadioButton romToDecRadioButton;
        private System.Windows.Forms.RadioButton decToRomRadioButton;
        private System.Windows.Forms.Label arabicEnterLB;
        private System.Windows.Forms.Label romanEnterLB;
        private System.Windows.Forms.Button convertBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton referenceRadioButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

