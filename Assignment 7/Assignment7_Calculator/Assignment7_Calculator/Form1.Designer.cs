//Cole Hemp
//Form1.Designer.cs
//Generates the form for the app.

namespace Assignment7_Calculator
{
    partial class CalculatorForm
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
            this.Value1TextBox = new System.Windows.Forms.TextBox();
            this.Value2TextBox = new System.Windows.Forms.TextBox();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.Value1Label = new System.Windows.Forms.Label();
            this.Value2Label = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AddLabel = new System.Windows.Forms.Label();
            this.MultiplyLabel = new System.Windows.Forms.Label();
            this.ResetLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value1TextBox
            // 
            this.Value1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value1TextBox.Location = new System.Drawing.Point(12, 57);
            this.Value1TextBox.Name = "Value1TextBox";
            this.Value1TextBox.Size = new System.Drawing.Size(110, 106);
            this.Value1TextBox.TabIndex = 0;
            this.Value1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value1TextBox.WordWrap = false;
            // 
            // Value2TextBox
            // 
            this.Value2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value2TextBox.Location = new System.Drawing.Point(253, 57);
            this.Value2TextBox.Name = "Value2TextBox";
            this.Value2TextBox.Size = new System.Drawing.Size(110, 106);
            this.Value2TextBox.TabIndex = 1;
            this.Value2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value2TextBox.WordWrap = false;
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Image = global::Assignment7_Calculator.Properties.Resources.Multiply;
            this.MultiplicationButton.Location = new System.Drawing.Point(253, 194);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(110, 110);
            this.MultiplicationButton.TabIndex = 3;
            this.MultiplicationButton.Text = "button2";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Image = global::Assignment7_Calculator.Properties.Resources.Add;
            this.AdditionButton.Location = new System.Drawing.Point(12, 194);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(110, 110);
            this.AdditionButton.TabIndex = 2;
            this.AdditionButton.Text = "button1";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // Value1Label
            // 
            this.Value1Label.AutoSize = true;
            this.Value1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value1Label.Location = new System.Drawing.Point(7, 29);
            this.Value1Label.Name = "Value1Label";
            this.Value1Label.Size = new System.Drawing.Size(122, 25);
            this.Value1Label.TabIndex = 4;
            this.Value1Label.Text = "1st Number";
            // 
            // Value2Label
            // 
            this.Value2Label.AutoSize = true;
            this.Value2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value2Label.Location = new System.Drawing.Point(248, 29);
            this.Value2Label.Name = "Value2Label";
            this.Value2Label.Size = new System.Drawing.Size(129, 25);
            this.Value2Label.TabIndex = 5;
            this.Value2Label.Text = "2nd Number";
            // 
            // ResetButton
            // 
            this.ResetButton.Image = global::Assignment7_Calculator.Properties.Resources.Reset;
            this.ResetButton.Location = new System.Drawing.Point(126, 434);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(120, 120);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(41, 166);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(50, 25);
            this.AddLabel.TabIndex = 7;
            this.AddLabel.Text = "Add";
            // 
            // MultiplyLabel
            // 
            this.MultiplyLabel.AutoSize = true;
            this.MultiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyLabel.Location = new System.Drawing.Point(266, 166);
            this.MultiplyLabel.Name = "MultiplyLabel";
            this.MultiplyLabel.Size = new System.Drawing.Size(86, 25);
            this.MultiplyLabel.TabIndex = 8;
            this.MultiplyLabel.Text = "Multiply";
            // 
            // ResetLabel
            // 
            this.ResetLabel.AutoSize = true;
            this.ResetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetLabel.Location = new System.Drawing.Point(151, 406);
            this.ResetLabel.Name = "ResetLabel";
            this.ResetLabel.Size = new System.Drawing.Size(68, 25);
            this.ResetLabel.TabIndex = 9;
            this.ResetLabel.Text = "Reset";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(158, 323);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 25);
            this.Output.TabIndex = 10;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 566);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ResetLabel);
            this.Controls.Add(this.MultiplyLabel);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Value2Label);
            this.Controls.Add(this.Value1Label);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.Value2TextBox);
            this.Controls.Add(this.Value1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value1TextBox;
        private System.Windows.Forms.TextBox Value2TextBox;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Label Value1Label;
        private System.Windows.Forms.Label Value2Label;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label MultiplyLabel;
        private System.Windows.Forms.Label ResetLabel;
        private System.Windows.Forms.Label Output;
    }
}

