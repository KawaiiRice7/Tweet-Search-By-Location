namespace TwitterAPIForms
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
            this.label3 = new System.Windows.Forms.Label();
            this.SearchEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchConfirm = new System.Windows.Forms.Button();
            this.QueryResult = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationEntry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "What do you want to search?";
            // 
            // SearchEntry
            // 
            this.SearchEntry.Location = new System.Drawing.Point(29, 118);
            this.SearchEntry.Name = "SearchEntry";
            this.SearchEntry.Size = new System.Drawing.Size(144, 20);
            this.SearchEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "You are logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "username";
            // 
            // SearchConfirm
            // 
            this.SearchConfirm.Location = new System.Drawing.Point(43, 321);
            this.SearchConfirm.Name = "SearchConfirm";
            this.SearchConfirm.Size = new System.Drawing.Size(117, 23);
            this.SearchConfirm.TabIndex = 5;
            this.SearchConfirm.Text = "Search!";
            this.SearchConfirm.UseVisualStyleBackColor = true;
            this.SearchConfirm.Click += new System.EventHandler(this.SearchConfirm_Click);
            // 
            // QueryResult
            // 
            this.QueryResult.Location = new System.Drawing.Point(216, 29);
            this.QueryResult.Name = "QueryResult";
            this.QueryResult.Size = new System.Drawing.Size(498, 315);
            this.QueryResult.TabIndex = 6;
            this.QueryResult.Text = "Tweets go here.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filter by Location";
            // 
            // LocationEntry
            // 
            this.LocationEntry.Location = new System.Drawing.Point(29, 198);
            this.LocationEntry.Name = "LocationEntry";
            this.LocationEntry.Size = new System.Drawing.Size(144, 20);
            this.LocationEntry.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 399);
            this.Controls.Add(this.LocationEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QueryResult);
            this.Controls.Add(this.SearchConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchEntry);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchConfirm;
        private System.Windows.Forms.RichTextBox QueryResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocationEntry;
    }
}

