namespace GymLife
{
    partial class GroupScheduleWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.cancelWorkoutButton = new System.Windows.Forms.Button();
            this.addWorkoutButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Список тренувань групи:\r\n\r\n";
            // 
            // cancelWorkoutButton
            // 
            this.cancelWorkoutButton.Location = new System.Drawing.Point(157, 315);
            this.cancelWorkoutButton.Name = "cancelWorkoutButton";
            this.cancelWorkoutButton.Size = new System.Drawing.Size(124, 29);
            this.cancelWorkoutButton.TabIndex = 46;
            this.cancelWorkoutButton.Text = "Відмінити тренування";
            this.cancelWorkoutButton.UseVisualStyleBackColor = true;
            this.cancelWorkoutButton.Click += new System.EventHandler(this.cancelWorkoutButton_Click);
            // 
            // addWorkoutButton
            // 
            this.addWorkoutButton.Location = new System.Drawing.Point(12, 315);
            this.addWorkoutButton.Name = "addWorkoutButton";
            this.addWorkoutButton.Size = new System.Drawing.Size(124, 29);
            this.addWorkoutButton.TabIndex = 45;
            this.addWorkoutButton.Text = "Додати тренування";
            this.addWorkoutButton.UseVisualStyleBackColor = true;
            this.addWorkoutButton.Click += new System.EventHandler(this.addWorkoutButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(567, 315);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(88, 29);
            this.OkButton.TabIndex = 44;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 39);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(643, 244);
            this.dataGridView.TabIndex = 43;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // GroupScheduleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelWorkoutButton);
            this.Controls.Add(this.addWorkoutButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GroupScheduleWindow";
            this.Text = "Розклад тренувань групи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelWorkoutButton;
        private System.Windows.Forms.Button addWorkoutButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}