namespace KidsLearnMath
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btmDivision = new System.Windows.Forms.Button();
            this.btmMultiplication = new System.Windows.Forms.Button();
            this.btmSubtraction = new System.Windows.Forms.Button();
            this.btmAddition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmExit = new System.Windows.Forms.Button();
            this.btmTmk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmDivision);
            this.groupBox1.Controls.Add(this.btmMultiplication);
            this.groupBox1.Controls.Add(this.btmSubtraction);
            this.groupBox1.Controls.Add(this.btmAddition);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learn";
            // 
            // btmDivision
            // 
            this.btmDivision.BackColor = System.Drawing.Color.Brown;
            this.btmDivision.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDivision.ForeColor = System.Drawing.Color.Black;
            this.btmDivision.Location = new System.Drawing.Point(6, 182);
            this.btmDivision.Name = "btmDivision";
            this.btmDivision.Size = new System.Drawing.Size(386, 42);
            this.btmDivision.TabIndex = 3;
            this.btmDivision.Text = "&Division";
            this.btmDivision.UseVisualStyleBackColor = false;
            this.btmDivision.Click += new System.EventHandler(this.btmDivision_Click);
            // 
            // btmMultiplication
            // 
            this.btmMultiplication.BackColor = System.Drawing.Color.Brown;
            this.btmMultiplication.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmMultiplication.ForeColor = System.Drawing.Color.Black;
            this.btmMultiplication.Location = new System.Drawing.Point(6, 134);
            this.btmMultiplication.Name = "btmMultiplication";
            this.btmMultiplication.Size = new System.Drawing.Size(386, 42);
            this.btmMultiplication.TabIndex = 2;
            this.btmMultiplication.Text = "&Multiplication";
            this.btmMultiplication.UseVisualStyleBackColor = false;
            this.btmMultiplication.Click += new System.EventHandler(this.btmMultiplication_Click);
            // 
            // btmSubtraction
            // 
            this.btmSubtraction.BackColor = System.Drawing.Color.Brown;
            this.btmSubtraction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSubtraction.ForeColor = System.Drawing.Color.Black;
            this.btmSubtraction.Location = new System.Drawing.Point(6, 86);
            this.btmSubtraction.Name = "btmSubtraction";
            this.btmSubtraction.Size = new System.Drawing.Size(386, 42);
            this.btmSubtraction.TabIndex = 1;
            this.btmSubtraction.Text = "&Subtraction";
            this.btmSubtraction.UseVisualStyleBackColor = false;
            this.btmSubtraction.Click += new System.EventHandler(this.btmSubtraction_Click);
            // 
            // btmAddition
            // 
            this.btmAddition.BackColor = System.Drawing.Color.Brown;
            this.btmAddition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAddition.ForeColor = System.Drawing.Color.Black;
            this.btmAddition.Location = new System.Drawing.Point(6, 38);
            this.btmAddition.Name = "btmAddition";
            this.btmAddition.Size = new System.Drawing.Size(386, 42);
            this.btmAddition.TabIndex = 0;
            this.btmAddition.Text = "&Addition";
            this.btmAddition.UseVisualStyleBackColor = false;
            this.btmAddition.Click += new System.EventHandler(this.btmAddition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btmExit);
            this.groupBox2.Controls.Add(this.btmTmk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 126);
            this.groupBox2.TabIndex = 3;
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
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // btmTmk
            // 
            this.btmTmk.BackColor = System.Drawing.Color.Sienna;
            this.btmTmk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmTmk.ForeColor = System.Drawing.Color.Black;
            this.btmTmk.Location = new System.Drawing.Point(6, 21);
            this.btmTmk.Name = "btmTmk";
            this.btmTmk.Size = new System.Drawing.Size(386, 42);
            this.btmTmk.TabIndex = 4;
            this.btmTmk.Text = "Test My Knowledge";
            this.btmTmk.UseVisualStyleBackColor = false;
            this.btmTmk.Click += new System.EventHandler(this.btmTestMySkills_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(443, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btmDivision;
        private System.Windows.Forms.Button btmMultiplication;
        private System.Windows.Forms.Button btmSubtraction;
        private System.Windows.Forms.Button btmAddition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmTmk;
    }
}