namespace LLBB
{
    partial class display
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Textlabel = new System.Windows.Forms.Label();
            this.notetxt = new System.Windows.Forms.RichTextBox();
            this.daytxt = new System.Windows.Forms.RichTextBox();
            this.datetxt = new System.Windows.Forms.RichTextBox();
            this.notelabel = new System.Windows.Forms.Label();
            this.daylabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.Prevbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 442);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.Textlabel);
            this.panel2.Controls.Add(this.notetxt);
            this.panel2.Controls.Add(this.daytxt);
            this.panel2.Controls.Add(this.datetxt);
            this.panel2.Controls.Add(this.notelabel);
            this.panel2.Controls.Add(this.daylabel);
            this.panel2.Controls.Add(this.datelabel);
            this.panel2.Controls.Add(this.Nextbtn);
            this.panel2.Controls.Add(this.Prevbtn);
            this.panel2.Controls.Add(this.Editbtn);
            this.panel2.Controls.Add(this.Delbtn);
            this.panel2.Location = new System.Drawing.Point(19, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 356);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textlabel.ForeColor = System.Drawing.Color.Teal;
            this.Textlabel.Location = new System.Drawing.Point(139, 168);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(0, 33);
            this.Textlabel.TabIndex = 25;
            // 
            // notetxt
            // 
            this.notetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.notetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notetxt.ForeColor = System.Drawing.Color.Teal;
            this.notetxt.Location = new System.Drawing.Point(145, 183);
            this.notetxt.Name = "notetxt";
            this.notetxt.Size = new System.Drawing.Size(251, 104);
            this.notetxt.TabIndex = 35;
            this.notetxt.Text = "";
            // 
            // daytxt
            // 
            this.daytxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.daytxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daytxt.ForeColor = System.Drawing.Color.Teal;
            this.daytxt.Location = new System.Drawing.Point(156, 118);
            this.daytxt.Name = "daytxt";
            this.daytxt.Size = new System.Drawing.Size(251, 48);
            this.daytxt.TabIndex = 34;
            this.daytxt.Text = "";
            // 
            // datetxt
            // 
            this.datetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.datetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.ForeColor = System.Drawing.Color.Teal;
            this.datetxt.Location = new System.Drawing.Point(156, 49);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(251, 47);
            this.datetxt.TabIndex = 33;
            this.datetxt.Text = "";
            // 
            // notelabel
            // 
            this.notelabel.AutoSize = true;
            this.notelabel.BackColor = System.Drawing.Color.Transparent;
            this.notelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelabel.ForeColor = System.Drawing.Color.Teal;
            this.notelabel.Location = new System.Drawing.Point(76, 183);
            this.notelabel.Name = "notelabel";
            this.notelabel.Size = new System.Drawing.Size(48, 18);
            this.notelabel.TabIndex = 32;
            this.notelabel.Text = "Notes";
            // 
            // daylabel
            // 
            this.daylabel.AutoSize = true;
            this.daylabel.BackColor = System.Drawing.Color.Transparent;
            this.daylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylabel.ForeColor = System.Drawing.Color.Teal;
            this.daylabel.Location = new System.Drawing.Point(76, 118);
            this.daylabel.Name = "daylabel";
            this.daylabel.Size = new System.Drawing.Size(34, 18);
            this.daylabel.TabIndex = 31;
            this.daylabel.Text = "Day";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.Transparent;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.Color.Teal;
            this.datelabel.Location = new System.Drawing.Point(76, 49);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(39, 18);
            this.datelabel.TabIndex = 30;
            this.datelabel.Text = "Date";
            // 
            // Nextbtn
            // 
            this.Nextbtn.BackColor = System.Drawing.Color.Transparent;
            this.Nextbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbtn.Location = new System.Drawing.Point(450, 143);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(57, 47);
            this.Nextbtn.TabIndex = 2;
            this.Nextbtn.Text = ">";
            this.Nextbtn.UseVisualStyleBackColor = false;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Prevbtn
            // 
            this.Prevbtn.BackColor = System.Drawing.Color.Transparent;
            this.Prevbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prevbtn.Location = new System.Drawing.Point(0, 143);
            this.Prevbtn.Name = "Prevbtn";
            this.Prevbtn.Size = new System.Drawing.Size(57, 47);
            this.Prevbtn.TabIndex = 1;
            this.Prevbtn.Text = "<";
            this.Prevbtn.UseVisualStyleBackColor = false;
            this.Prevbtn.Click += new System.EventHandler(this.Prevbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Transparent;
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.Color.Teal;
            this.Editbtn.Location = new System.Drawing.Point(300, 293);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(138, 46);
            this.Editbtn.TabIndex = 23;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Delbtn
            // 
            this.Delbtn.BackColor = System.Drawing.Color.Transparent;
            this.Delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.ForeColor = System.Drawing.Color.Teal;
            this.Delbtn.Location = new System.Drawing.Point(145, 293);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(138, 46);
            this.Delbtn.TabIndex = 22;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = false;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(190, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Notes";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Teal;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 1);
            this.linkLabel1.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel1.Location = new System.Drawing.Point(152, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 33);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LLBB.Properties.Resources.no_idea;
            this.ClientSize = new System.Drawing.Size(640, 518);
            this.Controls.Add(this.panel1);
            this.Name = "display";
            this.Text = "display";
            this.Load += new System.EventHandler(this.display_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Textlabel;
        private System.Windows.Forms.RichTextBox notetxt;
        private System.Windows.Forms.RichTextBox daytxt;
        private System.Windows.Forms.RichTextBox datetxt;
        private System.Windows.Forms.Label notelabel;
        private System.Windows.Forms.Label daylabel;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button Prevbtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}