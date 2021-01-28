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
        int index = 0;

        public TodoList()
        {
            InitializeComponent();
            string[] items = new string[] { "item1", "item2", "item3", "item4", "item5", "item6", "item7", "item8", "item9", "item10", "item11", "item12", "item13", "item14", "item15", "item16", "item17", "item18", "item19", "item20", "item21", "item22", "item23" };
            checkedListBox_ToDo.Items.AddRange(items);
        }

        private void TodoList_Load(object sender, EventArgs e)
        {
           
        }

        //to do
        private void checkedListBox_ToDo_MouseDown(object sender, MouseEventArgs e)
        {
            CheckedListBox check1 = sender as CheckedListBox;
            index = check1.IndexFromPoint(e.X, e.Y);
            if (index >=0 & e.Button == MouseButtons.Left)
                check1.DoDragDrop(check1.Items[index].ToString(), DragDropEffects.Move);
        }
        private void checkedListBox_ToDo_DragEnter(object sender, DragEventArgs e)
        {
            /*
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
            */
        }
        private void checkedListBox_ToDo_DragDrop(object sender, DragEventArgs e)
        {
            /*
            CheckedListBox check2 = sender as CheckedListBox;
            check2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox_ToDo.Items.RemoveAt(index);
            */
        }

        //doing
        private void checkedListBox_doing_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void checkedListBox_doing_DragDrop(object sender, DragEventArgs e)
        {
            CheckedListBox check2 = sender as CheckedListBox;
            check2.Items.Add(e.Data.GetData(typeof(System.String)).ToString());
            checkedListBox_ToDo.Items.RemoveAt(index);
        }

        private void checkedListBox_doing_MouseDown(object sender, MouseEventArgs e)
        {
            /*
            CheckedListBox check1 = sender as CheckedListBox;
            index = check1.IndexFromPoint(e.X, e.Y);
            if (index >= 0 & e.Button == MouseButtons.Left)
                check1.DoDragDrop(check1.Items[index].ToString(), DragDropEffects.Move);
            */
        }
        //done

        private void checkedListBox_done_MouseDown(object sender, MouseEventArgs e)
        {

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
            checkedListBox_ToDo.Items.RemoveAt(index); //checkenTODO ? W innych pozmieniaj
        }

      





    }
}
