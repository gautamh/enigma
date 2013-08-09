namespace EnigmaApp_v2
{
    partial class Enigma
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRotorIStart = new System.Windows.Forms.Label();
            this.lblRotorIIStart = new System.Windows.Forms.Label();
            this.lblRotorIIIStart = new System.Windows.Forms.Label();
            this.txtRotorIStart = new System.Windows.Forms.TextBox();
            this.txtRotorIIStart = new System.Windows.Forms.TextBox();
            this.txtRotorIIIStart = new System.Windows.Forms.TextBox();
            this.rxtOutput = new System.Windows.Forms.RichTextBox();
            this.rxtInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 57);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(433, 57);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(327, 534);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(436, 534);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(381, 563);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRotorIStart
            // 
            this.lblRotorIStart.AutoSize = true;
            this.lblRotorIStart.Location = new System.Drawing.Point(12, 17);
            this.lblRotorIStart.Name = "lblRotorIStart";
            this.lblRotorIStart.Size = new System.Drawing.Size(35, 13);
            this.lblRotorIStart.TabIndex = 9;
            this.lblRotorIStart.Text = "I Start";
            // 
            // lblRotorIIStart
            // 
            this.lblRotorIIStart.AutoSize = true;
            this.lblRotorIIStart.Location = new System.Drawing.Point(62, 17);
            this.lblRotorIIStart.Name = "lblRotorIIStart";
            this.lblRotorIIStart.Size = new System.Drawing.Size(38, 13);
            this.lblRotorIIStart.TabIndex = 10;
            this.lblRotorIIStart.Text = "II Start";
            // 
            // lblRotorIIIStart
            // 
            this.lblRotorIIIStart.AutoSize = true;
            this.lblRotorIIIStart.Location = new System.Drawing.Point(111, 17);
            this.lblRotorIIIStart.Name = "lblRotorIIIStart";
            this.lblRotorIIIStart.Size = new System.Drawing.Size(41, 13);
            this.lblRotorIIIStart.TabIndex = 11;
            this.lblRotorIIIStart.Text = "III Start";
            // 
            // txtRotorIStart
            // 
            this.txtRotorIStart.Location = new System.Drawing.Point(15, 33);
            this.txtRotorIStart.Name = "txtRotorIStart";
            this.txtRotorIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIStart.TabIndex = 12;
            // 
            // txtRotorIIStart
            // 
            this.txtRotorIIStart.Location = new System.Drawing.Point(65, 33);
            this.txtRotorIIStart.Name = "txtRotorIIStart";
            this.txtRotorIIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIIStart.TabIndex = 13;
            // 
            // txtRotorIIIStart
            // 
            this.txtRotorIIIStart.Location = new System.Drawing.Point(114, 33);
            this.txtRotorIIIStart.Name = "txtRotorIIIStart";
            this.txtRotorIIIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIIIStart.TabIndex = 14;
            // 
            // rxtOutput
            // 
            this.rxtOutput.Location = new System.Drawing.Point(436, 73);
            this.rxtOutput.Name = "rxtOutput";
            this.rxtOutput.Size = new System.Drawing.Size(390, 435);
            this.rxtOutput.TabIndex = 15;
            this.rxtOutput.Text = "";
            // 
            // rxtInput
            // 
            this.rxtInput.Location = new System.Drawing.Point(12, 73);
            this.rxtInput.Name = "rxtInput";
            this.rxtInput.Size = new System.Drawing.Size(390, 435);
            this.rxtInput.TabIndex = 16;
            this.rxtInput.Text = "";
            this.rxtInput.TextChanged += new System.EventHandler(this.rxtInput_TextChanged);
            // 
            // Enigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 650);
            this.Controls.Add(this.rxtInput);
            this.Controls.Add(this.rxtOutput);
            this.Controls.Add(this.txtRotorIIIStart);
            this.Controls.Add(this.txtRotorIIStart);
            this.Controls.Add(this.txtRotorIStart);
            this.Controls.Add(this.lblRotorIIIStart);
            this.Controls.Add(this.lblRotorIIStart);
            this.Controls.Add(this.lblRotorIStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Enigma";
            this.Text = "Enigma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRotorIStart;
        private System.Windows.Forms.Label lblRotorIIStart;
        private System.Windows.Forms.Label lblRotorIIIStart;
        private System.Windows.Forms.TextBox txtRotorIStart;
        private System.Windows.Forms.TextBox txtRotorIIStart;
        private System.Windows.Forms.TextBox txtRotorIIIStart;
        private System.Windows.Forms.RichTextBox rxtOutput;
        private System.Windows.Forms.RichTextBox rxtInput;

    }
}

