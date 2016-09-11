namespace GymLife
{
    partial class EditGroupDataWindow
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
            this.specializationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editGroupMembersButton = new System.Windows.Forms.Button();
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
            this.chooseTrainerButton.Size = new System.Drawing.Size(134, 23);
            this.chooseTrainerButton.TabIndex = 49;
            this.chooseTrainerButton.Text = "Вибрати тренера...";
            this.chooseTrainerButton.UseVisualStyleBackColor = true;
            this.chooseTrainerButton.Click += new System.EventHandler(this.chooseTrainerButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(271, 323);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 29);
            this.CancelButton.TabIndex = 48;
            this.CancelButton.Text = "Скасувати";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(159, 323);
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
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Тренер групи";
            // 
            // specializationComboBox
            // 
            this.specializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specializationComboBox.Enabled = false;
            this.specializationComboBox.FormattingEnabled = true;
            this.specializationComboBox.Location = new System.Drawing.Point(159, 66);
            this.specializationComboBox.Name = "specializationComboBox";
            this.specializationComboBox.Size = new System.Drawing.Size(200, 21);
            this.specializationComboBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "* Тип групи";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(159, 140);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.groupNameTextBox.TabIndex = 42;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(159, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Назва групи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "* Дата створення";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 38;
            this.label1.Text = "Для редагування даних групи змініть вміст нижче наведених\r\nполей. \r\nПоля, позначе" +
    "ні (*) є обов\'язковими.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Члени групи";
            // 
            // editGroupMembersButton
            // 
            this.editGroupMembersButton.Location = new System.Drawing.Point(159, 272);
            this.editGroupMembersButton.Name = "editGroupMembersButton";
            this.editGroupMembersButton.Size = new System.Drawing.Size(134, 23);
            this.editGroupMembersButton.TabIndex = 52;
            this.editGroupMembersButton.Text = "Змінити склад групи...";
            this.editGroupMembersButton.UseVisualStyleBackColor = true;
            this.editGroupMembersButton.Click += new System.EventHandler(this.editGroupMembersButton_Click);
            // 
            // EditGroupDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 387);
            this.Controls.Add(this.editGroupMembersButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chooseTrainerButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.trainerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.specializationComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupNameTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditGroupDataWindow";
            this.Text = "Редагувати дані групи";
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
        private System.Windows.Forms.ComboBox specializationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editGroupMembersButton;
    }
}