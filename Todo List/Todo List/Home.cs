using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class Home : Form
    {
        private Configuration myConfiguration;
        private NHibernate.ISessionFactory mySessionFactory;
        private ISession mySession;
        public Home()   
        {
            InitializeComponent();
            reminder();
            reminder();
            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        public void reminder()
        {
            DateTime date = DateTime.Now;
            DateTime date_plusOne = date.AddDays(1);
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
            int i = 0;
            //I'm checking if there are any new tasks tomorrow
            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<ToDo>();
                IList<ToDo> list = criteria.List<ToDo>().Where(a => a.Status == "ToDo" && (date
                                                                              <= a.StartDate && date_plusOne>=a.StartDate)).ToList();
                 i = 0;
                foreach (var item in list)
                {
                    i++;
                }
            }
            if (i>0)
            {
                Alert alert = new Alert();
                alert.showAlert("Jutro masz nowe zadania do zrobienia !");
            }

            button_TodoList.Text = "Rzeczy \ndo zrobienia";
        }
        private void button_exitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_addTasks_Click(object sender, EventArgs e)
        {
            AddTasks addTasks = new AddTasks();
            nav(addTasks, panel_Content);

        }
        private void button_TodoList_Click(object sender, EventArgs e)
        {
            TodoList todoList = new TodoList();
            nav(todoList, panel_Content);

        }
        private void button_allTasks_Click(object sender, EventArgs e)
        {
            AllTasks allTasks = new AllTasks();
            nav(allTasks, panel_Content);

        }
        private void button_reminder_Click(object sender, EventArgs e)
        {
            Reminders reminders = new Reminders();
            nav(reminders, panel_Content);
        }
        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
