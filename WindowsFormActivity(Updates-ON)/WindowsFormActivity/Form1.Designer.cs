namespace WindowsFormActivity
{
    partial class Animal_Kingdom
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
            this.canineButton = new System.Windows.Forms.Button();
            this.felineButton = new System.Windows.Forms.Button();
            this.horseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // canineButton
            // 
            this.canineButton.ForeColor = System.Drawing.Color.Coral;
            this.canineButton.Location = new System.Drawing.Point(69, 43);
            this.canineButton.Name = "canineButton";
            this.canineButton.Size = new System.Drawing.Size(145, 23);
            this.canineButton.TabIndex = 0;
            this.canineButton.Text = "Canine";
            this.canineButton.UseVisualStyleBackColor = true;
            this.canineButton.Click += new System.EventHandler(this.canineButton_Click);
            // 
            // felineButton
            // 
            this.felineButton.ForeColor = System.Drawing.Color.Coral;
            this.felineButton.Location = new System.Drawing.Point(69, 86);
            this.felineButton.Name = "felineButton";
            this.felineButton.Size = new System.Drawing.Size(145, 23);
            this.felineButton.TabIndex = 1;
            this.felineButton.Text = "Feline";
            this.felineButton.UseVisualStyleBackColor = true;
            this.felineButton.Click += new System.EventHandler(this.felineButton_Click);
            // 
            // horseButton
            // 
            this.horseButton.ForeColor = System.Drawing.Color.Coral;
            this.horseButton.Location = new System.Drawing.Point(69, 134);
            this.horseButton.Name = "horseButton";
            this.horseButton.Size = new System.Drawing.Size(145, 23);
            this.horseButton.TabIndex = 2;
            this.horseButton.Text = "Horse";
            this.horseButton.UseVisualStyleBackColor = true;
            this.horseButton.Click += new System.EventHandler(this.horseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(69, 181);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Animal_Kingdom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormActivity.Properties.Resources.animals;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.horseButton);
            this.Controls.Add(this.felineButton);
            this.Controls.Add(this.canineButton);
            this.Name = "Animal_Kingdom";
            this.Text = "Animal Kingdom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button canineButton;
        private System.Windows.Forms.Button felineButton;
        private System.Windows.Forms.Button horseButton;
        private System.Windows.Forms.Button exitButton;
    }
}

