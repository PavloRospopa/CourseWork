namespace GymLife
{
    partial class AddNewWorkoutWindow
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
            this.label7 = new System.Windows.Forms.Label();
            this.chooseTrainerButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.trainerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.durationComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionMultiTextBox = new System.Windows.Forms.TextBox();
            this.timePortionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(159, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ім\'я та прізвище тренера";
            // 
            // chooseTrainerButton
            // 
            this.chooseTrainerButton.Location = new System.Drawing.Point(159, 175);
            this.chooseTrainerButton.Name = "chooseTrainerButton";
            this.chooseTrainerButton.Size = new System.Drawing.Size(123, 23);
            this.chooseTrainerButton.TabIndex = 49;
            this.chooseTrainerButton.Text = "Вибрати тренера...";
            this.chooseTrainerButton.UseVisualStyleBackColor = true;
            this.chooseTrainerButton.Click += new System.EventHandler(this.chooseTrainerButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(271, 363);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 29);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(159, 363);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 29);
            this.OkButton.TabIndex = 47;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // trainerTextBox
            // 
            this.trainerTextBox.Location = new System.Drawing.Point(159, 211);
            this.trainerTextBox.Name = "trainerTextBox";
            this.trainerTextBox.ReadOnly = true;
            this.trainerTextBox.Size = new System.Drawing.Size(200, 20);
            this.trainerTextBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Тренер";
            // 
            // groupsComboBox
            // 
            this.groupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsComboBox.FormattingEnabled = true;
            this.groupsComboBox.Location = new System.Drawing.Point(159, 66);
            this.groupsComboBox.Name = "groupsComboBox";
            this.groupsComboBox.Size = new System.Drawing.Size(200, 21);
            this.groupsComboBox.TabIndex = 44;
            this.groupsComboBox.SelectedIndexChanged += new System.EventHandler(this.groupsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "* Група";
            // 
            // datePortionDateTimePicker
            // 
            this.datePortionDateTimePicker.Location = new System.Drawing.Point(159, 100);
            this.datePortionDateTimePicker.Name = "datePortionDateTimePicker";
            this.datePortionDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.datePortionDateTimePicker.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "* Тривалість тренування";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "* Дата та час тренування";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "Для створення нового тренування групи заповніть нижче\r\nнаведені поля. \r\nПоля, поз" +
    "начені (*) є обов\'язковими.";
            // 
            // durationComboBox
            // 
            this.durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationComboBox.FormattingEnabled = true;
            this.durationComboBox.Location = new System.Drawing.Point(159, 140);
            this.durationComboBox.Name = "durationComboBox";
            this.durationComboBox.Size = new System.Drawing.Size(123, 21);
            this.durationComboBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Опис тренування";
            // 
            // descriptionMultiTextBox
            // 
            this.descriptionMultiTextBox.Location = new System.Drawing.Point(162, 274);
            this.descriptionMultiTextBox.Multiline = true;
            this.descriptionMultiTextBox.Name = "descriptionMultiTextBox";
            this.descriptionMultiTextBox.Size = new System.Drawing.Size(197, 60);
            this.descriptionMultiTextBox.TabIndex = 53;
            // 
            // timePortionDateTimePicker
            // 
            this.timePortionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePortionDateTimePicker.Location = new System.Drawing.Point(289, 100);
            this.timePortionDateTimePicker.Name = "timePortionDateTimePicker";
            this.timePortionDateTimePicker.Size = new System.Drawing.Size(70, 20);
            this.timePortionDateTimePicker.TabIndex = 54;
            // 
            // AddNewWorkoutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 425);
            this.Controls.Add(this.timePortionDateTimePicker);
            this.Controls.Add(this.descriptionMultiTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.durationComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chooseTrainerButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.trainerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePortionDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewWorkoutWindow";
            this.Text = "Додати нове тренування";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button chooseTrainerButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox trainerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePortionDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox durationComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox descriptionMultiTextBox;
        private System.Windows.Forms.DateTimePicker timePortionDateTimePicker;
    }
}