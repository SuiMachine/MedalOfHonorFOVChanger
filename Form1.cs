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
        Process[] myProcess;
        string processName;
     
        float writeFOV = 90;

        float readFov = 0;

        int fovAddress = 0x01409338;
        int[] offsets = new int[] { 0x10, 0x40, 0x3c4, 0x244 };

        float readViewModelFOV = 0;
        float writeViewModelFOV = 0;

        bool changeViewModels = true;
        int viewModelBaseAddress = 0x015EA13C;
        int[] offsetsViewmodels = new int[] { 0x8, 0x48, 0x424, 0x4e8 };

        bool autoMode = false;

        string labelUrl = "http://www.pcgamingwiki.com";
        string developerURL = "https://www.gamingforgood.net/s/suicidemachine/widget";


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Form1()
        {
            InitializeComponent();
            processName = "moh";
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

                    readFov = Trainer.ReadPointerFloat(myProcess, baseAddress + fovAddress, offsets);
                    readViewModelFOV = Trainer.ReadPointerFloat(myProcess, baseAddress + viewModelBaseAddress, offsetsViewmodels);

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
            if(readViewModelFOV > 0 && readViewModelFOV < 180 && readViewModelFOV != writeViewModelFOV)
            {
                recalculateViewModelFOV();
                Trainer.WritePointerFloat(myProcess, baseAddress + viewModelBaseAddress, offsetsViewmodels, writeViewModelFOV);
            }
        }

        private void recalculateViewModelFOV()
        {
            float multiplier = writeFOV / 70.0f;
            writeViewModelFOV = 60.0f * multiplier;
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
                Trainer.WritePointerFloat(myProcess, baseAddress + fovAddress, offsets, writeFOV);
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
    }
}
