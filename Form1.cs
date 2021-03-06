﻿using System;
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
        Process[] myProcess;
        string processName;
     
        float writeFOV = 90;

        float readFov = 0;

        int fovAddressV49 = 0x15DA15C;
        int fovAddressV48 = 0x15D915C;
        int addressToUse = 0;
        int[] offsets = new int[] { 0x380, 0x0, 0x40, 0x3c4, 0x244 };
        float viewmodelMultiplier = 1.0f;

        float readViewModelFOV = 0;
        float writeViewModelFOV = 0;

        bool changeViewModels = true;
        int[] offsetsViewmodels = new int[] { 0x380, 0x0, 0x1A4, 0x4e8 };

        bool autoMode = false;

        string labelUrl = "http://www.pcgamingwiki.com";
        string developerURL = "https://www.twitchalerts.com/donate/suicidemachine";


        public Form1()
        {
            InitializeComponent();
            processName = "moh";
            L_FOVMultiplierValue.Text = viewmodelMultiplier.ToString("0.000");
        }

        bool foundProcess = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                myProcess = Process.GetProcessesByName(processName);
                if (myProcess.Length > 0)
                {
                    if (foundProcess == false)
                        System.Threading.Thread.Sleep(100);

                    if(baseAddress == 0x0)
                    {
                        IntPtr startOffset = myProcess[0].MainModule.BaseAddress;
                        IntPtr endOffset = IntPtr.Add(startOffset, myProcess[0].MainModule.ModuleMemorySize);
                        baseAddress = startOffset.ToInt32();

                        var details = myProcess[0].MainModule.FileVersionInfo;
                        if (details.FileMajorPart == 1 && details.FileMinorPart == 0 && details.FileBuildPart == 4 && details.FilePrivatePart == 0)
                            addressToUse = fovAddressV49;
                        else
                            addressToUse = fovAddressV48;
                    }

                    foundProcess = true;
                }
                else
                {
                    foundProcess = false;
                    baseAddress = 0x0;
                }


                if (foundProcess)
                {
                    // The game is running, ready for memory reading.
                    LB_Running.Text = "MOH IS RUNNING";
                    LB_Running.ForeColor = Color.Green;

                    readFov = Trainer.ReadPointerFloat(myProcess, baseAddress + addressToUse, offsets);
                    readViewModelFOV = Trainer.ReadPointerFloat(myProcess, baseAddress + addressToUse, offsetsViewmodels);

                    L_fov.Text = readFov.ToString();

                    if (autoMode)
                    {
                        ChangeFov();
                        if (changeViewModels)
                            ChangeViewModelFOV();
                    }
                }
                else
                {
                    // The game process has not been found, reseting values.
                    LB_Running.Text = "MOH IS NOT RUNNING";
                    LB_Running.ForeColor = Color.Red;
                    ResetValues();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void ChangeViewModelFOV()
        {
            if(readViewModelFOV > 0 && readViewModelFOV < 270 && readViewModelFOV != writeViewModelFOV)
            {
                recalculateViewModelFOV();
                Trainer.WritePointerFloat(myProcess, baseAddress + addressToUse, offsetsViewmodels, writeViewModelFOV);
            }
        }

        private void recalculateViewModelFOV()
        {
            float multiplier = writeFOV / 70.0f;
            writeViewModelFOV = 60.0f * multiplier * viewmodelMultiplier;
        }

        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
            L_fov.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }


        void ChangeFov()
        {
            if (readFov != writeFOV && !float.IsNaN(writeFOV) && readFov != 0)
            {
                Trainer.WritePointerFloat(myProcess, baseAddress + addressToUse, offsets, writeFOV);
            }
        }
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void C_AutoMode_CheckedChanged(object sender, EventArgs e)
        {
            autoMode = C_AutoMode.Checked;
        }

        private void B_set_Click(object sender, EventArgs e)
        {
            modifiedFOV();
        }

        private void modifiedFOV()
        {
            var res = 0f;
            if (float.TryParse(T_Input.Text, out res))
            {
                if (res < 1.0)
                {
                    writeFOV = 1.0f;
                    T_Input.Text = writeFOV.ToString();
                }
                else if (res > 179)
                {
                    writeFOV = 179.0f;
                    T_Input.Text = writeFOV.ToString();
                }
                else
                {
                    writeFOV = res;
                    recalculateViewModelFOV();
                }
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(labelUrl);
        }

        private void donateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(developerURL);
        }

        private void C_ChangeVIewModelFOV_CheckedChanged(object sender, EventArgs e)
        {
            changeViewModels = C_ChangeVIewModelFOV.Checked;
        }

        private void T_Input_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter )
            {
                modifiedFOV();
            }
        }

		private void TBar_Multiplier_Scroll(object sender, EventArgs e)
		{
            var percent = ((float)(TBar_Multiplier.Value) / TBar_Multiplier.Maximum);
            viewmodelMultiplier = Lerp(0.5f, 1.5f, percent);
            L_FOVMultiplierValue.Text = viewmodelMultiplier.ToString("0.000");
            recalculateViewModelFOV();
		}

        float Lerp(float lowerBound, float upperBound, float percent)
        {
            return lowerBound * (1 - percent) + upperBound * percent;
        }
    }
}
