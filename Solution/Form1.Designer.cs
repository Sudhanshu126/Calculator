namespace Calculator
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
            NumbersLayout = new TableLayoutPanel();
            bracketOpen = new Button();
            bracketClose = new Button();
            dot = new Button();
            zero = new Button();
            equals = new Button();
            percent = new Button();
            back = new Button();
            divide = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            multiply = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            subtract = new Button();
            one = new Button();
            three = new Button();
            add = new Button();
            clear = new Button();
            two = new Button();
            display = new Label();
            NumbersLayout.SuspendLayout();
            SuspendLayout();
            // 
            // NumbersLayout
            // 
            NumbersLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NumbersLayout.BackColor = Color.Black;
            NumbersLayout.ColumnCount = 4;
            NumbersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NumbersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NumbersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NumbersLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            NumbersLayout.Controls.Add(dot, 0, 5);
            NumbersLayout.Controls.Add(zero, 1, 5);
            NumbersLayout.Controls.Add(equals, 2, 5);
            NumbersLayout.Controls.Add(percent, 1, 1);
            NumbersLayout.Controls.Add(back, 2, 1);
            NumbersLayout.Controls.Add(divide, 3, 1);
            NumbersLayout.Controls.Add(seven, 0, 2);
            NumbersLayout.Controls.Add(eight, 1, 2);
            NumbersLayout.Controls.Add(nine, 2, 2);
            NumbersLayout.Controls.Add(multiply, 3, 2);
            NumbersLayout.Controls.Add(four, 0, 3);
            NumbersLayout.Controls.Add(five, 1, 3);
            NumbersLayout.Controls.Add(six, 2, 3);
            NumbersLayout.Controls.Add(subtract, 3, 3);
            NumbersLayout.Controls.Add(one, 0, 4);
            NumbersLayout.Controls.Add(three, 2, 4);
            NumbersLayout.Controls.Add(add, 3, 4);
            NumbersLayout.Controls.Add(clear, 0, 1);
            NumbersLayout.Controls.Add(two, 1, 4);
            NumbersLayout.Controls.Add(bracketOpen, 0, 0);
            NumbersLayout.Controls.Add(bracketClose, 2, 0);
            NumbersLayout.Location = new Point(12, 167);
            NumbersLayout.Name = "NumbersLayout";
            NumbersLayout.RowCount = 6;
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            NumbersLayout.Size = new Size(713, 600);
            NumbersLayout.TabIndex = 1;
            // 
            // bracketOpen
            // 
            bracketOpen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bracketOpen.AutoSize = true;
            bracketOpen.BackColor = Color.Cornsilk;
            NumbersLayout.SetColumnSpan(bracketOpen, 2);
            bracketOpen.Font = new Font("Segoe UI", 20F);
            bracketOpen.Location = new Point(3, 3);
            bracketOpen.Name = "bracketOpen";
            bracketOpen.Size = new Size(350, 94);
            bracketOpen.TabIndex = 23;
            bracketOpen.Text = "(";
            bracketOpen.UseVisualStyleBackColor = false;
            bracketOpen.Click += brackets_Click;
            // 
            // bracketClose
            // 
            bracketClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bracketClose.AutoSize = true;
            bracketClose.BackColor = Color.Cornsilk;
            NumbersLayout.SetColumnSpan(bracketClose, 2);
            bracketClose.Font = new Font("Segoe UI", 20F);
            bracketClose.Location = new Point(359, 3);
            bracketClose.Name = "bracketClose";
            bracketClose.Size = new Size(351, 94);
            bracketClose.TabIndex = 22;
            bracketClose.Text = ")";
            bracketClose.UseVisualStyleBackColor = false;
            bracketClose.Click += brackets_Click;
            // 
            // dot
            // 
            dot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dot.BackColor = Color.Cornsilk;
            dot.Font = new Font("Segoe UI", 20F);
            dot.Location = new Point(3, 503);
            dot.Name = "dot";
            dot.Size = new Size(172, 94);
            dot.TabIndex = 18;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_Click;
            // 
            // zero
            // 
            zero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zero.BackColor = Color.Cornsilk;
            zero.Font = new Font("Segoe UI", 20F);
            zero.Location = new Point(181, 503);
            zero.Name = "zero";
            zero.Size = new Size(172, 94);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // equals
            // 
            equals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equals.BackColor = Color.Cornsilk;
            NumbersLayout.SetColumnSpan(equals, 2);
            equals.Font = new Font("Segoe UI", 20F);
            equals.Location = new Point(359, 503);
            equals.Name = "equals";
            equals.Size = new Size(351, 94);
            equals.TabIndex = 4;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            equals.Click += equals_Click;
            // 
            // percent
            // 
            percent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            percent.BackColor = Color.Cornsilk;
            percent.Font = new Font("Segoe UI", 20F);
            percent.Location = new Point(181, 103);
            percent.Name = "percent";
            percent.Size = new Size(172, 94);
            percent.TabIndex = 1;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = false;
            percent.Click += operation_Click;
            // 
            // back
            // 
            back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            back.BackColor = Color.Cornsilk;
            back.Font = new Font("Segoe UI", 20F);
            back.Location = new Point(359, 103);
            back.Name = "back";
            back.Size = new Size(172, 94);
            back.TabIndex = 2;
            back.Text = "<-";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // divide
            // 
            divide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            divide.BackColor = Color.Cornsilk;
            divide.Font = new Font("Segoe UI", 20F);
            divide.Location = new Point(537, 103);
            divide.Name = "divide";
            divide.Size = new Size(173, 94);
            divide.TabIndex = 3;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += operation_Click;
            // 
            // seven
            // 
            seven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seven.BackColor = Color.Cornsilk;
            seven.Font = new Font("Segoe UI", 20F);
            seven.Location = new Point(3, 203);
            seven.Name = "seven";
            seven.Size = new Size(172, 94);
            seven.TabIndex = 6;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += number_Click;
            // 
            // eight
            // 
            eight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eight.BackColor = Color.Cornsilk;
            eight.Font = new Font("Segoe UI", 20F);
            eight.Location = new Point(181, 203);
            eight.Name = "eight";
            eight.Size = new Size(172, 94);
            eight.TabIndex = 5;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += number_Click;
            // 
            // nine
            // 
            nine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nine.BackColor = Color.Cornsilk;
            nine.Font = new Font("Segoe UI", 20F);
            nine.Location = new Point(359, 203);
            nine.Name = "nine";
            nine.Size = new Size(172, 94);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += number_Click;
            // 
            // multiply
            // 
            multiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiply.BackColor = Color.Cornsilk;
            multiply.Font = new Font("Segoe UI", 20F);
            multiply.Location = new Point(537, 203);
            multiply.Name = "multiply";
            multiply.Size = new Size(173, 94);
            multiply.TabIndex = 7;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += operation_Click;
            // 
            // four
            // 
            four.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            four.BackColor = Color.Cornsilk;
            four.Font = new Font("Segoe UI", 20F);
            four.Location = new Point(3, 303);
            four.Name = "four";
            four.Size = new Size(172, 94);
            four.TabIndex = 10;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += number_Click;
            // 
            // five
            // 
            five.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            five.BackColor = Color.Cornsilk;
            five.Font = new Font("Segoe UI", 20F);
            five.Location = new Point(181, 303);
            five.Name = "five";
            five.Size = new Size(172, 94);
            five.TabIndex = 9;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += number_Click;
            // 
            // six
            // 
            six.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            six.BackColor = Color.Cornsilk;
            six.Font = new Font("Segoe UI", 20F);
            six.Location = new Point(359, 303);
            six.Name = "six";
            six.Size = new Size(172, 94);
            six.TabIndex = 12;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += number_Click;
            // 
            // subtract
            // 
            subtract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subtract.BackColor = Color.Cornsilk;
            subtract.Font = new Font("Segoe UI", 20F);
            subtract.Location = new Point(537, 303);
            subtract.Name = "subtract";
            subtract.Size = new Size(173, 94);
            subtract.TabIndex = 11;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += operation_Click;
            // 
            // one
            // 
            one.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            one.BackColor = Color.Cornsilk;
            one.Font = new Font("Segoe UI", 20F);
            one.Location = new Point(3, 403);
            one.Name = "one";
            one.Size = new Size(172, 94);
            one.TabIndex = 14;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += number_Click;
            // 
            // three
            // 
            three.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            three.BackColor = Color.Cornsilk;
            three.Font = new Font("Segoe UI", 20F);
            three.Location = new Point(359, 403);
            three.Name = "three";
            three.Size = new Size(172, 94);
            three.TabIndex = 16;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += number_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            add.BackColor = Color.Cornsilk;
            add.Font = new Font("Segoe UI", 20F);
            add.Location = new Point(537, 403);
            add.Name = "add";
            add.Size = new Size(173, 94);
            add.TabIndex = 15;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += operation_Click;
            // 
            // clear
            // 
            clear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clear.AutoSize = true;
            clear.BackColor = Color.Cornsilk;
            clear.Font = new Font("Segoe UI", 20F);
            clear.Location = new Point(3, 103);
            clear.Name = "clear";
            clear.Size = new Size(172, 94);
            clear.TabIndex = 0;
            clear.Text = "C\r\n";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // two
            // 
            two.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            two.BackColor = Color.Cornsilk;
            two.Font = new Font("Segoe UI", 20F);
            two.Location = new Point(181, 403);
            two.Name = "two";
            two.Size = new Size(172, 94);
            two.TabIndex = 13;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += number_Click;
            // 
            // display
            // 
            display.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            display.BackColor = Color.DarkOliveGreen;
            display.Font = new Font("Segoe UI", 45F);
            display.Location = new Point(15, 26);
            display.Name = "display";
            display.Size = new Size(707, 117);
            display.TabIndex = 0;
            display.Text = "0";
            display.TextAlign = ContentAlignment.MiddleRight;
            display.TextChanged += Display_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(731, 787);
            Controls.Add(display);
            Controls.Add(NumbersLayout);
            MinimumSize = new Size(500, 800);
            Name = "Form1";
            Text = "Calculator";
            NumbersLayout.ResumeLayout(false);
            NumbersLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel NumbersLayout;
        private Button clear;
        private Button percent;
        private Button back;
        private Button equals;
        private Button divide;
        private Button seven;
        private Button eight;
        private Button dot;
        private Button zero;
        private Button nine;
        private Button multiply;
        private Button four;
        private Button five;
        private Button six;
        private Button subtract;
        private Button one;
        private Button two;
        private Button three;
        private Button add;
        private Button bracketOpen;
        private Button bracketClose;
        private Label display;
    }
}
