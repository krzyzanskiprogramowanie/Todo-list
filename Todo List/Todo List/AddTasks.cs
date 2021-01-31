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
                ToDo LotoDo = new ToDo
                {
                    TaskName = textBox1_taskName.Text,
                    TaskDescription = richTextBox_descriptionTask.Text,
                    EndDate = monthCalendar_endTaskDay.SelectionRange.Start,
                    StartDate = monthCalendar_startTaskDay.SelectionRange.Start,
                    Status = "done"
                };
                mySession.Save(LotoDo);
                mySession.Transaction.Commit();
            }
        }
    }
}
