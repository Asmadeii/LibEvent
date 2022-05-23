namespace LibEvent
{
    partial class addEvCalendar
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
            this.tEvBox = new System.Windows.Forms.TextBox();
            this.sEvBox = new System.Windows.Forms.TextBox();
            this.fEvBox = new System.Windows.Forms.TextBox();
            this.ev3 = new System.Windows.Forms.Label();
            this.ev2 = new System.Windows.Forms.Label();
            this.ev1 = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            this.addEvButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tEvBox
            // 
            this.tEvBox.Location = new System.Drawing.Point(33, 283);
            this.tEvBox.Name = "tEvBox";
            this.tEvBox.Size = new System.Drawing.Size(281, 23);
            this.tEvBox.TabIndex = 40;
            this.tEvBox.Enter += new System.EventHandler(this.tEvBox_Enter);
            this.tEvBox.Leave += new System.EventHandler(this.tEvBox_Leave);
            // 
            // sEvBox
            // 
            this.sEvBox.Location = new System.Drawing.Point(33, 214);
            this.sEvBox.Name = "sEvBox";
            this.sEvBox.Size = new System.Drawing.Size(281, 23);
            this.sEvBox.TabIndex = 39;
            this.sEvBox.Enter += new System.EventHandler(this.sEvBox_Enter);
            this.sEvBox.Leave += new System.EventHandler(this.sEvBox_Leave);
            // 
            // fEvBox
            // 
            this.fEvBox.Location = new System.Drawing.Point(33, 145);
            this.fEvBox.Name = "fEvBox";
            this.fEvBox.Size = new System.Drawing.Size(281, 23);
            this.fEvBox.TabIndex = 38;
            this.fEvBox.Enter += new System.EventHandler(this.fEvBox_Enter);
            this.fEvBox.Leave += new System.EventHandler(this.fEvBox_Leave);
            // 
            // ev3
            // 
            this.ev3.AutoSize = true;
            this.ev3.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ev3.Location = new System.Drawing.Point(33, 247);
            this.ev3.Name = "ev3";
            this.ev3.Size = new System.Drawing.Size(101, 26);
            this.ev3.TabIndex = 37;
            this.ev3.Text = "Мероприятие";
            // 
            // ev2
            // 
            this.ev2.AutoSize = true;
            this.ev2.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ev2.Location = new System.Drawing.Point(33, 178);
            this.ev2.Name = "ev2";
            this.ev2.Size = new System.Drawing.Size(101, 26);
            this.ev2.TabIndex = 36;
            this.ev2.Text = "Мероприятие";
            // 
            // ev1
            // 
            this.ev1.AutoSize = true;
            this.ev1.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ev1.Location = new System.Drawing.Point(33, 109);
            this.ev1.Name = "ev1";
            this.ev1.Size = new System.Drawing.Size(101, 26);
            this.ev1.TabIndex = 35;
            this.ev1.Text = "Мероприятие";
            // 
            // autoLabel
            // 
            this.autoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.autoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoLabel.Font = new System.Drawing.Font("Pobeda", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.autoLabel.Location = new System.Drawing.Point(0, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(346, 100);
            this.autoLabel.TabIndex = 34;
            this.autoLabel.Text = "Добавить мероприятие";
            this.autoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEvButton
            // 
            this.addEvButton.AutoSize = true;
            this.addEvButton.Font = new System.Drawing.Font("Pobeda", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEvButton.Location = new System.Drawing.Point(109, 341);
            this.addEvButton.Name = "addEvButton";
            this.addEvButton.Size = new System.Drawing.Size(125, 36);
            this.addEvButton.TabIndex = 41;
            this.addEvButton.Text = "Добавить";
            this.addEvButton.UseVisualStyleBackColor = true;
            this.addEvButton.Click += new System.EventHandler(this.addEvButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(325, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 19);
            this.closeButton.TabIndex = 42;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addEvCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(346, 390);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addEvButton);
            this.Controls.Add(this.tEvBox);
            this.Controls.Add(this.sEvBox);
            this.Controls.Add(this.fEvBox);
            this.Controls.Add(this.ev3);
            this.Controls.Add(this.ev2);
            this.Controls.Add(this.ev1);
            this.Controls.Add(this.autoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addEvCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tEvBox;
        private TextBox sEvBox;
        private TextBox fEvBox;
        private Label ev3;
        private Label ev2;
        private Label ev1;
        private Label autoLabel;
        private Button addEvButton;
        private Label closeButton;
    }
}