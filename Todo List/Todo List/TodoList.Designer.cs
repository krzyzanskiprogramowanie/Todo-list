
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
            this.button1_test = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(337, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 344);
            this.listBox1.TabIndex = 9;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(663, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(254, 364);
            this.listBox2.TabIndex = 10;
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseClick);
            this.listBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox2_DragDrop);
            this.listBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 623);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1_test);
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
        private System.Windows.Forms.Button button1_test;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}