namespace pixelBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            timerForTime = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            muteProgram = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(110, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 15);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(12, 1);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 1;
            button1.Text = "СТАРТ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timerForTime
            // 
            timerForTime.Enabled = true;
            timerForTime.Tick += timerForTime_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 3;
            // 
            // muteProgram
            // 
            muteProgram.Location = new Point(12, 36);
            muteProgram.Name = "muteProgram";
            muteProgram.Size = new Size(75, 23);
            muteProgram.TabIndex = 4;
            muteProgram.Text = "Mute";
            muteProgram.UseVisualStyleBackColor = true;
            muteProgram.Click += muteProgram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 98);
            Controls.Add(muteProgram);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private System.Windows.Forms.Timer timerForTime;
        private TextBox textBox1;
        private Button muteProgram;
    }
}