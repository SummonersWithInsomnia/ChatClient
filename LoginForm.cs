using System;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class LoginForm : Form
    {
        private const string UsernamePlaceholder = "Username";
        private const string PasswordPlaceholder = "Password";
        
        public LoginForm()
        {
            InitializeComponent();
            SetPlaceholder(tbUsername, UsernamePlaceholder);
            SetPlaceholder(tbPassword, PasswordPlaceholder);
            lbLoginMessage.Text = "Welcome to ChatChat!";
        }
        
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Enter += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.Leave += (sender, e) => AddPlaceholder(textBox, placeholder);
        }
        
        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            lbLoginMessage.Text = "Welcome to ChatChat!";
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
                if (textBox == tbPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }
        
        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            lbLoginMessage.Text = "Welcome to ChatChat!";
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
                if (textBox == tbPassword)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnStartChat_Click(object sender, EventArgs e)
        {
            tbUsername.Enabled = false;
            tbPassword.Enabled = false;
            btnStartChat.Enabled = false;

            if (tbUsername.Text == UsernamePlaceholder || tbPassword.Text == PasswordPlaceholder)
            {
                lbLoginMessage.Text = "Username or password cannot be empty!";
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                btnStartChat.Enabled = true;
                return;
            }
            
            lbLoginMessage.Text = "Connecting to server...";
        }
    }
}