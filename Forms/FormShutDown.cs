using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownWinForm2.Forms
{
    public partial class FormShutDown : Form
    {
        int initialSecounds;
        string cmdStartShutdownText = $"/C shutdown -s -t ";
        string cmdText = "CMD.exe";
        string cmdStopShutdownText = "/C shutdown -a";
        bool isOnShutDown;
        bool isCmdActive;
        bool isInitialSecounds = true;
        bool isEnableButtons = true;

        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int TotalSecounds { get; private set; }
        public bool IsCounting { get; private set; }

        public FormShutDown()
        {
            InitializeComponent();
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            TotalSecounds += 100;
            CalculateSecounds();
        }

        private void btnRemove100_Click(object sender, EventArgs e)
        {
            if(TotalSecounds > 0)
                TotalSecounds -= 100;
            CalculateSecounds();
        }

        private void btnAdd500_Click(object sender, EventArgs e)
        {
            TotalSecounds += 500;
            CalculateSecounds();
        }

        private void btnRemove500_Click(object sender, EventArgs e)
        {
            if(TotalSecounds > 0 && TotalSecounds < 500)
                TotalSecounds = 0;
            else if(TotalSecounds >= 500)
                TotalSecounds -= 500;
            CalculateSecounds();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --TotalSecounds;
            CalculateSecounds();
        }

        private void CalculateSecounds()
        {
            if (TotalSecounds > 0 && !IsCounting)
                btnClear.Visible = true;
            else
                btnClear.Visible = false;

            if (TotalSecounds >= 300 && !IsCounting)
            {
                btnStartCountdown.Enabled = true;
            }
            else
            {
                btnStartCountdown.Enabled = false;
            }

            if(TotalSecounds <= 600 && IsCounting && isEnableButtons)
            {
                btnAdd100.Enabled = false;
                btnRemove100.Enabled = false;
                btnAdd500.Enabled = false;
                btnRemove500.Enabled = false;

                isEnableButtons = false;
            }
            else if(TotalSecounds >600 && IsCounting && !isEnableButtons)
            {
                btnAdd100.Enabled = true;
                btnRemove100.Enabled = true;
                btnAdd500.Enabled = true;
                btnRemove500.Enabled = true;

                isEnableButtons = true;
            }

            if(TotalSecounds <= 600 && IsCounting && !isOnShutDown)
            {
                System.Diagnostics.Process.Start(cmdText, cmdStartShutdownText + TotalSecounds.ToString());
                isOnShutDown = true;
                isCmdActive = true;
            }

            Hours = TotalSecounds / 3600;
            Minutes = (TotalSecounds % 3600) / 60;

            lblTime.Text = Hours.ToString() + " : " + Minutes.ToString() + " : " + (TotalSecounds % 60).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TotalSecounds = 0;

            isInitialSecounds = true;
            isEnableButtons = true;

            btnResetCountdown.Visible = false;
            btnAdd100.Enabled = true;
            btnRemove100.Enabled = true;
            btnAdd500.Enabled = true;
            btnRemove500.Enabled = true;

            CalculateSecounds();
        }

        private void btnStartCountdown_Click(object sender, EventArgs e)
        {
            // Start the timer
            timer1.Start();
            IsCounting = true;

            if (isInitialSecounds)
            {
                initialSecounds = TotalSecounds;
                isInitialSecounds = false;
            }

            btnStartCountdown.Enabled = false;
            btnStopCountdown.Enabled = true;
            btnClear.Visible = false;
            btnResetCountdown.Visible = false;
        }

        private void btnStopCountDown_Click(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();
            IsCounting = false;
            isOnShutDown = false;

            btnStartCountdown.Enabled = true;
            btnStopCountdown.Enabled = false;
            btnClear.Visible = true;
            btnResetCountdown.Visible = true;

            if (isCmdActive)
            {
                System.Diagnostics.Process.Start(cmdText, cmdStopShutdownText);
                isCmdActive = false;
            }
        }

        private void btnResetCountdown_Click(object sender, EventArgs e)
        {
            TotalSecounds = initialSecounds;
            btnStopCountdown.Enabled = false;
            btnResetCountdown.Visible = false;
            CalculateSecounds();
        }
    }
}
