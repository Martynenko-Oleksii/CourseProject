namespace HomeLibrary
{
    partial class Instructions
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
            this.accept = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.rule1 = new System.Windows.Forms.Label();
            this.line21 = new System.Windows.Forms.Label();
            this.line22 = new System.Windows.Forms.Label();
            this.line23 = new System.Windows.Forms.Label();
            this.line24 = new System.Windows.Forms.Label();
            this.rule2 = new System.Windows.Forms.Label();
            this.rule3 = new System.Windows.Forms.Label();
            this.rule4 = new System.Windows.Forms.Label();
            this.rule5 = new System.Windows.Forms.Label();
            this.rule6 = new System.Windows.Forms.Label();
            this.rule61 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.FlatAppearance.BorderSize = 0;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accept.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept.Location = new System.Drawing.Point(254, 399);
            this.accept.Margin = new System.Windows.Forms.Padding(0);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(280, 53);
            this.accept.TabIndex = 0;
            this.accept.Text = "Прийняти";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(279, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(220, 19);
            this.header.TabIndex = 1;
            this.header.Text = "ІНСТРУКЦІЯ КОРИСТУВАЧА";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(12, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(579, 19);
            this.line1.TabIndex = 2;
            this.line1.Text = "Натискаючи кнопку \"Прийняти\" Ви підтверджуєте, що прочитали наступні правила:";
            this.line1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rule1
            // 
            this.rule1.AutoSize = true;
            this.rule1.Location = new System.Drawing.Point(44, 69);
            this.rule1.Name = "rule1";
            this.rule1.Size = new System.Drawing.Size(361, 19);
            this.rule1.TabIndex = 3;
            this.rule1.Text = "1) При додаванні нової книги обов\'язковими є поля:";
            // 
            // line21
            // 
            this.line21.AutoSize = true;
            this.line21.Location = new System.Drawing.Point(102, 88);
            this.line21.Name = "line21";
            this.line21.Size = new System.Drawing.Size(75, 19);
            this.line21.TabIndex = 4;
            this.line21.Text = "а) НАЗВА";
            // 
            // line22
            // 
            this.line22.AutoSize = true;
            this.line22.Location = new System.Drawing.Point(102, 107);
            this.line22.Name = "line22";
            this.line22.Size = new System.Drawing.Size(77, 19);
            this.line22.TabIndex = 5;
            this.line22.Text = "б) АВТОР";
            // 
            // line23
            // 
            this.line23.AutoSize = true;
            this.line23.Location = new System.Drawing.Point(102, 126);
            this.line23.Name = "line23";
            this.line23.Size = new System.Drawing.Size(176, 19);
            this.line23.TabIndex = 6;
            this.line23.Text = "в) РОЗДІЛ БІБЛІОТЕКИ";
            // 
            // line24
            // 
            this.line24.AutoSize = true;
            this.line24.Location = new System.Drawing.Point(102, 145);
            this.line24.Name = "line24";
            this.line24.Size = new System.Drawing.Size(112, 19);
            this.line24.TabIndex = 7;
            this.line24.Text = "г) НАЯВНІСТЬ";
            // 
            // rule2
            // 
            this.rule2.AutoSize = true;
            this.rule2.Location = new System.Drawing.Point(44, 164);
            this.rule2.Name = "rule2";
            this.rule2.Size = new System.Drawing.Size(532, 19);
            this.rule2.TabIndex = 8;
            this.rule2.Text = "2) Для редагування виберіть книгу зі списку та натисніть кнопку \"Редагувати\"";
            // 
            // rule3
            // 
            this.rule3.AutoSize = true;
            this.rule3.Location = new System.Drawing.Point(44, 194);
            this.rule3.Name = "rule3";
            this.rule3.Size = new System.Drawing.Size(640, 19);
            this.rule3.TabIndex = 9;
            this.rule3.Text = "3) Для видалення книги зі списку оберіть необхідну та натисніть клавішу \"Delete\" " +
    "на клавіатурі";
            // 
            // rule4
            // 
            this.rule4.AutoSize = true;
            this.rule4.Location = new System.Drawing.Point(44, 253);
            this.rule4.Name = "rule4";
            this.rule4.Size = new System.Drawing.Size(677, 19);
            this.rule4.TabIndex = 10;
            this.rule4.Text = "5) При вибірці книг за РОЗДІЛОМ Ви можете ввести власноруч назву розділу або обра" +
    "ти зі списку";
            // 
            // rule5
            // 
            this.rule5.AutoSize = true;
            this.rule5.Location = new System.Drawing.Point(44, 282);
            this.rule5.Name = "rule5";
            this.rule5.Size = new System.Drawing.Size(656, 19);
            this.rule5.TabIndex = 11;
            this.rule5.Text = "6) Щоб після сортування повернути початковий список, натисніть кнопку \"Початковий" +
    " список\"";
            // 
            // rule6
            // 
            this.rule6.AutoSize = true;
            this.rule6.Location = new System.Drawing.Point(44, 311);
            this.rule6.Name = "rule6";
            this.rule6.Size = new System.Drawing.Size(593, 19);
            this.rule6.TabIndex = 12;
            this.rule6.Text = "7) Для прегляду цієї інструкції під час користування програмою натисніть клавішу " +
    "\"F1\" ";
            // 
            // rule61
            // 
            this.rule61.AutoSize = true;
            this.rule61.Location = new System.Drawing.Point(66, 330);
            this.rule61.Name = "rule61";
            this.rule61.Size = new System.Drawing.Size(378, 19);
            this.rule61.TabIndex = 13;
            this.rule61.Text = "або натисніть на відповідний пункт у верхньому меню";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "4) Для перегляду додаткової інформації про книгу натисніть на необхідній двічі лі" +
    "вою кнопкою миші";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rule61);
            this.Controls.Add(this.rule6);
            this.Controls.Add(this.rule5);
            this.Controls.Add(this.rule4);
            this.Controls.Add(this.rule3);
            this.Controls.Add(this.rule2);
            this.Controls.Add(this.line24);
            this.Controls.Add(this.line23);
            this.Controls.Add(this.line22);
            this.Controls.Add(this.line21);
            this.Controls.Add(this.rule1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.accept);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інструкція користувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label rule1;
        private System.Windows.Forms.Label line21;
        private System.Windows.Forms.Label line22;
        private System.Windows.Forms.Label line23;
        private System.Windows.Forms.Label line24;
        private System.Windows.Forms.Label rule2;
        private System.Windows.Forms.Label rule3;
        private System.Windows.Forms.Label rule4;
        private System.Windows.Forms.Label rule5;
        private System.Windows.Forms.Label rule6;
        private System.Windows.Forms.Label rule61;
        private System.Windows.Forms.Label label1;
    }
}