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
    public partial class Reminders : Form
    {
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        public Reminders()
        {
            InitializeComponent();

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
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Status == "ToDo" &&(DateTime.Now < a.StartDate ))
                .OrderBy(a => a.StartDate).OrderBy(a=>a.EndDate).ToList();
                foreach (var item in list)
                {
                    listView_reminders.Items.Add(item.TaskName);
                    listView_reminders.Items.Add(item.StartDate.ToString("dd/MM/yyyy"));
                    listView_reminders.Items.Add(item.EndDate.ToString("dd/MM/yyyy"));

                }
            }
            ChangeView();
        }

        public void ChangeView()
        {
            label1.Text = "Nazwa \nZadania:";
            label2.Text = "      Data \nRozpoczęcia:";
            label3.Text = "        Data \nZakończenia:";
            listView_reminders.
        }
    }
}
