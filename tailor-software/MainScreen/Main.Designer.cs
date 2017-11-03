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
            this.loginFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.loginFlowLayoutPanel.SuspendLayout();
            this.loginFieldsContainerPanel.SuspendLayout();
            this.loginLinksContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.AutoSize = true;
            this.mainContainer.Controls.Add(this.loginFlowLayoutPanel);
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(970, 569);
            this.mainContainer.TabIndex = 0;
            this.mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MainContainer_Paint);
            // 
            // loginFlowLayoutPanel
            // 
            this.loginFlowLayoutPanel.AutoSize = true;
            this.loginFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginFlowLayoutPanel.Controls.Add(this.loginFieldsContainerPanel);
            this.loginFlowLayoutPanel.Controls.Add(this.loginLinksContainerPanel);
            this.loginFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.loginFlowLayoutPanel.Location = new System.Drawing.Point(276, 128);
            this.loginFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginFlowLayoutPanel.MaximumSize = new System.Drawing.Size(417, 313);
            this.loginFlowLayoutPanel.MinimumSize = new System.Drawing.Size(417, 313);
            this.loginFlowLayoutPanel.Name = "loginFlowLayoutPanel";
            this.loginFlowLayoutPanel.Size = new System.Drawing.Size(417, 313);
            this.loginFlowLayoutPanel.TabIndex = 0;
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
            this.loginHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.loginHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginHeaderLabel.MaximumSize = new System.Drawing.Size(419, 25);
            this.loginHeaderLabel.MinimumSize = new System.Drawing.Size(419, 25);
            this.loginHeaderLabel.Name = "loginHeaderLabel";
            this.loginHeaderLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.loginHeaderLabel.Size = new System.Drawing.Size(419, 25);
            this.loginHeaderLabel.TabIndex = 0;
            this.loginHeaderLabel.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(200, 167);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(88, 34);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordTextBox.Location = new System.Drawing.Point(144, 118);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(222, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(144, 56);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(222, 22);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(24, 59);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(24, 35, 0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(77, 16);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(24, 121);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(24, 35, 0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
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
            this.resetPasswordLink.Location = new System.Drawing.Point(178, 21);
            this.resetPasswordLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.forgotPasswordLink.Location = new System.Drawing.Point(178, 55);
            this.forgotPasswordLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ClientSize = new System.Drawing.Size(970, 568);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tailor Software";
            this.TopMost = true;
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.loginFlowLayoutPanel.ResumeLayout(false);
            this.loginFieldsContainerPanel.ResumeLayout(false);
            this.loginFieldsContainerPanel.PerformLayout();
            this.loginLinksContainerPanel.ResumeLayout(false);
            this.loginLinksContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel loginFlowLayoutPanel;
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