using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timely
{
    public partial class NotifiyFrm : Form
    {
        public NotifiyFrm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls=false;
        }

        public static void ShowNotify(string Message, Color MessageColor)
        {
            var frm = new NotifiyFrm();
            foreach (var openFroms in Application.OpenForms)
            {
                if (openFroms is NotifiyFrm)
                    frm = openFroms as NotifiyFrm;
            }
            frm.label1.Text = Message;
            frm.label1.ForeColor = MessageColor;
            Task.Run(() =>
            {
                frm.TopMost = true;
                Rectangle workingArea = Screen.GetWorkingArea(frm);
                frm.Location = new Point(workingArea.Right - frm.Size.Width,
                                          workingArea.Bottom - frm.Size.Height);
                frm.CloseTimer.Enabled = true;
                frm.ShowDialog();
            });
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void NotifiyFrm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
