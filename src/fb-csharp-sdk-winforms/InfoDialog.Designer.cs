namespace fb_csharp_sdk_winforms
{
    partial class InfoDialog
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
            this.btnProgressAndCancellation = new System.Windows.Forms.Button();
            this.lnkFacebokSdkFan = new System.Windows.Forms.LinkLabel();
            this.btnDeleteLastMessage = new System.Windows.Forms.Button();
            this.btnPostVideo = new System.Windows.Forms.Button();
            this.bntPostPicture = new System.Windows.Forms.Button();
            this.btnPostToWall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblTotalFriends = new System.Windows.Forms.Label();
            this.chkCSharpSdkFan = new System.Windows.Forms.CheckBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lnkName = new System.Windows.Forms.LinkLabel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProgressAndCancellation
            // 
            this.btnProgressAndCancellation.Location = new System.Drawing.Point(82, 341);
            this.btnProgressAndCancellation.Name = "btnProgressAndCancellation";
            this.btnProgressAndCancellation.Size = new System.Drawing.Size(178, 23);
            this.btnProgressAndCancellation.TabIndex = 29;
            this.btnProgressAndCancellation.Text = "Upload Progress and Cancellation Sample";
            this.btnProgressAndCancellation.UseVisualStyleBackColor = true;
            this.btnProgressAndCancellation.Click += new System.EventHandler(this.btnProgressAndCancellation_Click);
            // 
            // lnkFacebokSdkFan
            // 
            this.lnkFacebokSdkFan.AutoSize = true;
            this.lnkFacebokSdkFan.Location = new System.Drawing.Point(79, 175);
            this.lnkFacebokSdkFan.Name = "lnkFacebokSdkFan";
            this.lnkFacebokSdkFan.Size = new System.Drawing.Size(200, 13);
            this.lnkFacebokSdkFan.TabIndex = 28;
            this.lnkFacebokSdkFan.TabStop = true;
            this.lnkFacebokSdkFan.Text = "Like us on Facebook at our official page.";
            this.lnkFacebokSdkFan.Visible = false;
            // 
            // btnDeleteLastMessage
            // 
            this.btnDeleteLastMessage.Enabled = false;
            this.btnDeleteLastMessage.Location = new System.Drawing.Point(167, 277);
            this.btnDeleteLastMessage.Name = "btnDeleteLastMessage";
            this.btnDeleteLastMessage.Size = new System.Drawing.Size(131, 23);
            this.btnDeleteLastMessage.TabIndex = 27;
            this.btnDeleteLastMessage.Text = "Delete Last Message";
            this.btnDeleteLastMessage.UseVisualStyleBackColor = true;
            this.btnDeleteLastMessage.Click += new System.EventHandler(this.btnDeleteLastMessage_Click);
            // 
            // btnPostVideo
            // 
            this.btnPostVideo.Location = new System.Drawing.Point(167, 312);
            this.btnPostVideo.Name = "btnPostVideo";
            this.btnPostVideo.Size = new System.Drawing.Size(103, 23);
            this.btnPostVideo.TabIndex = 26;
            this.btnPostVideo.Text = "Post Video";
            this.btnPostVideo.UseVisualStyleBackColor = true;
            this.btnPostVideo.Click += new System.EventHandler(this.btnPostVideo_Click);
            // 
            // bntPostPicture
            // 
            this.bntPostPicture.Location = new System.Drawing.Point(58, 312);
            this.bntPostPicture.Name = "bntPostPicture";
            this.bntPostPicture.Size = new System.Drawing.Size(103, 23);
            this.bntPostPicture.TabIndex = 25;
            this.bntPostPicture.Text = "Post Picture";
            this.bntPostPicture.UseVisualStyleBackColor = true;
            this.bntPostPicture.Click += new System.EventHandler(this.bntPostPicture_Click);
            // 
            // btnPostToWall
            // 
            this.btnPostToWall.Location = new System.Drawing.Point(30, 277);
            this.btnPostToWall.Name = "btnPostToWall";
            this.btnPostToWall.Size = new System.Drawing.Size(131, 23);
            this.btnPostToWall.TabIndex = 24;
            this.btnPostToWall.Text = "Post To Wall";
            this.btnPostToWall.UseVisualStyleBackColor = true;
            this.btnPostToWall.Click += new System.EventHandler(this.btnPostToWall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(1, 204);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(354, 62);
            this.txtMessage.TabIndex = 22;
            // 
            // lblTotalFriends
            // 
            this.lblTotalFriends.AutoSize = true;
            this.lblTotalFriends.Location = new System.Drawing.Point(79, 128);
            this.lblTotalFriends.Name = "lblTotalFriends";
            this.lblTotalFriends.Size = new System.Drawing.Size(81, 13);
            this.lblTotalFriends.TabIndex = 21;
            this.lblTotalFriends.Text = "[lblTotalFriends]";
            // 
            // chkCSharpSdkFan
            // 
            this.chkCSharpSdkFan.AutoSize = true;
            this.chkCSharpSdkFan.Enabled = false;
            this.chkCSharpSdkFan.Location = new System.Drawing.Point(82, 155);
            this.chkCSharpSdkFan.Name = "chkCSharpSdkFan";
            this.chkCSharpSdkFan.Size = new System.Drawing.Size(280, 17);
            this.chkCSharpSdkFan.TabIndex = 20;
            this.chkCSharpSdkFan.Text = "Is fan of the official Facebok C# SDK facebook page.";
            this.chkCSharpSdkFan.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(79, 99);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 13);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "[lblLastName]";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(79, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 13);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "[lblFirstName]";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(79, 49);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(54, 13);
            this.lblUserId.TabIndex = 17;
            this.lblUserId.Text = "[lblUserId]";
            // 
            // lnkName
            // 
            this.lnkName.AutoSize = true;
            this.lnkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkName.Location = new System.Drawing.Point(78, 12);
            this.lnkName.Name = "lnkName";
            this.lnkName.Size = new System.Drawing.Size(95, 24);
            this.lnkName.TabIndex = 16;
            this.lnkName.TabStop = true;
            this.lnkName.Text = "[lnkName]";
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(12, 12);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(50, 50);
            this.picProfile.TabIndex = 15;
            this.picProfile.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(280, 44);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(361, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 355);
            this.listBox1.TabIndex = 31;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "label2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 168);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(529, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 376);
            this.panel1.TabIndex = 34;
            this.panel1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(297, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(360, 353);
            this.listBox2.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "No Folders Set";
            this.label3.Click += new System.EventHandler(this.setfolder_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(3, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Set Timer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.setTimer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Set Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.setfolder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Post Picture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Post To Wall";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.Tag = "Folder of Multiple Items";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProgressAndCancellation);
            this.Controls.Add(this.lnkFacebokSdkFan);
            this.Controls.Add(this.btnDeleteLastMessage);
            this.Controls.Add(this.btnPostVideo);
            this.Controls.Add(this.bntPostPicture);
            this.Controls.Add(this.btnPostToWall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblTotalFriends);
            this.Controls.Add(this.chkCSharpSdkFan);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lnkName);
            this.Controls.Add(this.picProfile);
            this.MaximizeBox = false;
            this.Name = "InfoDialog";
            this.Text = "Facebook C# SDK WinForms sample";
            this.Load += new System.EventHandler(this.InfoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgressAndCancellation;
        private System.Windows.Forms.LinkLabel lnkFacebokSdkFan;
        private System.Windows.Forms.Button btnDeleteLastMessage;
        private System.Windows.Forms.Button btnPostVideo;
        private System.Windows.Forms.Button bntPostPicture;
        private System.Windows.Forms.Button btnPostToWall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblTotalFriends;
        private System.Windows.Forms.CheckBox chkCSharpSdkFan;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.LinkLabel lnkName;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listBox2;

    }
}