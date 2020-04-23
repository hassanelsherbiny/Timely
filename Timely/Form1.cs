using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timely.Models;
namespace Timely
{
    public partial class Form1 : Form
    {
        bool ExitApp = false;

        bool IsRunning = false;
        public Form1()
        {
            InitializeComponent(); LoadProfiles();
        }
        void LoadProfiles()
        {
            CmbProfiles.DataSource = Session.Profiles;
            CmbProfiles.ValueMember = "Name";
            CmbProfiles.DisplayMember = "Name";
            CmbProfiles_SelectedIndexChanged(null, null);
        }
        void DisplayWorkTasks(WorkTask workTask)
        {
            WorkTaskLv.Items.Clear();
            WorkTaskLv.Groups.Clear();

            foreach (var periods in workTask.WorkPeriods.OrderByDescending(x => x.From).GroupBy(x => x.From))
            {
                var Title = TimeSpanToString(TimeSpan.FromMinutes(periods.Sum(x => x.Period.TotalMinutes))) + string.Format("  -  ") + periods.FirstOrDefault().From.ToShortDateString();
                ListViewGroup DayGroup = new ListViewGroup(Title);
                DayGroup.HeaderAlignment = HorizontalAlignment.Right;
                WorkTaskLv.Groups.Add(DayGroup);
                foreach (var period in periods)
                {
                    var cols = new List<string>();
                    cols.Add(period.Id);
                    cols.Add(period.From.ToShortTimeString());
                    cols.Add(period.To?.ToShortTimeString());
                    cols.Add(TimeSpanToString(period.Period));
                    WorkTaskLv.Items.Add(new ListViewItem(cols.ToArray()) { Group = DayGroup });
                }

            }
        }

        private string TimeSpanToString(TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours.ToString("00")}:{timeSpan.Minutes.ToString("00")}";
        }

        private void BtnStartPause_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            if (IsRunning)
            {
                BtnStartPause.Text = "Start";
                AutoSaveTimer_Tick(null, null);
                TrayIcon.Icon = Properties.Resources.iconStopped;
            }
            else
            {
                var WorkPeriod = new WorkPeriod();
                WorkPeriod.From = DateTime.Now;
                Session.ActiveWorkTask.WorkPeriods.Add(WorkPeriod);
                Session.ActiveProfile.Save();
                BtnStartPause.Text = "Pause";
                NotifiyFrm.ShowNotify("Timely Tracking Is Running", Color.Green);
                TrayIcon.Icon = Properties.Resources.iconRunning;
                DisplayWorkTasks(Session.ActiveWorkTask);
            }
            IsRunning = !IsRunning;
            AutoSaveTimer.Enabled = IsRunning;
        }
        void ShowNotifiy(string Message)
        {

        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                var WorkPeriod = Session.ActiveWorkTask.WorkPeriods.LastOrDefault();
                WorkPeriod.To = DateTime.Now;
                Session.ActiveProfile.Save();
                NotifiyFrm.ShowNotify("Timely Tracking Is Paused", Color.Red);
                DisplayWorkTasks(Session.ActiveWorkTask);
            }
        }

        private void CmbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectedTask = CmbTasks.SelectedValue.ToString();
            Session.ActiveWorkTask = Session.ActiveProfile.WorkTasks.FirstOrDefault(x => x.Id == SelectedTask);
            DisplayWorkTasks(Session.ActiveWorkTask);
        }

        private void CmbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbProfiles.SelectedValue != null)
            {
                Session.ActiveProfile = Profile.Load(CmbProfiles.SelectedValue.ToString());
                CmbTasks.DataSource = Session.ActiveProfile.WorkTasks;
                CmbTasks.ValueMember = "Id";
                CmbTasks.DisplayMember = "TaskName";
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var frm = new WorkTaskFrm(CmbProfiles.SelectedValue?.ToString());
            frm.ShowDialog();
            LoadProfiles();
            CmbProfiles.SelectedValue = frm.SelectedProfile;
            CmbProfiles_SelectedIndexChanged(null, null);
            CmbTasks.SelectedValue = frm.SelectedWorkTask;
            CmbTasks_SelectedIndexChanged(null, null);

        }

        private void WorkTaskLv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var ToBeDeleted = new List<string>();
                foreach (ListViewItem item in WorkTaskLv.SelectedItems)
                {
                    ToBeDeleted.Add(item.Text);
                }
                Session.ActiveWorkTask.WorkPeriods = Session.ActiveWorkTask.WorkPeriods.Where(x => !ToBeDeleted.Contains(x.Id)).ToList();
                Session.ActiveProfile.Save();
                DisplayWorkTasks(Session.ActiveWorkTask);
            }
        }

        private void BtnAddToTray_Click(object sender, EventArgs e)
        {

        }

        private void BtnMenuShow_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void BtnMenuExit_Click(object sender, EventArgs e)
        {
            ExitApp = true;
            Session.ActiveProfile?.Save();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ExitApp)
            {
                e.Cancel = true;
                Visible = false;
                TrayIcon.Visible = true;

                if (IsRunning)
                {
                    TrayIcon.Icon = Properties.Resources.iconRunning;
                }
                else
                {
                    TrayIcon.Icon = Properties.Resources.iconStopped;
                }
            }
        }

        private void WorkTaskLv_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = WorkTaskLv.Columns[e.ColumnIndex].Width;
        }

        private void LblCopyRight_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hassanelsherbiny.github.io/");
        }
    }
}
