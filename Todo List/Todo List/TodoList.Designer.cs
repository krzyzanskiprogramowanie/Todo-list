
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
            this.label_ToDo = new System.Windows.Forms.Label();
            this.label_doing = new System.Windows.Forms.Label();
            this.label_done = new System.Windows.Forms.Label();
            this.panel1_editTask = new System.Windows.Forms.Panel();
            this.listBox_toDo = new System.Windows.Forms.ListBox();
            this.listBox_doing = new System.Windows.Forms.ListBox();
            this.listBox_done = new System.Windows.Forms.ListBox();
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
            this.monthCalendar_TodoList.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_TodoList_DateChanged);
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
            // listBox_toDo
            // 
            this.listBox_toDo.AllowDrop = true;
            this.listBox_toDo.FormattingEnabled = true;
            this.listBox_toDo.ItemHeight = 20;
            this.listBox_toDo.Location = new System.Drawing.Point(337, 74);
            this.listBox_toDo.Name = "listBox_toDo";
            this.listBox_toDo.Size = new System.Drawing.Size(289, 344);
            this.listBox_toDo.TabIndex = 9;
            this.listBox_toDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox_toDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox_toDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_toDo_MouseDown);
            // 
            // listBox_doing
            // 
            this.listBox_doing.AllowDrop = true;
            this.listBox_doing.FormattingEnabled = true;
            this.listBox_doing.ItemHeight = 20;
            this.listBox_doing.Location = new System.Drawing.Point(652, 74);
            this.listBox_doing.Name = "listBox_doing";
            this.listBox_doing.Size = new System.Drawing.Size(289, 344);
            this.listBox_doing.TabIndex = 10;
            this.listBox_doing.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox_doing.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox_doing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_doing_MouseDown);
            // 
            // listBox_done
            // 
            this.listBox_done.AllowDrop = true;
            this.listBox_done.FormattingEnabled = true;
            this.listBox_done.ItemHeight = 20;
            this.listBox_done.Location = new System.Drawing.Point(964, 74);
            this.listBox_done.Name = "listBox_done";
            this.listBox_done.Size = new System.Drawing.Size(289, 344);
            this.listBox_done.TabIndex = 11;
            this.listBox_done.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_done_DragDrop);
            this.listBox_done.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_done_DragEnter);
            this.listBox_done.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_done_MouseDown);
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 623);
            this.Controls.Add(this.listBox_done);
            this.Controls.Add(this.listBox_doing);
            this.Controls.Add(this.listBox_toDo);
            this.Controls.Add(this.panel1_editTask);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_doing);
            this.Controls.Add(this.label_ToDo);
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
        private System.Windows.Forms.Label label1_ToDo;
        private System.Windows.Forms.Label label1_doing;
        private System.Windows.Forms.Label label_done;
        private System.Windows.Forms.Label label_doing;
        private System.Windows.Forms.Label label_ToDo;
        private System.Windows.Forms.Panel panel1_editTask;
        private System.Windows.Forms.ListBox listBox_toDo;
        private System.Windows.Forms.ListBox listBox_doing;
        private System.Windows.Forms.ListBox listBox_done;
    }
}