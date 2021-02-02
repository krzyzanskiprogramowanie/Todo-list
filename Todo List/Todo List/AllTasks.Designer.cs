
namespace Todo_List
{
    partial class AllTasks
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
            this.listView_toDo = new System.Windows.Forms.ListView();
            this.listView_doing = new System.Windows.Forms.ListView();
            this.listView_done = new System.Windows.Forms.ListView();
            this.label1_doingAllTasks = new System.Windows.Forms.Label();
            this.label_toDoAllTasks = new System.Windows.Forms.Label();
            this.label_doneAllTasks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_dateStartToDo = new System.Windows.Forms.Label();
            this.label3_dateEnd_toDo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_dateStart_doing = new System.Windows.Forms.Label();
            this.label6_dateEnd_doing = new System.Windows.Forms.Label();
            this.label7_dateEnd_done = new System.Windows.Forms.Label();
            this.label8_dateStart_done = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_toDo
            // 
            this.listView_toDo.HideSelection = false;
            this.listView_toDo.Location = new System.Drawing.Point(12, 108);
            this.listView_toDo.Name = "listView_toDo";
            this.listView_toDo.Size = new System.Drawing.Size(346, 503);
            this.listView_toDo.TabIndex = 0;
            this.listView_toDo.UseCompatibleStateImageBehavior = false;
            // 
            // listView_doing
            // 
            this.listView_doing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_doing.HideSelection = false;
            this.listView_doing.Location = new System.Drawing.Point(464, 108);
            this.listView_doing.Name = "listView_doing";
            this.listView_doing.Size = new System.Drawing.Size(346, 503);
            this.listView_doing.TabIndex = 1;
            this.listView_doing.UseCompatibleStateImageBehavior = false;
            // 
            // listView_done
            // 
            this.listView_done.HideSelection = false;
            this.listView_done.Location = new System.Drawing.Point(916, 108);
            this.listView_done.Name = "listView_done";
            this.listView_done.Size = new System.Drawing.Size(346, 503);
            this.listView_done.TabIndex = 2;
            this.listView_done.UseCompatibleStateImageBehavior = false;
            // 
            // label1_doingAllTasks
            // 
            this.label1_doingAllTasks.AutoSize = true;
            this.label1_doingAllTasks.Location = new System.Drawing.Point(604, 22);
            this.label1_doingAllTasks.Name = "label1_doingAllTasks";
            this.label1_doingAllTasks.Size = new System.Drawing.Size(74, 20);
            this.label1_doingAllTasks.TabIndex = 3;
            this.label1_doingAllTasks.Text = "W trakcie:";
            // 
            // label_toDoAllTasks
            // 
            this.label_toDoAllTasks.AutoSize = true;
            this.label_toDoAllTasks.Location = new System.Drawing.Point(135, 22);
            this.label_toDoAllTasks.Name = "label_toDoAllTasks";
            this.label_toDoAllTasks.Size = new System.Drawing.Size(98, 20);
            this.label_toDoAllTasks.TabIndex = 4;
            this.label_toDoAllTasks.Text = "Do zrobienia:";
            // 
            // label_doneAllTasks
            // 
            this.label_doneAllTasks.AutoSize = true;
            this.label_doneAllTasks.Location = new System.Drawing.Point(1065, 22);
            this.label_doneAllTasks.Name = "label_doneAllTasks";
            this.label_doneAllTasks.Size = new System.Drawing.Size(73, 20);
            this.label_doneAllTasks.TabIndex = 5;
            this.label_doneAllTasks.Text = "Zrobione:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa Zadania:";
            // 
            // label2_dateStartToDo
            // 
            this.label2_dateStartToDo.AutoSize = true;
            this.label2_dateStartToDo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2_dateStartToDo.Location = new System.Drawing.Point(134, 77);
            this.label2_dateStartToDo.Name = "label2_dateStartToDo";
            this.label2_dateStartToDo.Size = new System.Drawing.Size(99, 15);
            this.label2_dateStartToDo.TabIndex = 7;
            this.label2_dateStartToDo.Text = "Data rozpoczęcia:";
            // 
            // label3_dateEnd_toDo
            // 
            this.label3_dateEnd_toDo.AutoSize = true;
            this.label3_dateEnd_toDo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3_dateEnd_toDo.Location = new System.Drawing.Point(255, 77);
            this.label3_dateEnd_toDo.Name = "label3_dateEnd_toDo";
            this.label3_dateEnd_toDo.Size = new System.Drawing.Size(103, 15);
            this.label3_dateEnd_toDo.TabIndex = 8;
            this.label3_dateEnd_toDo.Text = "Data Zakończenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(483, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nazwa Zadania:";
            // 
            // label5_dateStart_doing
            // 
            this.label5_dateStart_doing.AutoSize = true;
            this.label5_dateStart_doing.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5_dateStart_doing.Location = new System.Drawing.Point(579, 77);
            this.label5_dateStart_doing.Name = "label5_dateStart_doing";
            this.label5_dateStart_doing.Size = new System.Drawing.Size(99, 15);
            this.label5_dateStart_doing.TabIndex = 10;
            this.label5_dateStart_doing.Text = "Data rozpoczęcia:";
            // 
            // label6_dateEnd_doing
            // 
            this.label6_dateEnd_doing.AutoSize = true;
            this.label6_dateEnd_doing.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6_dateEnd_doing.Location = new System.Drawing.Point(707, 77);
            this.label6_dateEnd_doing.Name = "label6_dateEnd_doing";
            this.label6_dateEnd_doing.Size = new System.Drawing.Size(103, 15);
            this.label6_dateEnd_doing.TabIndex = 11;
            this.label6_dateEnd_doing.Text = "Data Zakończenia:";
            // 
            // label7_dateEnd_done
            // 
            this.label7_dateEnd_done.AutoSize = true;
            this.label7_dateEnd_done.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7_dateEnd_done.Location = new System.Drawing.Point(1159, 77);
            this.label7_dateEnd_done.Name = "label7_dateEnd_done";
            this.label7_dateEnd_done.Size = new System.Drawing.Size(103, 15);
            this.label7_dateEnd_done.TabIndex = 14;
            this.label7_dateEnd_done.Text = "Data Zakończenia:";
            // 
            // label8_dateStart_done
            // 
            this.label8_dateStart_done.AutoSize = true;
            this.label8_dateStart_done.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8_dateStart_done.Location = new System.Drawing.Point(1039, 77);
            this.label8_dateStart_done.Name = "label8_dateStart_done";
            this.label8_dateStart_done.Size = new System.Drawing.Size(99, 15);
            this.label8_dateStart_done.TabIndex = 13;
            this.label8_dateStart_done.Text = "Data rozpoczęcia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(943, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nazwa Zadania:";
            // 
            // AllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1274, 623);
            this.Controls.Add(this.label7_dateEnd_done);
            this.Controls.Add(this.label8_dateStart_done);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6_dateEnd_doing);
            this.Controls.Add(this.label5_dateStart_doing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3_dateEnd_toDo);
            this.Controls.Add(this.label2_dateStartToDo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_doneAllTasks);
            this.Controls.Add(this.label_toDoAllTasks);
            this.Controls.Add(this.label1_doingAllTasks);
            this.Controls.Add(this.listView_done);
            this.Controls.Add(this.listView_doing);
            this.Controls.Add(this.listView_toDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllTasks";
            this.Text = "AllTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_toDo;
        private System.Windows.Forms.ListView listView_doing;
        private System.Windows.Forms.ListView listView_done;
        private System.Windows.Forms.Label label1_doingAllTasks;
        private System.Windows.Forms.Label label_toDoAllTasks;
        private System.Windows.Forms.Label label_doneAllTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_dateStartToDo;
        private System.Windows.Forms.Label label3_dateEnd_toDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_dateStart_doing;
        private System.Windows.Forms.Label label6_dateEnd_doing;
        private System.Windows.Forms.Label label7_dateEnd_done;
        private System.Windows.Forms.Label label8_dateStart_done;
        private System.Windows.Forms.Label label9;
    }
}