namespace HomeLibrary
{
    partial class AddChange
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
            this.save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.publisherText = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.bookSizeText = new System.Windows.Forms.TextBox();
            this.bookSizeLabel = new System.Windows.Forms.Label();
            this.controlButtons = new System.Windows.Forms.GroupBox();
            this.availabilityGroup = new System.Windows.Forms.GroupBox();
            this.nonAvailable = new System.Windows.Forms.RadioButton();
            this.available = new System.Windows.Forms.RadioButton();
            this.departmentText = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.fromWhereLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.fromWhereText = new System.Windows.Forms.TextBox();
            this.rateText = new System.Windows.Forms.TextBox();
            this.controlButtons.SuspendLayout();
            this.availabilityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(554, 10);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(200, 40);
            this.save.TabIndex = 0;
            this.save.TabStop = false;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveBook);
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(6, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(200, 40);
            this.back.TabIndex = 1;
            this.back.TabStop = false;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.BackToMain);
            // 
            // titleText
            // 
            this.titleText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleText.Location = new System.Drawing.Point(12, 39);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(355, 35);
            this.titleText.TabIndex = 1;
            // 
            // authorText
            // 
            this.authorText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorText.Location = new System.Drawing.Point(417, 39);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(355, 35);
            this.authorText.TabIndex = 2;
            // 
            // publisherText
            // 
            this.publisherText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherText.Location = new System.Drawing.Point(12, 123);
            this.publisherText.Name = "publisherText";
            this.publisherText.Size = new System.Drawing.Size(355, 35);
            this.publisherText.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(7, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 27);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Назва книги:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(412, 9);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(146, 27);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Автор книги:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherLabel.Location = new System.Drawing.Point(7, 93);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(153, 27);
            this.publisherLabel.TabIndex = 7;
            this.publisherLabel.Text = "Видавництво:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(412, 93);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(50, 27);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Рік:";
            // 
            // yearText
            // 
            this.yearText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearText.Location = new System.Drawing.Point(417, 123);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(150, 35);
            this.yearText.TabIndex = 4;
            // 
            // bookSizeText
            // 
            this.bookSizeText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookSizeText.Location = new System.Drawing.Point(622, 123);
            this.bookSizeText.Name = "bookSizeText";
            this.bookSizeText.Size = new System.Drawing.Size(150, 35);
            this.bookSizeText.TabIndex = 5;
            // 
            // bookSizeLabel
            // 
            this.bookSizeLabel.AutoSize = true;
            this.bookSizeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookSizeLabel.Location = new System.Drawing.Point(617, 93);
            this.bookSizeLabel.Name = "bookSizeLabel";
            this.bookSizeLabel.Size = new System.Drawing.Size(112, 27);
            this.bookSizeLabel.TabIndex = 11;
            this.bookSizeLabel.Text = "Сторінки:";
            // 
            // controlButtons
            // 
            this.controlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlButtons.Controls.Add(this.back);
            this.controlButtons.Controls.Add(this.save);
            this.controlButtons.Location = new System.Drawing.Point(12, 486);
            this.controlButtons.Name = "controlButtons";
            this.controlButtons.Size = new System.Drawing.Size(760, 56);
            this.controlButtons.TabIndex = 12;
            this.controlButtons.TabStop = false;
            // 
            // availabilityGroup
            // 
            this.availabilityGroup.Controls.Add(this.nonAvailable);
            this.availabilityGroup.Controls.Add(this.available);
            this.availabilityGroup.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availabilityGroup.Location = new System.Drawing.Point(417, 177);
            this.availabilityGroup.Name = "availabilityGroup";
            this.availabilityGroup.Size = new System.Drawing.Size(355, 65);
            this.availabilityGroup.TabIndex = 13;
            this.availabilityGroup.TabStop = false;
            this.availabilityGroup.Text = "Наявність";
            // 
            // nonAvailable
            // 
            this.nonAvailable.AutoSize = true;
            this.nonAvailable.Location = new System.Drawing.Point(149, 28);
            this.nonAvailable.Name = "nonAvailable";
            this.nonAvailable.Size = new System.Drawing.Size(94, 31);
            this.nonAvailable.TabIndex = 1;
            this.nonAvailable.Text = "Немає";
            this.nonAvailable.UseVisualStyleBackColor = true;
            // 
            // available
            // 
            this.available.AutoSize = true;
            this.available.Location = new System.Drawing.Point(6, 28);
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(46, 31);
            this.available.TabIndex = 0;
            this.available.Text = "Є";
            this.available.UseVisualStyleBackColor = true;
            // 
            // departmentText
            // 
            this.departmentText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentText.Location = new System.Drawing.Point(12, 207);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(355, 35);
            this.departmentText.TabIndex = 6;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departmentLabel.Location = new System.Drawing.Point(7, 177);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(193, 27);
            this.departmentLabel.TabIndex = 15;
            this.departmentLabel.Text = "Розділ бібліотеки:";
            // 
            // fromWhereLabel
            // 
            this.fromWhereLabel.AutoSize = true;
            this.fromWhereLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromWhereLabel.Location = new System.Drawing.Point(7, 264);
            this.fromWhereLabel.Name = "fromWhereLabel";
            this.fromWhereLabel.Size = new System.Drawing.Size(212, 27);
            this.fromWhereLabel.TabIndex = 16;
            this.fromWhereLabel.Text = "Походження книги:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateLabel.Location = new System.Drawing.Point(412, 264);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(188, 27);
            this.rateLabel.TabIndex = 17;
            this.rateLabel.Text = "Особиста оцінка:";
            // 
            // fromWhereText
            // 
            this.fromWhereText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromWhereText.Location = new System.Drawing.Point(12, 294);
            this.fromWhereText.Multiline = true;
            this.fromWhereText.Name = "fromWhereText";
            this.fromWhereText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fromWhereText.Size = new System.Drawing.Size(355, 143);
            this.fromWhereText.TabIndex = 7;
            // 
            // rateText
            // 
            this.rateText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rateText.Location = new System.Drawing.Point(417, 294);
            this.rateText.Multiline = true;
            this.rateText.Name = "rateText";
            this.rateText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rateText.Size = new System.Drawing.Size(355, 143);
            this.rateText.TabIndex = 8;
            // 
            // AddChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 554);
            this.ControlBox = false;
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.fromWhereText);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.fromWhereLabel);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.availabilityGroup);
            this.Controls.Add(this.controlButtons);
            this.Controls.Add(this.bookSizeLabel);
            this.Controls.Add(this.bookSizeText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.publisherText);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.titleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "AddChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Книга";
            this.controlButtons.ResumeLayout(false);
            this.availabilityGroup.ResumeLayout(false);
            this.availabilityGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox publisherText;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox bookSizeText;
        private System.Windows.Forms.Label bookSizeLabel;
        private System.Windows.Forms.GroupBox controlButtons;
        private System.Windows.Forms.GroupBox availabilityGroup;
        private System.Windows.Forms.RadioButton nonAvailable;
        private System.Windows.Forms.RadioButton available;
        private System.Windows.Forms.TextBox departmentText;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label fromWhereLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox fromWhereText;
        private System.Windows.Forms.TextBox rateText;
    }
}