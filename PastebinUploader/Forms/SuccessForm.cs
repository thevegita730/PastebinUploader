using System;
using System.Windows.Forms;

namespace PastebinUploader
{
    public partial class SuccessForm : Form
    {
        public SuccessForm(string pastebinLink)
        {
            InitializeComponent();
            txtPastebinLink.Text = pastebinLink;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPastebinLink.Text);
            Close();
        }
    }
}
