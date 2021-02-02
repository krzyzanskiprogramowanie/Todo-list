using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Todo_List
{
    public partial class Alert : Form
    {
        string fname;
        public Alert()
        {
            InitializeComponent();
        }

        private enum enmAction
        {
            wait, 
            start,
            close
        }
        private Alert.enmAction action;
        private int x, y;

        private void button_exit_Click(object sender, EventArgs e)
        {
            timer_notification.Interval = 1;
            action = enmAction.close;
        }

        private void timer_notification_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer_notification.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer_notification.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x<this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity==1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer_notification.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity==0.0)
                    {
                        base.Close();
                    }
                    break;
            
            }

        }

        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            for (int i = 0; i < 10; i++)
            {
                fname = "Alert" + i.ToString();
                Alert alert = (Alert)Application.OpenForms[fname];
                if (alert==null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                    
                }
            }
            this.label1.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer_notification.Interval = 1;
            timer_notification.Start();
        }
    }
}
