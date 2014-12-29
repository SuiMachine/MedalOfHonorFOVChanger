namespace FovChanger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Running = new System.Windows.Forms.Label();
            this.T_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C_AutoMode = new System.Windows.Forms.CheckBox();
            this.C_KeyMode = new System.Windows.Forms.CheckBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.B_set = new System.Windows.Forms.Button();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.advancedFeatures = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_SetDecrease = new System.Windows.Forms.Button();
            this.B_SetIncrease = new System.Windows.Forms.Button();
            this.T_decrease = new System.Windows.Forms.TextBox();
            this.T_Increase = new System.Windows.Forms.TextBox();
            this.C_Decrease = new System.Windows.Forms.CheckBox();
            this.C_Increase = new System.Windows.Forms.CheckBox();
            this.B_Key = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_fov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputPanel.SuspendLayout();
            this.KeyPanel.SuspendLayout();
            this.advancedFeatures.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_Running
            // 
            this.LB_Running.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Running.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Running.ForeColor = System.Drawing.Color.Red;
            this.LB_Running.Location = new System.Drawing.Point(0, 0);
            this.LB_Running.Name = "LB_Running";
            this.LB_Running.Size = new System.Drawing.Size(302, 24);
            this.LB_Running.TabIndex = 1;
            this.LB_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // T_Input
            // 
            this.T_Input.Location = new System.Drawing.Point(23, 31);
            this.T_Input.Name = "T_Input";
            this.T_Input.Size = new System.Drawing.Size(170, 20);
            this.T_Input.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Insert Fov";
            // 
            // C_AutoMode
            // 
            this.C_AutoMode.AutoSize = true;
            this.C_AutoMode.Location = new System.Drawing.Point(14, 67);
            this.C_AutoMode.Name = "C_AutoMode";
            this.C_AutoMode.Size = new System.Drawing.Size(103, 17);
            this.C_AutoMode.TabIndex = 39;
            this.C_AutoMode.Text = "Automatic Mode";
            this.C_AutoMode.UseVisualStyleBackColor = true;
            this.C_AutoMode.CheckedChanged += new System.EventHandler(this.C_AutoMode_CheckedChanged);
            // 
            // C_KeyMode
            // 
            this.C_KeyMode.AutoSize = true;
            this.C_KeyMode.Location = new System.Drawing.Point(3, 9);
            this.C_KeyMode.Name = "C_KeyMode";
            this.C_KeyMode.Size = new System.Drawing.Size(74, 17);
            this.C_KeyMode.TabIndex = 40;
            this.C_KeyMode.Text = "Key Mode";
            this.C_KeyMode.UseVisualStyleBackColor = true;
            this.C_KeyMode.CheckedChanged += new System.EventHandler(this.C_KeyMode_CheckedChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.linkLabel);
            this.InputPanel.Controls.Add(this.B_set);
            this.InputPanel.Controls.Add(this.KeyPanel);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.T_Input);
            this.InputPanel.Controls.Add(this.C_AutoMode);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 65);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(302, 232);
            this.InputPanel.TabIndex = 41;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(8, 209);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(84, 13);
            this.linkLabel.TabIndex = 43;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "PC Gaming Wiki";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // B_set
            // 
            this.B_set.Location = new System.Drawing.Point(199, 29);
            this.B_set.Name = "B_set";
            this.B_set.Size = new System.Drawing.Size(45, 23);
            this.B_set.TabIndex = 42;
            this.B_set.Text = "Set";
            this.B_set.UseVisualStyleBackColor = true;
            this.B_set.Click += new System.EventHandler(this.B_set_Click);
            // 
            // KeyPanel
            // 
            this.KeyPanel.Controls.Add(this.advancedFeatures);
            this.KeyPanel.Controls.Add(this.B_Key);
            this.KeyPanel.Controls.Add(this.C_KeyMode);
            this.KeyPanel.Location = new System.Drawing.Point(11, 90);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(278, 113);
            this.KeyPanel.TabIndex = 41;
            // 
            // advancedFeatures
            // 
            this.advancedFeatures.Controls.Add(this.label4);
            this.advancedFeatures.Controls.Add(this.label3);
            this.advancedFeatures.Controls.Add(this.B_SetDecrease);
            this.advancedFeatures.Controls.Add(this.B_SetIncrease);
            this.advancedFeatures.Controls.Add(this.T_decrease);
            this.advancedFeatures.Controls.Add(this.T_Increase);
            this.advancedFeatures.Controls.Add(this.C_Decrease);
            this.advancedFeatures.Controls.Add(this.C_Increase);
            this.advancedFeatures.Location = new System.Drawing.Point(3, 41);
            this.advancedFeatures.Name = "advancedFeatures";
            this.advancedFeatures.Size = new System.Drawing.Size(272, 69);
            this.advancedFeatures.TabIndex = 42;
            this.advancedFeatures.TabStop = false;
            this.advancedFeatures.Text = "Advanced features";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Decrease FOV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Increase FOV";
            // 
            // B_SetDecrease
            // 
            this.B_SetDecrease.Location = new System.Drawing.Point(226, 41);
            this.B_SetDecrease.Name = "B_SetDecrease";
            this.B_SetDecrease.Size = new System.Drawing.Size(45, 23);
            this.B_SetDecrease.TabIndex = 45;
            this.B_SetDecrease.Text = "Set";
            this.B_SetDecrease.UseVisualStyleBackColor = true;
            this.B_SetDecrease.Click += new System.EventHandler(this.B_SetDecrease_Click);
            // 
            // B_SetIncrease
            // 
            this.B_SetIncrease.Location = new System.Drawing.Point(226, 13);
            this.B_SetIncrease.Name = "B_SetIncrease";
            this.B_SetIncrease.Size = new System.Drawing.Size(45, 23);
            this.B_SetIncrease.TabIndex = 44;
            this.B_SetIncrease.Text = "Set";
            this.B_SetIncrease.UseVisualStyleBackColor = true;
            this.B_SetIncrease.Click += new System.EventHandler(this.B_SetIncrease_Click);
            // 
            // T_decrease
            // 
            this.T_decrease.Location = new System.Drawing.Point(166, 43);
            this.T_decrease.Name = "T_decrease";
            this.T_decrease.Size = new System.Drawing.Size(54, 20);
            this.T_decrease.TabIndex = 3;
            // 
            // T_Increase
            // 
            this.T_Increase.Location = new System.Drawing.Point(166, 16);
            this.T_Increase.Name = "T_Increase";
            this.T_Increase.Size = new System.Drawing.Size(54, 20);
            this.T_Increase.TabIndex = 2;
            // 
            // C_Decrease
            // 
            this.C_Decrease.Appearance = System.Windows.Forms.Appearance.Button;
            this.C_Decrease.Location = new System.Drawing.Point(97, 42);
            this.C_Decrease.Name = "C_Decrease";
            this.C_Decrease.Size = new System.Drawing.Size(63, 24);
            this.C_Decrease.TabIndex = 1;
            this.C_Decrease.Text = "Decrease";
            this.C_Decrease.UseVisualStyleBackColor = true;
            this.C_Decrease.CheckedChanged += new System.EventHandler(this.C_Decrease_CheckedChanged);
            // 
            // C_Increase
            // 
            this.C_Increase.Appearance = System.Windows.Forms.Appearance.Button;
            this.C_Increase.Location = new System.Drawing.Point(98, 14);
            this.C_Increase.Name = "C_Increase";
            this.C_Increase.Size = new System.Drawing.Size(62, 24);
            this.C_Increase.TabIndex = 0;
            this.C_Increase.Text = "Increase";
            this.C_Increase.UseVisualStyleBackColor = true;
            this.C_Increase.CheckedChanged += new System.EventHandler(this.C_Increase_CheckedChanged);
            // 
            // B_Key
            // 
            this.B_Key.Appearance = System.Windows.Forms.Appearance.Button;
            this.B_Key.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_Key.Location = new System.Drawing.Point(117, 4);
            this.B_Key.Name = "B_Key";
            this.B_Key.Size = new System.Drawing.Size(132, 24);
            this.B_Key.TabIndex = 41;
            this.B_Key.Text = "Set Key";
            this.B_Key.UseVisualStyleBackColor = true;
            this.B_Key.CheckedChanged += new System.EventHandler(this.B_Key_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.L_fov);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 41);
            this.panel1.TabIndex = 42;
            // 
            // L_fov
            // 
            this.L_fov.AutoSize = true;
            this.L_fov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_fov.Location = new System.Drawing.Point(109, 15);
            this.L_fov.Name = "L_fov";
            this.L_fov.Size = new System.Drawing.Size(47, 13);
            this.L_fov.TabIndex = 1;
            this.L_fov.Text = "#####";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Fov";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.LB_Running);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fov Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.advancedFeatures.ResumeLayout(false);
            this.advancedFeatures.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_Running;
        private System.Windows.Forms.TextBox T_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox C_AutoMode;
        private System.Windows.Forms.CheckBox C_KeyMode;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel KeyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_fov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox B_Key;
        private System.Windows.Forms.Button B_set;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.GroupBox advancedFeatures;
        private System.Windows.Forms.TextBox T_decrease;
        private System.Windows.Forms.TextBox T_Increase;
        private System.Windows.Forms.CheckBox C_Decrease;
        private System.Windows.Forms.CheckBox C_Increase;
        private System.Windows.Forms.Button B_SetIncrease;
        private System.Windows.Forms.Button B_SetDecrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

