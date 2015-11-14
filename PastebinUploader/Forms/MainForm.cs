using System;
using System.Windows.Forms;

namespace PastebinUploader
{
    public partial class MainForm : Form
    {
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

                Pastebin pastebin = new Pastebin("583429dd9faffdda390145ae727bfbef");
                string response = await pastebin.CreatePaste(txtPasteTitle.Text, txtPasteContent.Text);

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
    }
}
