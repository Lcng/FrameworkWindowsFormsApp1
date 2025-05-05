namespace FrameworkWindowsFormsApp1
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
            this.highlightLabel4 = new FrameworkWindowsFormsApp1.HighlightLabel();
            this.highlightLabel3 = new FrameworkWindowsFormsApp1.HighlightLabel();
            this.highlightLabel2 = new FrameworkWindowsFormsApp1.HighlightLabel();
            this.highlightLabel1 = new FrameworkWindowsFormsApp1.HighlightLabel();
            this.SuspendLayout();
            // 
            // highlightLabel4
            // 
            this.highlightLabel4.AutoSize = true;
            this.highlightLabel4.BackColor = System.Drawing.Color.LightCoral;
            this.highlightLabel4.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlightLabel4.Location = new System.Drawing.Point(300, 16);
            this.highlightLabel4.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.highlightLabel4.Name = "highlightLabel4";
            this.highlightLabel4.Size = new System.Drawing.Size(83, 34);
            this.highlightLabel4.TabIndex = 5;
            this.highlightLabel4.Text = "项目";
            // 
            // highlightLabel3
            // 
            this.highlightLabel3.AutoSize = true;
            this.highlightLabel3.BackColor = System.Drawing.Color.Brown;
            this.highlightLabel3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlightLabel3.Location = new System.Drawing.Point(205, 16);
            this.highlightLabel3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.highlightLabel3.Name = "highlightLabel3";
            this.highlightLabel3.Size = new System.Drawing.Size(83, 34);
            this.highlightLabel3.TabIndex = 4;
            this.highlightLabel3.Text = "视图";
            // 
            // highlightLabel2
            // 
            this.highlightLabel2.AutoSize = true;
            this.highlightLabel2.BackColor = System.Drawing.Color.IndianRed;
            this.highlightLabel2.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlightLabel2.Location = new System.Drawing.Point(110, 16);
            this.highlightLabel2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.highlightLabel2.Name = "highlightLabel2";
            this.highlightLabel2.Size = new System.Drawing.Size(83, 34);
            this.highlightLabel2.TabIndex = 3;
            this.highlightLabel2.Text = "编辑";
            // 
            // highlightLabel1
            // 
            this.highlightLabel1.AutoSize = true;
            this.highlightLabel1.BackColor = System.Drawing.Color.RosyBrown;
            this.highlightLabel1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.highlightLabel1.Location = new System.Drawing.Point(15, 16);
            this.highlightLabel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.highlightLabel1.Name = "highlightLabel1";
            this.highlightLabel1.Size = new System.Drawing.Size(83, 34);
            this.highlightLabel1.TabIndex = 2;
            this.highlightLabel1.Text = "文件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highlightLabel4);
            this.Controls.Add(this.highlightLabel3);
            this.Controls.Add(this.highlightLabel2);
            this.Controls.Add(this.highlightLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HighlightLabel highlightLabel1;
        private HighlightLabel highlightLabel2;
        private HighlightLabel highlightLabel3;
        private HighlightLabel highlightLabel4;
    }
}

