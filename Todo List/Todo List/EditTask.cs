using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class EditTask : Form
    {
        public EditTask(string taskName)
        {
            InitializeComponent();
            richTextBox_editTaskName.Text = taskName;


            disableEdits();
        }

        public void enableEdits()
        {
            richTextBox_editTaskName.Enabled = true;
            richTextBox_descriptionTask.Enabled = true;
            monthCalendar_startTask.Enabled = true;
            monthCalendar_endTask.Enabled = true;
            button_updateChanges.Enabled = true;
        }
        public void disableEdits()
        {
            richTextBox_editTaskName.Enabled = false;
            richTextBox_descriptionTask.Enabled = false;
            monthCalendar_startTask.Enabled = false;
            monthCalendar_endTask.Enabled = false;
            button_updateChanges.Enabled = false;
        }

        private void button_editTask_Click(object sender, EventArgs e)
        {
            enableEdits();
        }
    }
}
