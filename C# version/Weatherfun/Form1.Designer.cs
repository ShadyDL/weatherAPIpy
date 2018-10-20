namespace Weatherfun
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.getReqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(94, 76);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(128, 48);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(102, 150);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(100, 29);
            this.cityTextbox.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 3;
            // 
            // getReqButton
            // 
            this.getReqButton.Location = new System.Drawing.Point(102, 213);
            this.getReqButton.Name = "getReqButton";
            this.getReqButton.Size = new System.Drawing.Size(120, 32);
            this.getReqButton.TabIndex = 4;
            this.getReqButton.Text = "Request";
            this.getReqButton.UseVisualStyleBackColor = true;
            this.getReqButton.Click += new System.EventHandler(this.getReqButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 937);
            this.Controls.Add(this.getReqButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Text = "Stad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button getReqButton;
    }
}

