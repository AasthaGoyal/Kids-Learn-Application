namespace KidsLearnMath
{
    partial class FrontMainForm
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
            this.kidsLearnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainApplicationTitle = new System.Windows.Forms.Label();
            this.btmMaths = new System.Windows.Forms.Button();
            this.btmEnglish = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kidsLearnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kidsLearnToolStripMenuItem
            // 
            this.kidsLearnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathsToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.kidsLearnToolStripMenuItem.Name = "kidsLearnToolStripMenuItem";
            this.kidsLearnToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.kidsLearnToolStripMenuItem.Text = "Kids Learn";
            // 
            // mathsToolStripMenuItem
            // 
            this.mathsToolStripMenuItem.Name = "mathsToolStripMenuItem";
            this.mathsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mathsToolStripMenuItem.Text = "&Maths";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "&English";
            // 
            // lblMainApplicationTitle
            // 
            this.lblMainApplicationTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMainApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainApplicationTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMainApplicationTitle.Location = new System.Drawing.Point(12, 41);
            this.lblMainApplicationTitle.Name = "lblMainApplicationTitle";
            this.lblMainApplicationTitle.Size = new System.Drawing.Size(417, 41);
            this.lblMainApplicationTitle.TabIndex = 2;
            this.lblMainApplicationTitle.Text = "Kids Learn ";
            this.lblMainApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMainApplicationTitle.Click += new System.EventHandler(this.lblMainApplicationTitle_Click);
            // 
            // btmMaths
            // 
            this.btmMaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btmMaths.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMaths.ForeColor = System.Drawing.Color.Maroon;
            this.btmMaths.Location = new System.Drawing.Point(16, 111);
            this.btmMaths.Name = "btmMaths";
            this.btmMaths.Size = new System.Drawing.Size(413, 90);
            this.btmMaths.TabIndex = 3;
            this.btmMaths.Text = "MATHS";
            this.btmMaths.UseVisualStyleBackColor = false;
            this.btmMaths.Click += new System.EventHandler(this.btmMaths_Click);
            // 
            // btmEnglish
            // 
            this.btmEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btmEnglish.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEnglish.ForeColor = System.Drawing.Color.Maroon;
            this.btmEnglish.Location = new System.Drawing.Point(16, 217);
            this.btmEnglish.Name = "btmEnglish";
            this.btmEnglish.Size = new System.Drawing.Size(413, 90);
            this.btmEnglish.TabIndex = 4;
            this.btmEnglish.Text = "ENGLISH";
            this.btmEnglish.UseVisualStyleBackColor = false;
            this.btmEnglish.Click += new System.EventHandler(this.btmEnglish_Click);
            // 
            // FrontMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 342);
            this.Controls.Add(this.btmEnglish);
            this.Controls.Add(this.btmMaths);
            this.Controls.Add(this.lblMainApplicationTitle);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrontMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kidsLearnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label lblMainApplicationTitle;
        private System.Windows.Forms.Button btmMaths;
        private System.Windows.Forms.Button btmEnglish;
    }
}