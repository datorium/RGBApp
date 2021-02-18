namespace RGBApp
{
    partial class Form1
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
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.NumericRed = new System.Windows.Forms.NumericUpDown();
            this.GreenBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.NumericGreen = new System.Windows.Forms.NumericUpDown();
            this.NumericBlue = new System.Windows.Forms.NumericUpDown();
            this.RandomColorButton = new System.Windows.Forms.Button();
            this.RedSlider = new System.Windows.Forms.TrackBar();
            this.GreenSlider = new System.Windows.Forms.TrackBar();
            this.BlueSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Red;
            this.ColorBox.Location = new System.Drawing.Point(774, 104);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(209, 193);
            this.ColorBox.TabIndex = 0;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            this.ColorBox.MouseEnter += new System.EventHandler(this.ColorBox_MouseEnter);
            this.ColorBox.MouseLeave += new System.EventHandler(this.ColorBox_MouseLeave);
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Red;
            this.RedBox.Location = new System.Drawing.Point(49, 104);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(205, 193);
            this.RedBox.TabIndex = 1;
            this.RedBox.TabStop = false;
            // 
            // NumericRed
            // 
            this.NumericRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericRed.Location = new System.Drawing.Point(49, 43);
            this.NumericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericRed.Name = "NumericRed";
            this.NumericRed.Size = new System.Drawing.Size(205, 41);
            this.NumericRed.TabIndex = 2;
            this.NumericRed.ValueChanged += new System.EventHandler(this.NumericRed_ValueChanged);
            // 
            // GreenBox
            // 
            this.GreenBox.BackColor = System.Drawing.Color.Lime;
            this.GreenBox.Location = new System.Drawing.Point(283, 104);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(205, 193);
            this.GreenBox.TabIndex = 3;
            this.GreenBox.TabStop = false;
            // 
            // BlueBox
            // 
            this.BlueBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.BlueBox.Location = new System.Drawing.Point(522, 104);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(205, 193);
            this.BlueBox.TabIndex = 4;
            this.BlueBox.TabStop = false;
            // 
            // NumericGreen
            // 
            this.NumericGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericGreen.Location = new System.Drawing.Point(283, 43);
            this.NumericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericGreen.Name = "NumericGreen";
            this.NumericGreen.Size = new System.Drawing.Size(205, 41);
            this.NumericGreen.TabIndex = 5;
            this.NumericGreen.ValueChanged += new System.EventHandler(this.NumericGreen_ValueChanged);
            // 
            // NumericBlue
            // 
            this.NumericBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericBlue.Location = new System.Drawing.Point(522, 43);
            this.NumericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericBlue.Name = "NumericBlue";
            this.NumericBlue.Size = new System.Drawing.Size(205, 41);
            this.NumericBlue.TabIndex = 6;
            this.NumericBlue.ValueChanged += new System.EventHandler(this.NumericBlue_ValueChanged);
            // 
            // RandomColorButton
            // 
            this.RandomColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomColorButton.Location = new System.Drawing.Point(49, 324);
            this.RandomColorButton.Name = "RandomColorButton";
            this.RandomColorButton.Size = new System.Drawing.Size(678, 70);
            this.RandomColorButton.TabIndex = 7;
            this.RandomColorButton.Text = "Random Color";
            this.RandomColorButton.UseVisualStyleBackColor = true;
            this.RandomColorButton.Click += new System.EventHandler(this.RandomColorButton_Click);
            // 
            // RedSlider
            // 
            this.RedSlider.Location = new System.Drawing.Point(49, 410);
            this.RedSlider.Maximum = 255;
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(678, 56);
            this.RedSlider.TabIndex = 8;
            this.RedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedSlider.Scroll += new System.EventHandler(this.RedSlider_Scroll);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Location = new System.Drawing.Point(49, 453);
            this.GreenSlider.Maximum = 255;
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(678, 56);
            this.GreenSlider.TabIndex = 9;
            this.GreenSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenSlider.Scroll += new System.EventHandler(this.GreenSlider_Scroll);
            // 
            // BlueSlider
            // 
            this.BlueSlider.Location = new System.Drawing.Point(49, 498);
            this.BlueSlider.Maximum = 255;
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(678, 56);
            this.BlueSlider.TabIndex = 10;
            this.BlueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueSlider.Scroll += new System.EventHandler(this.BlueSlider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 557);
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.RedSlider);
            this.Controls.Add(this.RandomColorButton);
            this.Controls.Add(this.NumericBlue);
            this.Controls.Add(this.NumericGreen);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.NumericRed);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.ColorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.PictureBox RedBox;
        private System.Windows.Forms.NumericUpDown NumericRed;
        private System.Windows.Forms.PictureBox GreenBox;
        private System.Windows.Forms.PictureBox BlueBox;
        private System.Windows.Forms.NumericUpDown NumericGreen;
        private System.Windows.Forms.NumericUpDown NumericBlue;
        private System.Windows.Forms.Button RandomColorButton;
        private System.Windows.Forms.TrackBar RedSlider;
        private System.Windows.Forms.TrackBar GreenSlider;
        private System.Windows.Forms.TrackBar BlueSlider;
    }
}

