
namespace Todo_List
{
    partial class AddTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTasks));
            this.textBox1_taskName = new System.Windows.Forms.TextBox();
            this.label_taskName = new System.Windows.Forms.Label();
            this.label1_descriptionTask = new System.Windows.Forms.Label();
            this.richTextBox_descriptionTask = new System.Windows.Forms.RichTextBox();
            this.label1_taskStartDay = new System.Windows.Forms.Label();
            this.label1_TaskEndDay = new System.Windows.Forms.Label();
            this.monthCalendar_startTaskDay = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar_endTaskDay = new System.Windows.Forms.MonthCalendar();
            this.button_addTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_taskName
            // 
            this.textBox1_taskName.Location = new System.Drawing.Point(73, 80);
            this.textBox1_taskName.Name = "textBox1_taskName";
            this.textBox1_taskName.Size = new System.Drawing.Size(397, 27);
            this.textBox1_taskName.TabIndex = 0;
            // 
            // label_taskName
            // 
            this.label_taskName.AutoSize = true;
            this.label_taskName.Location = new System.Drawing.Point(207, 40);
            this.label_taskName.Name = "label_taskName";
            this.label_taskName.Size = new System.Drawing.Size(112, 20);
            this.label_taskName.TabIndex = 1;
            this.label_taskName.Text = "Nazwa Zadania";
            // 
            // label1_descriptionTask
            // 
            this.label1_descriptionTask.AutoSize = true;
            this.label1_descriptionTask.Location = new System.Drawing.Point(222, 176);
            this.label1_descriptionTask.Name = "label1_descriptionTask";
            this.label1_descriptionTask.Size = new System.Drawing.Size(97, 20);
            this.label1_descriptionTask.TabIndex = 2;
            this.label1_descriptionTask.Text = "Opis Zadania";
            // 
            // richTextBox_descriptionTask
            // 
            this.richTextBox_descriptionTask.Location = new System.Drawing.Point(73, 227);
            this.richTextBox_descriptionTask.Name = "richTextBox_descriptionTask";
            this.richTextBox_descriptionTask.Size = new System.Drawing.Size(397, 263);
            this.richTextBox_descriptionTask.TabIndex = 3;
            this.richTextBox_descriptionTask.Text = "";
            // 
            // label1_taskStartDay
            // 
            this.label1_taskStartDay.AutoSize = true;
            this.label1_taskStartDay.Location = new System.Drawing.Point(646, 9);
            this.label1_taskStartDay.Name = "label1_taskStartDay";
            this.label1_taskStartDay.Size = new System.Drawing.Size(126, 20);
            this.label1_taskStartDay.TabIndex = 4;
            this.label1_taskStartDay.Text = "Zadanie na dzień:";
            // 
            // label1_TaskEndDay
            // 
            this.label1_TaskEndDay.AutoSize = true;
            this.label1_TaskEndDay.Location = new System.Drawing.Point(1013, 9);
            this.label1_TaskEndDay.Name = "label1_TaskEndDay";
            this.label1_TaskEndDay.Size = new System.Drawing.Size(121, 20);
            this.label1_TaskEndDay.TabIndex = 5;
            this.label1_TaskEndDay.Text = "Zadanie do dnia:";
            // 
            // monthCalendar_startTaskDay
            // 
            this.monthCalendar_startTaskDay.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar_startTaskDay.Location = new System.Drawing.Point(542, 40);
            this.monthCalendar_startTaskDay.Name = "monthCalendar_startTaskDay";
            this.monthCalendar_startTaskDay.TabIndex = 6;
            this.monthCalendar_startTaskDay.TitleBackColor = System.Drawing.Color.DimGray;
            // 
            // monthCalendar_endTaskDay
            // 
            this.monthCalendar_endTaskDay.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar_endTaskDay.Location = new System.Drawing.Point(914, 40);
            this.monthCalendar_endTaskDay.Name = "monthCalendar_endTaskDay";
            this.monthCalendar_endTaskDay.TabIndex = 7;
            this.monthCalendar_endTaskDay.TitleBackColor = System.Drawing.Color.DimGray;
            // 
            // button_addTask
            // 
            this.button_addTask.Image = ((System.Drawing.Image)(resources.GetObject("button_addTask.Image")));
            this.button_addTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTask.Location = new System.Drawing.Point(1027, 501);
            this.button_addTask.Name = "button_addTask";
            this.button_addTask.Size = new System.Drawing.Size(175, 50);
            this.button_addTask.TabIndex = 8;
            this.button_addTask.Text = "       Dodaj Zadanie";
            this.button_addTask.UseVisualStyleBackColor = true;
            this.button_addTask.Click += new System.EventHandler(this.button_addTask_Click);
            // 
            // AddTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 623);
            this.Controls.Add(this.button_addTask);
            this.Controls.Add(this.monthCalendar_endTaskDay);
            this.Controls.Add(this.monthCalendar_startTaskDay);
            this.Controls.Add(this.label1_TaskEndDay);
            this.Controls.Add(this.label1_taskStartDay);
            this.Controls.Add(this.richTextBox_descriptionTask);
            this.Controls.Add(this.label1_descriptionTask);
            this.Controls.Add(this.label_taskName);
            this.Controls.Add(this.textBox1_taskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTasks";
            this.Text = "AddTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_taskName;
        private System.Windows.Forms.Label label_taskName;
        private System.Windows.Forms.Label label1_descriptionTask;
        private System.Windows.Forms.RichTextBox richTextBox_descriptionTask;
        private System.Windows.Forms.Label label1_taskStartDay;
        private System.Windows.Forms.Label label1_TaskEndDay;
        private System.Windows.Forms.MonthCalendar monthCalendar_startTaskDay;
        private System.Windows.Forms.MonthCalendar monthCalendar_endTaskDay;
        private System.Windows.Forms.Button button_addTask;
    }
}