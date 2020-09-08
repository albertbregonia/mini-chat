namespace MiniChat
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.input = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.serverLabel = new System.Windows.Forms.Label();
            this.msgInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.ListBox();
            this.attemptConnection = new System.ComponentModel.BackgroundWorker();
            this.ping = new System.ComponentModel.BackgroundWorker();
            this.serverMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.input.ForeColor = System.Drawing.Color.White;
            this.input.HideSelection = false;
            this.input.Location = new System.Drawing.Point(160, 11);
            this.input.Margin = new System.Windows.Forms.Padding(1);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(153, 23);
            this.input.TabIndex = 0;
            this.input.Text = "IP:Port";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connectBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.connectBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.connectBtn.Location = new System.Drawing.Point(612, 7);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(1);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(78, 30);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.serverLabel.ForeColor = System.Drawing.Color.White;
            this.serverLabel.Location = new System.Drawing.Point(9, 13);
            this.serverLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(149, 18);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server Address:";
            // 
            // msgInput
            // 
            this.msgInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.msgInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.msgInput.ForeColor = System.Drawing.Color.White;
            this.msgInput.Location = new System.Drawing.Point(9, 376);
            this.msgInput.Margin = new System.Windows.Forms.Padding(1);
            this.msgInput.Multiline = true;
            this.msgInput.Name = "msgInput";
            this.msgInput.Size = new System.Drawing.Size(689, 31);
            this.msgInput.TabIndex = 3;
            this.msgInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msgInput_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sendBtn.Location = new System.Drawing.Point(699, 376);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(1);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(81, 31);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disconnectBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.disconnectBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.disconnectBtn.Location = new System.Drawing.Point(692, 7);
            this.disconnectBtn.Margin = new System.Windows.Forms.Padding(1);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(89, 30);
            this.disconnectBtn.TabIndex = 5;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(153)))), ((int)(((byte)(212)))));
            this.console.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.FormattingEnabled = true;
            this.console.HorizontalScrollbar = true;
            this.console.ItemHeight = 18;
            this.console.Location = new System.Drawing.Point(9, 40);
            this.console.Margin = new System.Windows.Forms.Padding(1);
            this.console.Name = "console";
            this.console.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.console.Size = new System.Drawing.Size(773, 328);
            this.console.TabIndex = 6;
            // 
            // attemptConnection
            // 
            this.attemptConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.attemptConnection_DoWork);
            // 
            // ping
            // 
            this.ping.WorkerSupportsCancellation = true;
            this.ping.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ping_DoWork);
            // 
            // serverMode
            // 
            this.serverMode.AutoSize = true;
            this.serverMode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.serverMode.ForeColor = System.Drawing.Color.White;
            this.serverMode.Location = new System.Drawing.Point(469, 11);
            this.serverMode.Name = "serverMode";
            this.serverMode.Size = new System.Drawing.Size(139, 22);
            this.serverMode.TabIndex = 7;
            this.serverMode.Text = "Server Mode";
            this.serverMode.UseVisualStyleBackColor = true;
            this.serverMode.CheckedChanged += new System.EventHandler(this.serverMode_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(789, 416);
            this.Controls.Add(this.serverMode);
            this.Controls.Add(this.console);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgInput);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 455);
            this.MinimumSize = new System.Drawing.Size(805, 455);
            this.Name = "Main";
            this.Text = "MiniChat by Albert Bregonia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox msgInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.ListBox console;
        private System.ComponentModel.BackgroundWorker attemptConnection;
        private System.ComponentModel.BackgroundWorker ping;
        private System.Windows.Forms.CheckBox serverMode;
    }
}

