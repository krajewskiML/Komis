namespace Komis
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
            this.AddCarButton = new System.Windows.Forms.Button();
            this.ReserveCarButton = new System.Windows.Forms.Button();
            this.FindCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(93, 272);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(75, 23);
            this.AddCarButton.TabIndex = 0;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // ReserveCarButton
            // 
            this.ReserveCarButton.Location = new System.Drawing.Point(268, 273);
            this.ReserveCarButton.Name = "ReserveCarButton";
            this.ReserveCarButton.Size = new System.Drawing.Size(162, 23);
            this.ReserveCarButton.TabIndex = 1;
            this.ReserveCarButton.Text = "Zarezerwuj Auto";
            this.ReserveCarButton.UseVisualStyleBackColor = true;
            this.ReserveCarButton.Click += new System.EventHandler(this.ReserveCarButton_Click);
            // 
            // FindCarButton
            // 
            this.FindCarButton.Location = new System.Drawing.Point(498, 272);
            this.FindCarButton.Name = "FindCarButton";
            this.FindCarButton.Size = new System.Drawing.Size(139, 23);
            this.FindCarButton.TabIndex = 2;
            this.FindCarButton.Text = "Find Car";
            this.FindCarButton.UseVisualStyleBackColor = true;
            this.FindCarButton.Click += new System.EventHandler(this.FindCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 412);
            this.Controls.Add(this.FindCarButton);
            this.Controls.Add(this.ReserveCarButton);
            this.Controls.Add(this.AddCarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button ReserveCarButton;
        private System.Windows.Forms.Button FindCarButton;
    }
}

