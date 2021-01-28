
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
            this.richTextBox1_editTaskName = new System.Windows.Forms.RichTextBox();
            this.label1_editTaskDescription = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.button1_deleteTask = new System.Windows.Forms.Button();
            this.button2_editTask = new System.Windows.Forms.Button();
            this.button3_updateChanges = new System.Windows.Forms.Button();
            this.label1_dataStartTask = new System.Windows.Forms.Label();
            this.label1_whenEndingTask = new System.Windows.Forms.Label();
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
            // richTextBox1_editTaskName
            // 
            this.richTextBox1_editTaskName.Location = new System.Drawing.Point(2, 32);
            this.richTextBox1_editTaskName.Name = "richTextBox1_editTaskName";
            this.richTextBox1_editTaskName.Size = new System.Drawing.Size(168, 121);
            this.richTextBox1_editTaskName.TabIndex = 1;
            this.richTextBox1_editTaskName.Text = "";
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(191, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 121);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(353, 225);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.DimGray;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(2, 225);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            this.monthCalendar2.TitleBackColor = System.Drawing.Color.DimGray;
            // 
            // button1_deleteTask
            // 
            this.button1_deleteTask.Image = ((System.Drawing.Image)(resources.GetObject("button1_deleteTask.Image")));
            this.button1_deleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_deleteTask.Location = new System.Drawing.Point(694, 32);
            this.button1_deleteTask.Name = "button1_deleteTask";
            this.button1_deleteTask.Size = new System.Drawing.Size(94, 29);
            this.button1_deleteTask.TabIndex = 6;
            this.button1_deleteTask.Text = "Usuń";
            this.button1_deleteTask.UseVisualStyleBackColor = true;
            // 
            // button2_editTask
            // 
            this.button2_editTask.Image = ((System.Drawing.Image)(resources.GetObject("button2_editTask.Image")));
            this.button2_editTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_editTask.Location = new System.Drawing.Point(694, 98);
            this.button2_editTask.Name = "button2_editTask";
            this.button2_editTask.Size = new System.Drawing.Size(94, 29);
            this.button2_editTask.TabIndex = 7;
            this.button2_editTask.Text = " Edytuj";
            this.button2_editTask.UseVisualStyleBackColor = true;
            // 
            // button3_updateChanges
            // 
            this.button3_updateChanges.Image = ((System.Drawing.Image)(resources.GetObject("button3_updateChanges.Image")));
            this.button3_updateChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_updateChanges.Location = new System.Drawing.Point(694, 170);
            this.button3_updateChanges.Name = "button3_updateChanges";
            this.button3_updateChanges.Size = new System.Drawing.Size(94, 29);
            this.button3_updateChanges.TabIndex = 8;
            this.button3_updateChanges.Text = "   Zapisz";
            this.button3_updateChanges.UseVisualStyleBackColor = true;
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
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1_whenEndingTask);
            this.Controls.Add(this.label1_dataStartTask);
            this.Controls.Add(this.button3_updateChanges);
            this.Controls.Add(this.button2_editTask);
            this.Controls.Add(this.button1_deleteTask);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1_editTaskDescription);
            this.Controls.Add(this.richTextBox1_editTaskName);
            this.Controls.Add(this.label1_editTaskName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTask";
            this.Text = "EditTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_editTaskName;
        private System.Windows.Forms.RichTextBox richTextBox1_editTaskName;
        private System.Windows.Forms.Label label1_editTaskDescription;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button button1_deleteTask;
        private System.Windows.Forms.Button button2_editTask;
        private System.Windows.Forms.Button button3_updateChanges;
        private System.Windows.Forms.Label label1_dataStartTask;
        private System.Windows.Forms.Label label1_whenEndingTask;
    }
}