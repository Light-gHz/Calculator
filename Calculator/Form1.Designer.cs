namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_C = new System.Windows.Forms.Button();
            this.button_degree = new System.Windows.Forms.Button();
            this.button_putaway = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.button_bracket1 = new System.Windows.Forms.Button();
            this.button_bracket2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(367, -1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(39, 37);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_result.Location = new System.Drawing.Point(12, 9);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(381, 168);
            this.label_result.TabIndex = 1;
            this.label_result.Text = "0";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button_C
            // 
            this.button_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_C.Location = new System.Drawing.Point(22, 180);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(181, 61);
            this.button_C.TabIndex = 2;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_degree
            // 
            this.button_degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_degree.Location = new System.Drawing.Point(23, 247);
            this.button_degree.Name = "button_degree";
            this.button_degree.Size = new System.Drawing.Size(87, 61);
            this.button_degree.TabIndex = 3;
            this.button_degree.Text = "^";
            this.button_degree.UseVisualStyleBackColor = true;
            this.button_degree.Click += new System.EventHandler(this.button_sing_Click);
            // 
            // button_putaway
            // 
            this.button_putaway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_putaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_putaway.Location = new System.Drawing.Point(209, 180);
            this.button_putaway.Name = "button_putaway";
            this.button_putaway.Size = new System.Drawing.Size(180, 61);
            this.button_putaway.TabIndex = 4;
            this.button_putaway.Text = "<=]";
            this.button_putaway.UseVisualStyleBackColor = true;
            this.button_putaway.Click += new System.EventHandler(this.button_putaway_Click);
            // 
            // button_division
            // 
            this.button_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_division.Location = new System.Drawing.Point(302, 247);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(87, 61);
            this.button_division.TabIndex = 5;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_sing_Click);
            // 
            // button_7
            // 
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.Location = new System.Drawing.Point(23, 314);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(87, 61);
            this.button_7.TabIndex = 6;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.number_Click);
            // 
            // button_8
            // 
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.Location = new System.Drawing.Point(116, 314);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(87, 61);
            this.button_8.TabIndex = 7;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.number_Click);
            // 
            // button_9
            // 
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.Location = new System.Drawing.Point(209, 314);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(87, 61);
            this.button_9.TabIndex = 8;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.number_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Location = new System.Drawing.Point(302, 314);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(87, 61);
            this.button_multiply.TabIndex = 9;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_sing_Click);
            // 
            // button_4
            // 
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.Location = new System.Drawing.Point(23, 381);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(87, 61);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.number_Click);
            // 
            // button_5
            // 
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(116, 381);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(87, 61);
            this.button_5.TabIndex = 11;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.number_Click);
            // 
            // button_6
            // 
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.Location = new System.Drawing.Point(209, 381);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(87, 61);
            this.button_6.TabIndex = 12;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.number_Click);
            // 
            // button_minus
            // 
            this.button_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(302, 381);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(87, 61);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_1
            // 
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.Location = new System.Drawing.Point(23, 448);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(87, 61);
            this.button_1.TabIndex = 14;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.number_Click);
            // 
            // button_2
            // 
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.Location = new System.Drawing.Point(116, 448);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(87, 61);
            this.button_2.TabIndex = 15;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.number_Click);
            // 
            // button_3
            // 
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.Location = new System.Drawing.Point(209, 448);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(87, 61);
            this.button_3.TabIndex = 16;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.number_Click);
            // 
            // button_plus
            // 
            this.button_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(302, 448);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(87, 61);
            this.button_plus.TabIndex = 17;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_sing_Click);
            // 
            // button_0
            // 
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_0.Location = new System.Drawing.Point(23, 515);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(180, 61);
            this.button_0.TabIndex = 19;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.number_Click);
            // 
            // button_point
            // 
            this.button_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_point.Location = new System.Drawing.Point(209, 515);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(87, 61);
            this.button_point.TabIndex = 20;
            this.button_point.Text = ",";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_equals.Location = new System.Drawing.Point(302, 515);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(87, 61);
            this.button_equals.TabIndex = 21;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            this.button_equals.Click += new System.EventHandler(this.button_equals_Click);
            // 
            // button_bracket1
            // 
            this.button_bracket1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bracket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bracket1.Location = new System.Drawing.Point(116, 247);
            this.button_bracket1.Name = "button_bracket1";
            this.button_bracket1.Size = new System.Drawing.Size(87, 61);
            this.button_bracket1.TabIndex = 22;
            this.button_bracket1.Text = "(";
            this.button_bracket1.UseVisualStyleBackColor = true;
            this.button_bracket1.Click += new System.EventHandler(this.button_bracket1_Click);
            // 
            // button_bracket2
            // 
            this.button_bracket2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bracket2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bracket2.Location = new System.Drawing.Point(209, 247);
            this.button_bracket2.Name = "button_bracket2";
            this.button_bracket2.Size = new System.Drawing.Size(87, 61);
            this.button_bracket2.TabIndex = 23;
            this.button_bracket2.Text = ")";
            this.button_bracket2.UseVisualStyleBackColor = true;
            this.button_bracket2.Click += new System.EventHandler(this.button_bracket2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 592);
            this.Controls.Add(this.button_bracket2);
            this.Controls.Add(this.button_bracket1);
            this.Controls.Add(this.button_equals);
            this.Controls.Add(this.button_point);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_putaway);
            this.Controls.Add(this.button_degree);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_degree;
        private System.Windows.Forms.Button button_putaway;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Button button_bracket1;
        private System.Windows.Forms.Button button_bracket2;
    }
}

