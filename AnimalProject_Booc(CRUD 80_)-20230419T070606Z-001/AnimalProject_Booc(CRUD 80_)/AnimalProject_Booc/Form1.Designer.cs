namespace AnimalProject_Booc
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearTable = new System.Windows.Forms.Button();
            this.function = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.function.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameBox.Location = new System.Drawing.Point(34, 159);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(203, 21);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ageBox.Location = new System.Drawing.Point(34, 198);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(203, 21);
            this.ageBox.TabIndex = 3;
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeBox.Location = new System.Drawing.Point(34, 237);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(203, 21);
            this.typeBox.TabIndex = 4;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayPicker.Location = new System.Drawing.Point(34, 354);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 22);
            this.birthdayPicker.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animal Type:";
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.Location = new System.Drawing.Point(34, 276);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(203, 21);
            this.colorBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSalmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color:";
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(9, 8);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(99, 24);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(138, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 24);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(268, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(391, 8);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(87, 24);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(690, 445);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 27);
            this.button5.TabIndex = 0;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(358, 403);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.genderBox.Location = new System.Drawing.Point(34, 315);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(203, 21);
            this.genderBox.TabIndex = 6;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Sex.Location = new System.Drawing.Point(31, 299);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(62, 16);
            this.Sex.TabIndex = 18;
            this.Sex.Text = "Gender:";
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.id_box.Location = new System.Drawing.Point(34, 120);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(203, 21);
            this.id_box.TabIndex = 1;
            this.id_box.TextChanged += new System.EventHandler(this.id_box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Animal ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Felix Titling", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(478, 43);
            this.label6.TabIndex = 21;
            this.label6.Text = "ANIMAL KINGDOM Reg.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Birthdate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Search -->";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MistyRose;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(68, 393);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 27);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearTable
            // 
            this.clearTable.BackColor = System.Drawing.Color.MistyRose;
            this.clearTable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTable.Location = new System.Drawing.Point(581, 397);
            this.clearTable.Name = "clearTable";
            this.clearTable.Size = new System.Drawing.Size(110, 27);
            this.clearTable.TabIndex = 0;
            this.clearTable.Text = "Clear Table";
            this.clearTable.UseVisualStyleBackColor = false;
            this.clearTable.Click += new System.EventHandler(this.clearTable_Click);
            // 
            // function
            // 
            this.function.BackColor = System.Drawing.Color.MistyRose;
            this.function.Controls.Add(this.removeButton);
            this.function.Controls.Add(this.button3);
            this.function.Controls.Add(this.saveButton);
            this.function.Controls.Add(this.viewButton);
            this.function.Location = new System.Drawing.Point(243, 60);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(493, 38);
            this.function.TabIndex = 26;
            this.function.TabStop = false;
            this.function.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(761, 484);
            this.Controls.Add(this.function);
            this.Controls.Add(this.clearTable);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Animal Kingdom";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.function.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearTable;
        private System.Windows.Forms.GroupBox function;
    }
}

