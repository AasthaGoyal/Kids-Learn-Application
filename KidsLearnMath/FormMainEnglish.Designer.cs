namespace KidsLearnMath
{
    partial class FormMainEnglish
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmExit = new System.Windows.Forms.Button();
            this.btmChallenge = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmSports = new System.Windows.Forms.Button();
            this.btmColours = new System.Windows.Forms.Button();
            this.btmVegetables = new System.Windows.Forms.Button();
            this.btmFruits = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btmExit);
            this.groupBox2.Controls.Add(this.btmChallenge);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 126);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Functions";
            // 
            // btmExit
            // 
            this.btmExit.BackColor = System.Drawing.Color.Sienna;
            this.btmExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmExit.ForeColor = System.Drawing.Color.Black;
            this.btmExit.Location = new System.Drawing.Point(6, 69);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(386, 42);
            this.btmExit.TabIndex = 5;
            this.btmExit.Text = "Exit";
            this.btmExit.UseVisualStyleBackColor = false;
            // 
            // btmChallenge
            // 
            this.btmChallenge.BackColor = System.Drawing.Color.Sienna;
            this.btmChallenge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmChallenge.ForeColor = System.Drawing.Color.Black;
            this.btmChallenge.Location = new System.Drawing.Point(6, 21);
            this.btmChallenge.Name = "btmChallenge";
            this.btmChallenge.Size = new System.Drawing.Size(386, 42);
            this.btmChallenge.TabIndex = 4;
            this.btmChallenge.Text = "Challenges";
            this.btmChallenge.UseVisualStyleBackColor = false;
            this.btmChallenge.Click += new System.EventHandler(this.btmChallenge_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmSports);
            this.groupBox1.Controls.Add(this.btmColours);
            this.groupBox1.Controls.Add(this.btmVegetables);
            this.groupBox1.Controls.Add(this.btmFruits);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learn Names Of";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btmSports
            // 
            this.btmSports.BackColor = System.Drawing.Color.Brown;
            this.btmSports.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSports.ForeColor = System.Drawing.Color.Black;
            this.btmSports.Location = new System.Drawing.Point(6, 182);
            this.btmSports.Name = "btmSports";
            this.btmSports.Size = new System.Drawing.Size(386, 42);
            this.btmSports.TabIndex = 3;
            this.btmSports.Text = "&Sports";
            this.btmSports.UseVisualStyleBackColor = false;
            this.btmSports.Click += new System.EventHandler(this.btmSports_Click);
            // 
            // btmColours
            // 
            this.btmColours.BackColor = System.Drawing.Color.Brown;
            this.btmColours.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmColours.ForeColor = System.Drawing.Color.Black;
            this.btmColours.Location = new System.Drawing.Point(6, 134);
            this.btmColours.Name = "btmColours";
            this.btmColours.Size = new System.Drawing.Size(386, 42);
            this.btmColours.TabIndex = 2;
            this.btmColours.Text = "&Colours";
            this.btmColours.UseVisualStyleBackColor = false;
            this.btmColours.Click += new System.EventHandler(this.btmColours_Click);
            // 
            // btmVegetables
            // 
            this.btmVegetables.BackColor = System.Drawing.Color.Brown;
            this.btmVegetables.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVegetables.ForeColor = System.Drawing.Color.Black;
            this.btmVegetables.Location = new System.Drawing.Point(6, 86);
            this.btmVegetables.Name = "btmVegetables";
            this.btmVegetables.Size = new System.Drawing.Size(386, 42);
            this.btmVegetables.TabIndex = 1;
            this.btmVegetables.Text = "&Vegetables";
            this.btmVegetables.UseVisualStyleBackColor = false;
            this.btmVegetables.Click += new System.EventHandler(this.btmVegetables_Click);
            // 
            // btmFruits
            // 
            this.btmFruits.BackColor = System.Drawing.Color.Brown;
            this.btmFruits.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmFruits.ForeColor = System.Drawing.Color.Black;
            this.btmFruits.Location = new System.Drawing.Point(6, 38);
            this.btmFruits.Name = "btmFruits";
            this.btmFruits.Size = new System.Drawing.Size(386, 42);
            this.btmFruits.TabIndex = 0;
            this.btmFruits.Text = "&Fruits";
            this.btmFruits.UseVisualStyleBackColor = false;
            this.btmFruits.Click += new System.EventHandler(this.btmFruits_Click);
            // 
            // FormMainEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMainEnglish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainEnglish";
            this.Load += new System.EventHandler(this.FormMainEnglish_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmChallenge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btmSports;
        private System.Windows.Forms.Button btmColours;
        private System.Windows.Forms.Button btmVegetables;
        private System.Windows.Forms.Button btmFruits;
    }
}