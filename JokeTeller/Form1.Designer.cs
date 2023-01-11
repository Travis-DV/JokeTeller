namespace JokeTeller
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
            this.SetUpLB = new System.Windows.Forms.Label();
            this.PunchLineLB = new System.Windows.Forms.Label();
            this.SetUpBUT = new System.Windows.Forms.Button();
            this.PunchLineBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpLB
            // 
            this.SetUpLB.AutoSize = true;
            this.SetUpLB.Location = new System.Drawing.Point(38, 45);
            this.SetUpLB.Name = "SetUpLB";
            this.SetUpLB.Size = new System.Drawing.Size(134, 13);
            this.SetUpLB.TabIndex = 0;
            this.SetUpLB.Text = "How did the fire all in love?";
            this.SetUpLB.Visible = false;
            // 
            // PunchLineLB
            // 
            this.PunchLineLB.AutoSize = true;
            this.PunchLineLB.Location = new System.Drawing.Point(178, 45);
            this.PunchLineLB.Name = "PunchLineLB";
            this.PunchLineLB.Size = new System.Drawing.Size(124, 13);
            this.PunchLineLB.TabIndex = 1;
            this.PunchLineLB.Text = "It found its perfect match";
            this.PunchLineLB.Visible = false;
            // 
            // SetUpBUT
            // 
            this.SetUpBUT.Location = new System.Drawing.Point(41, 80);
            this.SetUpBUT.Name = "SetUpBUT";
            this.SetUpBUT.Size = new System.Drawing.Size(131, 23);
            this.SetUpBUT.TabIndex = 2;
            this.SetUpBUT.Text = "Show Setup";
            this.SetUpBUT.UseVisualStyleBackColor = true;
            this.SetUpBUT.Click += new System.EventHandler(this.SetUpBUT_Click);
            // 
            // PunchLineBUT
            // 
            this.PunchLineBUT.Location = new System.Drawing.Point(181, 80);
            this.PunchLineBUT.Name = "PunchLineBUT";
            this.PunchLineBUT.Size = new System.Drawing.Size(121, 23);
            this.PunchLineBUT.TabIndex = 3;
            this.PunchLineBUT.Text = "Show Punch Line";
            this.PunchLineBUT.UseVisualStyleBackColor = true;
            this.PunchLineBUT.Click += new System.EventHandler(this.PunchLineBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 152);
            this.Controls.Add(this.PunchLineBUT);
            this.Controls.Add(this.SetUpBUT);
            this.Controls.Add(this.PunchLineLB);
            this.Controls.Add(this.SetUpLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetUpLB;
        private System.Windows.Forms.Label PunchLineLB;
        private System.Windows.Forms.Button SetUpBUT;
        private System.Windows.Forms.Button PunchLineBUT;
    }
}

