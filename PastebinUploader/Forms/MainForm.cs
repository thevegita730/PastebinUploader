using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PastebinUploader
{
    public partial class MainForm : Form
    {
        readonly string DeveloperKey = "583429dd9faffdda390145ae727bfbef";
        KeyValuePair<bool, string> _loginResponse = new KeyValuePair<bool, string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasteTitle.Text) ||
                string.IsNullOrEmpty(txtPasteContent.Text))
            {
                MessageBox.Show("Please do not leave any fields blank!", "ERROR : Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnSubmit.Enabled = false;

                string response = string.Empty;

                using (var pastebin = new Pastebin(DeveloperKey))
                {
                    if (_loginResponse.Key)
                        response = await pastebin.CreatePaste(txtPasteTitle.Text, txtPasteContent.Text, _loginResponse.Value);
                    else
                        response = await pastebin.CreatePaste(txtPasteTitle.Text, txtPasteContent.Text);
                }

                if (!response.Contains("Bad API request"))
                {
                    var success = new SuccessForm(response);
                    success.ShowDialog();

                    txtPasteTitle.Clear();
                    txtPasteContent.Clear();
                }
                else
                {
                    MessageBox.Show(string.Format("ERROR : {0}", response), "ERROR : Bad Request",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnSubmit.Enabled = true;
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            if (string.Equals(btnExpand.Text, ">"))
            {
                btnExpand.Text = "<";
                Size = new Size(new Point(654, 350));
            }
            else
            {
                btnExpand.Text = ">";
                Size = new Size(new Point(371, 350));
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please do not leave any fields blank!", "ERROR : Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnLogin.Enabled = false;

                using (var pastebin = new Pastebin(DeveloperKey))
                    _loginResponse = await pastebin.Authenticate(txtUsername.Text, txtPassword.Text);

                if (_loginResponse.Key)
                {
                    btnExpand_Click(sender, e);
                    tsslLoginStatus.Text = string.Format("Logged in as {0}", txtUsername.Text);

                    MessageBox.Show("Login Successful!", "Login Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!_loginResponse.Key && !string.Equals(_loginResponse.Value, "Bad API request, invalid login"))
                {
                    btnLogin.Enabled = true;

                    MessageBox.Show(string.Format("ERROR : {0}", _loginResponse.Value), "Login Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnLogin.Enabled = true;

                    MessageBox.Show("Login Failed!", "Login Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
