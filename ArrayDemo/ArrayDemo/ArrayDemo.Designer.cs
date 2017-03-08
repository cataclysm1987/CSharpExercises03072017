namespace ArrayDemo
{
    partial class ArrayDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblArrayOutput = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtArrayValues = new System.Windows.Forms.TextBox();
            this.btnGetIndex = new System.Windows.Forms.Button();
            this.txtNthValue = new System.Windows.Forms.TextBox();
            this.lblNthValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Value to Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArrayOutput
            // 
            this.lblArrayOutput.AutoSize = true;
            this.lblArrayOutput.Location = new System.Drawing.Point(45, 155);
            this.lblArrayOutput.Name = "lblArrayOutput";
            this.lblArrayOutput.Size = new System.Drawing.Size(142, 13);
            this.lblArrayOutput.TabIndex = 1;
            this.lblArrayOutput.Text = "Array Will Be Displayed Here";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Array in Reverse Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtArrayValues
            // 
            this.txtArrayValues.Location = new System.Drawing.Point(97, 51);
            this.txtArrayValues.Name = "txtArrayValues";
            this.txtArrayValues.Size = new System.Drawing.Size(283, 20);
            this.txtArrayValues.TabIndex = 3;
            this.txtArrayValues.Text = "Enter Array Values Here";
            // 
            // btnGetIndex
            // 
            this.btnGetIndex.Location = new System.Drawing.Point(287, 185);
            this.btnGetIndex.Name = "btnGetIndex";
            this.btnGetIndex.Size = new System.Drawing.Size(93, 23);
            this.btnGetIndex.TabIndex = 4;
            this.btnGetIndex.Text = "Get Nth Value";
            this.btnGetIndex.UseVisualStyleBackColor = true;
            this.btnGetIndex.Click += new System.EventHandler(this.btnGetIndex_Click);
            // 
            // txtNthValue
            // 
            this.txtNthValue.Location = new System.Drawing.Point(324, 159);
            this.txtNthValue.Name = "txtNthValue";
            this.txtNthValue.Size = new System.Drawing.Size(56, 20);
            this.txtNthValue.TabIndex = 5;
            // 
            // lblNthValue
            // 
            this.lblNthValue.AutoSize = true;
            this.lblNthValue.Location = new System.Drawing.Point(405, 190);
            this.lblNthValue.Name = "lblNthValue";
            this.lblNthValue.Size = new System.Drawing.Size(0, 13);
            this.lblNthValue.TabIndex = 6;
            // 
            // ArrayDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 220);
            this.Controls.Add(this.lblNthValue);
            this.Controls.Add(this.txtNthValue);
            this.Controls.Add(this.btnGetIndex);
            this.Controls.Add(this.txtArrayValues);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblArrayOutput);
            this.Controls.Add(this.button1);
            this.Name = "ArrayDemo";
            this.Text = "Array Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblArrayOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtArrayValues;
        private System.Windows.Forms.Button btnGetIndex;
        private System.Windows.Forms.TextBox txtNthValue;
        private System.Windows.Forms.Label lblNthValue;
    }
}

