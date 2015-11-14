namespace PastebinUploader
{
    partial class SuccessForm
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
            this.lblPastebinLink = new System.Windows.Forms.Label();
            this.txtPastebinLink = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPastebinLink
            // 
            this.lblPastebinLink.AutoSize = true;
            this.lblPastebinLink.Location = new System.Drawing.Point(12, 9);
            this.lblPastebinLink.Name = "lblPastebinLink";
            this.lblPastebinLink.Size = new System.Drawing.Size(100, 16);
            this.lblPastebinLink.TabIndex = 0;
            this.lblPastebinLink.Text = "Pastebin Link:";
            // 
            // txtPastebinLink
            // 
            this.txtPastebinLink.Location = new System.Drawing.Point(15, 28);
            this.txtPastebinLink.Name = "txtPastebinLink";
            this.txtPastebinLink.ReadOnly = true;
            this.txtPastebinLink.Size = new System.Drawing.Size(283, 23);
            this.txtPastebinLink.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(304, 28);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(63, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 63);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtPastebinLink);
            this.Controls.Add(this.lblPastebinLink);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paste Uploaded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPastebinLink;
        private System.Windows.Forms.TextBox txtPastebinLink;
        private System.Windows.Forms.Button btnCopy;
    }
}