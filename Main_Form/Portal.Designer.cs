
namespace Main_Form
{
    partial class Portal
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
            this.chart1_button = new System.Windows.Forms.Button();
            this.chart2_button = new System.Windows.Forms.Button();
            this.chart3_button = new System.Windows.Forms.Button();
            this.chart4_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chart1_button
            // 
            this.chart1_button.Location = new System.Drawing.Point(309, 41);
            this.chart1_button.Name = "chart1_button";
            this.chart1_button.Size = new System.Drawing.Size(216, 47);
            this.chart1_button.TabIndex = 0;
            this.chart1_button.Text = "Burrito Line";
            this.chart1_button.UseVisualStyleBackColor = true;
            this.chart1_button.Click += new System.EventHandler(this.chart1_button_Click);
            // 
            // chart2_button
            // 
            this.chart2_button.Location = new System.Drawing.Point(309, 94);
            this.chart2_button.Name = "chart2_button";
            this.chart2_button.Size = new System.Drawing.Size(215, 48);
            this.chart2_button.TabIndex = 1;
            this.chart2_button.Text = "GME Stock Area";
            this.chart2_button.UseVisualStyleBackColor = true;
            this.chart2_button.Click += new System.EventHandler(this.chart2_button_Click);
            // 
            // chart3_button
            // 
            this.chart3_button.Location = new System.Drawing.Point(309, 148);
            this.chart3_button.Name = "chart3_button";
            this.chart3_button.Size = new System.Drawing.Size(215, 48);
            this.chart3_button.TabIndex = 2;
            this.chart3_button.Text = "GoT Depressing Columns";
            this.chart3_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chart3_button.UseVisualStyleBackColor = true;
            this.chart3_button.Click += new System.EventHandler(this.chart3_button_Click);
            // 
            // chart4_button
            // 
            this.chart4_button.Location = new System.Drawing.Point(309, 202);
            this.chart4_button.Name = "chart4_button";
            this.chart4_button.Size = new System.Drawing.Size(215, 48);
            this.chart4_button.TabIndex = 3;
            this.chart4_button.Text = "DeKalb Weather Points";
            this.chart4_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chart4_button.UseVisualStyleBackColor = true;
            this.chart4_button.Click += new System.EventHandler(this.chart4_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(309, 256);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(215, 48);
            this.Exit_button.TabIndex = 4;
            this.Exit_button.Text = "Exit";
            this.Exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.chart4_button);
            this.Controls.Add(this.chart3_button);
            this.Controls.Add(this.chart2_button);
            this.Controls.Add(this.chart1_button);
            this.Name = "Portal";
            this.Text = "Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Portal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chart1_button;
        private System.Windows.Forms.Button chart2_button;
        private System.Windows.Forms.Button chart3_button;
        private System.Windows.Forms.Button chart4_button;
        private System.Windows.Forms.Button Exit_button;
    }
}