namespace wifiApp
{
    partial class formInitialization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInitialization));
            this.mTextBoxDefaultGateway = new System.Windows.Forms.MaskedTextBox();
            this.lblWelcomeFirstRun = new System.Windows.Forms.Label();
            this.lblgetUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.toolTipUserName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDefaultGateway = new System.Windows.Forms.ToolTip(this.components);
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.bttnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTextBoxDefaultGateway
            // 
            this.mTextBoxDefaultGateway.CausesValidation = false;
            this.mTextBoxDefaultGateway.Location = new System.Drawing.Point(89, 124);
            this.mTextBoxDefaultGateway.Mask = "000.000.0.0";
            this.mTextBoxDefaultGateway.Name = "mTextBoxDefaultGateway";
            this.mTextBoxDefaultGateway.Size = new System.Drawing.Size(156, 20);
            this.mTextBoxDefaultGateway.SkipLiterals = false;
            this.mTextBoxDefaultGateway.TabIndex = 0;
            this.mTextBoxDefaultGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipDefaultGateway.SetToolTip(this.mTextBoxDefaultGateway, "Your default gateway can be found on the back of your router.");
            // 
            // lblWelcomeFirstRun
            // 
            this.lblWelcomeFirstRun.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeFirstRun.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeFirstRun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcomeFirstRun.Location = new System.Drawing.Point(39, 50);
            this.lblWelcomeFirstRun.Name = "lblWelcomeFirstRun";
            this.lblWelcomeFirstRun.Size = new System.Drawing.Size(257, 57);
            this.lblWelcomeFirstRun.TabIndex = 1;
            this.lblWelcomeFirstRun.Text = "This is your first time running this application.  Please enter your default gate" +
    "way";
            this.lblWelcomeFirstRun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblgetUserName
            // 
            this.lblgetUserName.AutoSize = true;
            this.lblgetUserName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgetUserName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblgetUserName.Location = new System.Drawing.Point(35, 161);
            this.lblgetUserName.Name = "lblgetUserName";
            this.lblgetUserName.Size = new System.Drawing.Size(264, 18);
            this.lblgetUserName.TabIndex = 4;
            this.lblgetUserName.Text = "Please create a unique username ";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.CausesValidation = false;
            this.textBoxUserName.Location = new System.Drawing.Point(89, 196);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(156, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipUserName.SetToolTip(this.textBoxUserName, "Enter a unique user name.");
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMessage.Location = new System.Drawing.Point(5, 287);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(325, 13);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Text = "The correct information must be entered to continue..";
            this.lblErrorMessage.Visible = false;
            // 
            // bttnSubmit
            // 
            this.bttnSubmit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bttnSubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bttnSubmit.Location = new System.Drawing.Point(118, 233);
            this.bttnSubmit.Name = "bttnSubmit";
            this.bttnSubmit.Padding = new System.Windows.Forms.Padding(1);
            this.bttnSubmit.Size = new System.Drawing.Size(88, 29);
            this.bttnSubmit.TabIndex = 7;
            this.bttnSubmit.Text = "Submit";
            this.bttnSubmit.UseVisualStyleBackColor = false;
            this.bttnSubmit.Click += new System.EventHandler(this.bttnSubmit_Click_1);
            // 
            // formInitialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 313);
            this.Controls.Add(this.bttnSubmit);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.lblgetUserName);
            this.Controls.Add(this.lblWelcomeFirstRun);
            this.Controls.Add(this.mTextBoxDefaultGateway);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formInitialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who\'s Stealing My Wifi?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTextBoxDefaultGateway;
        private System.Windows.Forms.Label lblWelcomeFirstRun;
        private System.Windows.Forms.Label lblgetUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ToolTip toolTipDefaultGateway;
        private System.Windows.Forms.ToolTip toolTipUserName;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button bttnSubmit;
    }
}