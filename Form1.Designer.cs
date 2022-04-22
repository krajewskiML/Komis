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
            this.AddCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCarButton.Location = new System.Drawing.Point(172, 36);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(162, 80);
            this.AddCarButton.TabIndex = 0;
            this.AddCarButton.Text = "Add Car To Car Dealership";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // ReserveCarButton
            // 
            this.ReserveCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveCarButton.Location = new System.Drawing.Point(172, 148);
            this.ReserveCarButton.Name = "ReserveCarButton";
            this.ReserveCarButton.Size = new System.Drawing.Size(162, 89);
            this.ReserveCarButton.TabIndex = 1;
            this.ReserveCarButton.Text = "Reserve Car For A Test Drive";
            this.ReserveCarButton.UseVisualStyleBackColor = true;
            this.ReserveCarButton.Click += new System.EventHandler(this.ReserveCarButton_Click);
            // 
            // FindCarButton
            // 
            this.FindCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindCarButton.Location = new System.Drawing.Point(172, 268);
            this.FindCarButton.Name = "FindCarButton";
            this.FindCarButton.Size = new System.Drawing.Size(162, 87);
            this.FindCarButton.TabIndex = 2;
            this.FindCarButton.Text = "Find Car";
            this.FindCarButton.UseVisualStyleBackColor = true;
            this.FindCarButton.Click += new System.EventHandler(this.FindCarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 410);
            this.Controls.Add(this.FindCarButton);
            this.Controls.Add(this.ReserveCarButton);
            this.Controls.Add(this.AddCarButton);
            this.Name = "Form1";
            this.Text = "Car Dealership";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Button ReserveCarButton;
        private System.Windows.Forms.Button FindCarButton;
    }
}

