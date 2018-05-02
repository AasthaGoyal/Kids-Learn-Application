namespace KidsLearnMath
{
    partial class FormTemplate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.learnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testMyKnowledgeToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // learnToolStripMenuItem
            // 
            this.learnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.multiplicationToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.testMyKnowledgeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.learnToolStripMenuItem.Name = "learnToolStripMenuItem";
            this.learnToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.learnToolStripMenuItem.Text = "&Learn";
            this.learnToolStripMenuItem.Click += new System.EventHandler(this.learnToolStripMenuItem_Click);
            // 
            // additionToolStripMenuItem
            // 
            this.additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            this.additionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.additionToolStripMenuItem.Text = "&Addition";
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.subtractionToolStripMenuItem.Text = "&Subtraction";
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.multiplicationToolStripMenuItem.Text = "&Multiplication";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.divisionToolStripMenuItem.Text = "&Division";
            // 
            // testMyKnowledgeToolStripMenuItem
            // 
            this.testMyKnowledgeToolStripMenuItem.Name = "testMyKnowledgeToolStripMenuItem";
            this.testMyKnowledgeToolStripMenuItem.Size = new System.Drawing.Size(174, 6);
            this.testMyKnowledgeToolStripMenuItem.Click += new System.EventHandler(this.testMyKnowledgeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Test My Knowledge";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationTitle.Location = new System.Drawing.Point(12, 40);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(417, 41);
            this.lblApplicationTitle.TabIndex = 1;
            this.lblApplicationTitle.Text = "lblApplicationTitle";
            this.lblApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 371);
            this.Controls.Add(this.lblApplicationTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem learnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator testMyKnowledgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label lblApplicationTitle;
    }
}

