using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (label_result.Text == "0")
            {
                label_result.Text = button.Text;
            }
            else
            {
                label_result.Text += button.Text;
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            label_result.Text = "0";
        }
        private void button_sing_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position_last = label_result.Text.Length - 1;
            if (((label_result.Text[position_last] >= '0') && (label_result.Text[position_last] <= '9')) || 
                (label_result.Text[position_last] == ')'))
            {
                label_result.Text += button.Text;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position_last = label_result.Text.Length - 1;
            if (((label_result.Text[position_last] >= '0') && (label_result.Text[position_last] <= '9')) ||
                (label_result.Text[position_last] == ')') ||
                (label_result.Text[position_last] == '('))
            {
                if (label_result.Text == "0")
                {
                    label_result.Text = button.Text;
                }
                else
                {
                    label_result.Text += button.Text;
                }
            } 
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position_last = label_result.Text.Length - 1;
            int count_point = 0;
            for (int i = 0; i < label_result.Text.Length; i++)
            {
                if(((label_result.Text[i] >= '0') && (label_result.Text[i] <= '9')) || 
                    label_result.Text[i] == ',')
                {
                    if (label_result.Text[i] == ',')
                    {
                        count_point++;
                    }
                }
                else
                {
                    count_point = 0;
                }

            }
            if ((label_result.Text[position_last] >= '0') && 
                (label_result.Text[position_last] <= '9') && 
                count_point != 1)
            {
                label_result.Text += button.Text;
            }
        }

        private void button_bracket1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position_last = label_result.Text.Length - 1;
            if (label_result.Text == "0")
            {
                label_result.Text = button.Text;
            }
            else
            {
                if (label_result.Text[position_last] == '+' || 
                    label_result.Text[position_last] == '-' || 
                    label_result.Text[position_last] == '*' || 
                    label_result.Text[position_last] == '/')
                {
                    label_result.Text += button.Text;
                }
            }
        }

        private void button_bracket2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int position_last = label_result.Text.Length - 1;
            int count_bracket1 = 0;
            int count_bracket2 = 0;
            for (int i = 0; i < label_result.Text.Length; i++)
            {
                if (label_result.Text[i] == '(')
                {
                    count_bracket1++;
                }
                if (label_result.Text[i] == ')')
                {
                    count_bracket2++;
                }
            }
            if (label_result.Text != "0")
            {
                if ((label_result.Text[position_last] >= '0') && 
                    (label_result.Text[position_last] <= '9') && 
                    (count_bracket1 - count_bracket2 >= 1))
                {
                    label_result.Text += button.Text;
                }
            }
        }

        private void button_putaway_Click(object sender, EventArgs e)
        {
            int position_last = label_result.Text.Length - 1;
            label_result.Text = label_result.Text.Remove(position_last);
            if (label_result.Text.Length == 0)
            {
                label_result.Text = "0";
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            int position_last = label_result.Text.Length - 1;
            if (label_result.Text[position_last] == '+' ||
                label_result.Text[position_last] == '-' ||
                label_result.Text[position_last] == '*' || 
                label_result.Text[position_last] == '/' || 
                label_result.Text[position_last] == '^' || 
                label_result.Text[position_last] == ',')
            {
                label_result.Text = label_result.Text.Remove(position_last);
            }
            if (label_result.Text[position_last] == '(')
            {
                label_result.Text += '0';
            }
            int count_bracket1 = 0;
            int count_bracket2 = 0;
            for (int i = 0; i < label_result.Text.Length; i++) 
            {
                if (label_result.Text[i] == '(')
                {
                    count_bracket1++;
                }
                if (label_result.Text[i] == ')')
                {
                    count_bracket2++;
                }
            } 
            for (int i = count_bracket2; i < count_bracket1; i++)
            {
                label_result.Text += ')';
            }
            List<string> exampleRPN = WriteRPN(label_result.Text);
            label_result.Text = CountExample(exampleRPN);
        }
        private List<string> WriteRPN(string str)
        {
            str = " " + str + " ";
            List<string> new_str = new List<string>();
            Stack<char> sings = new Stack<char>();
            sings.Push('\0');
            string number = "";
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (((str[i] >= '0') && (str[i] <= '9')) || str[i] == ',')
                {
                    number += str[i];
                    if (((str[i + 1] < '0') || (str[i + 1] > '9')) && str[i + 1] != ',')
                    {
                        new_str.Add(number);
                        number = "";
                    }
                }
                else
                {
                    if ((sings.Peek() == '\0')&&(new_str.Count != 0))
                    {
                        sings.Push(str[i]);
                    }
                    else
                    {
                        if (str[i] == '-' || str[i] == '+')
                        {
                            if ((str[i] == '-') && ((str[i - 1] == '(') || (str[i - 1] == ' ')))
                            {
                                number += str[i];
                            }
                            else
                            {
                                while (sings.Peek() != '(' &&
                                       sings.Peek() != '\0')
                                {  
                                    new_str.Add(Convert.ToString(sings.Pop()));
                                }
                                sings.Push(str[i]);
                            }
                        }
                        if (str[i] == '/' || str[i] == '*')
                        {
                            while (sings.Peek() != '(' &&
                                   sings.Peek() != '\0'&&
                                   sings.Peek() != '+' &&
                                   sings.Peek() != '-')
                            {
                                new_str.Add(Convert.ToString(sings.Pop()));
                            }
                            sings.Push(str[i]);
                        }
                        if (str[i] == '^')
                        {
                            while (sings.Peek() != '(' &&
                                   sings.Peek() != '\0'&&
                                   sings.Peek() != '+' &&
                                   sings.Peek() != '-' &&
                                   sings.Peek() != '/' &&
                                   sings.Peek() != '*')
                            {
                                new_str.Add(Convert.ToString(sings.Pop()));
                            }
                            sings.Push(str[i]);
                        }
                        if (str[i] == '(')
                        {
                            sings.Push(str[i]);
                        }
                        if (str[i] == ')')
                        {
                            while (sings.Peek() != '(')
                            {
                                new_str.Add(Convert.ToString(sings.Pop()));
                            }
                            sings.Pop();
                        }
                    }
                }
            }
            while(sings.Peek() != '\0')
            {
                new_str.Add(Convert.ToString(sings.Pop()));
            }
            return new_str;
        }
        private string CountExample(List<string> list)
        {
            double Num;
            while(list.Count > 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == "+")
                    {
                        Num = Convert.ToDouble(list[i - 2]) + Convert.ToDouble(list[i - 1]);
                        list.RemoveAt(i - 1);
                        i--;
                        list.RemoveAt(i - 1);
                        i--;
                        list[i] = Convert.ToString(Num);
                        break;
                    }
                    if (list[i] == "-")
                    {
                        Num = Convert.ToDouble(list[i - 2]) - Convert.ToDouble(list[i - 1]);
                        list.RemoveAt(i - 1);
                        i--;
                        list.RemoveAt(i - 1);
                        i--;
                        list[i] = Convert.ToString(Num);
                        break;
                    }
                    if (list[i] == "*")
                    {
                        Num = Convert.ToDouble(list[i - 2]) * Convert.ToDouble(list[i - 1]);
                        list.RemoveAt(i - 1);
                        i--;
                        list.RemoveAt(i - 1);
                        i--;
                        list[i] = Convert.ToString(Num);
                        break;
                    }
                    if (list[i] == "/")
                    {
                        Num = Convert.ToDouble(list[i - 2]) / Convert.ToDouble(list[i - 1]);
                        list.RemoveAt(i - 1);
                        i--;
                        list.RemoveAt(i - 1);
                        i--;
                        list[i] = Convert.ToString(Num);
                        break;
                    }
                    if (list[i] == "^")
                    {
                        Num = Math.Pow(Convert.ToDouble(list[i - 2]) , Convert.ToDouble(list[i - 1]));
                        list.RemoveAt(i - 1);
                        i--;
                        list.RemoveAt(i - 1);
                        i--;
                        list[i] = Convert.ToString(Num);
                        break;
                    }
                }
            }
            string answer = list[0];
            if (answer.Length >= 13)
            {
                answer = answer.Remove(13);
            }
            return answer;
        }
    }
}
