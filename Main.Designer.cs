namespace AgeKnow
{
    partial class AgeKnow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeKnow));
            this.label1 = new System.Windows.Forms.Label();
            this.hightval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your height";
            // 
            // hightval
            // 
            this.hightval.Location = new System.Drawing.Point(105, 19);
            this.hightval.MaxLength = 3;
            this.hightval.Name = "hightval";
            this.hightval.Size = new System.Drawing.Size(42, 20);
            this.hightval.TabIndex = 1;
            this.hightval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hightval_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "cm";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(67, 60);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 24);
            this.submit.TabIndex = 2;
            this.submit.Text = "Result";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // help
            // 
            this.help.AccessibleName = "MainBox";
            this.help.Location = new System.Drawing.Point(31, 60);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(24, 24);
            this.help.TabIndex = 2;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // AgeKnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 101);
            this.Controls.Add(this.help);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.hightval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgeKnow";
            this.ShowInTaskbar = false;
            this.Text = "AgeKnow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hightval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button help;
    }
}

