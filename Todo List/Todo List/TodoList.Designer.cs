
namespace Todo_List
{
    partial class TodoList
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
            this.monthCalendar_TodoList = new System.Windows.Forms.MonthCalendar();
            this.checkedListBox_ToDo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_doing = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_done = new System.Windows.Forms.CheckedListBox();
            this.label_ToDo = new System.Windows.Forms.Label();
            this.label_doing = new System.Windows.Forms.Label();
            this.label_done = new System.Windows.Forms.Label();
            this.panel1_editTask = new System.Windows.Forms.Panel();
            this.button1_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar_TodoList
            // 
            this.monthCalendar_TodoList.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar_TodoList.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendar_TodoList.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar_TodoList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar_TodoList.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar_TodoList.Name = "monthCalendar_TodoList";
            this.monthCalendar_TodoList.TabIndex = 0;
            this.monthCalendar_TodoList.TitleBackColor = System.Drawing.Color.DimGray;
            // 
            // checkedListBox_ToDo
            // 
            this.checkedListBox_ToDo.AllowDrop = true;
            this.checkedListBox_ToDo.FormattingEnabled = true;
            this.checkedListBox_ToDo.Location = new System.Drawing.Point(348, 62);
            this.checkedListBox_ToDo.Name = "checkedListBox_ToDo";
            this.checkedListBox_ToDo.Size = new System.Drawing.Size(254, 356);
            this.checkedListBox_ToDo.TabIndex = 1;
            this.checkedListBox_ToDo.UseTabStops = false;
            this.checkedListBox_ToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox_ToDo_DragDrop);
            this.checkedListBox_ToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox_ToDo_DragEnter);
            this.checkedListBox_ToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_ToDo_MouseDown);
            // 
            // checkedListBox_doing
            // 
            this.checkedListBox_doing.AllowDrop = true;
            this.checkedListBox_doing.FormattingEnabled = true;
            this.checkedListBox_doing.Location = new System.Drawing.Point(650, 62);
            this.checkedListBox_doing.Name = "checkedListBox_doing";
            this.checkedListBox_doing.Size = new System.Drawing.Size(254, 356);
            this.checkedListBox_doing.TabIndex = 2;
            this.checkedListBox_doing.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox_doing_DragDrop);
            this.checkedListBox_doing.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox_doing_DragEnter);
            this.checkedListBox_doing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_doing_MouseDown);
            // 
            // checkedListBox_done
            // 
            this.checkedListBox_done.AllowDrop = true;
            this.checkedListBox_done.FormattingEnabled = true;
            this.checkedListBox_done.Location = new System.Drawing.Point(976, 62);
            this.checkedListBox_done.Name = "checkedListBox_done";
            this.checkedListBox_done.Size = new System.Drawing.Size(254, 356);
            this.checkedListBox_done.TabIndex = 3;
            this.checkedListBox_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkedListBox_done_DragDrop);
            this.checkedListBox_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkedListBox_done_DragEnter);
            this.checkedListBox_done.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_done_MouseDown);
            // 
            // label_ToDo
            // 
            this.label_ToDo.AutoSize = true;
            this.label_ToDo.Location = new System.Drawing.Point(430, 23);
            this.label_ToDo.Name = "label_ToDo";
            this.label_ToDo.Size = new System.Drawing.Size(95, 20);
            this.label_ToDo.TabIndex = 4;
            this.label_ToDo.Text = "Do zrobienia";
            // 
            // label_doing
            // 
            this.label_doing.AutoSize = true;
            this.label_doing.Location = new System.Drawing.Point(727, 23);
            this.label_doing.Name = "label_doing";
            this.label_doing.Size = new System.Drawing.Size(71, 20);
            this.label_doing.TabIndex = 5;
            this.label_doing.Text = "W trakcie";
            // 
            // label_done
            // 
            this.label_done.AutoSize = true;
            this.label_done.Location = new System.Drawing.Point(1074, 23);
            this.label_done.Name = "label_done";
            this.label_done.Size = new System.Drawing.Size(70, 20);
            this.label_done.TabIndex = 6;
            this.label_done.Text = "Zrobione";
            // 
            // panel1_editTask
            // 
            this.panel1_editTask.AutoScroll = true;
            this.panel1_editTask.Location = new System.Drawing.Point(348, 439);
            this.panel1_editTask.Name = "panel1_editTask";
            this.panel1_editTask.Size = new System.Drawing.Size(882, 172);
            this.panel1_editTask.TabIndex = 7;
            // 
            // button1_test
            // 
            this.button1_test.Location = new System.Drawing.Point(179, 581);
            this.button1_test.Name = "button1_test";
            this.button1_test.Size = new System.Drawing.Size(94, 29);
            this.button1_test.TabIndex = 8;
            this.button1_test.Text = "button1";
            this.button1_test.UseVisualStyleBackColor = true;
            this.button1_test.Click += new System.EventHandler(this.button1_test_Click);
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 623);
            this.Controls.Add(this.button1_test);
            this.Controls.Add(this.panel1_editTask);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_doing);
            this.Controls.Add(this.label_ToDo);
            this.Controls.Add(this.checkedListBox_done);
            this.Controls.Add(this.checkedListBox_doing);
            this.Controls.Add(this.checkedListBox_ToDo);
            this.Controls.Add(this.monthCalendar_TodoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TodoList";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.TodoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar_TodoList;
        private System.Windows.Forms.CheckedListBox checkedListBox_ToDo;
        private System.Windows.Forms.CheckedListBox checkedListBox_doing;
        private System.Windows.Forms.CheckedListBox checkedListBox_done;
        private System.Windows.Forms.Label label1_ToDo;
        private System.Windows.Forms.Label label1_doing;
        private System.Windows.Forms.Label label_done;
        private System.Windows.Forms.Label label_doing;
        private System.Windows.Forms.Label label_ToDo;
        private System.Windows.Forms.Panel panel1_editTask;
        private System.Windows.Forms.Button button1_test;
    }
}