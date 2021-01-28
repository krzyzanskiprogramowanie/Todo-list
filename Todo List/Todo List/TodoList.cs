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
        int indexToDo = 0;
        int indexDoing = 0;
        int indexDone = 0;
        double mouseX;
        double mouseY;

        double mouseX1;
        double mouseY2;
        public TodoList()
        {
            InitializeComponent();

            //test value
            string[] items = new string[] { "item1", "item2", "item3", "item4", "item5", "item6"};
            string[] items2 = new string[] { "m1", "m2", "m3", "m4", "m5"};
            string[] items3 = new string[] { "em1", "em2", "em3", "em4"};
           listBox1.Items.AddRange(items);
            listBox2.Items.AddRange(items2);
       //     listBox1.Visible = false;
       //     listBox2.Visible = false;
        }
        private void TodoList_Load(object sender, EventArgs e)
        {
        }
        //test button
        private void button1_test_Click(object sender, EventArgs e)
        {

            EditTask editTask = new EditTask();
            editTaskView(editTask, panel1_editTask);
        }
        public void editTaskView(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        //list Box
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox2.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {

            mouseX1 = MousePosition.X;
            mouseY2 = MousePosition.Y;

            if (e.Data.GetDataPresent(DataFormats.Text) && mouseX1 != mouseX )
            {
                e.Effect = DragDropEffects.Move;
                
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Move);
        }
        //list box 2
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {//
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;
            listBox1.DoDragDrop(listBox2.SelectedItem.ToString(), DragDropEffects.Move);

        }
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
            
        }
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {//
            mouseX = MousePosition.X;
            mouseY = MousePosition.Y;
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
