﻿namespace E_Raport_SMA
{
    partial class Login
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
            label1 = new Label();
            NIPLabel = new Label();
            label3 = new Label();
            txtNIP = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 54);
            label1.TabIndex = 0;
            label1.Text = "Login to E-Raport";
            // 
            // NIPLabel
            // 
            NIPLabel.AutoSize = true;
            NIPLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            NIPLabel.Location = new Point(214, 226);
            NIPLabel.Margin = new Padding(4, 0, 4, 0);
            NIPLabel.Name = "NIPLabel";
            NIPLabel.Size = new Size(47, 25);
            NIPLabel.TabIndex = 1;
            NIPLabel.Text = "NIP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.Location = new Point(214, 297);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtNIP
            // 
            txtNIP.Font = new Font("Segoe UI", 10F);
            txtNIP.Location = new Point(356, 216);
            txtNIP.Margin = new Padding(4, 5, 4, 5);
            txtNIP.Name = "txtNIP";
            txtNIP.PlaceholderText = "Masukkan NIP";
            txtNIP.Size = new Size(210, 34);
            txtNIP.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(356, 288);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan Password";
            txtPassword.Size = new Size(210, 34);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.CausesValidation = false;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(301, 398);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(751, 595);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtNIP);
            Controls.Add(label3);
            Controls.Add(NIPLabel);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NIPLabel;
        private Label label3;
        private TextBox txtNIP;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
