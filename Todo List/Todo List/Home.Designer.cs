
namespace Todo_List
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exitApplication = new System.Windows.Forms.Button();
            this.button_reminder = new System.Windows.Forms.Button();
            this.button_allTasks = new System.Windows.Forms.Button();
            this.button_TodoList = new System.Windows.Forms.Button();
            this.button_addTasks = new System.Windows.Forms.Button();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(145)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.button_exitApplication);
            this.panel1.Controls.Add(this.button_reminder);
            this.panel1.Controls.Add(this.button_allTasks);
            this.panel1.Controls.Add(this.button_TodoList);
            this.panel1.Controls.Add(this.button_addTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 106);
            this.panel1.TabIndex = 0;
            // 
            // button_exitApplication
            // 
            this.button_exitApplication.BackColor = System.Drawing.SystemColors.Control;
            this.button_exitApplication.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_exitApplication.Image = ((System.Drawing.Image)(resources.GetObject("button_exitApplication.Image")));
            this.button_exitApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exitApplication.Location = new System.Drawing.Point(1016, 12);
            this.button_exitApplication.Name = "button_exitApplication";
            this.button_exitApplication.Size = new System.Drawing.Size(245, 80);
            this.button_exitApplication.TabIndex = 3;
            this.button_exitApplication.Text = "Zamknij Aplikacje";
            this.button_exitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_exitApplication.UseVisualStyleBackColor = false;
            this.button_exitApplication.Click += new System.EventHandler(this.button_exitApplication_Click);
            // 
            // button_reminder
            // 
            this.button_reminder.BackColor = System.Drawing.SystemColors.Control;
            this.button_reminder.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reminder.Image = ((System.Drawing.Image)(resources.GetObject("button_reminder.Image")));
            this.button_reminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reminder.Location = new System.Drawing.Point(765, 12);
            this.button_reminder.Name = "button_reminder";
            this.button_reminder.Size = new System.Drawing.Size(245, 80);
            this.button_reminder.TabIndex = 3;
            this.button_reminder.Text = "          Przypomnienia";
            this.button_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reminder.UseVisualStyleBackColor = false;
            this.button_reminder.Click += new System.EventHandler(this.button_reminder_Click);
            // 
            // button_allTasks
            // 
            this.button_allTasks.BackColor = System.Drawing.SystemColors.Control;
            this.button_allTasks.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_allTasks.Image = ((System.Drawing.Image)(resources.GetObject("button_allTasks.Image")));
            this.button_allTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_allTasks.Location = new System.Drawing.Point(514, 12);
            this.button_allTasks.Name = "button_allTasks";
            this.button_allTasks.Size = new System.Drawing.Size(245, 80);
            this.button_allTasks.TabIndex = 2;
            this.button_allTasks.Text = "Wszystkie Zadania";
            this.button_allTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_allTasks.UseVisualStyleBackColor = false;
            this.button_allTasks.Click += new System.EventHandler(this.button_allTasks_Click);
            // 
            // button_TodoList
            // 
            this.button_TodoList.BackColor = System.Drawing.SystemColors.Control;
            this.button_TodoList.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_TodoList.Image = ((System.Drawing.Image)(resources.GetObject("button_TodoList.Image")));
            this.button_TodoList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_TodoList.Location = new System.Drawing.Point(263, 12);
            this.button_TodoList.Name = "button_TodoList";
            this.button_TodoList.Size = new System.Drawing.Size(245, 80);
            this.button_TodoList.TabIndex = 1;
            this.button_TodoList.Text = "  Rzeczy do zrobienia";
            this.button_TodoList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_TodoList.UseVisualStyleBackColor = false;
            this.button_TodoList.Click += new System.EventHandler(this.button_TodoList_Click);
            // 
            // button_addTasks
            // 
            this.button_addTasks.BackColor = System.Drawing.SystemColors.Control;
            this.button_addTasks.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addTasks.Image = ((System.Drawing.Image)(resources.GetObject("button_addTasks.Image")));
            this.button_addTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addTasks.Location = new System.Drawing.Point(12, 12);
            this.button_addTasks.Name = "button_addTasks";
            this.button_addTasks.Size = new System.Drawing.Size(245, 80);
            this.button_addTasks.TabIndex = 0;
            this.button_addTasks.Text = "          Dodaj Zadanie";
            this.button_addTasks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addTasks.UseVisualStyleBackColor = false;
            this.button_addTasks.Click += new System.EventHandler(this.button_addTasks_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Content.BackgroundImage")));
            this.panel_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 106);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1274, 623);
            this.panel_Content.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 729);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Grzegorz Krzyżański";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_addTasks;
        private System.Windows.Forms.Button button_exitApplication;
        private System.Windows.Forms.Button button_reminder;
        private System.Windows.Forms.Button button_allTasks;
        private System.Windows.Forms.Button button_TodoList;
        private System.Windows.Forms.Panel panel_Content;
    }
}

