namespace AddSubtract
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.firstNumberText = new System.Windows.Forms.TextBox();
            this.secondNumberText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplybutton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(12, 35);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 98);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(40, 13);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(115, 98);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(19, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "00";
            // 
            // firstNumberText
            // 
            this.firstNumberText.Location = new System.Drawing.Point(118, 28);
            this.firstNumberText.Name = "firstNumberText";
            this.firstNumberText.Size = new System.Drawing.Size(100, 20);
            this.firstNumberText.TabIndex = 4;
            // 
            // secondNumberText
            // 
            this.secondNumberText.Location = new System.Drawing.Point(118, 63);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(100, 20);
            this.secondNumberText.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(118, 144);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "Substract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplybutton
            // 
            this.multiplybutton.Location = new System.Drawing.Point(211, 144);
            this.multiplybutton.Name = "multiplybutton";
            this.multiplybutton.Size = new System.Drawing.Size(75, 23);
            this.multiplybutton.TabIndex = 8;
            this.multiplybutton.Text = "Multiply";
            this.multiplybutton.UseVisualStyleBackColor = true;
            this.multiplybutton.Click += new System.EventHandler(this.multiplybutton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(307, 144);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 9;
            this.divisionButton.Text = "Division";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 406);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplybutton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondNumberText);
            this.Controls.Add(this.firstNumberText);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox firstNumberText;
        private System.Windows.Forms.TextBox secondNumberText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplybutton;
        private System.Windows.Forms.Button divisionButton;
    }
}

