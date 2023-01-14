namespace ShapeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.squareBtn = new System.Windows.Forms.Button();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.circleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // squareBtn
            // 
            this.squareBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squareBtn.Location = new System.Drawing.Point(12, 12);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(233, 43);
            this.squareBtn.TabIndex = 0;
            this.squareBtn.Text = "SQUARE";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // triangleBtn
            // 
            this.triangleBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleBtn.Location = new System.Drawing.Point(284, 12);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(233, 43);
            this.triangleBtn.TabIndex = 1;
            this.triangleBtn.Text = "TRIANGLE";
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click_1);
            // 
            // circleBtn
            // 
            this.circleBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleBtn.Location = new System.Drawing.Point(550, 12);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(233, 43);
            this.circleBtn.TabIndex = 2;
            this.circleBtn.Text = "CIRCLE";
            this.circleBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circleBtn);
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.squareBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button squareBtn;
        private Button triangleBtn;
        private Button circleBtn;
    }
}