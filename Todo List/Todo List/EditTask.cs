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
    public partial class EditTask : Form
    {
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        public EditTask(string taskName)
        {
            InitializeComponent();
            disableEdits();

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

            int id = Convert.ToInt32(taskName.Substring(taskName.IndexOf("(id=") + "(id=".Length));

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
                }

            }

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
