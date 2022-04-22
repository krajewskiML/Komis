namespace Komis
{
    partial class AddCar
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
            this.BrandsBox = new System.Windows.Forms.ComboBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.EngineBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.CancelAddingButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandsBox
            // 
            this.BrandsBox.FormattingEnabled = true;
            this.BrandsBox.Location = new System.Drawing.Point(45, 104);
            this.BrandsBox.Name = "BrandsBox";
            this.BrandsBox.Size = new System.Drawing.Size(121, 21);
            this.BrandsBox.TabIndex = 0;
            this.BrandsBox.SelectedIndexChanged += new System.EventHandler(this.BrandsBox_SelectedIndexChanged);
            // 
            // ModelBox
            // 
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(256, 104);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 21);
            this.ModelBox.TabIndex = 1;
            this.ModelBox.SelectedIndexChanged += new System.EventHandler(this.ModelBox_SelectedIndexChanged);
            // 
            // EngineBox
            // 
            this.EngineBox.FormattingEnabled = true;
            this.EngineBox.Location = new System.Drawing.Point(462, 104);
            this.EngineBox.Name = "EngineBox";
            this.EngineBox.Size = new System.Drawing.Size(121, 21);
            this.EngineBox.TabIndex = 2;
            this.EngineBox.SelectedIndexChanged += new System.EventHandler(this.EngineBox_SelectedIndexChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(692, 104);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(121, 21);
            this.ColorBox.TabIndex = 3;
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.Location = new System.Drawing.Point(45, 58);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(60, 24);
            this.BrandLabel.TabIndex = 4;
            this.BrandLabel.Text = "Brand";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(256, 58);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineLabel.Location = new System.Drawing.Point(462, 58);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(71, 24);
            this.EngineLabel.TabIndex = 6;
            this.EngineLabel.Text = "Engine";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(692, 58);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(55, 24);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color";
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.AddPictureBox.Location = new System.Drawing.Point(256, 200);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(327, 210);
            this.AddPictureBox.TabIndex = 8;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddPictureBox_DragDrop);
            this.AddPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddPictureBox_DragEnter);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(692, 295);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(90, 32);
            this.AddCarButton.TabIndex = 9;
            this.AddCarButton.Text = "Add car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // CancelAddingButton
            // 
            this.CancelAddingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAddingButton.Location = new System.Drawing.Point(48, 200);
            this.CancelAddingButton.Name = "CancelAddingButton";
            this.CancelAddingButton.Size = new System.Drawing.Size(82, 33);
            this.CancelAddingButton.TabIndex = 10;
            this.CancelAddingButton.Text = "Cancel ";
            this.CancelAddingButton.UseVisualStyleBackColor = true;
            this.CancelAddingButton.Click += new System.EventHandler(this.CancelAddingButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(48, 371);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(82, 38);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 173);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Drop picture of your car here";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CancelAddingButton);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.EngineLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.EngineBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.BrandsBox);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BrandsBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.ComboBox EngineBox;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button CancelAddingButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
    }
}