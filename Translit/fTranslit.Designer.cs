namespace Translit
{
    partial class fTranslit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTranslit));
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.lbInputText = new System.Windows.Forms.Label();
            this.tbResultText = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCopyBuffer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputText
            // 
            this.tbInputText.Location = new System.Drawing.Point(15, 27);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(253, 20);
            this.tbInputText.TabIndex = 0;
            this.tbInputText.TextChanged += new System.EventHandler(this.tbInputText_TextChanged);
            // 
            // lbInputText
            // 
            this.lbInputText.AutoSize = true;
            this.lbInputText.Location = new System.Drawing.Point(12, 11);
            this.lbInputText.Name = "lbInputText";
            this.lbInputText.Size = new System.Drawing.Size(83, 13);
            this.lbInputText.TabIndex = 1;
            this.lbInputText.Text = "Введите текст:";
            // 
            // tbResultText
            // 
            this.tbResultText.Location = new System.Drawing.Point(15, 77);
            this.tbResultText.Name = "tbResultText";
            this.tbResultText.Size = new System.Drawing.Size(253, 20);
            this.tbResultText.TabIndex = 5;
            this.tbResultText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbResultText_MouseClick);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 61);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(62, 13);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стандарт: Passport (2013) ICAO";
            // 
            // lbCopyBuffer
            // 
            this.lbCopyBuffer.AutoSize = true;
            this.lbCopyBuffer.Location = new System.Drawing.Point(12, 100);
            this.lbCopyBuffer.Name = "lbCopyBuffer";
            this.lbCopyBuffer.Size = new System.Drawing.Size(179, 13);
            this.lbCopyBuffer.TabIndex = 8;
            this.lbCopyBuffer.Text = "Чтоб скопировать нажми на поле";
            // 
            // fTranslit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(278, 145);
            this.Controls.Add(this.lbCopyBuffer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbResultText);
            this.Controls.Add(this.lbInputText);
            this.Controls.Add(this.tbInputText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fTranslit";
            this.Text = "Транслит";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.Label lbInputText;
        private System.Windows.Forms.TextBox tbResultText;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCopyBuffer;
    }
}

