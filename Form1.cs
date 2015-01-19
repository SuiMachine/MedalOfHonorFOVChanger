using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;


namespace FovChanger
{
    public partial class Form1 : Form
    {
        // Base address value for pointers.
        int baseAddress = 0x0000000;

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        string gameName, processName;
     
        float  fov=90;

        float readFov = 0;
        int[] offsets = new int[] { 0x10, 0x40, 0x3c4, 0x244 };

        int fovAddress = 0x01409338;

        Keys Key = Keys.P;

        bool autoMode;
        
        bool settingInputKey;

        string labelUrl = "www.pcgamingwiki.com";


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Form1()
        {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
            gameName = "moh";
            processName = "moh";
        }

        bool foundProcess = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName(processName);
            if (myProcess.Length > 0)
            {
                IntPtr startOffset = myProcess[0].MainModule.BaseAddress;
                IntPtr endOffset = IntPtr.Add(startOffset, myProcess[0].MainModule.ModuleMemorySize);
                baseAddress = startOffset.ToInt32();
                foundProcess = true;
            }
            else
                foundProcess = false;

            if (foundProcess)
            {
                // The game is running, ready for memory reading.
                LB_Running.Text = "MEDAL OF HONOR IS RUNNING";
                LB_Running.ForeColor = Color.Green;

                readFov = Trainer.ReadPointerFloat(processName, baseAddress+ fovAddress,  offsets);

                L_fov.Text = readFov.ToString();

                if (autoMode)
                    ChangeFov();
            }
            else
            {
                // The game process has not been found, reseting values.
                LB_Running.Text = "MOH IS NOT RUNNING";
                LB_Running.ForeColor = Color.Red;
                ResetValues();
            }
        }

        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
            L_fov.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitHotkey();
            Timer.Start();
        }

        public void InitHotkey()
        {
            if (!KeyGrabber.Hooked)
            {
                KeyGrabber.keyPressEvent += KeyGrabber_KeyPress;
                KeyGrabber.key.Clear();
                if (Key != Keys.None)
                    KeyGrabber.key.Add(Key);

                KeyGrabber.SetHook();
            }
            else
            {
                if (Key != Keys.None)
                    KeyGrabber.key.Add(Key);
            }

        }

        public void UnHook()
        {
            KeyGrabber.UnHook();
        }

        private void KeyGrabber_KeyPress(object sender, EventArgs e)
        {
            ChangeFov();
        }

        void ChangeFov()
        {
            if (fovAddress != 0x0000000 && foundProcess)
                if(readFov != fov)
                {
                    Trainer.WritePointerFloat(processName, baseAddress+ fovAddress, offsets, fov);
                }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (settingInputKey)
            {
                Key = keyData;
                B_Key.Text = Key.ToString();
                B_Key.Checked = false;
                InitHotkey();
                return true;
            }
                
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void B_Key_CheckedChanged(object sender, EventArgs e)
        {
            if (B_Key.Checked)
            {
                settingInputKey = true;
                B_Key.Text = "";
                C_KeyMode.Checked = true;
            }
            else
            {
                settingInputKey = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
        }


        // Lazy way to do it i know, it would be better with events

        private void C_AutoMode_CheckedChanged(object sender, EventArgs e)
        {
            if (C_AutoMode.Checked)
            {
                C_KeyMode.Checked = false;
                B_Key.Enabled = false;
                autoMode = true;
            }
            else
            {
                autoMode = false;
            }
        }

        private void C_KeyMode_CheckedChanged(object sender, EventArgs e)
        {
            if (C_KeyMode.Checked)
            {
                C_AutoMode.Checked = false;
                B_Key.Enabled = true;
                autoMode = false;
                InitHotkey();
            }
            else
            {
                UnHook();
            }
        }

        private void B_set_Click(object sender, EventArgs e)
        {
            var res = 0f;
            if (float.TryParse(T_Input.Text, out res))
            {
                fov = res;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(labelUrl);
        }
    }
}
