using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class TodoList : Form
    {
        int mouseX;
        int mouseX1;
        int id;
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        string taskName, taskDescription;
        DateTime startDate, endDate;
        public TodoList()
        {
            InitializeComponent();
        }

        public void editTaskView(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
        public void InitializingHibernate()
        {
            if (mySession != null && mySession.IsOpen)
            {
                mySession.Close();
            }
            if (mySessionFactory != null && !mySessionFactory.IsClosed)
            {
                mySessionFactory.Close();
            }
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }
        //it changes status if I drag an item from the listBox to another
        public void updateDatabaseStatus(string status)
        {
            InitializingHibernate();
            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<ToDo>();
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Id == id).ToList();
                foreach (var item in list)
                {
                    taskName = item.TaskName.ToString();
                    taskDescription = item.TaskDescription.ToString();
                    startDate = item.StartDate;
                    endDate = item.EndDate;
                }
                ToDo LotoDo = new ToDo
                {
                    TaskName = taskName,
                    TaskDescription = taskDescription,
                    EndDate = endDate,
                    StartDate = DateTime.Now,
                    Id = id,
                    Status = status

                };
                mySession.Merge(LotoDo);
                mySession.Transaction.Commit();
            }
        }
        public  void TodoList_Load(object sender, EventArgs e)
        {
            monthCalendar_TodoList_DateChanged(null,null);
        }

        //listBox_toDo
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox_toDo.Items.Add(e.Data.GetData(DataFormats.Text));
            string taskNameFromListBox = Convert.ToString(e.Data.GetData(DataFormats.Text));
            id = Convert.ToInt32(taskNameFromListBox.Substring(taskNameFromListBox.IndexOf("(id=") + "(id=".Length));
            updateDatabaseStatus("ToDo");
            listBox_doing.Items.Remove(e.Data.GetData(DataFormats.Text));
            listBox_done.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
        //The position of the mouse is necessary, because without it, a new record will appear in the listBox
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            mouseX1 = MousePosition.X;
            if (e.Data.GetDataPresent(DataFormats.Text) && (((mouseX - mouseX1 < -5) || mouseX - mouseX1 > 5)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_toDo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = MousePosition.X;
            if (listBox_toDo.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_toDo.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);
                listBox_doing.DoDragDrop(listBox_toDo.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }
        //listBox_doing
        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            listBox_doing.Items.Add(e.Data.GetData(DataFormats.Text));
            string taskNameFromListBox = Convert.ToString(e.Data.GetData(DataFormats.Text));
            id = Convert.ToInt32(taskNameFromListBox.Substring(taskNameFromListBox.IndexOf("(id=") + "(id=".Length));
            updateDatabaseStatus("doing");
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
            mouseX = MousePosition.X;

            if (listBox_doing.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_doing.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);
                listBox_toDo.DoDragDrop(listBox_doing.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }
        //listBox_done
        private void listBox_done_DragDrop(object sender, DragEventArgs e)
        {
            listBox_done.Items.Add(e.Data.GetData(DataFormats.Text));
            string taskNameFromListBox = Convert.ToString(e.Data.GetData(DataFormats.Text));
            id = Convert.ToInt32(taskNameFromListBox.Substring(taskNameFromListBox.IndexOf("(id=") + "(id=".Length));
            updateDatabaseStatus("done");
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
            mouseX = MousePosition.X;
            if (listBox_done.SelectedItem != null)
            {
                EditTask editTask = new EditTask(listBox_done.SelectedItem.ToString());
                editTaskView(editTask, panel1_editTask);
                listBox_toDo.DoDragDrop(listBox_done.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }
        //If you click on the calendar, the data will be loaded into the listBoxes by the appropriate date
        public void monthCalendar_TodoList_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox_toDo.Items.Clear();
            listBox_doing.Items.Clear();
            listBox_done.Items.Clear();

            InitializingHibernate();

            using (mySession.BeginTransaction())
            {

                ICriteria criteria = mySession.CreateCriteria<ToDo>();
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Status == "ToDo" && (monthCalendar_TodoList
                                                                    .SelectionRange.Start>=a.StartDate && monthCalendar_TodoList
                                                                    .SelectionRange.Start<=a.EndDate)).ToList();
                foreach (var item in list)
                {
                   // The id is hidden from the user, I had to pass the id somehow through the listBox
                    listBox_toDo.Items.Add(item.TaskName + "                                                                      (id=" + item.Id); 
                }
                list = criteria.List<ToDo>().Where(a => a.Status == "doing" && (monthCalendar_TodoList
                                                        .SelectionRange.Start >= a.StartDate && monthCalendar_TodoList
                                                        .SelectionRange.Start <= a.EndDate)).ToList();
                foreach (var item in list)
                {
                    listBox_doing.Items.Add(item.TaskName + "                                                                      (id=" + item.Id);
                }
                list = criteria.List<ToDo>().Where(a => a.Status == "done" && (monthCalendar_TodoList
                                                        .SelectionRange.Start >= a.StartDate && monthCalendar_TodoList
                                                        .SelectionRange.Start <= a.EndDate)).ToList();
                foreach (var item in list)
                {
                    listBox_done.Items.Add(item.TaskName + "                                                                      (id=" + item.Id);
                }
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
               monthCalendar_TodoList_DateChanged(null, null);
        }


      
    }
}
