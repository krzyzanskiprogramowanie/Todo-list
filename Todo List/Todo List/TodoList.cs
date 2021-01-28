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

        public TodoList()
        {
            InitializeComponent();

            //test value
            string[] items = new string[] { "item1", "item2", "item3", "item4", "item5", "item6"};
            string[] items2 = new string[] { "m1", "m2", "m3", "m4", "m5"};
            string[] items3 = new string[] { "em1", "em2", "em3", "em4"};
            checkedListBox_ToDo.Items.AddRange(items);
            checkedListBox_doing.Items.AddRange(items2);
            checkedListBox_done.Items.AddRange(items3);
        }

        private void TodoList_Load(object sender, EventArgs e)
        {
           
        }

        //to do
        private void checkedListBox_ToDo_MouseDown(object sender, MouseEventArgs e)
        {
            CheckedListBox check1 = sender as CheckedListBox;
            indexToDo = check1.IndexFromPoint(e.X, e.Y);
            if (indexToDo >=0 & e.Button == MouseButtons.Left)
                check1.DoDragDrop(check1.Items[indexToDo].ToString(), DragDropEffects.Move);
        }
        private void checkedListBox_ToDo_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
           
        }
        private void checkedListBox_ToDo_DragDrop(object sender, DragEventArgs e)
        {
            
            CheckedListBox check2 = sender as CheckedListBox;
            check2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());

            try
            {
                checkedListBox_doing.Items.RemoveAt(indexDoing);
            }
            catch (Exception) 
            {
                checkedListBox_done.Items.RemoveAt(indexDone);
            }


        }








        //doing

        private void checkedListBox_doing_MouseDown(object sender, MouseEventArgs e)
        {

            CheckedListBox check2 = sender as CheckedListBox;
            indexDoing = check2.IndexFromPoint(e.X, e.Y);
            if (indexDoing >= 0 & e.Button == MouseButtons.Left)
                check2.DoDragDrop(check2.Items[indexDoing].ToString(), DragDropEffects.Move);

        }
        private void checkedListBox_doing_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void checkedListBox_doing_DragDrop(object sender, DragEventArgs e)
        {
            CheckedListBox check1 = sender as CheckedListBox;
            check1.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            try
            {
                checkedListBox_ToDo.Items.RemoveAt(indexToDo);
            }
            catch (Exception) 
            {
                checkedListBox_done.Items.RemoveAt(indexDone);

            }

          


        }

    





        
        //done

        private void checkedListBox_done_MouseDown(object sender, MouseEventArgs e)
        {

            CheckedListBox check3 = sender as CheckedListBox;
            indexDone = check3.IndexFromPoint(e.X, e.Y);
            if (indexDone >= 0 & e.Button == MouseButtons.Left)
                check3.DoDragDrop(check3.Items[indexDone].ToString(), DragDropEffects.Move);
        }



        private void checkedListBox_done_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private void checkedListBox_done_DragDrop(object sender, DragEventArgs e)
        {
            CheckedListBox check3 = sender as CheckedListBox;
            check3.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            try
            {
                checkedListBox_ToDo.Items.RemoveAt(indexToDo);

            }
            catch (Exception)
            {
                checkedListBox_doing.Items.RemoveAt(indexDoing);

            }


        }



        //test 
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
    }
}
