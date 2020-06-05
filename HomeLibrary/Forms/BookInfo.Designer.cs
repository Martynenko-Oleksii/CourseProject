namespace HomeLibrary
{
    partial class BookInfo
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
            this.infoHeader = new System.Windows.Forms.Label();
            this.infoBookTitle = new System.Windows.Forms.Label();
            this.infoPublisher = new System.Windows.Forms.Label();
            this.infoYear = new System.Windows.Forms.Label();
            this.infoSize = new System.Windows.Forms.Label();
            this.infoFrom = new System.Windows.Forms.Label();
            this.infoRate = new System.Windows.Forms.Label();
            this.infoBookPublisher = new System.Windows.Forms.Label();
            this.infoBookYear = new System.Windows.Forms.Label();
            this.infoBookSize = new System.Windows.Forms.Label();
            this.infoBookFrom = new System.Windows.Forms.TextBox();
            this.infoBookRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // infoHeader
            // 
            this.infoHeader.AutoSize = true;
            this.infoHeader.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoHeader.Location = new System.Drawing.Point(61, 9);
            this.infoHeader.Name = "infoHeader";
            this.infoHeader.Size = new System.Drawing.Size(349, 27);
            this.infoHeader.TabIndex = 0;
            this.infoHeader.Text = "Додаткова інформація про книгу";
            // 
            // infoBookTitle
            // 
            this.infoBookTitle.AutoSize = true;
            this.infoBookTitle.Location = new System.Drawing.Point(62, 45);
            this.infoBookTitle.Name = "infoBookTitle";
            this.infoBookTitle.Size = new System.Drawing.Size(0, 23);
            this.infoBookTitle.TabIndex = 1;
            // 
            // infoPublisher
            // 
            this.infoPublisher.AutoSize = true;
            this.infoPublisher.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPublisher.Location = new System.Drawing.Point(12, 99);
            this.infoPublisher.Name = "infoPublisher";
            this.infoPublisher.Size = new System.Drawing.Size(137, 24);
            this.infoPublisher.TabIndex = 2;
            this.infoPublisher.Text = "Видавництво";
            // 
            // infoYear
            // 
            this.infoYear.AutoSize = true;
            this.infoYear.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoYear.Location = new System.Drawing.Point(13, 140);
            this.infoYear.Name = "infoYear";
            this.infoYear.Size = new System.Drawing.Size(126, 24);
            this.infoYear.TabIndex = 3;
            this.infoYear.Text = "Рік видання";
            // 
            // infoSize
            // 
            this.infoSize.AutoSize = true;
            this.infoSize.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoSize.Location = new System.Drawing.Point(13, 181);
            this.infoSize.Name = "infoSize";
            this.infoSize.Size = new System.Drawing.Size(186, 24);
            this.infoSize.TabIndex = 4;
            this.infoSize.Text = "Кількість сторінок";
            // 
            // infoFrom
            // 
            this.infoFrom.AutoSize = true;
            this.infoFrom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoFrom.Location = new System.Drawing.Point(12, 259);
            this.infoFrom.Name = "infoFrom";
            this.infoFrom.Size = new System.Drawing.Size(126, 24);
            this.infoFrom.TabIndex = 5;
            this.infoFrom.Text = "Походження";
            // 
            // infoRate
            // 
            this.infoRate.AutoSize = true;
            this.infoRate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoRate.Location = new System.Drawing.Point(238, 259);
            this.infoRate.Name = "infoRate";
            this.infoRate.Size = new System.Drawing.Size(78, 24);
            this.infoRate.TabIndex = 6;
            this.infoRate.Text = "Оцінка";
            // 
            // infoBookPublisher
            // 
            this.infoBookPublisher.AutoSize = true;
            this.infoBookPublisher.Location = new System.Drawing.Point(238, 99);
            this.infoBookPublisher.Name = "infoBookPublisher";
            this.infoBookPublisher.Size = new System.Drawing.Size(0, 23);
            this.infoBookPublisher.TabIndex = 7;
            // 
            // infoBookYear
            // 
            this.infoBookYear.AutoSize = true;
            this.infoBookYear.Location = new System.Drawing.Point(238, 140);
            this.infoBookYear.Name = "infoBookYear";
            this.infoBookYear.Size = new System.Drawing.Size(0, 23);
            this.infoBookYear.TabIndex = 8;
            // 
            // infoBookSize
            // 
            this.infoBookSize.AutoSize = true;
            this.infoBookSize.Location = new System.Drawing.Point(238, 181);
            this.infoBookSize.Name = "infoBookSize";
            this.infoBookSize.Size = new System.Drawing.Size(0, 23);
            this.infoBookSize.TabIndex = 9;
            // 
            // infoBookFrom
            // 
            this.infoBookFrom.Location = new System.Drawing.Point(17, 296);
            this.infoBookFrom.Multiline = true;
            this.infoBookFrom.Name = "infoBookFrom";
            this.infoBookFrom.ReadOnly = true;
            this.infoBookFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoBookFrom.Size = new System.Drawing.Size(182, 145);
            this.infoBookFrom.TabIndex = 10;
            this.infoBookFrom.TabStop = false;
            // 
            // infoBookRate
            // 
            this.infoBookRate.Location = new System.Drawing.Point(242, 296);
            this.infoBookRate.Multiline = true;
            this.infoBookRate.Name = "infoBookRate";
            this.infoBookRate.ReadOnly = true;
            this.infoBookRate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoBookRate.Size = new System.Drawing.Size(205, 145);
            this.infoBookRate.TabIndex = 11;
            this.infoBookRate.TabStop = false;
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 486);
            this.Controls.Add(this.infoBookRate);
            this.Controls.Add(this.infoBookFrom);
            this.Controls.Add(this.infoBookSize);
            this.Controls.Add(this.infoBookYear);
            this.Controls.Add(this.infoBookPublisher);
            this.Controls.Add(this.infoRate);
            this.Controls.Add(this.infoFrom);
            this.Controls.Add(this.infoSize);
            this.Controls.Add(this.infoYear);
            this.Controls.Add(this.infoPublisher);
            this.Controls.Add(this.infoBookTitle);
            this.Controls.Add(this.infoHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 525);
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додатково";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoHeader;
        private System.Windows.Forms.Label infoBookTitle;
        private System.Windows.Forms.Label infoPublisher;
        private System.Windows.Forms.Label infoYear;
        private System.Windows.Forms.Label infoSize;
        private System.Windows.Forms.Label infoFrom;
        private System.Windows.Forms.Label infoRate;
        private System.Windows.Forms.Label infoBookPublisher;
        private System.Windows.Forms.Label infoBookYear;
        private System.Windows.Forms.Label infoBookSize;
        private System.Windows.Forms.TextBox infoBookFrom;
        private System.Windows.Forms.TextBox infoBookRate;
    }
}