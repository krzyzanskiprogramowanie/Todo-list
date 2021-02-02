using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class AddTasks : Form
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        public AddTasks()
        {
            InitializeComponent();
        }

        private void button_addTask_Click(object sender, EventArgs e)
        {
            if (textBox1_taskName.TextLength <1)
            {
                label_errors_addTasks.Text = "Musisz podać tytuł zadania";
                button_addTask.Enabled = false;
            }
            else
            {
                label_errors_addTasks.Text = "";
                button_addTask.Enabled = true;

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

                using (mySession.BeginTransaction())
                {
                    ToDo LotoDo = new ToDo
                    {
                        TaskName = textBox1_taskName.Text,
                        TaskDescription = richTextBox_descriptionTask.Text,
                        EndDate = monthCalendar_endTaskDay.SelectionRange.Start,
                        StartDate = monthCalendar_startTaskDay.SelectionRange.Start,
                        Status = "ToDo"
                    };
                    mySession.Save(LotoDo);

                    mySession.Transaction.Commit();
                }
                MessageBox.Show("Zadanie zostało dodane");
            }
           
        }

        //Protection against invalid data
        private void textBox1_taskName_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_taskName.TextLength > 30 || textBox1_taskName.TextLength<1)
            {
                label_errors_addTasks.Text = "Nazwa Zadania powinna mieć mniej niż 30 znaków i więcej niż 0";
                button_addTask.Enabled = false;
            }
            else
            {
                label_errors_addTasks.Text = "";
                button_addTask.Enabled = true;
            }
        }

        private void monthCalendar_startTaskDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar_startTaskDay.SelectionRange.Start>monthCalendar_endTaskDay.SelectionRange.Start)
            {
                label_errors_addTasks.Text = "Data rozpoczęcia zadania nie może być większa niż data zakończenia !";
                button_addTask.Enabled = false;
            }
            else
            {
                label_errors_addTasks.Text = "";
                button_addTask.Enabled = true;
            }
        }

        private void monthCalendar_endTaskDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (monthCalendar_startTaskDay.SelectionRange.Start > monthCalendar_endTaskDay.SelectionRange.Start)
            {
                label_errors_addTasks.Text = "Data rozpoczęcia zadania nie może być większa niż data zakończenia !";
                button_addTask.Enabled = false;
            }
            else
            {
                label_errors_addTasks.Text = "";
                button_addTask.Enabled = true;
            }
        }
    }
}
