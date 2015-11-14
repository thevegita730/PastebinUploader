namespace PastebinUploader
{
    partial class MainForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPasteTitle = new System.Windows.Forms.TextBox();
            this.txtPasteContent = new System.Windows.Forms.TextBox();
            this.lblPasteTitle = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(331, 31);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPasteTitle
            // 
            this.txtPasteTitle.Location = new System.Drawing.Point(12, 28);
            this.txtPasteTitle.Name = "txtPasteTitle";
            this.txtPasteTitle.Size = new System.Drawing.Size(331, 23);
            this.txtPasteTitle.TabIndex = 1;
            // 
            // txtPasteContent
            // 
            this.txtPasteContent.Location = new System.Drawing.Point(12, 73);
            this.txtPasteContent.Multiline = true;
            this.txtPasteContent.Name = "txtPasteContent";
            this.txtPasteContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPasteContent.Size = new System.Drawing.Size(331, 171);
            this.txtPasteContent.TabIndex = 2;
            // 
            // lblPasteTitle
            // 
            this.lblPasteTitle.AutoSize = true;
            this.lblPasteTitle.Location = new System.Drawing.Point(12, 9);
            this.lblPasteTitle.Name = "lblPasteTitle";
            this.lblPasteTitle.Size = new System.Drawing.Size(85, 16);
            this.lblPasteTitle.TabIndex = 3;
            this.lblPasteTitle.Text = "Paste Title:";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(12, 54);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(67, 16);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Content:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 293);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblPasteTitle);
            this.Controls.Add(this.txtPasteContent);
            this.Controls.Add(this.txtPasteTitle);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastebin Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPasteTitle;
        private System.Windows.Forms.TextBox txtPasteContent;
        private System.Windows.Forms.Label lblPasteTitle;
        private System.Windows.Forms.Label lblContent;
    }
}

