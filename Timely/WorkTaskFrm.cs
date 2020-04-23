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
    public partial class WorkTaskFrm : Form
    {
        public string SelectedProfile { get; set; }
        public string SelectedWorkTask { get; set; }
        public WorkTaskFrm(string Profile)
        {
            InitializeComponent();
            txtProfile.Text = Profile;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProfile.Text) && !string.IsNullOrEmpty(txtWorkTask.Text))
            {
                var profile = Profile.Load(txtProfile.Text);
                if (profile == null)
                    profile = new Profile();
                profile.Name = txtProfile.Text;
                var task = new WorkTask() { TaskName = txtWorkTask.Text };
                profile.WorkTasks.Add(task);
                profile.Save();
                SelectedWorkTask = task.Id;
                SelectedProfile = profile.Name;
                Close();
            }
            else
                MessageBox.Show("Please Enter Profile Name And Work Task");

        }
    }
}
