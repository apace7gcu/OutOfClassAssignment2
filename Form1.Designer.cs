namespace OutOfClassAssignment2
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
            this.listBoxCeleb = new System.Windows.Forms.ListBox();
            this.chckBoxBold = new System.Windows.Forms.CheckBox();
            this.chckBoxFancy = new System.Windows.Forms.CheckBox();
            this.groupBoxDesign = new System.Windows.Forms.GroupBox();
            this.groupBoxTopic = new System.Windows.Forms.GroupBox();
            this.radbttnThoughts = new System.Windows.Forms.RadioButton();
            this.radbttnCeleb = new System.Windows.Forms.RadioButton();
            this.radbttnSmoking = new System.Windows.Forms.RadioButton();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.lblQuote = new System.Windows.Forms.Label();
            this.groupBoxCelebrity = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBoxCeleb = new System.Windows.Forms.PictureBox();
            this.groupBoxDesign.SuspendLayout();
            this.groupBoxTopic.SuspendLayout();
            this.groupBoxCelebrity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCeleb)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCeleb
            // 
            this.listBoxCeleb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxCeleb.Font = new System.Drawing.Font("Gabriola", 12F);
            this.listBoxCeleb.FormattingEnabled = true;
            this.listBoxCeleb.ItemHeight = 29;
            this.listBoxCeleb.Items.AddRange(new object[] {
            "Sienna Miller",
            "Brooke Shields",
            "Justin Bieber"});
            this.listBoxCeleb.Location = new System.Drawing.Point(6, 26);
            this.listBoxCeleb.Name = "listBoxCeleb";
            this.listBoxCeleb.Size = new System.Drawing.Size(134, 91);
            this.listBoxCeleb.TabIndex = 0;
            // 
            // chckBoxBold
            // 
            this.chckBoxBold.AutoSize = true;
            this.chckBoxBold.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chckBoxBold.Location = new System.Drawing.Point(6, 29);
            this.chckBoxBold.Name = "chckBoxBold";
            this.chckBoxBold.Size = new System.Drawing.Size(125, 39);
            this.chckBoxBold.TabIndex = 1;
            this.chckBoxBold.Text = "Bold Statement";
            this.chckBoxBold.UseVisualStyleBackColor = false;
            // 
            // chckBoxFancy
            // 
            this.chckBoxFancy.AutoSize = true;
            this.chckBoxFancy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chckBoxFancy.Location = new System.Drawing.Point(6, 65);
            this.chckBoxFancy.Name = "chckBoxFancy";
            this.chckBoxFancy.Size = new System.Drawing.Size(131, 39);
            this.chckBoxFancy.TabIndex = 2;
            this.chckBoxFancy.Text = "Fancy Statement";
            this.chckBoxFancy.UseVisualStyleBackColor = false;
            // 
            // groupBoxDesign
            // 
            this.groupBoxDesign.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBoxDesign.Controls.Add(this.chckBoxBold);
            this.groupBoxDesign.Controls.Add(this.chckBoxFancy);
            this.groupBoxDesign.Font = new System.Drawing.Font("Gabriola", 14.25F);
            this.groupBoxDesign.Location = new System.Drawing.Point(634, 2);
            this.groupBoxDesign.Name = "groupBoxDesign";
            this.groupBoxDesign.Size = new System.Drawing.Size(154, 147);
            this.groupBoxDesign.TabIndex = 3;
            this.groupBoxDesign.TabStop = false;
            this.groupBoxDesign.Text = "Design:";
            // 
            // groupBoxTopic
            // 
            this.groupBoxTopic.Controls.Add(this.radbttnThoughts);
            this.groupBoxTopic.Controls.Add(this.radbttnCeleb);
            this.groupBoxTopic.Controls.Add(this.radbttnSmoking);
            this.groupBoxTopic.Font = new System.Drawing.Font("Gabriola", 14.25F);
            this.groupBoxTopic.Location = new System.Drawing.Point(473, 2);
            this.groupBoxTopic.Name = "groupBoxTopic";
            this.groupBoxTopic.Size = new System.Drawing.Size(155, 147);
            this.groupBoxTopic.TabIndex = 4;
            this.groupBoxTopic.TabStop = false;
            this.groupBoxTopic.Text = "Topic:";
            // 
            // radbttnThoughts
            // 
            this.radbttnThoughts.AutoSize = true;
            this.radbttnThoughts.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbttnThoughts.Location = new System.Drawing.Point(5, 96);
            this.radbttnThoughts.Name = "radbttnThoughts";
            this.radbttnThoughts.Size = new System.Drawing.Size(123, 39);
            this.radbttnThoughts.TabIndex = 2;
            this.radbttnThoughts.TabStop = true;
            this.radbttnThoughts.Text = "Deep Thoughts";
            this.radbttnThoughts.UseVisualStyleBackColor = false;
            // 
            // radbttnCeleb
            // 
            this.radbttnCeleb.AutoSize = true;
            this.radbttnCeleb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbttnCeleb.Location = new System.Drawing.Point(5, 64);
            this.radbttnCeleb.Name = "radbttnCeleb";
            this.radbttnCeleb.Size = new System.Drawing.Size(144, 39);
            this.radbttnCeleb.TabIndex = 1;
            this.radbttnCeleb.TabStop = true;
            this.radbttnCeleb.Text = "Celebrity Privilege ";
            this.radbttnCeleb.UseVisualStyleBackColor = false;
            // 
            // radbttnSmoking
            // 
            this.radbttnSmoking.AutoSize = true;
            this.radbttnSmoking.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radbttnSmoking.Location = new System.Drawing.Point(6, 28);
            this.radbttnSmoking.Name = "radbttnSmoking";
            this.radbttnSmoking.Size = new System.Drawing.Size(85, 39);
            this.radbttnSmoking.TabIndex = 0;
            this.radbttnSmoking.TabStop = true;
            this.radbttnSmoking.Text = "Smoking";
            this.radbttnSmoking.UseVisualStyleBackColor = false;
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnGenerate.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGenerate.ForeColor = System.Drawing.Color.Purple;
            this.bttnGenerate.Location = new System.Drawing.Point(461, 155);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(167, 62);
            this.bttnGenerate.TabIndex = 5;
            this.bttnGenerate.Text = "Generate my quote...";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuote.Location = new System.Drawing.Point(307, 247);
            this.lblQuote.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(0, 26);
            this.lblQuote.TabIndex = 6;
            // 
            // groupBoxCelebrity
            // 
            this.groupBoxCelebrity.Controls.Add(this.listBoxCeleb);
            this.groupBoxCelebrity.Font = new System.Drawing.Font("Gabriola", 14.25F);
            this.groupBoxCelebrity.Location = new System.Drawing.Point(306, 2);
            this.groupBoxCelebrity.Name = "groupBoxCelebrity";
            this.groupBoxCelebrity.Size = new System.Drawing.Size(161, 147);
            this.groupBoxCelebrity.TabIndex = 15;
            this.groupBoxCelebrity.TabStop = false;
            this.groupBoxCelebrity.Text = "Celebrity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(51, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 50);
            this.label10.TabIndex = 16;
            this.label10.Text = "Celebrity Quote Generator!";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gabriola", 14.25F);
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 35);
            this.label11.TabIndex = 17;
            this.label11.Text = "Really questionable quotes from real celebrities.";
            // 
            // pictureBoxCeleb
            // 
            this.pictureBoxCeleb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCeleb.Location = new System.Drawing.Point(59, 164);
            this.pictureBoxCeleb.Name = "pictureBoxCeleb";
            this.pictureBoxCeleb.Size = new System.Drawing.Size(212, 201);
            this.pictureBoxCeleb.TabIndex = 18;
            this.pictureBoxCeleb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCeleb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBoxCelebrity);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.bttnGenerate);
            this.Controls.Add(this.groupBoxTopic);
            this.Controls.Add(this.groupBoxDesign);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "CelebQuotes";
            this.groupBoxDesign.ResumeLayout(false);
            this.groupBoxDesign.PerformLayout();
            this.groupBoxTopic.ResumeLayout(false);
            this.groupBoxTopic.PerformLayout();
            this.groupBoxCelebrity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCeleb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCeleb;
        private System.Windows.Forms.CheckBox chckBoxBold;
        private System.Windows.Forms.CheckBox chckBoxFancy;
        private System.Windows.Forms.GroupBox groupBoxDesign;
        private System.Windows.Forms.GroupBox groupBoxTopic;
        private System.Windows.Forms.RadioButton radbttnThoughts;
        private System.Windows.Forms.RadioButton radbttnCeleb;
        private System.Windows.Forms.RadioButton radbttnSmoking;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxCelebrity;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.PictureBox pictureBoxCeleb;
    }
}

