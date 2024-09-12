namespace Voting_System__SDP_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_hide_button = new System.Windows.Forms.Button();
            this.login_button1 = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.User_Name_label1 = new System.Windows.Forms.Label();
            this.Login_Level_1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.password_hide_button);
            this.panel1.Controls.Add(this.login_button1);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.username_textbox);
            this.panel1.Controls.Add(this.User_Name_label1);
            this.panel1.Controls.Add(this.Login_Level_1);
            this.panel1.Location = new System.Drawing.Point(147, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 355);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // password_hide_button
            // 
            this.password_hide_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password_hide_button.BackgroundImage = global::Voting_System__SDP_.Properties.Resources.Untitled_design__3_;
            this.password_hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.password_hide_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password_hide_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_hide_button.Location = new System.Drawing.Point(256, 222);
            this.password_hide_button.Name = "password_hide_button";
            this.password_hide_button.Size = new System.Drawing.Size(28, 23);
            this.password_hide_button.TabIndex = 7;
            this.password_hide_button.UseVisualStyleBackColor = true;
            this.password_hide_button.Click += new System.EventHandler(this.password_hide_button_Click);
            // 
            // login_button1
            // 
            this.login_button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button1.BackColor = System.Drawing.Color.Cyan;
            this.login_button1.Location = new System.Drawing.Point(108, 267);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(119, 48);
            this.login_button1.TabIndex = 5;
            this.login_button1.Text = "Log In";
            this.login_button1.UseVisualStyleBackColor = false;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_textbox.Location = new System.Drawing.Point(20, 222);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.ShortcutsEnabled = false;
            this.password_textbox.Size = new System.Drawing.Size(264, 22);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(15, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // username_textbox
            // 
            this.username_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textbox.Location = new System.Drawing.Point(20, 142);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(264, 22);
            this.username_textbox.TabIndex = 2;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // User_Name_label1
            // 
            this.User_Name_label1.AutoSize = true;
            this.User_Name_label1.BackColor = System.Drawing.Color.Transparent;
            this.User_Name_label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_label1.ForeColor = System.Drawing.Color.Cyan;
            this.User_Name_label1.Location = new System.Drawing.Point(15, 112);
            this.User_Name_label1.Name = "User_Name_label1";
            this.User_Name_label1.Size = new System.Drawing.Size(72, 27);
            this.User_Name_label1.TabIndex = 1;
            this.User_Name_label1.Text = "Email";
            // 
            // Login_Level_1
            // 
            this.Login_Level_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_Level_1.AutoSize = true;
            this.Login_Level_1.BackColor = System.Drawing.Color.Transparent;
            this.Login_Level_1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Level_1.ForeColor = System.Drawing.Color.Cyan;
            this.Login_Level_1.Location = new System.Drawing.Point(100, 40);
            this.Login_Level_1.Name = "Login_Level_1";
            this.Login_Level_1.Size = new System.Drawing.Size(150, 48);
            this.Login_Level_1.TabIndex = 0;
            this.Login_Level_1.Text = "Log In";
            this.Login_Level_1.Click += new System.EventHandler(this.Login_Level_1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.login_button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voting_System__SDP_.Properties.Resources.AdobeStock_801896095_Preview1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 545);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_Level_1;
        private System.Windows.Forms.Label User_Name_label1;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button password_hide_button;
    }
}

