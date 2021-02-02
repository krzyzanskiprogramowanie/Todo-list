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
    public partial class AllTasks : Form
    {
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        public AllTasks()
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
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Status == "ToDo").OrderBy(a=>a.StartDate).ToList();
                foreach (var item in list)
                {
                    listView_toDo.Items.Add(item.TaskName);
                    listView_toDo.Items.Add(item.StartDate.ToString("dd/MM/yyyy"));
                    listView_toDo.Items.Add(item.EndDate.ToString("dd/MM/yyyy"));


                }
                list = criteria.List<ToDo>().Where(a => a.Status == "doing").OrderBy(a => a.StartDate).ToList();
                foreach (var item in list)
                {
                    listView_doing.Items.Add(item.TaskName);
                    listView_doing.Items.Add(item.StartDate.ToString("dd/MM/yyyy"));
                    listView_doing.Items.Add(item.EndDate.ToString("dd/MM/yyyy"));

                }
                list = criteria.List<ToDo>().Where(a => a.Status == "done").OrderBy(a => a.StartDate).ToList();
                foreach (var item in list)
                {
                    listView_done.Items.Add(item.TaskName);
                    listView_done.Items.Add(item.StartDate.ToString("dd/MM/yyyy"));
                    listView_done.Items.Add(item.EndDate.ToString("dd/MM/yyyy"));

                }
            }
            ChangeView();

        }
        public void ChangeView()
        {
            label1.Text = "Nazwa \nZadania:";
            label4.Text = "Nazwa \nZadania:";
            label9.Text = "Nazwa \nZadania:";
            label2_dateStartToDo.Text = "       Data \nRozpoczęcia:";
            label3_dateEnd_toDo.Text = "        Data \nZakończenia:";
            label5_dateStart_doing.Text = "      Data \nRozpoczęcia:";
            label6_dateEnd_doing.Text = "       Data \nZakończenia:";
            label8_dateStart_done.Text = "      Data \nRozpoczęcia:";
            label7_dateEnd_done.Text = "        Data \nZakończenia:";
        }
  
    }
}
