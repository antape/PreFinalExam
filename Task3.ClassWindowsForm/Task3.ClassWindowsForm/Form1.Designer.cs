namespace Task3.ClassWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDate = new System.Windows.Forms.Button();
            this.removeDate = new System.Windows.Forms.Button();
            this.searchDate = new System.Windows.Forms.Button();
            this.showDate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDate
            // 
            this.addDate.Location = new System.Drawing.Point(105, 23);
            this.addDate.Name = "addDate";
            this.addDate.Size = new System.Drawing.Size(75, 23);
            this.addDate.TabIndex = 0;
            this.addDate.Text = "Add";
            this.addDate.UseVisualStyleBackColor = true;
            this.addDate.Click += new System.EventHandler(this.addDate_Click);
            // 
            // removeDate
            // 
            this.removeDate.Location = new System.Drawing.Point(105, 57);
            this.removeDate.Name = "removeDate";
            this.removeDate.Size = new System.Drawing.Size(75, 23);
            this.removeDate.TabIndex = 1;
            this.removeDate.Text = "Remove";
            this.removeDate.UseVisualStyleBackColor = true;
            this.removeDate.Click += new System.EventHandler(this.removeDate_Click);
            // 
            // searchDate
            // 
            this.searchDate.Location = new System.Drawing.Point(105, 146);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(75, 23);
            this.searchDate.TabIndex = 2;
            this.searchDate.Text = "Search";
            this.searchDate.UseVisualStyleBackColor = true;
            this.searchDate.Click += new System.EventHandler(this.searchDate_Click);
            // 
            // showDate
            // 
            this.showDate.Location = new System.Drawing.Point(105, 91);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(75, 23);
            this.showDate.TabIndex = 3;
            this.showDate.Text = "Show";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.Click += new System.EventHandler(this.showDate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showDate);
            this.Controls.Add(this.searchDate);
            this.Controls.Add(this.removeDate);
            this.Controls.Add(this.addDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDate;
        private System.Windows.Forms.Button removeDate;
        private System.Windows.Forms.Button searchDate;
        private System.Windows.Forms.Button showDate;
        private System.Windows.Forms.Button button1;
    }
}

