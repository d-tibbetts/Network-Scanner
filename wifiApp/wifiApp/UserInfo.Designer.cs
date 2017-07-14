namespace wifiApp
{
    partial class formUserInformation
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
            this.mTextBoxChangeGateway = new System.Windows.Forms.MaskedTextBox();
            this.lblGateway = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.lbluserName = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTextBoxChangeGateway
            // 
            this.mTextBoxChangeGateway.CausesValidation = false;
            this.mTextBoxChangeGateway.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTextBoxChangeGateway.Location = new System.Drawing.Point(165, 22);
            this.mTextBoxChangeGateway.Mask = "000.000.0.0";
            this.mTextBoxChangeGateway.Name = "mTextBoxChangeGateway";
            this.mTextBoxChangeGateway.Size = new System.Drawing.Size(156, 20);
            this.mTextBoxChangeGateway.SkipLiterals = false;
            this.mTextBoxChangeGateway.TabIndex = 1;
            this.mTextBoxChangeGateway.Text = global::wifiApp.Properties.Settings.Default.defaultGateway;
            this.mTextBoxChangeGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGateway
            // 
            this.lblGateway.AutoSize = true;
            this.lblGateway.BackColor = System.Drawing.Color.Transparent;
            this.lblGateway.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateway.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGateway.Location = new System.Drawing.Point(29, 21);
            this.lblGateway.Name = "lblGateway";
            this.lblGateway.Size = new System.Drawing.Size(136, 18);
            this.lblGateway.TabIndex = 2;
            this.lblGateway.Text = "Default Gateway:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(165, 73);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(156, 20);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.Text = global::wifiApp.Properties.Settings.Default.userName;
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.BackColor = System.Drawing.Color.Transparent;
            this.lbluserName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbluserName.Location = new System.Drawing.Point(71, 75);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(88, 18);
            this.lbluserName.TabIndex = 4;
            this.lbluserName.Text = "User Name:";
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonChange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonChange.Location = new System.Drawing.Point(138, 124);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Padding = new System.Windows.Forms.Padding(1);
            this.buttonChange.Size = new System.Drawing.Size(88, 29);
            this.buttonChange.TabIndex = 6;
            this.buttonChange.Text = "Update";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click_1);
            // 
            // formUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(351, 175);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.lblGateway);
            this.Controls.Add(this.mTextBoxChangeGateway);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = global::wifiApp.Properties.Resources.Wifi_Transparent;
            this.Name = "formUserInformation";
            this.Text = "Who\'s Stealing My Wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTextBoxChangeGateway;
        private System.Windows.Forms.Label lblGateway;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Button buttonChange;
    }
}