namespace tailor_software.Login
{
    partial class LoginForm
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
            this.loginHeaderLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.resetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginFieldsContainerPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loginLinksContainerPanel = new System.Windows.Forms.Panel();
            this.loginFieldsContainerPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.loginLinksContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginHeaderLabel
            // 
            this.loginHeaderLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginHeaderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.loginHeaderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginHeaderLabel.MaximumSize = new System.Drawing.Size(360, 22);
            this.loginHeaderLabel.MinimumSize = new System.Drawing.Size(360, 22);
            this.loginHeaderLabel.Name = "loginHeaderLabel";
            this.loginHeaderLabel.Padding = new System.Windows.Forms.Padding(1);
            this.loginHeaderLabel.Size = new System.Drawing.Size(360, 22);
            this.loginHeaderLabel.TabIndex = 0;
            this.loginHeaderLabel.Text = "Login";
            this.loginHeaderLabel.Click += new System.EventHandler(this.loginHeaderLabel_Click);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLink.Location = new System.Drawing.Point(152, 48);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(106, 15);
            this.forgotPasswordLink.TabIndex = 4;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forget Password?";
            this.forgotPasswordLink.Click += new System.EventHandler(this.forgotPasswordLink_Click);
            // 
            // resetPasswordLink
            // 
            this.resetPasswordLink.AutoSize = true;
            this.resetPasswordLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordLink.Location = new System.Drawing.Point(152, 18);
            this.resetPasswordLink.Name = "resetPasswordLink";
            this.resetPasswordLink.Size = new System.Drawing.Size(96, 15);
            this.resetPasswordLink.TabIndex = 5;
            this.resetPasswordLink.TabStop = true;
            this.resetPasswordLink.Text = "Reset Password";
            this.resetPasswordLink.Click += new System.EventHandler(this.resetPasswordLink_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(20, 105);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 15);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(20, 50);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(20, 30, 0, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(70, 15);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(124, 49);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordTextBox.Location = new System.Drawing.Point(124, 102);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(191, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(172, 145);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 29);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            this.loginFieldsContainerPanel.MaximumSize = new System.Drawing.Size(357, 208);
            this.loginFieldsContainerPanel.MinimumSize = new System.Drawing.Size(357, 208);
            this.loginFieldsContainerPanel.Name = "loginFieldsContainerPanel";
            this.loginFieldsContainerPanel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.loginFieldsContainerPanel.Size = new System.Drawing.Size(357, 208);
            this.loginFieldsContainerPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.loginFieldsContainerPanel);
            this.flowLayoutPanel1.Controls.Add(this.loginLinksContainerPanel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(237, 88);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(358, 271);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(358, 271);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 271);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // loginLinksContainerPanel
            // 
            this.loginLinksContainerPanel.Controls.Add(this.resetPasswordLink);
            this.loginLinksContainerPanel.Controls.Add(this.forgotPasswordLink);
            this.loginLinksContainerPanel.Location = new System.Drawing.Point(0, 208);
            this.loginLinksContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginLinksContainerPanel.Name = "loginLinksContainerPanel";
            this.loginLinksContainerPanel.Size = new System.Drawing.Size(357, 63);
            this.loginLinksContainerPanel.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 492);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 531);
            this.MinimumSize = new System.Drawing.Size(848, 531);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tailor Software";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginFieldsContainerPanel.ResumeLayout(false);
            this.loginFieldsContainerPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.loginLinksContainerPanel.ResumeLayout(false);
            this.loginLinksContainerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label loginHeaderLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.LinkLabel resetPasswordLink;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel loginFieldsContainerPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel loginLinksContainerPanel;
    }
}

