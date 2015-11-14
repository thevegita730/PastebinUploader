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
            this.btnExpand = new System.Windows.Forms.Button();
            this.gbLoginCredentials = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLoginStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbLoginCredentials.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(285, 31);
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
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(303, 250);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(40, 31);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.Text = ">";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // gbLoginCredentials
            // 
            this.gbLoginCredentials.Controls.Add(this.lblPassword);
            this.gbLoginCredentials.Controls.Add(this.lblUsername);
            this.gbLoginCredentials.Controls.Add(this.txtPassword);
            this.gbLoginCredentials.Controls.Add(this.txtUsername);
            this.gbLoginCredentials.Location = new System.Drawing.Point(358, 83);
            this.gbLoginCredentials.Name = "gbLoginCredentials";
            this.gbLoginCredentials.Size = new System.Drawing.Size(269, 80);
            this.gbLoginCredentials.TabIndex = 6;
            this.gbLoginCredentials.TabStop = false;
            this.gbLoginCredentials.Text = "Login Credentials";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(86, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(358, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(269, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslLoginStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(42, 17);
            this.tsslStatus.Text = "Status:";
            // 
            // tsslLoginStatus
            // 
            this.tsslLoginStatus.Name = "tsslLoginStatus";
            this.tsslLoginStatus.Size = new System.Drawing.Size(107, 17);
            this.tsslLoginStatus.Text = "Logged in as Guest";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbLoginCredentials);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblPasteTitle);
            this.Controls.Add(this.txtPasteContent);
            this.Controls.Add(this.txtPasteTitle);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastebin Uploader";
            this.gbLoginCredentials.ResumeLayout(false);
            this.gbLoginCredentials.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPasteTitle;
        private System.Windows.Forms.TextBox txtPasteContent;
        private System.Windows.Forms.Label lblPasteTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.GroupBox gbLoginCredentials;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslLoginStatus;
    }
}

