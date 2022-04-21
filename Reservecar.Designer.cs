namespace Komis
{
    partial class Reservecar
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
            this.BrandBox = new System.Windows.Forms.ComboBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.EngineBox = new System.Windows.Forms.ComboBox();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.CarPreviewBox = new System.Windows.Forms.PictureBox();
            this.CarPreviewLabel = new System.Windows.Forms.Label();
            this.ReserveButton = new System.Windows.Forms.Button();
            this.TestDrivePicker = new System.Windows.Forms.MonthCalendar();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarPreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandBox
            // 
            this.BrandBox.FormattingEnabled = true;
            this.BrandBox.Location = new System.Drawing.Point(43, 91);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(121, 21);
            this.BrandBox.TabIndex = 1;
            this.BrandBox.SelectedIndexChanged += new System.EventHandler(this.BrandBox_SelectedIndexChanged);
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Location = new System.Drawing.Point(43, 53);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(35, 13);
            this.BrandLabel.TabIndex = 2;
            this.BrandLabel.Text = "Brand";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(201, 52);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model";
            // 
            // ModelBox
            // 
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(204, 91);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 21);
            this.ModelBox.TabIndex = 4;
            this.ModelBox.SelectedIndexChanged += new System.EventHandler(this.ModelBox_SelectedIndexChanged);
            // 
            // EngineBox
            // 
            this.EngineBox.FormattingEnabled = true;
            this.EngineBox.Location = new System.Drawing.Point(43, 188);
            this.EngineBox.Name = "EngineBox";
            this.EngineBox.Size = new System.Drawing.Size(121, 21);
            this.EngineBox.TabIndex = 5;
            this.EngineBox.SelectedIndexChanged += new System.EventHandler(this.EngineBox_SelectedIndexChanged);
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Location = new System.Drawing.Point(43, 155);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(40, 13);
            this.EngineLabel.TabIndex = 6;
            this.EngineLabel.Text = "Engine";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(204, 154);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(31, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(204, 187);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(121, 21);
            this.ColorBox.TabIndex = 8;
            this.ColorBox.SelectedIndexChanged += new System.EventHandler(this.ColorBox_SelectedIndexChanged);
            // 
            // CarPreviewBox
            // 
            this.CarPreviewBox.Location = new System.Drawing.Point(43, 300);
            this.CarPreviewBox.Name = "CarPreviewBox";
            this.CarPreviewBox.Size = new System.Drawing.Size(282, 138);
            this.CarPreviewBox.TabIndex = 9;
            this.CarPreviewBox.TabStop = false;
            // 
            // CarPreviewLabel
            // 
            this.CarPreviewLabel.AutoSize = true;
            this.CarPreviewLabel.Location = new System.Drawing.Point(43, 258);
            this.CarPreviewLabel.Name = "CarPreviewLabel";
            this.CarPreviewLabel.Size = new System.Drawing.Size(64, 13);
            this.CarPreviewLabel.TabIndex = 10;
            this.CarPreviewLabel.Text = "Car Preview";
            // 
            // ReserveButton
            // 
            this.ReserveButton.Location = new System.Drawing.Point(518, 415);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(75, 23);
            this.ReserveButton.TabIndex = 11;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // TestDrivePicker
            // 
            this.TestDrivePicker.Location = new System.Drawing.Point(518, 91);
            this.TestDrivePicker.Name = "TestDrivePicker";
            this.TestDrivePicker.TabIndex = 12;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(518, 300);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "If date is bolded,\r\n then chosen car is\r\n ressrved by someone";
            // 
            // Reservecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.TestDrivePicker);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.CarPreviewLabel);
            this.Controls.Add(this.CarPreviewBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.EngineLabel);
            this.Controls.Add(this.EngineBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.BrandBox);
            this.Name = "Reservecar";
            this.Text = "Reservecar";
            this.Load += new System.EventHandler(this.Reservecar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarPreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BrandBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.ComboBox EngineBox;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.PictureBox CarPreviewBox;
        private System.Windows.Forms.Label CarPreviewLabel;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.MonthCalendar TestDrivePicker;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}