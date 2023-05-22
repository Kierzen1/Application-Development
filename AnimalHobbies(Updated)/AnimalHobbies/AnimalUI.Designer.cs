namespace Exercise_9
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.animalType = new System.Windows.Forms.TextBox();
            this.animalName = new System.Windows.Forms.TextBox();
            this.ownersName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.animalGender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.animalAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.animalFood = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(358, 403);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 23);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // animalType
            // 
            this.animalType.BackColor = System.Drawing.SystemColors.Window;
            this.animalType.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animalType.Location = new System.Drawing.Point(34, 120);
            this.animalType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalType.Name = "animalType";
            this.animalType.Size = new System.Drawing.Size(203, 23);
            this.animalType.TabIndex = 7;
            this.animalType.TextChanged += new System.EventHandler(this.animalType_TextChanged);
            // 
            // animalName
            // 
            this.animalName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animalName.Location = new System.Drawing.Point(36, 165);
            this.animalName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(203, 23);
            this.animalName.TabIndex = 8;
            // 
            // ownersName
            // 
            this.ownersName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ownersName.Location = new System.Drawing.Point(38, 390);
            this.ownersName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ownersName.Name = "ownersName";
            this.ownersName.Size = new System.Drawing.Size(203, 23);
            this.ownersName.TabIndex = 12;
            this.ownersName.TextChanged += new System.EventHandler(this.ownersName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Tan;
            this.dataGridView1.Location = new System.Drawing.Point(252, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 287);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 346);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(272, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Search -->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Animal Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Animal Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(33, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Owners Name:";
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.MistyRose;
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewButton.Location = new System.Drawing.Point(7, 8);
            this.viewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(99, 24);
            this.viewButton.TabIndex = 0;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.MistyRose;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.insertButton.Location = new System.Drawing.Point(121, 8);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(99, 24);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Save";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MistyRose;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(243, 8);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(99, 24);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(378, 8);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 24);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.MistyRose;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(690, 445);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(67, 27);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "EXIT";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 43);
            this.label5.TabIndex = 28;
            this.label5.Text = "Animal Kingdom Reg.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.insertButton);
            this.groupBox1.Controls.Add(this.viewButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Location = new System.Drawing.Point(243, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 38);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(581, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear Table";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Animal Gender:";
            // 
            // animalGender
            // 
            this.animalGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animalGender.Location = new System.Drawing.Point(34, 210);
            this.animalGender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalGender.Name = "animalGender";
            this.animalGender.Size = new System.Drawing.Size(203, 23);
            this.animalGender.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(35, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Animal Age:";
            // 
            // animalAge
            // 
            this.animalAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.animalAge.Location = new System.Drawing.Point(36, 255);
            this.animalAge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalAge.Name = "animalAge";
            this.animalAge.Size = new System.Drawing.Size(203, 23);
            this.animalAge.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(33, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Animal Food Type:";
            // 
            // animalFood
            // 
            this.animalFood.FormattingEnabled = true;
            this.animalFood.Items.AddRange(new object[] {
            "Plant-Based",
            "Meat-Based"});
            this.animalFood.Location = new System.Drawing.Point(38, 300);
            this.animalFood.Name = "animalFood";
            this.animalFood.Size = new System.Drawing.Size(199, 23);
            this.animalFood.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(72, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 24);
            this.button2.TabIndex = 38;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.animalFood);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.animalAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.animalGender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ownersName);
            this.Controls.Add(this.animalName);
            this.Controls.Add(this.animalType);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Animal Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox animalType;
        private System.Windows.Forms.TextBox animalName;
        private System.Windows.Forms.TextBox ownersName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox animalGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox animalAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox animalFood;
        private System.Windows.Forms.Button button2;
    }
}

