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
            this.lang_vie = new System.Windows.Forms.Button();
            this.lang_eng = new System.Windows.Forms.Button();
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
            this.hightval.Location = new System.Drawing.Point(101, 19);
            this.hightval.MaxLength = 5;
            this.hightval.Name = "hightval";
            this.hightval.Size = new System.Drawing.Size(42, 20);
            this.hightval.TabIndex = 1;
            this.hightval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hightval_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "inches";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(87, 60);
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
            this.help.Location = new System.Drawing.Point(57, 60);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(24, 24);
            this.help.TabIndex = 2;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.Help_Click);
            // 
            // lang_vie
            // 
            this.lang_vie.Location = new System.Drawing.Point(15, 60);
            this.lang_vie.Name = "lang_vie";
            this.lang_vie.Size = new System.Drawing.Size(36, 24);
            this.lang_vie.TabIndex = 3;
            this.lang_vie.Text = "vie";
            this.lang_vie.UseVisualStyleBackColor = true;
            this.lang_vie.Click += new System.EventHandler(this.lang_vie_Click);
            // 
            // lang_eng
            // 
            this.lang_eng.Location = new System.Drawing.Point(15, 60);
            this.lang_eng.Name = "lang_eng";
            this.lang_eng.Size = new System.Drawing.Size(36, 24);
            this.lang_eng.TabIndex = 4;
            this.lang_eng.Text = "eng";
            this.lang_eng.UseVisualStyleBackColor = true;
            this.lang_eng.Visible = false;
            this.lang_eng.Click += new System.EventHandler(this.lang_eng_Click);
            // 
            // AgeKnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 101);
            this.Controls.Add(this.lang_eng);
            this.Controls.Add(this.lang_vie);
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
        private System.Windows.Forms.Button lang_vie;
        private System.Windows.Forms.Button lang_eng;
    }
}

