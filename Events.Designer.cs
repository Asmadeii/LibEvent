namespace LibEvent
{
    partial class Events
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
            this.autoLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.backButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.monday = new System.Windows.Forms.Label();
            this.tuesday = new System.Windows.Forms.Label();
            this.wednesday = new System.Windows.Forms.Label();
            this.thursday = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.Label();
            this.saturday = new System.Windows.Forms.Label();
            this.sunday = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.docButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(1048, 100);
            this.autoLabel.TabIndex = 14;
            this.autoLabel.Text = "Календарь мероприятий";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(1027, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(11, 215);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(1027, 522);
            this.dayContainer.TabIndex = 16;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(477, 743);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.AutoSize = true;
            this.prevButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prevButton.Image = global::LibEvent.Properties.Resources.rewind;
            this.prevButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prevButton.Location = new System.Drawing.Point(227, 115);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(141, 38);
            this.prevButton.TabIndex = 23;
            this.prevButton.Text = "Предыдущий";
            this.prevButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Image = global::LibEvent.Properties.Resources.next;
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.Location = new System.Drawing.Point(699, 115);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(127, 38);
            this.nextButton.TabIndex = 24;
            this.nextButton.Text = "Следующий";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.monday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monday.Location = new System.Drawing.Point(54, 172);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(100, 26);
            this.monday.TabIndex = 25;
            this.monday.Text = "Понедельник";
            this.monday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.tuesday.Location = new System.Drawing.Point(213, 172);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(68, 26);
            this.tuesday.TabIndex = 26;
            this.tuesday.Text = "Вторник";
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.wednesday.Location = new System.Drawing.Point(363, 172);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(52, 26);
            this.wednesday.TabIndex = 27;
            this.wednesday.Text = "Среда";
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.thursday.Location = new System.Drawing.Point(506, 172);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(65, 26);
            this.thursday.TabIndex = 28;
            this.thursday.Text = "Четверг";
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.friday.Location = new System.Drawing.Point(659, 172);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(68, 26);
            this.friday.TabIndex = 29;
            this.friday.Text = "Пятница";
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.saturday.Location = new System.Drawing.Point(799, 172);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(69, 26);
            this.saturday.TabIndex = 30;
            this.saturday.Text = "Суббота";
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.sunday.Location = new System.Drawing.Point(936, 172);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(97, 26);
            this.sunday.TabIndex = 31;
            this.sunday.Text = "Воскресенье";
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Pobeda", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(370, 115);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(323, 32);
            this.lbDate.TabIndex = 32;
            this.lbDate.Text = "МЕСЯЦ ГОД";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibEvent.Properties.Resources.friday;
            this.pictureBox1.Location = new System.Drawing.Point(616, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibEvent.Properties.Resources.thursday;
            this.pictureBox2.Location = new System.Drawing.Point(463, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibEvent.Properties.Resources.saturday;
            this.pictureBox3.Location = new System.Drawing.Point(756, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibEvent.Properties.Resources.sunday;
            this.pictureBox4.Location = new System.Drawing.Point(893, 161);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LibEvent.Properties.Resources.wednesday;
            this.pictureBox5.Location = new System.Drawing.Point(320, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 37;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LibEvent.Properties.Resources.tuesday;
            this.pictureBox6.Location = new System.Drawing.Point(170, 161);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LibEvent.Properties.Resources.monday1;
            this.pictureBox7.Location = new System.Drawing.Point(11, 161);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.pictureBox8.Image = global::LibEvent.Properties.Resources.season;
            this.pictureBox8.Location = new System.Drawing.Point(312, 23);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(56, 56);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 39;
            this.pictureBox8.TabStop = false;
            // 
            // docButton
            // 
            this.docButton.AutoSize = true;
            this.docButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docButton.Image = global::LibEvent.Properties.Resources.file;
            this.docButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.docButton.Location = new System.Drawing.Point(12, 743);
            this.docButton.Name = "docButton";
            this.docButton.Size = new System.Drawing.Size(155, 38);
            this.docButton.TabIndex = 40;
            this.docButton.Text = "Документация";
            this.docButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.docButton.UseVisualStyleBackColor = true;
            this.docButton.Click += new System.EventHandler(this.docButton_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1048, 791);
            this.Controls.Add(this.docButton);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.friday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label autoLabel;
        private Label closeButton;
        private FlowLayoutPanel dayContainer;
        private Button backButton;
        private Button prevButton;
        private Button nextButton;
        private Label monday;
        private Label tuesday;
        private Label wednesday;
        private Label thursday;
        private Label friday;
        private Label saturday;
        private Label sunday;
        private Label lbDate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button docButton;
    }
}