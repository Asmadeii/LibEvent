namespace LibEvent
{
    partial class Reports
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
            this.backButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPartn = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.autoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = global::LibEvent.Properties.Resources.arrows;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(131, 352);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(95, 38);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Назад";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(336, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 45;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibEvent.Properties.Resources.deal;
            this.pictureBox4.Location = new System.Drawing.Point(56, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibEvent.Properties.Resources.informative;
            this.pictureBox2.Location = new System.Drawing.Point(56, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibEvent.Properties.Resources.list;
            this.pictureBox1.Location = new System.Drawing.Point(56, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnPartn
            // 
            this.btnPartn.AutoSize = true;
            this.btnPartn.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPartn.Location = new System.Drawing.Point(118, 277);
            this.btnPartn.Name = "btnPartn";
            this.btnPartn.Size = new System.Drawing.Size(182, 36);
            this.btnPartn.TabIndex = 41;
            this.btnPartn.Text = "Партнеры мероприятия";
            this.btnPartn.UseVisualStyleBackColor = true;
            this.btnPartn.Click += new System.EventHandler(this.btnPartn_Click);
            // 
            // btnList
            // 
            this.btnList.AutoSize = true;
            this.btnList.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(118, 145);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(182, 36);
            this.btnList.TabIndex = 40;
            this.btnList.Text = "Список мероприятий";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.AutoSize = true;
            this.btnInfo.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(118, 211);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(182, 36);
            this.btnInfo.TabIndex = 39;
            this.btnInfo.Text = "Инфоповод";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(357, 100);
            this.autoLabel.TabIndex = 38;
            this.autoLabel.Text = "Отчеты";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(357, 411);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPartn);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Label closeButton;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnPartn;
        private Button btnList;
        private Button btnInfo;
        private Label autoLabel;
    }
}