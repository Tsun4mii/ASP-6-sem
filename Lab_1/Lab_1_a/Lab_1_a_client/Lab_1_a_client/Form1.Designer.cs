
namespace Lab_1_a_client
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
            this.valueOne = new System.Windows.Forms.TextBox();
            this.valueTwo = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueOne
            // 
            this.valueOne.Location = new System.Drawing.Point(120, 79);
            this.valueOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueOne.Name = "valueOne";
            this.valueOne.Size = new System.Drawing.Size(100, 27);
            this.valueOne.TabIndex = 0;
            // 
            // valueTwo
            // 
            this.valueTwo.Location = new System.Drawing.Point(550, 79);
            this.valueTwo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.valueTwo.Name = "valueTwo";
            this.valueTwo.Size = new System.Drawing.Size(100, 27);
            this.valueTwo.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(366, 82);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(45, 20);
            this.result.TabIndex = 2;
            this.result.Text = "result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.valueTwo);
            this.Controls.Add(this.valueOne);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valueOne;
        private System.Windows.Forms.TextBox valueTwo;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

