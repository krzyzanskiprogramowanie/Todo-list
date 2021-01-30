using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class TodoList : Form
    {
        int mouseX;
        int mouseX1;

        public TodoList()
        {
            InitializeComponent();

            //test value
            string[] items = new string[] { "item1", "item2", "item3", "item4", "item5", "item6" };
            string[] items2 = new string[] { "m1", "m2", "m3", "m4", "m5" };
            string[] items3 = new string[] { "em1", "em2", "em3", "em4" };
            listBox_toDo.Items.AddRange(items);
            listBox_doing.Items.AddRange(items2);
            listBox_done.Items.AddRange(items3);

        }
        private void TodoList_Load(object sender, EventArgs e)
        {
        }
      
        public void editTaskView(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }



        //to do
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox_toDo.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox_doing.Items.Remove(e.Data.GetData(DataFormats.Text));
            listBox_done.Items.Remove(e.Data.GetData(DataFormats.Text));

        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            mouseX1 = MousePosition.X;
            //mouseX1 != mouseX 
            if (e.Data.GetDataPresent(DataFormats.Text) && (((mouseX - mouseX1 < -5) || mouseX - mouseX1 > 5)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void listBox_toDo_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox_toDo.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_toDo.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);
            }
            mouseX = MousePosition.X;
            if(listBox_toDo.SelectedItem != null)
                listBox_doing.DoDragDrop(listBox_toDo.SelectedItem.ToString(), DragDropEffects.Copy);
        }
        //doing
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox_doing.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox_toDo.Items.Remove(e.Data.GetData(DataFormats.Text));
            listBox_done.Items.Remove(e.Data.GetData(DataFormats.Text));


        }
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            mouseX1 = MousePosition.X;
            if (e.Data.GetDataPresent(DataFormats.Text) && ((mouseX - mouseX1 < -5) || mouseX - mouseX1 > 5))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_doing_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox_doing.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_doing.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);

            }
            mouseX = MousePosition.X;
            if (listBox_doing.SelectedItem != null)
                listBox_toDo.DoDragDrop(listBox_doing.SelectedItem.ToString(), DragDropEffects.Copy);
            
        }
        //done
        private void listBox_done_DragDrop(object sender, DragEventArgs e)
        {
            listBox_done.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox_toDo.Items.Remove(e.Data.GetData(DataFormats.Text));
            listBox_doing.Items.Remove(e.Data.GetData(DataFormats.Text));

        }

        private void listBox_done_DragEnter(object sender, DragEventArgs e)
        {
            mouseX1 = MousePosition.X;
            if (e.Data.GetDataPresent(DataFormats.Text) && ((mouseX - mouseX1 < -5) || mouseX - mouseX1 > 5))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_done_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox_done.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_done.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);
            }
            mouseX = MousePosition.X;
            if (listBox_done.SelectedItem != null)
                listBox_toDo.DoDragDrop(listBox_done.SelectedItem.ToString(), DragDropEffects.Copy);
        }
    }
}
