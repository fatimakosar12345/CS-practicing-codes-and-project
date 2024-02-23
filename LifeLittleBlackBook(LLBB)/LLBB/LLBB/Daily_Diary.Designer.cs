namespace LLBB
{
    partial class Daily_Diary
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
            this.DNotebtn = new System.Windows.Forms.Button();
            this.MemPicbtn = new System.Windows.Forms.Button();
            this.EMangbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DNotebtn
            // 
            this.DNotebtn.BackColor = System.Drawing.Color.Transparent;
            this.DNotebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNotebtn.ForeColor = System.Drawing.Color.Teal;
            this.DNotebtn.Location = new System.Drawing.Point(472, 238);
            this.DNotebtn.Name = "DNotebtn";
            this.DNotebtn.Size = new System.Drawing.Size(261, 53);
            this.DNotebtn.TabIndex = 11;
            this.DNotebtn.Text = "Daily Notes";
            this.DNotebtn.UseVisualStyleBackColor = false;
            this.DNotebtn.Click += new System.EventHandler(this.DNotebtn_Click);
            // 
            // MemPicbtn
            // 
            this.MemPicbtn.BackColor = System.Drawing.Color.Transparent;
            this.MemPicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemPicbtn.ForeColor = System.Drawing.Color.Teal;
            this.MemPicbtn.Location = new System.Drawing.Point(472, 338);
            this.MemPicbtn.Name = "MemPicbtn";
            this.MemPicbtn.Size = new System.Drawing.Size(261, 53);
            this.MemPicbtn.TabIndex = 12;
            this.MemPicbtn.Text = "Memorable Pictures ";
            this.MemPicbtn.UseVisualStyleBackColor = false;
            this.MemPicbtn.Click += new System.EventHandler(this.MemPicbtn_Click);
            // 
            // EMangbtn
            // 
            this.EMangbtn.BackColor = System.Drawing.Color.Transparent;
            this.EMangbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMangbtn.ForeColor = System.Drawing.Color.Teal;
            this.EMangbtn.Location = new System.Drawing.Point(472, 434);
            this.EMangbtn.Name = "EMangbtn";
            this.EMangbtn.Size = new System.Drawing.Size(261, 53);
            this.EMangbtn.TabIndex = 13;
            this.EMangbtn.Text = "Events Management";
            this.EMangbtn.UseVisualStyleBackColor = false;
            this.EMangbtn.Click += new System.EventHandler(this.EMangbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(512, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Daily Dairy";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Teal;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 1);
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(474, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 33);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Transparent;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.LinkColor = System.Drawing.Color.Teal;
            this.link.Location = new System.Drawing.Point(680, 23);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(104, 16);
            this.link.TabIndex = 23;
            this.link.TabStop = true;
            this.link.Text = "Back to Home";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // Daily_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LLBB.Properties.Resources.ohh;
            this.ClientSize = new System.Drawing.Size(796, 576);
            this.Controls.Add(this.link);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DNotebtn);
            this.Controls.Add(this.MemPicbtn);
            this.Controls.Add(this.EMangbtn);
            this.Name = "Daily_Diary";
            this.Text = "Daily_Diary";
            this.Load += new System.EventHandler(this.Daily_Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DNotebtn;
        private System.Windows.Forms.Button MemPicbtn;
        private System.Windows.Forms.Button EMangbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel link;
    }
}