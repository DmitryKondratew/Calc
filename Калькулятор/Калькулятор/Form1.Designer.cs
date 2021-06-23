namespace Калькулятор
{
    partial class Calculator
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Sign = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Number_7 = new System.Windows.Forms.Button();
            this.Number_8 = new System.Windows.Forms.Button();
            this.Number_9 = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Remainder = new System.Windows.Forms.Button();
            this.Number_4 = new System.Windows.Forms.Button();
            this.Number_5 = new System.Windows.Forms.Button();
            this.Number_6 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.Number_1 = new System.Windows.Forms.Button();
            this.Number_2 = new System.Windows.Forms.Button();
            this.Number_3 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Number_0 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Equally = new System.Windows.Forms.Button();
            this.More = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Factorial_ = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(278, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(12, 80);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(42, 35);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "button1";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(60, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(109, 80);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(42, 35);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sign
            // 
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign.Location = new System.Drawing.Point(157, 80);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(42, 35);
            this.Sign.TabIndex = 4;
            this.Sign.Text = "button4";
            this.Sign.UseVisualStyleBackColor = true;
            this.Sign.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sqrt.Location = new System.Drawing.Point(205, 80);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(42, 35);
            this.Sqrt.TabIndex = 5;
            this.Sqrt.Text = "button5";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Number_7
            // 
            this.Number_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_7.Location = new System.Drawing.Point(12, 121);
            this.Number_7.Name = "Number_7";
            this.Number_7.Size = new System.Drawing.Size(42, 35);
            this.Number_7.TabIndex = 6;
            this.Number_7.Text = "7";
            this.Number_7.UseVisualStyleBackColor = true;
            this.Number_7.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_8
            // 
            this.Number_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_8.Location = new System.Drawing.Point(60, 121);
            this.Number_8.Name = "Number_8";
            this.Number_8.Size = new System.Drawing.Size(42, 35);
            this.Number_8.TabIndex = 7;
            this.Number_8.Text = "8";
            this.Number_8.UseVisualStyleBackColor = true;
            this.Number_8.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_9
            // 
            this.Number_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_9.Location = new System.Drawing.Point(109, 121);
            this.Number_9.Name = "Number_9";
            this.Number_9.Size = new System.Drawing.Size(42, 35);
            this.Number_9.TabIndex = 8;
            this.Number_9.Text = "9";
            this.Number_9.UseVisualStyleBackColor = true;
            this.Number_9.Click += new System.EventHandler(this.Number_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(157, 121);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(42, 35);
            this.Division.TabIndex = 9;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Remainder
            // 
            this.Remainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remainder.Location = new System.Drawing.Point(204, 121);
            this.Remainder.Name = "Remainder";
            this.Remainder.Size = new System.Drawing.Size(42, 35);
            this.Remainder.TabIndex = 10;
            this.Remainder.Text = "Mod";
            this.Remainder.UseVisualStyleBackColor = true;
            this.Remainder.Click += new System.EventHandler(this.Remainder_Click);
            // 
            // Number_4
            // 
            this.Number_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_4.Location = new System.Drawing.Point(12, 162);
            this.Number_4.Name = "Number_4";
            this.Number_4.Size = new System.Drawing.Size(42, 35);
            this.Number_4.TabIndex = 11;
            this.Number_4.Text = "4";
            this.Number_4.UseVisualStyleBackColor = true;
            this.Number_4.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_5
            // 
            this.Number_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_5.Location = new System.Drawing.Point(61, 162);
            this.Number_5.Name = "Number_5";
            this.Number_5.Size = new System.Drawing.Size(42, 35);
            this.Number_5.TabIndex = 12;
            this.Number_5.Text = "5";
            this.Number_5.UseVisualStyleBackColor = true;
            this.Number_5.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_6
            // 
            this.Number_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_6.Location = new System.Drawing.Point(109, 162);
            this.Number_6.Name = "Number_6";
            this.Number_6.Size = new System.Drawing.Size(42, 35);
            this.Number_6.TabIndex = 13;
            this.Number_6.Text = "6";
            this.Number_6.UseVisualStyleBackColor = true;
            this.Number_6.Click += new System.EventHandler(this.Number_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiply.Location = new System.Drawing.Point(157, 162);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(42, 35);
            this.Multiply.TabIndex = 14;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Fraction
            // 
            this.Fraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fraction.Location = new System.Drawing.Point(204, 162);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(42, 35);
            this.Fraction.TabIndex = 15;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.Fraction_Click);
            // 
            // Number_1
            // 
            this.Number_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_1.Location = new System.Drawing.Point(12, 203);
            this.Number_1.Name = "Number_1";
            this.Number_1.Size = new System.Drawing.Size(42, 35);
            this.Number_1.TabIndex = 16;
            this.Number_1.Text = "1";
            this.Number_1.UseVisualStyleBackColor = true;
            this.Number_1.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_2
            // 
            this.Number_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_2.Location = new System.Drawing.Point(61, 203);
            this.Number_2.Name = "Number_2";
            this.Number_2.Size = new System.Drawing.Size(42, 35);
            this.Number_2.TabIndex = 17;
            this.Number_2.Text = "2";
            this.Number_2.UseVisualStyleBackColor = true;
            this.Number_2.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number_3
            // 
            this.Number_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_3.Location = new System.Drawing.Point(109, 203);
            this.Number_3.Name = "Number_3";
            this.Number_3.Size = new System.Drawing.Size(42, 35);
            this.Number_3.TabIndex = 18;
            this.Number_3.Text = "3";
            this.Number_3.UseVisualStyleBackColor = true;
            this.Number_3.Click += new System.EventHandler(this.Number_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(157, 203);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(42, 35);
            this.Minus.TabIndex = 19;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Number_0
            // 
            this.Number_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_0.Location = new System.Drawing.Point(12, 244);
            this.Number_0.Name = "Number_0";
            this.Number_0.Size = new System.Drawing.Size(90, 35);
            this.Number_0.TabIndex = 20;
            this.Number_0.Text = "0";
            this.Number_0.UseVisualStyleBackColor = true;
            this.Number_0.Click += new System.EventHandler(this.Number_Click);
            // 
            // Point
            // 
            this.Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point.Location = new System.Drawing.Point(108, 244);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(42, 35);
            this.Point.TabIndex = 21;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(157, 244);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(42, 35);
            this.Sum.TabIndex = 22;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Equally
            // 
            this.Equally.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equally.Location = new System.Drawing.Point(204, 203);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(42, 76);
            this.Equally.TabIndex = 23;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = true;
            this.Equally.Click += new System.EventHandler(this.Equally_Click);
            // 
            // More
            // 
            this.More.Font = new System.Drawing.Font("MT Extra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.More.Location = new System.Drawing.Point(252, 121);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(44, 76);
            this.More.TabIndex = 24;
            this.More.Text = ">";
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Factorial_
            // 
            this.Factorial_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Factorial_.Location = new System.Drawing.Point(315, 80);
            this.Factorial_.Name = "Factorial_";
            this.Factorial_.Size = new System.Drawing.Size(42, 35);
            this.Factorial_.TabIndex = 25;
            this.Factorial_.Text = "n!";
            this.Factorial_.UseVisualStyleBackColor = true;
            this.Factorial_.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Sin
            // 
            this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sin.Location = new System.Drawing.Point(315, 121);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(42, 35);
            this.Sin.TabIndex = 26;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Cos
            // 
            this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.Location = new System.Drawing.Point(315, 162);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(42, 35);
            this.Cos.TabIndex = 27;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // Tan
            // 
            this.Tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tan.Location = new System.Drawing.Point(315, 203);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(42, 35);
            this.Tan.TabIndex = 28;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power.Location = new System.Drawing.Point(315, 244);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(42, 35);
            this.Power.TabIndex = 29;
            this.Power.Text = "x^y";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 293);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Factorial_);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Equally);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Number_0);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Number_3);
            this.Controls.Add(this.Number_2);
            this.Controls.Add(this.Number_1);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Number_6);
            this.Controls.Add(this.Number_5);
            this.Controls.Add(this.Number_4);
            this.Controls.Add(this.Remainder);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Number_9);
            this.Controls.Add(this.Number_8);
            this.Controls.Add(this.Number_7);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Sign;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Number_7;
        private System.Windows.Forms.Button Number_8;
        private System.Windows.Forms.Button Number_9;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Remainder;
        private System.Windows.Forms.Button Number_4;
        private System.Windows.Forms.Button Number_5;
        private System.Windows.Forms.Button Number_6;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button Number_1;
        private System.Windows.Forms.Button Number_2;
        private System.Windows.Forms.Button Number_3;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Number_0;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Equally;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Factorial_;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Power;
    }
}

