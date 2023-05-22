namespace DBMS_project
{
    partial class Q4
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
            this.c_types = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_types
            // 
            this.c_types.FormattingEnabled = true;
            this.c_types.Location = new System.Drawing.Point(128, 171);
            this.c_types.Name = "c_types";
            this.c_types.Size = new System.Drawing.Size(171, 28);
            this.c_types.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "display photoshoots types";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Q4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_types);
            this.Name = "Q4";
            this.Text = "Q4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Q4_FormClosing);
            this.Load += new System.EventHandler(this.Q4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox c_types;
        private System.Windows.Forms.Button button1;
    }
}