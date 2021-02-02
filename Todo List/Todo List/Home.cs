using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            // panel_Content.BackgroundImageLayout = ImageLayout.Stretch;  => this autosize bacground image 
            
        }

        private void button_exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_addTasks_Click(object sender, EventArgs e)
        {
            AddTasks addTasks = new AddTasks();
            nav(addTasks, panel_Content);

        }

        private void button_TodoList_Click(object sender, EventArgs e)
        {
            TodoList todoList = new TodoList();
            nav(todoList, panel_Content);

        }

        private void button_allTasks_Click(object sender, EventArgs e)
        {
            AllTasks allTasks = new AllTasks();
            nav(allTasks, panel_Content);

        }

        private void button_reminder_Click(object sender, EventArgs e)
        {
            Reminders reminders = new Reminders();
            nav(reminders, panel_Content);
        }

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
