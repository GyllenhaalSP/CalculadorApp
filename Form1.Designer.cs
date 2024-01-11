using System.Runtime.CompilerServices;

namespace CalculadorApp
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
            num1Button = new Button();
            calculatorDisplay = new Label();
            num2Button = new Button();
            num3Button = new Button();
            num4Button = new Button();
            num5Button = new Button();
            num6Button = new Button();
            num7Button = new Button();
            num8Button = new Button();
            num9Button = new Button();
            equalsButton = new Button();
            plusButton = new Button();
            minusButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            clearButton = new Button();
            logButton = new Button();
            zeroButton = new Button();
            decimalButton = new Button();
            sqrtButton = new Button();
            exponentButton = new Button();
            percentButton = new Button();
            modButton = new Button();
            SuspendLayout();
            // 
            // num1Button
            // 
            num1Button.Font = new Font("Papyrus", 15F);
            num1Button.Location = new Point(12, 390);
            num1Button.Name = "num1Button";
            num1Button.Size = new Size(70, 70);
            num1Button.TabIndex = 1;
            num1Button.Text = "1";
            num1Button.UseVisualStyleBackColor = true;
            num1Button.Click += num1Button_Click;
            // 
            // calculatorDisplay
            // 
            calculatorDisplay.BackColor = SystemColors.ControlText;
            calculatorDisplay.Font = new Font("Segoe UI", 35F);
            calculatorDisplay.ForeColor = Color.White;
            calculatorDisplay.Location = new Point(12, 9);
            calculatorDisplay.Name = "calculatorDisplay";
            calculatorDisplay.Size = new Size(298, 70);
            calculatorDisplay.TabIndex = 2;
            calculatorDisplay.Text = "0";
            // 
            // num2Button
            // 
            num2Button.Font = new Font("Papyrus", 15F);
            num2Button.Location = new Point(88, 390);
            num2Button.Name = "num2Button";
            num2Button.Size = new Size(70, 70);
            num2Button.TabIndex = 3;
            num2Button.Text = "2";
            num2Button.UseVisualStyleBackColor = true;
            num2Button.Click += num2Button_Click;
            // 
            // num3Button
            // 
            num3Button.Font = new Font("Papyrus", 15F);
            num3Button.Location = new Point(164, 390);
            num3Button.Name = "num3Button";
            num3Button.Size = new Size(70, 70);
            num3Button.TabIndex = 4;
            num3Button.Text = "3";
            num3Button.UseVisualStyleBackColor = true;
            num3Button.Click += num3Button_Click;
            // 
            // num4Button
            // 
            num4Button.Font = new Font("Papyrus", 15F);
            num4Button.Location = new Point(12, 314);
            num4Button.Name = "num4Button";
            num4Button.Size = new Size(70, 70);
            num4Button.TabIndex = 5;
            num4Button.Text = "4";
            num4Button.UseVisualStyleBackColor = true;
            num4Button.Click += num4Button_Click;
            // 
            // num5Button
            // 
            num5Button.Font = new Font("Papyrus", 15F);
            num5Button.Location = new Point(88, 314);
            num5Button.Name = "num5Button";
            num5Button.Size = new Size(70, 70);
            num5Button.TabIndex = 6;
            num5Button.Text = "5";
            num5Button.UseVisualStyleBackColor = true;
            num5Button.Click += num5Button_Click;
            // 
            // num6Button
            // 
            num6Button.Font = new Font("Papyrus", 15F);
            num6Button.Location = new Point(164, 314);
            num6Button.Name = "num6Button";
            num6Button.Size = new Size(70, 70);
            num6Button.TabIndex = 7;
            num6Button.Text = "6";
            num6Button.UseVisualStyleBackColor = true;
            num6Button.Click += num6Button_Click;
            // 
            // num7Button
            // 
            num7Button.Font = new Font("Papyrus", 15F);
            num7Button.Location = new Point(12, 238);
            num7Button.Name = "num7Button";
            num7Button.Size = new Size(70, 70);
            num7Button.TabIndex = 8;
            num7Button.Text = "7";
            num7Button.UseVisualStyleBackColor = true;
            num7Button.Click += num7Button_Click;
            // 
            // num8Button
            // 
            num8Button.Font = new Font("Papyrus", 15F);
            num8Button.Location = new Point(88, 238);
            num8Button.Name = "num8Button";
            num8Button.Size = new Size(70, 70);
            num8Button.TabIndex = 9;
            num8Button.Text = "8";
            num8Button.UseVisualStyleBackColor = true;
            num8Button.Click += num8Button_Click;
            // 
            // num9Button
            // 
            num9Button.Font = new Font("Papyrus", 15F);
            num9Button.Location = new Point(164, 238);
            num9Button.Name = "num9Button";
            num9Button.Size = new Size(70, 70);
            num9Button.TabIndex = 10;
            num9Button.Text = "9";
            num9Button.UseVisualStyleBackColor = true;
            num9Button.Click += num9Button_Click;
            // 
            // equalsButton
            // 
            equalsButton.Font = new Font("Papyrus", 15F);
            equalsButton.Location = new Point(240, 466);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(70, 70);
            equalsButton.TabIndex = 11;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += equalsButton_Click;
            // 
            // plusButton
            // 
            plusButton.Font = new Font("Papyrus", 15F);
            plusButton.Location = new Point(240, 390);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(70, 70);
            plusButton.TabIndex = 12;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Papyrus", 15F);
            minusButton.Location = new Point(240, 314);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(70, 70);
            minusButton.TabIndex = 13;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Papyrus", 15F);
            multiplyButton.Location = new Point(240, 238);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(70, 70);
            multiplyButton.TabIndex = 14;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.Font = new Font("Papyrus", 15F);
            divideButton.Location = new Point(238, 162);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(70, 70);
            divideButton.TabIndex = 15;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Papyrus", 15F);
            clearButton.Location = new Point(12, 86);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(222, 70);
            clearButton.TabIndex = 16;
            clearButton.Text = "AC";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // logButton
            // 
            logButton.Font = new Font("Papyrus", 15F);
            logButton.Location = new Point(12, 466);
            logButton.Name = "logButton";
            logButton.Size = new Size(70, 70);
            logButton.TabIndex = 17;
            logButton.Text = "log";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Font = new Font("Papyrus", 15F);
            zeroButton.Location = new Point(88, 466);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(70, 70);
            zeroButton.TabIndex = 18;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += zeroButton_Click;
            // 
            // decimalButton
            // 
            decimalButton.Font = new Font("Papyrus", 15F);
            decimalButton.Location = new Point(164, 466);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(70, 70);
            decimalButton.TabIndex = 19;
            decimalButton.Text = ",";
            decimalButton.UseVisualStyleBackColor = true;
            decimalButton.Click += decimalButton_Click;
            // 
            // sqrtButton
            // 
            sqrtButton.Font = new Font("Papyrus", 15F);
            sqrtButton.Location = new Point(12, 162);
            sqrtButton.Name = "sqrtButton";
            sqrtButton.Size = new Size(70, 70);
            sqrtButton.TabIndex = 20;
            sqrtButton.Text = "√";
            sqrtButton.UseVisualStyleBackColor = true;
            sqrtButton.Click += sqrtButton_Click;
            // 
            // exponentButton
            // 
            exponentButton.Font = new Font("Papyrus", 15F);
            exponentButton.Location = new Point(88, 162);
            exponentButton.Name = "exponentButton";
            exponentButton.Size = new Size(70, 70);
            exponentButton.TabIndex = 21;
            exponentButton.Text = "𝑥ⁿ";
            exponentButton.UseVisualStyleBackColor = true;
            exponentButton.Click += exponentButton_Click;
            // 
            // percentButton
            // 
            percentButton.Font = new Font("Papyrus", 15F);
            percentButton.Location = new Point(164, 162);
            percentButton.Name = "percentButton";
            percentButton.Size = new Size(70, 70);
            percentButton.TabIndex = 22;
            percentButton.Text = "%";
            percentButton.UseVisualStyleBackColor = true;
            percentButton.Click += percentButton_Click;
            // 
            // modButton
            // 
            modButton.Font = new Font("Papyrus", 15F);
            modButton.Location = new Point(238, 86);
            modButton.Name = "modButton";
            modButton.Size = new Size(70, 70);
            modButton.TabIndex = 23;
            modButton.Text = "mod";
            modButton.UseVisualStyleBackColor = true;
            modButton.Click += modButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 544);
            Controls.Add(modButton);
            Controls.Add(percentButton);
            Controls.Add(exponentButton);
            Controls.Add(sqrtButton);
            Controls.Add(decimalButton);
            Controls.Add(zeroButton);
            Controls.Add(logButton);
            Controls.Add(clearButton);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(minusButton);
            Controls.Add(plusButton);
            Controls.Add(equalsButton);
            Controls.Add(num9Button);
            Controls.Add(num8Button);
            Controls.Add(num7Button);
            Controls.Add(num6Button);
            Controls.Add(num5Button);
            Controls.Add(num4Button);
            Controls.Add(num3Button);
            Controls.Add(num2Button);
            Controls.Add(num1Button);
            Controls.Add(calculatorDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button num1Button;
        private Label calculatorDisplay;
        private Button num2Button;
        private Button num3Button;
        private Button num4Button;
        private Button num5Button;
        private Button num6Button;
        private Button num7Button;
        private Button num8Button;
        private Button num9Button;
        private Button equalsButton;
        private Button plusButton;
        private Button minusButton;
        private Button multiplyButton;
        private Button divideButton;
        private Button clearButton;
        private Button logButton;
        private Button zeroButton;
        private Button decimalButton;
        private Button sqrtButton;
        private Button exponentButton;
        private Button percentButton;
        private Button modButton;
    }
}
