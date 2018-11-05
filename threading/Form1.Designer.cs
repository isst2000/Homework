namespace threading
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadButton = new System.Windows.Forms.Button();
            this.ReadTimeLabel = new System.Windows.Forms.Label();
            this.ReadTimeText = new System.Windows.Forms.TextBox();
            this.ReadCountLabel = new System.Windows.Forms.Label();
            this.ReadCountText = new System.Windows.Forms.TextBox();
            this.SearchWordLabel = new System.Windows.Forms.Label();
            this.SearchWordText = new System.Windows.Forms.TextBox();
            this.PSearchButton = new System.Windows.Forms.Button();
            this.MDLabel = new System.Windows.Forms.Label();
            this.MDText = new System.Windows.Forms.TextBox();
            this.TCLabel = new System.Windows.Forms.Label();
            this.TCText = new System.Windows.Forms.TextBox();
            this.CTLabel = new System.Windows.Forms.Label();
            this.CTText = new System.Windows.Forms.TextBox();
            this.STLabel = new System.Windows.Forms.Label();
            this.STText = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadButton.Location = new System.Drawing.Point(12, 12);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(245, 50);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Чтение из файла";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // ReadTimeLabel
            // 
            this.ReadTimeLabel.AutoSize = true;
            this.ReadTimeLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTimeLabel.Location = new System.Drawing.Point(300, 23);
            this.ReadTimeLabel.Name = "ReadTimeLabel";
            this.ReadTimeLabel.Size = new System.Drawing.Size(236, 29);
            this.ReadTimeLabel.TabIndex = 1;
            this.ReadTimeLabel.Text = "Время чтения из файла:";
            // 
            // ReadTimeText
            // 
            this.ReadTimeText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadTimeText.Location = new System.Drawing.Point(669, 20);
            this.ReadTimeText.Name = "ReadTimeText";
            this.ReadTimeText.ReadOnly = true;
            this.ReadTimeText.Size = new System.Drawing.Size(198, 35);
            this.ReadTimeText.TabIndex = 2;
            // 
            // ReadCountLabel
            // 
            this.ReadCountLabel.AutoSize = true;
            this.ReadCountLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadCountLabel.Location = new System.Drawing.Point(300, 69);
            this.ReadCountLabel.Name = "ReadCountLabel";
            this.ReadCountLabel.Size = new System.Drawing.Size(363, 29);
            this.ReadCountLabel.TabIndex = 3;
            this.ReadCountLabel.Text = "Количество уникальных слов в файле:";
            // 
            // ReadCountText
            // 
            this.ReadCountText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadCountText.Location = new System.Drawing.Point(669, 66);
            this.ReadCountText.Name = "ReadCountText";
            this.ReadCountText.ReadOnly = true;
            this.ReadCountText.Size = new System.Drawing.Size(198, 35);
            this.ReadCountText.TabIndex = 4;
            // 
            // SearchWordLabel
            // 
            this.SearchWordLabel.AutoSize = true;
            this.SearchWordLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordLabel.Location = new System.Drawing.Point(114, 127);
            this.SearchWordLabel.Name = "SearchWordLabel";
            this.SearchWordLabel.Size = new System.Drawing.Size(181, 29);
            this.SearchWordLabel.TabIndex = 5;
            this.SearchWordLabel.Text = "Слово для поиска:";
            // 
            // SearchWordText
            // 
            this.SearchWordText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchWordText.Location = new System.Drawing.Point(305, 121);
            this.SearchWordText.Name = "SearchWordText";
            this.SearchWordText.Size = new System.Drawing.Size(358, 35);
            this.SearchWordText.TabIndex = 6;
            // 
            // PSearchButton
            // 
            this.PSearchButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PSearchButton.Location = new System.Drawing.Point(12, 225);
            this.PSearchButton.Name = "PSearchButton";
            this.PSearchButton.Size = new System.Drawing.Size(245, 167);
            this.PSearchButton.TabIndex = 7;
            this.PSearchButton.Text = "Многопоточный поиск";
            this.PSearchButton.UseVisualStyleBackColor = true;
            this.PSearchButton.Click += new System.EventHandler(this.PSearchButton_Click);
            // 
            // MDLabel
            // 
            this.MDLabel.AutoSize = true;
            this.MDLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDLabel.Location = new System.Drawing.Point(300, 225);
            this.MDLabel.Name = "MDLabel";
            this.MDLabel.Size = new System.Drawing.Size(372, 29);
            this.MDLabel.TabIndex = 8;
            this.MDLabel.Text = "Максимальное расстояние для поиска:";
            // 
            // MDText
            // 
            this.MDText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MDText.Location = new System.Drawing.Point(678, 222);
            this.MDText.Name = "MDText";
            this.MDText.Size = new System.Drawing.Size(116, 35);
            this.MDText.TabIndex = 9;
            // 
            // TCLabel
            // 
            this.TCLabel.AutoSize = true;
            this.TCLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCLabel.Location = new System.Drawing.Point(300, 272);
            this.TCLabel.Name = "TCLabel";
            this.TCLabel.Size = new System.Drawing.Size(200, 29);
            this.TCLabel.TabIndex = 10;
            this.TCLabel.Text = "Количество потоков:";
            // 
            // TCText
            // 
            this.TCText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TCText.Location = new System.Drawing.Point(506, 269);
            this.TCText.Name = "TCText";
            this.TCText.Size = new System.Drawing.Size(116, 35);
            this.TCText.TabIndex = 11;
            // 
            // CTLabel
            // 
            this.CTLabel.AutoSize = true;
            this.CTLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTLabel.Location = new System.Drawing.Point(300, 316);
            this.CTLabel.Name = "CTLabel";
            this.CTLabel.Size = new System.Drawing.Size(328, 29);
            this.CTLabel.TabIndex = 12;
            this.CTLabel.Text = "Вычисленное количество потоков:";
            // 
            // CTText
            // 
            this.CTText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTText.Location = new System.Drawing.Point(634, 313);
            this.CTText.Name = "CTText";
            this.CTText.ReadOnly = true;
            this.CTText.Size = new System.Drawing.Size(160, 35);
            this.CTText.TabIndex = 13;
            // 
            // STLabel
            // 
            this.STLabel.AutoSize = true;
            this.STLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STLabel.Location = new System.Drawing.Point(300, 360);
            this.STLabel.Name = "STLabel";
            this.STLabel.Size = new System.Drawing.Size(297, 29);
            this.STLabel.TabIndex = 14;
            this.STLabel.Text = "Время многопоточного поиска:";
            // 
            // STText
            // 
            this.STText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.STText.Location = new System.Drawing.Point(603, 357);
            this.STText.Name = "STText";
            this.STText.ReadOnly = true;
            this.STText.Size = new System.Drawing.Size(191, 35);
            this.STText.TabIndex = 15;
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 29;
            this.ResultBox.Location = new System.Drawing.Point(12, 412);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(855, 323);
            this.ResultBox.TabIndex = 16;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportButton.Location = new System.Drawing.Point(12, 754);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(245, 50);
            this.ReportButton.TabIndex = 17;
            this.ReportButton.Text = "Сохранение отчёта";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(622, 754);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(245, 50);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 820);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.STText);
            this.Controls.Add(this.STLabel);
            this.Controls.Add(this.CTText);
            this.Controls.Add(this.CTLabel);
            this.Controls.Add(this.TCText);
            this.Controls.Add(this.TCLabel);
            this.Controls.Add(this.MDText);
            this.Controls.Add(this.MDLabel);
            this.Controls.Add(this.PSearchButton);
            this.Controls.Add(this.SearchWordText);
            this.Controls.Add(this.SearchWordLabel);
            this.Controls.Add(this.ReadCountText);
            this.Controls.Add(this.ReadCountLabel);
            this.Controls.Add(this.ReadTimeText);
            this.Controls.Add(this.ReadTimeLabel);
            this.Controls.Add(this.ReadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Многопоточный поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Label ReadTimeLabel;
        private System.Windows.Forms.TextBox ReadTimeText;
        private System.Windows.Forms.Label ReadCountLabel;
        private System.Windows.Forms.TextBox ReadCountText;
        private System.Windows.Forms.Label SearchWordLabel;
        private System.Windows.Forms.TextBox SearchWordText;
        private System.Windows.Forms.Button PSearchButton;
        private System.Windows.Forms.Label MDLabel;
        private System.Windows.Forms.TextBox MDText;
        private System.Windows.Forms.Label TCLabel;
        private System.Windows.Forms.TextBox TCText;
        private System.Windows.Forms.Label CTLabel;
        private System.Windows.Forms.TextBox CTText;
        private System.Windows.Forms.Label STLabel;
        private System.Windows.Forms.TextBox STText;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

