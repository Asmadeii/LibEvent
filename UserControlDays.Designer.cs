namespace LibEvent
{
    partial class UserControlDays
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.text_1 = new System.Windows.Forms.Label();
            this.text_2 = new System.Windows.Forms.Label();
            this.text_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.AutoSize = true;
            this.lbdays.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbdays.Location = new System.Drawing.Point(3, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(27, 26);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "01";
            this.lbdays.Click += new System.EventHandler(this.lbdays_Click);
            // 
            // text_1
            // 
            this.text_1.AutoSize = true;
            this.text_1.Font = new System.Drawing.Font("Pobeda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_1.Location = new System.Drawing.Point(36, 12);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(14, 17);
            this.text_1.TabIndex = 1;
            this.text_1.Text = "  ";
            // 
            // text_2
            // 
            this.text_2.AutoSize = true;
            this.text_2.Font = new System.Drawing.Font("Pobeda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_2.Location = new System.Drawing.Point(36, 34);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(17, 17);
            this.text_2.TabIndex = 2;
            this.text_2.Text = "   ";
            // 
            // text_3
            // 
            this.text_3.AutoSize = true;
            this.text_3.Font = new System.Drawing.Font("Pobeda", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_3.Location = new System.Drawing.Point(36, 56);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(17, 17);
            this.text_3.TabIndex = 3;
            this.text_3.Text = "   ";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.text_3);
            this.Controls.Add(this.text_2);
            this.Controls.Add(this.text_1);
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(140, 80);
            this.DoubleClick += new System.EventHandler(this.addEventButton_Doubleclick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbdays;
        private Label text_1;
        private Label text_2;
        private Label text_3;
    }
}
