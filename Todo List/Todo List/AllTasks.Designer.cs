
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTasks));
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
            this.listView_toDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_toDo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_toDo.HideSelection = false;
            this.listView_toDo.Location = new System.Drawing.Point(74, 128);
            this.listView_toDo.Name = "listView_toDo";
            this.listView_toDo.Size = new System.Drawing.Size(314, 483);
            this.listView_toDo.TabIndex = 0;
            this.listView_toDo.UseCompatibleStateImageBehavior = false;
            // 
            // listView_doing
            // 
            this.listView_doing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_doing.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_doing.HideSelection = false;
            this.listView_doing.Location = new System.Drawing.Point(467, 128);
            this.listView_doing.Name = "listView_doing";
            this.listView_doing.Size = new System.Drawing.Size(323, 483);
            this.listView_doing.TabIndex = 1;
            this.listView_doing.UseCompatibleStateImageBehavior = false;
            // 
            // listView_done
            // 
            this.listView_done.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_done.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_done.HideSelection = false;
            this.listView_done.Location = new System.Drawing.Point(872, 128);
            this.listView_done.Name = "listView_done";
            this.listView_done.Size = new System.Drawing.Size(325, 483);
            this.listView_done.TabIndex = 2;
            this.listView_done.UseCompatibleStateImageBehavior = false;
            // 
            // label1_doingAllTasks
            // 
            this.label1_doingAllTasks.AutoSize = true;
            this.label1_doingAllTasks.BackColor = System.Drawing.Color.Transparent;
            this.label1_doingAllTasks.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_doingAllTasks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1_doingAllTasks.Location = new System.Drawing.Point(561, 28);
            this.label1_doingAllTasks.Name = "label1_doingAllTasks";
            this.label1_doingAllTasks.Size = new System.Drawing.Size(156, 41);
            this.label1_doingAllTasks.TabIndex = 3;
            this.label1_doingAllTasks.Text = "W trakcie:";
            // 
            // label_toDoAllTasks
            // 
            this.label_toDoAllTasks.AutoSize = true;
            this.label_toDoAllTasks.BackColor = System.Drawing.Color.Transparent;
            this.label_toDoAllTasks.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_toDoAllTasks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_toDoAllTasks.Location = new System.Drawing.Point(135, 28);
            this.label_toDoAllTasks.Name = "label_toDoAllTasks";
            this.label_toDoAllTasks.Size = new System.Drawing.Size(204, 41);
            this.label_toDoAllTasks.TabIndex = 4;
            this.label_toDoAllTasks.Text = "Do zrobienia:";
            // 
            // label_doneAllTasks
            // 
            this.label_doneAllTasks.AutoSize = true;
            this.label_doneAllTasks.BackColor = System.Drawing.Color.Transparent;
            this.label_doneAllTasks.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_doneAllTasks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_doneAllTasks.Location = new System.Drawing.Point(963, 28);
            this.label_doneAllTasks.Name = "label_doneAllTasks";
            this.label_doneAllTasks.Size = new System.Drawing.Size(152, 41);
            this.label_doneAllTasks.TabIndex = 5;
            this.label_doneAllTasks.Text = "Zrobione:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "   Nazwa Zadania:";
            // 
            // label2_dateStartToDo
            // 
            this.label2_dateStartToDo.AutoSize = true;
            this.label2_dateStartToDo.BackColor = System.Drawing.Color.Transparent;
            this.label2_dateStartToDo.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_dateStartToDo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2_dateStartToDo.Location = new System.Drawing.Point(176, 86);
            this.label2_dateStartToDo.Name = "label2_dateStartToDo";
            this.label2_dateStartToDo.Size = new System.Drawing.Size(117, 18);
            this.label2_dateStartToDo.TabIndex = 7;
            this.label2_dateStartToDo.Text = "Data rozpoczęcia:";
            // 
            // label3_dateEnd_toDo
            // 
            this.label3_dateEnd_toDo.AutoSize = true;
            this.label3_dateEnd_toDo.BackColor = System.Drawing.Color.Transparent;
            this.label3_dateEnd_toDo.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3_dateEnd_toDo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3_dateEnd_toDo.Location = new System.Drawing.Point(287, 86);
            this.label3_dateEnd_toDo.Name = "label3_dateEnd_toDo";
            this.label3_dateEnd_toDo.Size = new System.Drawing.Size(123, 18);
            this.label3_dateEnd_toDo.TabIndex = 8;
            this.label3_dateEnd_toDo.Text = "Data Zakończenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(492, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "   Nazwa Zadania:";
            // 
            // label5_dateStart_doing
            // 
            this.label5_dateStart_doing.AutoSize = true;
            this.label5_dateStart_doing.BackColor = System.Drawing.Color.Transparent;
            this.label5_dateStart_doing.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5_dateStart_doing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5_dateStart_doing.Location = new System.Drawing.Point(577, 86);
            this.label5_dateStart_doing.Name = "label5_dateStart_doing";
            this.label5_dateStart_doing.Size = new System.Drawing.Size(117, 18);
            this.label5_dateStart_doing.TabIndex = 10;
            this.label5_dateStart_doing.Text = "Data rozpoczęcia:";
            // 
            // label6_dateEnd_doing
            // 
            this.label6_dateEnd_doing.AutoSize = true;
            this.label6_dateEnd_doing.BackColor = System.Drawing.Color.Transparent;
            this.label6_dateEnd_doing.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6_dateEnd_doing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6_dateEnd_doing.Location = new System.Drawing.Point(689, 86);
            this.label6_dateEnd_doing.Name = "label6_dateEnd_doing";
            this.label6_dateEnd_doing.Size = new System.Drawing.Size(123, 18);
            this.label6_dateEnd_doing.TabIndex = 11;
            this.label6_dateEnd_doing.Text = "Data Zakończenia:";
            // 
            // label7_dateEnd_done
            // 
            this.label7_dateEnd_done.AutoSize = true;
            this.label7_dateEnd_done.BackColor = System.Drawing.Color.Transparent;
            this.label7_dateEnd_done.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7_dateEnd_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7_dateEnd_done.Location = new System.Drawing.Point(1097, 86);
            this.label7_dateEnd_done.Name = "label7_dateEnd_done";
            this.label7_dateEnd_done.Size = new System.Drawing.Size(123, 18);
            this.label7_dateEnd_done.TabIndex = 14;
            this.label7_dateEnd_done.Text = "Data Zakończenia:";
            // 
            // label8_dateStart_done
            // 
            this.label8_dateStart_done.AutoSize = true;
            this.label8_dateStart_done.BackColor = System.Drawing.Color.Transparent;
            this.label8_dateStart_done.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8_dateStart_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8_dateStart_done.Location = new System.Drawing.Point(984, 86);
            this.label8_dateStart_done.Name = "label8_dateStart_done";
            this.label8_dateStart_done.Size = new System.Drawing.Size(117, 18);
            this.label8_dateStart_done.TabIndex = 13;
            this.label8_dateStart_done.Text = "Data rozpoczęcia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(898, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "   Nazwa Zadania:";
            // 
            // AllTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.DoubleBuffered = true;
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