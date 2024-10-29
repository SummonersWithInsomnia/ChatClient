using System.ComponentModel;

namespace ChatClient
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbLoginMessage = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnStartChat = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLoginMessage
            // 
            this.lbLoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginMessage.Location = new System.Drawing.Point(12, 184);
            this.lbLoginMessage.Name = "lbLoginMessage";
            this.lbLoginMessage.Size = new System.Drawing.Size(448, 34);
            this.lbLoginMessage.TabIndex = 4;
            this.lbLoginMessage.Text = "lbLoginMessage";
            this.lbLoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(448, 35);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Login / Signup";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartChat
            // 
            this.btnStartChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChat.Location = new System.Drawing.Point(171, 135);
            this.btnStartChat.Name = "btnStartChat";
            this.btnStartChat.Size = new System.Drawing.Size(130, 42);
            this.btnStartChat.TabIndex = 1;
            this.btnStartChat.Text = "Start Chat";
            this.btnStartChat.UseVisualStyleBackColor = true;
            this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbUsername.Location = new System.Drawing.Point(12, 47);
            this.tbUsername.MaxLength = 30;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ShortcutsEnabled = false;
            this.tbUsername.Size = new System.Drawing.Size(448, 38);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.WordWrap = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbPassword.Location = new System.Drawing.Point(12, 91);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ShortcutsEnabled = false;
            this.tbPassword.Size = new System.Drawing.Size(448, 38);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.WordWrap = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(472, 227);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnStartChat);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbLoginMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatChat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbPassword;

        private System.Windows.Forms.TextBox tbUsername;

        private System.Windows.Forms.Button btnStartChat;

        private System.Windows.Forms.Label lbTitle;

        private System.Windows.Forms.Label lbLoginMessage;

        #endregion
    }
}