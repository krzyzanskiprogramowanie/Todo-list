
namespace Todo_List
{
    partial class EditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.label1_editTaskName = new System.Windows.Forms.Label();
            this.richTextBox_editTaskName = new System.Windows.Forms.RichTextBox();
            this.label1_editTaskDescription = new System.Windows.Forms.Label();
            this.richTextBox_descriptionTask = new System.Windows.Forms.RichTextBox();
            this.monthCalendar_endTask = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar_startTask = new System.Windows.Forms.MonthCalendar();
            this.button_deleteTask = new System.Windows.Forms.Button();
            this.button_editTask = new System.Windows.Forms.Button();
            this.button_updateChanges = new System.Windows.Forms.Button();
            this.label1_dataStartTask = new System.Windows.Forms.Label();
            this.label1_whenEndingTask = new System.Windows.Forms.Label();
            this.label_errorsEditTasks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_editTaskName
            // 
            this.label1_editTaskName.AutoSize = true;
            this.label1_editTaskName.Location = new System.Drawing.Point(29, 9);
            this.label1_editTaskName.Name = "label1_editTaskName";
            this.label1_editTaskName.Size = new System.Drawing.Size(115, 20);
            this.label1_editTaskName.TabIndex = 0;
            this.label1_editTaskName.Text = "Nazwa Zadania:";
            // 
            // richTextBox_editTaskName
            // 
            this.richTextBox_editTaskName.Location = new System.Drawing.Point(2, 32);
            this.richTextBox_editTaskName.Name = "richTextBox_editTaskName";
            this.richTextBox_editTaskName.Size = new System.Drawing.Size(168, 121);
            this.richTextBox_editTaskName.TabIndex = 1;
            this.richTextBox_editTaskName.Text = "";
            this.richTextBox_editTaskName.TextChanged += new System.EventHandler(this.richTextBox_editTaskName_TextChanged);
            // 
            // label1_editTaskDescription
            // 
            this.label1_editTaskDescription.AutoSize = true;
            this.label1_editTaskDescription.Location = new System.Drawing.Point(404, 9);
            this.label1_editTaskDescription.Name = "label1_editTaskDescription";
            this.label1_editTaskDescription.Size = new System.Drawing.Size(100, 20);
            this.label1_editTaskDescription.TabIndex = 2;
            this.label1_editTaskDescription.Text = "Opis Zadania:";
            // 
            // richTextBox_descriptionTask
            // 
            this.richTextBox_descriptionTask.Location = new System.Drawing.Point(191, 32);
            this.richTextBox_descriptionTask.Name = "richTextBox_descriptionTask";
            this.richTextBox_descriptionTask.Size = new System.Drawing.Size(487, 121);
            this.richTextBox_descriptionTask.TabIndex = 3;
            this.richTextBox_descriptionTask.Text = "";
            // 
            // monthCalendar_endTask
            // 
            this.monthCalendar_endTask.Location = new System.Drawing.Point(353, 225);
            this.monthCalendar_endTask.Name = "monthCalendar_endTask";
            this.monthCalendar_endTask.TabIndex = 4;
            this.monthCalendar_endTask.TitleBackColor = System.Drawing.Color.DimGray;
            this.monthCalendar_endTask.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_endTask_DateChanged);
            // 
            // monthCalendar_startTask
            // 
            this.monthCalendar_startTask.Location = new System.Drawing.Point(2, 225);
            this.monthCalendar_startTask.Name = "monthCalendar_startTask";
            this.monthCalendar_startTask.TabIndex = 5;
            this.monthCalendar_startTask.TitleBackColor = System.Drawing.Color.DimGray;
            this.monthCalendar_startTask.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_startTask_DateChanged);
            // 
            // button_deleteTask
            // 
            this.button_deleteTask.Image = ((System.Drawing.Image)(resources.GetObject("button_deleteTask.Image")));
            this.button_deleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deleteTask.Location = new System.Drawing.Point(694, 32);
            this.button_deleteTask.Name = "button_deleteTask";
            this.button_deleteTask.Size = new System.Drawing.Size(94, 29);
            this.button_deleteTask.TabIndex = 6;
            this.button_deleteTask.Text = "Usuń";
            this.button_deleteTask.UseVisualStyleBackColor = true;
            this.button_deleteTask.Click += new System.EventHandler(this.button_deleteTask_Click);
            // 
            // button_editTask
            // 
            this.button_editTask.Image = ((System.Drawing.Image)(resources.GetObject("button_editTask.Image")));
            this.button_editTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_editTask.Location = new System.Drawing.Point(694, 98);
            this.button_editTask.Name = "button_editTask";
            this.button_editTask.Size = new System.Drawing.Size(94, 29);
            this.button_editTask.TabIndex = 7;
            this.button_editTask.Text = " Edytuj";
            this.button_editTask.UseVisualStyleBackColor = true;
            this.button_editTask.Click += new System.EventHandler(this.button_editTask_Click);
            // 
            // button_updateChanges
            // 
            this.button_updateChanges.Image = ((System.Drawing.Image)(resources.GetObject("button_updateChanges.Image")));
            this.button_updateChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updateChanges.Location = new System.Drawing.Point(694, 170);
            this.button_updateChanges.Name = "button_updateChanges";
            this.button_updateChanges.Size = new System.Drawing.Size(94, 29);
            this.button_updateChanges.TabIndex = 8;
            this.button_updateChanges.Text = "   Zapisz";
            this.button_updateChanges.UseVisualStyleBackColor = true;
            this.button_updateChanges.Click += new System.EventHandler(this.button_updateChanges_Click);
            // 
            // label1_dataStartTask
            // 
            this.label1_dataStartTask.AutoSize = true;
            this.label1_dataStartTask.Location = new System.Drawing.Point(130, 196);
            this.label1_dataStartTask.Name = "label1_dataStartTask";
            this.label1_dataStartTask.Size = new System.Drawing.Size(90, 20);
            this.label1_dataStartTask.TabIndex = 9;
            this.label1_dataStartTask.Text = "Zadanie Od:";
            // 
            // label1_whenEndingTask
            // 
            this.label1_whenEndingTask.AutoSize = true;
            this.label1_whenEndingTask.Location = new System.Drawing.Point(484, 196);
            this.label1_whenEndingTask.Name = "label1_whenEndingTask";
            this.label1_whenEndingTask.Size = new System.Drawing.Size(71, 20);
            this.label1_whenEndingTask.TabIndex = 10;
            this.label1_whenEndingTask.Text = "Do kiedy:";
            // 
            // label_errorsEditTasks
            // 
            this.label_errorsEditTasks.AutoSize = true;
            this.label_errorsEditTasks.ForeColor = System.Drawing.Color.Red;
            this.label_errorsEditTasks.Location = new System.Drawing.Point(290, 160);
            this.label_errorsEditTasks.Name = "label_errorsEditTasks";
            this.label_errorsEditTasks.Size = new System.Drawing.Size(0, 20);
            this.label_errorsEditTasks.TabIndex = 11;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label_errorsEditTasks);
            this.Controls.Add(this.label1_whenEndingTask);
            this.Controls.Add(this.label1_dataStartTask);
            this.Controls.Add(this.button_updateChanges);
            this.Controls.Add(this.button_editTask);
            this.Controls.Add(this.button_deleteTask);
            this.Controls.Add(this.monthCalendar_startTask);
            this.Controls.Add(this.monthCalendar_endTask);
            this.Controls.Add(this.richTextBox_descriptionTask);
            this.Controls.Add(this.label1_editTaskDescription);
            this.Controls.Add(this.richTextBox_editTaskName);
            this.Controls.Add(this.label1_editTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_editTaskName;
        private System.Windows.Forms.RichTextBox richTextBox_editTaskName;
        private System.Windows.Forms.Label label1_editTaskDescription;
        private System.Windows.Forms.RichTextBox richTextBox_descriptionTask;
        private System.Windows.Forms.MonthCalendar monthCalendar_endTask;
        private System.Windows.Forms.MonthCalendar monthCalendar_startTask;
        private System.Windows.Forms.Button button_deleteTask;
        private System.Windows.Forms.Button button_editTask;
        private System.Windows.Forms.Button button_updateChanges;
        private System.Windows.Forms.Label label1_dataStartTask;
        private System.Windows.Forms.Label label1_whenEndingTask;
        private System.Windows.Forms.Label label_errorsEditTasks;
    }
}