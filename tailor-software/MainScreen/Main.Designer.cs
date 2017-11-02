namespace tailor_software.MainScreen
{
    partial class Main
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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loginFieldsContainerPanel = new System.Windows.Forms.Panel();
            this.loginHeaderLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLinksContainerPanel = new System.Windows.Forms.Panel();
            this.resetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.mainContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.loginFieldsContainerPanel.SuspendLayout();
            this.loginLinksContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.flowLayoutPanel1);
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.MaximumSize = new System.Drawing.Size(971, 569);
            this.mainContainer.MinimumSize = new System.Drawing.Size(971, 569);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(971, 569);
            this.mainContainer.TabIndex = 1;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MainContainer_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.loginFieldsContainerPanel);
            this.flowLayoutPanel1.Controls.Add(this.loginLinksContainerPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 128);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(418, 313);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(418, 313);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 313);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // loginFieldsContainerPanel
            // 
            this.loginFieldsContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginFieldsContainerPanel.Controls.Add(this.loginHeaderLabel);
            this.loginFieldsContainerPanel.Controls.Add(this.loginButton);
            this.loginFieldsContainerPanel.Controls.Add(this.passwordTextBox);
            this.loginFieldsContainerPanel.Controls.Add(this.userNameTextBox);
            this.loginFieldsContainerPanel.Controls.Add(this.userNameLabel);
            this.loginFieldsContainerPanel.Controls.Add(this.passwordLabel);
            this.loginFieldsContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFieldsContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginFieldsContainerPanel.MaximumSize = new System.Drawing.Size(416, 240);
            this.loginFieldsContainerPanel.MinimumSize = new System.Drawing.Size(416, 240);
            this.loginFieldsContainerPanel.Name = "loginFieldsContainerPanel";
            this.loginFieldsContainerPanel.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.loginFieldsContainerPanel.Size = new System.Drawing.Size(416, 240);
            this.loginFieldsContainerPanel.TabIndex = 0;
            // 
            // loginHeaderLabel
            // 
            this.loginHeaderLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.loginHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginHeaderLabel.MaximumSize = new System.Drawing.Size(420, 25);
            this.loginHeaderLabel.MinimumSize = new System.Drawing.Size(420, 25);
            this.loginHeaderLabel.Name = "loginHeaderLabel";
            this.loginHeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            this.loginHeaderLabel.Size = new System.Drawing.Size(420, 25);
            this.loginHeaderLabel.TabIndex = 0;
            this.loginHeaderLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(201, 167);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(87, 33);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordTextBox.Location = new System.Drawing.Point(145, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 21);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(145, 57);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(222, 21);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(23, 58);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(23, 35, 0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(70, 15);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(23, 121);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(23, 35, 0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // loginLinksContainerPanel
            // 
            this.loginLinksContainerPanel.Controls.Add(this.resetPasswordLink);
            this.loginLinksContainerPanel.Controls.Add(this.forgotPasswordLink);
            this.loginLinksContainerPanel.Location = new System.Drawing.Point(0, 240);
            this.loginLinksContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginLinksContainerPanel.Name = "loginLinksContainerPanel";
            this.loginLinksContainerPanel.Size = new System.Drawing.Size(416, 73);
            this.loginLinksContainerPanel.TabIndex = 0;
            // 
            // resetPasswordLink
            // 
            this.resetPasswordLink.AutoSize = true;
            this.resetPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordLink.Location = new System.Drawing.Point(177, 21);
            this.resetPasswordLink.Name = "resetPasswordLink";
            this.resetPasswordLink.Size = new System.Drawing.Size(96, 15);
            this.resetPasswordLink.TabIndex = 5;
            this.resetPasswordLink.TabStop = true;
            this.resetPasswordLink.Text = "Reset Password";
            this.resetPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPasswordLink_LinkClicked);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.Location = new System.Drawing.Point(177, 55);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(106, 15);
            this.forgotPasswordLink.TabIndex = 4;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forget Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 568);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(987, 607);
            this.MinimumSize = new System.Drawing.Size(987, 607);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Tailor Software";
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.loginFieldsContainerPanel.ResumeLayout(false);
            this.loginFieldsContainerPanel.PerformLayout();
            this.loginLinksContainerPanel.ResumeLayout(false);
            this.loginLinksContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel loginFieldsContainerPanel;
        private System.Windows.Forms.Label loginHeaderLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel loginLinksContainerPanel;
        private System.Windows.Forms.LinkLabel resetPasswordLink;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
    }
}