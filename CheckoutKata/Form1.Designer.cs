namespace CheckoutKata
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
            this.decrementA = new System.Windows.Forms.Button();
            this.incrementA = new System.Windows.Forms.Button();
            this.quantityA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityB = new System.Windows.Forms.Label();
            this.incrementB = new System.Windows.Forms.Button();
            this.decrementB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityC = new System.Windows.Forms.Label();
            this.incrementC = new System.Windows.Forms.Button();
            this.decrementC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityD = new System.Windows.Forms.Label();
            this.IncrementD = new System.Windows.Forms.Button();
            this.decrementD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decrementA
            // 
            this.decrementA.Location = new System.Drawing.Point(120, 162);
            this.decrementA.Name = "decrementA";
            this.decrementA.Size = new System.Drawing.Size(32, 29);
            this.decrementA.TabIndex = 0;
            this.decrementA.Text = "-";
            this.decrementA.UseVisualStyleBackColor = true;
            this.decrementA.Click += new System.EventHandler(this.decrementA_Click);
            // 
            // incrementA
            // 
            this.incrementA.Location = new System.Drawing.Point(215, 162);
            this.incrementA.Name = "incrementA";
            this.incrementA.Size = new System.Drawing.Size(31, 29);
            this.incrementA.TabIndex = 1;
            this.incrementA.Text = "+";
            this.incrementA.UseVisualStyleBackColor = true;
            this.incrementA.Click += new System.EventHandler(this.incrementA_Click);
            // 
            // quantityA
            // 
            this.quantityA.AutoSize = true;
            this.quantityA.Location = new System.Drawing.Point(175, 166);
            this.quantityA.Name = "quantityA";
            this.quantityA.Size = new System.Drawing.Size(17, 20);
            this.quantityA.TabIndex = 2;
            this.quantityA.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product B";
            // 
            // quantityB
            // 
            this.quantityB.AutoSize = true;
            this.quantityB.Location = new System.Drawing.Point(345, 166);
            this.quantityB.Name = "quantityB";
            this.quantityB.Size = new System.Drawing.Size(17, 20);
            this.quantityB.TabIndex = 6;
            this.quantityB.Text = "0";
            // 
            // incrementB
            // 
            this.incrementB.Location = new System.Drawing.Point(385, 162);
            this.incrementB.Name = "incrementB";
            this.incrementB.Size = new System.Drawing.Size(31, 29);
            this.incrementB.TabIndex = 5;
            this.incrementB.Text = "+";
            this.incrementB.UseVisualStyleBackColor = true;
            this.incrementB.Click += new System.EventHandler(this.incrementB_Click);
            // 
            // decrementB
            // 
            this.decrementB.Location = new System.Drawing.Point(290, 162);
            this.decrementB.Name = "decrementB";
            this.decrementB.Size = new System.Drawing.Size(32, 29);
            this.decrementB.TabIndex = 4;
            this.decrementB.Text = "-";
            this.decrementB.UseVisualStyleBackColor = true;
            this.decrementB.Click += new System.EventHandler(this.decrementB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product C";
            // 
            // quantityC
            // 
            this.quantityC.AutoSize = true;
            this.quantityC.Location = new System.Drawing.Point(513, 166);
            this.quantityC.Name = "quantityC";
            this.quantityC.Size = new System.Drawing.Size(17, 20);
            this.quantityC.TabIndex = 10;
            this.quantityC.Text = "0";
            // 
            // incrementC
            // 
            this.incrementC.Location = new System.Drawing.Point(553, 162);
            this.incrementC.Name = "incrementC";
            this.incrementC.Size = new System.Drawing.Size(31, 29);
            this.incrementC.TabIndex = 9;
            this.incrementC.Text = "+";
            this.incrementC.UseVisualStyleBackColor = true;
            this.incrementC.Click += new System.EventHandler(this.incrementC_Click);
            // 
            // decrementC
            // 
            this.decrementC.Location = new System.Drawing.Point(458, 162);
            this.decrementC.Name = "decrementC";
            this.decrementC.Size = new System.Drawing.Size(32, 29);
            this.decrementC.TabIndex = 8;
            this.decrementC.Text = "-";
            this.decrementC.UseVisualStyleBackColor = true;
            this.decrementC.Click += new System.EventHandler(this.decrementC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product D";
            // 
            // quantityD
            // 
            this.quantityD.AutoSize = true;
            this.quantityD.Location = new System.Drawing.Point(684, 166);
            this.quantityD.Name = "quantityD";
            this.quantityD.Size = new System.Drawing.Size(17, 20);
            this.quantityD.TabIndex = 14;
            this.quantityD.Text = "0";
            // 
            // IncrementD
            // 
            this.IncrementD.Location = new System.Drawing.Point(724, 162);
            this.IncrementD.Name = "IncrementD";
            this.IncrementD.Size = new System.Drawing.Size(31, 29);
            this.IncrementD.TabIndex = 13;
            this.IncrementD.Text = "+";
            this.IncrementD.UseVisualStyleBackColor = true;
            this.IncrementD.Click += new System.EventHandler(this.IncrementD_Click);
            // 
            // decrementD
            // 
            this.decrementD.Location = new System.Drawing.Point(629, 162);
            this.decrementD.Name = "decrementD";
            this.decrementD.Size = new System.Drawing.Size(32, 29);
            this.decrementD.TabIndex = 12;
            this.decrementD.Text = "-";
            this.decrementD.UseVisualStyleBackColor = true;
            this.decrementD.Click += new System.EventHandler(this.decrementD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityD);
            this.Controls.Add(this.IncrementD);
            this.Controls.Add(this.decrementD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityC);
            this.Controls.Add(this.incrementC);
            this.Controls.Add(this.decrementC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantityB);
            this.Controls.Add(this.incrementB);
            this.Controls.Add(this.decrementB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityA);
            this.Controls.Add(this.incrementA);
            this.Controls.Add(this.decrementA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label quantityA;
        private Button decrementA;
        private Button incrementA;
        private Label label1;
        private Label label2;
        private Label quantityB;
        private Button incrementB;
        private Button decrementB;
        private Label label3;
        private Label quantityC;
        private Button incrementC;
        private Button decrementC;
        private Label label4;
        private Label quantityD;
        private Button IncrementD;
        private Button decrementD;
    }
}