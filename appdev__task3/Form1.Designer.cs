
namespace appdev__task3
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
            this.textBoxCowsMilk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGoatsMilk = new System.Windows.Forms.TextBox();
            this.textBoxCostOfVacCow = new System.Windows.Forms.TextBox();
            this.textBoxCostOfVacJC = new System.Windows.Forms.TextBox();
            this.textBoxCostOfVacGoat = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCowsMilk
            // 
            this.textBoxCowsMilk.Location = new System.Drawing.Point(460, 17);
            this.textBoxCowsMilk.Name = "textBoxCowsMilk";
            this.textBoxCowsMilk.Size = new System.Drawing.Size(200, 39);
            this.textBoxCowsMilk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price of cow\'s milk per litre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price of Goat\'s milk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost of vaccination for a single cow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost of vaccination for a Jersey Cow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cost of vaccination for a goat";
            // 
            // textBoxGoatsMilk
            // 
            this.textBoxGoatsMilk.Location = new System.Drawing.Point(460, 79);
            this.textBoxGoatsMilk.Name = "textBoxGoatsMilk";
            this.textBoxGoatsMilk.Size = new System.Drawing.Size(200, 39);
            this.textBoxGoatsMilk.TabIndex = 6;
            // 
            // textBoxCostOfVacCow
            // 
            this.textBoxCostOfVacCow.Location = new System.Drawing.Point(523, 143);
            this.textBoxCostOfVacCow.Name = "textBoxCostOfVacCow";
            this.textBoxCostOfVacCow.Size = new System.Drawing.Size(200, 39);
            this.textBoxCostOfVacCow.TabIndex = 7;
            // 
            // textBoxCostOfVacJC
            // 
            this.textBoxCostOfVacJC.Location = new System.Drawing.Point(523, 207);
            this.textBoxCostOfVacJC.Name = "textBoxCostOfVacJC";
            this.textBoxCostOfVacJC.Size = new System.Drawing.Size(200, 39);
            this.textBoxCostOfVacJC.TabIndex = 8;
            // 
            // textBoxCostOfVacGoat
            // 
            this.textBoxCostOfVacGoat.Location = new System.Drawing.Point(460, 273);
            this.textBoxCostOfVacGoat.Name = "textBoxCostOfVacGoat";
            this.textBoxCostOfVacGoat.Size = new System.Drawing.Size(200, 39);
            this.textBoxCostOfVacGoat.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(361, 379);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 46);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(352, 460);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(192, 39);
            this.textBoxOutput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "total profitability";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxCostOfVacGoat);
            this.Controls.Add(this.textBoxCostOfVacJC);
            this.Controls.Add(this.textBoxCostOfVacCow);
            this.Controls.Add(this.textBoxGoatsMilk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCowsMilk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCowsMilk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGoatsMilk;
        private System.Windows.Forms.TextBox textBoxCostOfVacCow;
        private System.Windows.Forms.TextBox textBoxCostOfVacJC;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCostOfVacGoat;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

