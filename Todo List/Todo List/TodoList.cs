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
        public void TodoList_Load(object sender, EventArgs e)
        {
            if (mySession != null && mySession.IsOpen)
            {
                mySession.Close();
            }
            if (mySessionFactory != null && !mySessionFactory.IsClosed)
            {
                mySessionFactory.Close();
            }
            // Initializing NHibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
            
            //Show TaskNameFromDatabase in ListBox
            using (mySession.BeginTransaction())
            {
                
                ICriteria criteria = mySession.CreateCriteria<ToDo>();
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Status == "ToDo").ToList();
                foreach (var item in list)
                {
                    listBox_toDo.Items.Add(item.TaskName +"                                                                      (id="+ item.Id);
                }
                 list = criteria.List<ToDo>().Where(a => a.Status == "doing").ToList();
                foreach (var item in list)
                {
                    listBox_doing.Items.Add(item.TaskName + "                                                                      (id=" + item.Id);
                }
                list = criteria.List<ToDo>().Where(a => a.Status == "done").ToList();
                foreach (var item in list)
                {
                    listBox_done.Items.Add(item.TaskName + "                                                                      (id=" + item.Id);
                }
            }
        }
        public void editTaskView(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        public void reset()
        {
            this.Close();
        }

        //to do
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox_toDo.Items.Add(e.Data.GetData(DataFormats.Text));
            string taskNameFromListBox = Convert.ToString(e.Data.GetData(DataFormats.Text));
            id = Convert.ToInt32(taskNameFromListBox.Substring(taskNameFromListBox.IndexOf("(id=") + "(id=".Length));
            updateDatabaseStatus("ToDo");
            listBox_doing.Items.Remove(e.Data.GetData(DataFormats.Text));
            listBox_done.Items.Remove(e.Data.GetData(DataFormats.Text));

        }


        public void updateDatabaseStatus(string status)
        {

            if (mySession != null && mySession.IsOpen)
            {
                mySession.Close();
            }
            if (mySessionFactory != null && !mySessionFactory.IsClosed)
            {
                mySessionFactory.Close();
            }
            // Inicjowanie NHibernate
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

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
