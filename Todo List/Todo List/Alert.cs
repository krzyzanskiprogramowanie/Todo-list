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
        string name;
        private Alert.enmAction operation;
        private int x, y;
        public Alert()
        {
            InitializeComponent();
        }
        private enum enmAction
        {
            start,
            wait, 
            close
        }
     
        private void timer_notification_Tick(object sender, EventArgs e)
        {
            switch (this.operation)
            {
                case enmAction.wait:
                    timer_notification.Interval = 5000;
                    operation = enmAction.close;
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
                            operation = enmAction.wait;
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

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            timer_notification.Interval = 1;
            operation = enmAction.close;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            for (int i = 0; i < 10; i++)
            {
                name = "Alert" + i.ToString();
                Alert alert = (Alert)Application.OpenForms[name];
                if (alert==null)
                {
                    this.Name = name;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.label1.Text = msg;
            this.Show();
            this.operation = enmAction.start;
            this.timer_notification.Interval = 1;
            timer_notification.Start();
        }
    }
}
