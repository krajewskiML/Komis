namespace Komis
{
    partial class FindCar
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
            this.BrandLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrandComboBox = new System.Windows.Forms.ComboBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.ViewCarBox = new System.Windows.Forms.PictureBox();
            this.PictureOverviewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandLabel.Location = new System.Drawing.Point(55, 50);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(60, 24);
            this.BrandLabel.TabIndex = 5;
            this.BrandLabel.Text = "Brand";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(199, 50);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(63, 24);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineLabel.Location = new System.Drawing.Point(335, 50);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(71, 24);
            this.EngineLabel.TabIndex = 7;
            this.EngineLabel.Text = "Engine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color";
            // 
            // BrandComboBox
            // 
            this.BrandComboBox.FormattingEnabled = true;
            this.BrandComboBox.Location = new System.Drawing.Point(59, 86);
            this.BrandComboBox.Name = "BrandComboBox";
            this.BrandComboBox.Size = new System.Drawing.Size(121, 21);
            this.BrandComboBox.TabIndex = 12;
            this.BrandComboBox.SelectedIndexChanged += new System.EventHandler(this.BrandComboBox_SelectedIndexChanged);
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Location = new System.Drawing.Point(203, 86);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModelComboBox.TabIndex = 12;
            this.ModelComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelComboBox_SelectedIndexChanged);
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Location = new System.Drawing.Point(339, 86);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(121, 21);
            this.EngineComboBox.TabIndex = 12;
            this.EngineComboBox.SelectedIndexChanged += new System.EventHandler(this.EngineComboBox_SelectedIndexChanged);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(490, 86);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 12;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // ViewCarBox
            // 
            this.ViewCarBox.BackColor = System.Drawing.SystemColors.Window;
            this.ViewCarBox.Location = new System.Drawing.Point(59, 170);
            this.ViewCarBox.Name = "ViewCarBox";
            this.ViewCarBox.Size = new System.Drawing.Size(265, 210);
            this.ViewCarBox.TabIndex = 12;
            this.ViewCarBox.TabStop = false;
            // 
            // PictureOverviewLabel
            // 
            this.PictureOverviewLabel.AutoSize = true;
            this.PictureOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureOverviewLabel.Location = new System.Drawing.Point(57, 126);
            this.PictureOverviewLabel.Name = "PictureOverviewLabel";
            this.PictureOverviewLabel.Size = new System.Drawing.Size(123, 24);
            this.PictureOverviewLabel.TabIndex = 13;
            this.PictureOverviewLabel.Text = "Car Overview";
            // 
            // FindCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureOverviewLabel);
            this.Controls.Add(this.ViewCarBox);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.EngineComboBox);
            this.Controls.Add(this.ModelComboBox);
            this.Controls.Add(this.BrandComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EngineLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BrandLabel);
            this.Name = "FindCar";
            this.Text = "FindCar";
            this.Load += new System.EventHandler(this.FindCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.PictureBox ViewCarBox;
        private System.Windows.Forms.Label PictureOverviewLabel;
    }
}