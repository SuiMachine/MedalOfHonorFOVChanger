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
            this.B_Key = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.L_fov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeveloperButton = new System.Windows.Forms.PictureBox();
            this.InputPanel.SuspendLayout();
            this.KeyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).BeginInit();
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
            this.InputPanel.Controls.Add(this.DeveloperButton);
            this.InputPanel.Controls.Add(this.linkLabel);
            this.InputPanel.Controls.Add(this.B_set);
            this.InputPanel.Controls.Add(this.KeyPanel);
            this.InputPanel.Controls.Add(this.label1);
            this.InputPanel.Controls.Add(this.T_Input);
            this.InputPanel.Controls.Add(this.C_AutoMode);
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPanel.Location = new System.Drawing.Point(0, 67);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(302, 168);
            this.InputPanel.TabIndex = 41;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(20, 137);
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
            this.KeyPanel.Controls.Add(this.B_Key);
            this.KeyPanel.Controls.Add(this.C_KeyMode);
            this.KeyPanel.Location = new System.Drawing.Point(11, 90);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(278, 37);
            this.KeyPanel.TabIndex = 41;
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
            this.panel1.Size = new System.Drawing.Size(302, 43);
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
            // DeveloperButton
            // 
            this.DeveloperButton.Image = global::FovChanger.Properties.Resources.donatebutton;
            this.DeveloperButton.Location = new System.Drawing.Point(156, 133);
            this.DeveloperButton.Name = "DeveloperButton";
            this.DeveloperButton.Size = new System.Drawing.Size(74, 21);
            this.DeveloperButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DeveloperButton.TabIndex = 44;
            this.DeveloperButton.TabStop = false;
            this.DeveloperButton.Click += new System.EventHandler(this.DeveloperButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 235);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeveloperButton)).EndInit();
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
        private System.Windows.Forms.PictureBox DeveloperButton;
    }
}

