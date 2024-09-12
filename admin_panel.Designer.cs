namespace Voting_System__SDP_
{
    partial class admin_panel
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
            this.welcome_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_register = new System.Windows.Forms.Button();
            this.previous_vote = new System.Windows.Forms.Button();
            this.registered_user = new System.Windows.Forms.Button();
            this.running_vote = new System.Windows.Forms.Button();
            this.new_vote = new System.Windows.Forms.Button();
            this.welcome_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_panel
            // 
            this.welcome_panel.Controls.Add(this.label2);
            this.welcome_panel.Controls.Add(this.label1);
            this.welcome_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcome_panel.Location = new System.Drawing.Point(0, 0);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(923, 100);
            this.welcome_panel.TabIndex = 0;
            this.welcome_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.welcome_panel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.new_register);
            this.panel1.Controls.Add(this.previous_vote);
            this.panel1.Controls.Add(this.registered_user);
            this.panel1.Controls.Add(this.running_vote);
            this.panel1.Controls.Add(this.new_vote);
            this.panel1.Location = new System.Drawing.Point(284, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 517);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // new_register
            // 
            this.new_register.Location = new System.Drawing.Point(76, 316);
            this.new_register.Name = "new_register";
            this.new_register.Size = new System.Drawing.Size(228, 71);
            this.new_register.TabIndex = 6;
            this.new_register.Text = "Register New User";
            this.new_register.UseVisualStyleBackColor = true;
            this.new_register.Click += new System.EventHandler(this.new_register_Click);
            // 
            // previous_vote
            // 
            this.previous_vote.Location = new System.Drawing.Point(76, 214);
            this.previous_vote.Name = "previous_vote";
            this.previous_vote.Size = new System.Drawing.Size(228, 69);
            this.previous_vote.TabIndex = 5;
            this.previous_vote.Text = "Previous Vote";
            this.previous_vote.UseVisualStyleBackColor = true;
            this.previous_vote.Click += new System.EventHandler(this.previous_vote_Click);
            // 
            // registered_user
            // 
            this.registered_user.Location = new System.Drawing.Point(76, 417);
            this.registered_user.Name = "registered_user";
            this.registered_user.Size = new System.Drawing.Size(228, 71);
            this.registered_user.TabIndex = 4;
            this.registered_user.Text = "See Registered Users";
            this.registered_user.UseVisualStyleBackColor = true;
            this.registered_user.Click += new System.EventHandler(this.registered_user_Click);
            // 
            // running_vote
            // 
            this.running_vote.Location = new System.Drawing.Point(76, 120);
            this.running_vote.Name = "running_vote";
            this.running_vote.Size = new System.Drawing.Size(228, 67);
            this.running_vote.TabIndex = 1;
            this.running_vote.Text = "Running Vote";
            this.running_vote.UseVisualStyleBackColor = true;
            this.running_vote.Click += new System.EventHandler(this.running_vote_Click);
            // 
            // new_vote
            // 
            this.new_vote.Location = new System.Drawing.Point(76, 25);
            this.new_vote.Name = "new_vote";
            this.new_vote.Size = new System.Drawing.Size(228, 65);
            this.new_vote.TabIndex = 0;
            this.new_vote.Text = "New Vote";
            this.new_vote.UseVisualStyleBackColor = true;
            this.new_vote.Click += new System.EventHandler(this.new_vote_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voting_System__SDP_.Properties.Resources.Registration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcome_panel);
            this.DoubleBuffered = true;
            this.Name = "admin_panel";
            this.Text = "admin_panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcome_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button running_vote;
        private System.Windows.Forms.Button new_vote;
        private System.Windows.Forms.Button registered_user;
        private System.Windows.Forms.Button previous_vote;
        private System.Windows.Forms.Button new_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}