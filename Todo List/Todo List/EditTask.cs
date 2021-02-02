using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class EditTask : Form
    {
        int id;
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        string status;
        public EditTask(string taskName)
        {
            InitializeComponent();
            disableEdits();
            InitializingHibernate();
          //  I am receiving hidden id from listBox
             id = Convert.ToInt32(taskName.Substring(taskName.IndexOf("(id=") + "(id=".Length));

            //Show TaskNameFromDatabase in editPanel
            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<ToDo>();
                IList<ToDo> list = criteria.List<ToDo>().Where(a=>a.Id==id).ToList();

                foreach (var item in list)
                {
                    richTextBox_editTaskName.Text = item.TaskName.ToString();
                    richTextBox_descriptionTask.Text = item.TaskDescription.ToString();
                    monthCalendar_startTask.SetDate(item.StartDate);
                    monthCalendar_endTask.SetDate(item.EndDate);
                    status = item.Status;
                }

            }

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
        public void enableEdits()
        {
            //Protection against data deletion and subsequent modification
            if (richTextBox_editTaskName.TextLength < 1)
            {
                richTextBox_editTaskName.Enabled = false;
                richTextBox_descriptionTask.Enabled =false;
                monthCalendar_startTask.Enabled = false;
                monthCalendar_endTask.Enabled = false;
                button_updateChanges.Enabled = false;
                richTextBox_descriptionTask.Text = "Element został usunięty odśwież strone przyciskiem z lewiej strony !";

            }
            else
            {
                richTextBox_editTaskName.Enabled = true;
                richTextBox_descriptionTask.Enabled = true;
                monthCalendar_startTask.Enabled = true;
                monthCalendar_endTask.Enabled = true;
                button_updateChanges.Enabled = true;
            }
            
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

        //delete from database
        private void button_deleteTask_Click(object sender, EventArgs e)
        {
           
                using (ISession session = mySessionFactory.OpenSession())
                {
                    SqlConnection con = session.Connection as SqlConnection;
                    SqlCommand cmd = new SqlCommand($"Delete from ToDo where Id={id}", con);
                    cmd.ExecuteNonQuery();
                }
                this.Close();
        }
        private void button_updateChanges_Click(object sender, EventArgs e)
        {
            InitializingHibernate();

            using (mySession.BeginTransaction())
            {
                ToDo LotoDo = new ToDo
                {
                    TaskName = richTextBox_editTaskName.Text,
                    TaskDescription = richTextBox_descriptionTask.Text,
                    EndDate = monthCalendar_endTask.SelectionRange.Start,
                    StartDate = monthCalendar_startTask.SelectionRange.Start,
                    Id = id,
                    Status = status
                    
                };
                mySession.Update(LotoDo);

                mySession.Transaction.Commit();
            }
        }


        //Protection against invalid data
        private void monthCalendar_startTask_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar_startTask.SelectionRange.Start > monthCalendar_endTask.SelectionRange.Start)
            {
                label_errorsEditTasks.Text = "Data rozpoczęcia zadania nie może być większa niż data zakończenia !";
                button_updateChanges.Enabled = false;
            }
            else
            {
                label_errorsEditTasks.Text = "";
                button_updateChanges.Enabled = true;
            }
        }

        private void monthCalendar_endTask_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar_startTask.SelectionRange.Start > monthCalendar_endTask.SelectionRange.Start)
            {
                label_errorsEditTasks.Text = "Data rozpoczęcia zadania nie może być większa niż data zakończenia !";
                button_updateChanges.Enabled = false;
            }
            else
            {
                label_errorsEditTasks.Text = "";
                button_updateChanges.Enabled = true;
            }
        }

        private void richTextBox_editTaskName_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox_editTaskName.TextLength > 30 || richTextBox_editTaskName.TextLength < 1)
            {
                label_errorsEditTasks.Text = "Nazwa Zadania powinna mieć mniej niż 30 znaków i więcej niż 0";
                button_updateChanges.Enabled = false;
            }
            else
            {
                label_errorsEditTasks.Text = "";
                button_updateChanges.Enabled = true;
            }
        }
    }
}
