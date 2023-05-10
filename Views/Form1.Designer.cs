namespace Qu_Te
{
    partial class formMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainMenu));
            panelSidebar = new Panel();
            btnExit = new Button();
            btnSaveAs = new Button();
            btnSave = new Button();
            btnCreate = new Button();
            btnOpen = new Button();
            panelLogo = new Panel();
            txtServerName = new TextBox();
            txtDatabaseName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtParameters = new TextBox();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(78, 17, 168);
            panelSidebar.Controls.Add(btnExit);
            panelSidebar.Controls.Add(btnSaveAs);
            panelSidebar.Controls.Add(btnSave);
            panelSidebar.Controls.Add(btnCreate);
            panelSidebar.Controls.Add(btnOpen);
            panelSidebar.Controls.Add(panelLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 500);
            panelSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 12, 245);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(222, 194, 11);
            btnExit.Location = new Point(0, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Dock = DockStyle.Top;
            btnSaveAs.FlatAppearance.BorderSize = 0;
            btnSaveAs.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 12, 245);
            btnSaveAs.FlatStyle = FlatStyle.Flat;
            btnSaveAs.ForeColor = Color.FromArgb(222, 194, 11);
            btnSaveAs.Location = new Point(0, 340);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(200, 36);
            btnSaveAs.TabIndex = 4;
            btnSaveAs.Text = "Save As";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Top;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 12, 245);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(222, 194, 11);
            btnSave.Location = new Point(0, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCreate
            // 
            btnCreate.Dock = DockStyle.Top;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 12, 245);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.FromArgb(222, 194, 11);
            btnCreate.Location = new Point(0, 268);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(200, 36);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnOpen
            // 
            btnOpen.Dock = DockStyle.Top;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 12, 245);
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.ForeColor = Color.FromArgb(222, 194, 11);
            btnOpen.Location = new Point(0, 232);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(200, 36);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 232);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panel1_Paint;
            // 
            // txtServerName
            // 
            txtServerName.BackColor = Color.FromArgb(201, 105, 202);
            txtServerName.ForeColor = Color.FromArgb(222, 194, 11);
            txtServerName.Location = new Point(244, 240);
            txtServerName.Name = "txtServerName";
            txtServerName.PlaceholderText = "My Server Name";
            txtServerName.Size = new Size(201, 23);
            txtServerName.TabIndex = 1;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.BackColor = Color.FromArgb(201, 105, 202);
            txtDatabaseName.ForeColor = Color.FromArgb(222, 194, 11);
            txtDatabaseName.Location = new Point(244, 291);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.PlaceholderText = "My Database Name";
            txtDatabaseName.Size = new Size(201, 23);
            txtDatabaseName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(201, 105, 202);
            txtUsername.ForeColor = Color.FromArgb(222, 194, 11);
            txtUsername.Location = new Point(244, 340);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "My Username";
            txtUsername.Size = new Size(201, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(201, 105, 202);
            txtPassword.ForeColor = Color.FromArgb(222, 194, 11);
            txtPassword.Location = new Point(244, 384);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "My Password";
            txtPassword.Size = new Size(201, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtParameters
            // 
            txtParameters.BackColor = Color.FromArgb(201, 105, 202);
            txtParameters.ForeColor = Color.FromArgb(222, 194, 11);
            txtParameters.Location = new Point(505, 240);
            txtParameters.Multiline = true;
            txtParameters.Name = "txtParameters";
            txtParameters.PlaceholderText = "Parameters:";
            txtParameters.Size = new Size(208, 167);
            txtParameters.TabIndex = 5;
            // 
            // formMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(201, 105, 202);
            ClientSize = new Size(750, 500);
            Controls.Add(txtParameters);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDatabaseName);
            Controls.Add(txtServerName);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(750, 500);
            Name = "formMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelLogo;
        private Button btnExit;
        private Button btnSaveAs;
        private Button btnSave;
        private Button btnCreate;
        private Button btnOpen;
        private TextBox txtServerName;
        private TextBox txtDatabaseName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtParameters;
    }
}