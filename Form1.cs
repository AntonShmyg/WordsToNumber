namespace WordsToNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nul = "����";
            string[] units = new string[9] { "����", "���", "���", "������", "����", "�����", "����", "������", "������" };
            string[] array_11_19 = new string[9] { "�����������", "����������", "����������", "������������", "����������", "�����������", "����������", "������������", "������������" };
            string[] tens = new string[9] { "������", "��������", "��������", "�����", "���������", "����������", "���������", "�����������", "���������" };
            string[] hundreds = new string[9] { "���", "������", "������", "���������", "�������", "��������", "�������", "���������", "���������" };
            String line1 = textBox1.Text;
            String[] wordsInLine1 = line1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            textBox2.Text = "";
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            if (wordsInLine1.Length == 1)
            {
                string value = wordsInLine1[0];

                switch (value)
                {
                    case "����":
                        result += "0";
                        break;
                    case "����":
                        result += "1";
                        break;
                    case "���":
                        result += "2";
                        break;
                    case "���":
                        result += "3";
                        break;
                    case "������":
                        result += "4";
                        break;
                    case "����":
                        result += "5";
                        break;
                    case "�����":
                        result += "6";
                        break;
                    case "����":
                        result += "7";
                        break;
                    case "������":
                        result += "8";
                        break;
                    case "������":
                        result += "9";
                        break;
                    case "�����������":
                        result += "11";
                        break;
                    case "����������":
                        result += "12";
                        break;
                    case "����������":
                        result += "13";
                        break;
                    case "������������":
                        result += "14";
                        break;
                    case "����������":
                        result += "15";
                        break;
                    case "�����������":
                        result += "16";
                        break;
                    case "����������":
                        result += "17";
                        break;
                    case "������������":
                        result += "18";
                        break;
                    case "������������":
                        result += "19";
                        break;
                    case "������":
                        result += "10";
                        break;
                    case "��������":
                        result += "20";
                        break;
                    case "��������":
                        result += "30";
                        break;
                    case "�����":
                        result += "40";
                        break;
                    case "���������":
                        result += "50";
                        break;
                    case "����������":
                        result += "60";
                        break;
                    case "���������":
                        result += "70";
                        break;
                    case "�����������":
                        result += "80";
                        break;
                    case "���������":
                        result += "90";
                        break;
                    case "���":
                        result += "100";
                        break;
                    case "������":
                        result += "200";
                        break;
                    case "������":
                        result += "300";
                        break;
                    case "���������":
                        result += "400";
                        break;
                    case "�������":
                        result += "500";
                        break;
                    case "��������":
                        result += "600";
                        break;
                    case "�������":
                        result += "700";
                        break;
                    case "���������":
                        result += "800";
                        break;
                    case "���������":
                        result += "900";
                        break;
                }
            }
            else if (wordsInLine1.Length == 2)
            {
                string value = wordsInLine1[0];

                if (units.Contains(wordsInLine1[1]))
                {
                    switch (value)
                    {
                        case "��������":
                            result += "2";
                            break;
                        case "��������":
                            result += "3";
                            break;
                        case "�����":
                            result += "4";
                            break;
                        case "���������":
                            result += "5";
                            break;
                        case "����������":
                            result += "6";
                            break;
                        case "���������":
                            result += "7";
                            break;
                        case "�����������":
                            result += "8";
                            break;
                        case "���������":
                            result += "9";
                            break;
                        case "���":
                            result += "10";
                            break;
                        case "������":
                            result += "20";
                            break;
                        case "������":
                            result += "30";
                            break;
                        case "���������":
                            result += "40";
                            break;
                        case "�������":
                            result += "50";
                            break;
                        case "��������":
                            result += "60";
                            break;
                        case "�������":
                            result += "70";
                            break;
                        case "���������":
                            result += "80";
                            break;
                        case "���������":
                            result += "90";
                            break;
                    }
                }
                else
                {
                    switch (value)
                    {
                        case "��������":
                            result += "2";
                            break;
                        case "��������":
                            result += "3";
                            break;
                        case "�����":
                            result += "4";
                            break;
                        case "���������":
                            result += "5";
                            break;
                        case "����������":
                            result += "6";
                            break;
                        case "���������":
                            result += "7";
                            break;
                        case "�����������":
                            result += "8";
                            break;
                        case "���������":
                            result += "9";
                            break;
                        case "���":
                            result += "1";
                            break;
                        case "������":
                            result += "2";
                            break;
                        case "������":
                            result += "3";
                            break;
                        case "���������":
                            result += "4";
                            break;
                        case "�������":
                            result += "5";
                            break;
                        case "��������":
                            result += "6";
                            break;
                        case "�������":
                            result += "7";
                            break;
                        case "���������":
                            result += "8";
                            break;
                        case "���������":
                            result += "9";
                            break;
                    }
                }

                string value1 = wordsInLine1[1];
                switch (value1)
                {
                    case "����":
                        result += "1";
                        break;
                    case "���":
                        result += "2";
                        break;
                    case "���":
                        result += "3";
                        break;
                    case "������":
                        result += "4";
                        break;
                    case "����":
                        result += "5";
                        break;
                    case "�����":
                        result += "6";
                        break;
                    case "����":
                        result += "7";
                        break;
                    case "������":
                        result += "8";
                        break;
                    case "������":
                        result += "9";
                        break;
                    case "�����������":
                        result += "11";
                        break;
                    case "����������":
                        result += "12";
                        break;
                    case "����������":
                        result += "13";
                        break;
                    case "������������":
                        result += "14";
                        break;
                    case "����������":
                        result += "15";
                        break;
                    case "�����������":
                        result += "16";
                        break;
                    case "����������":
                        result += "17";
                        break;
                    case "������������":
                        result += "18";
                        break;
                    case "������������":
                        result += "19";
                        break;
                    case "������":
                        result += "10";
                        break;
                    case "��������":
                        result += "20";
                        break;
                    case "��������":
                        result += "30";
                        break;
                    case "�����":
                        result += "40";
                        break;
                    case "���������":
                        result += "50";
                        break;
                    case "����������":
                        result += "60";
                        break;
                    case "���������":
                        result += "70";
                        break;
                    case "�����������":
                        result += "80";
                        break;
                    case "���������":
                        result += "90";
                        break;
                }
            }
            else if (wordsInLine1.Length == 3)
            {
                string value_1 = wordsInLine1[0];
                switch (value_1)
                {
                    case "���":
                        result += "1";
                        break;
                    case "������":
                        result += "2";
                        break;
                    case "������":
                        result += "3";
                        break;
                    case "���������":
                        result += "4";
                        break;
                    case "�������":
                        result += "5";
                        break;
                    case "��������":
                        result += "6";
                        break;
                    case "�������":
                        result += "7";
                        break;
                    case "���������":
                        result += "8";
                        break;
                    case "���������":
                        result += "9";
                        break;
                }
                string value_2 = wordsInLine1[1];
                switch (value_2)
                {
                    case "��������":
                        result += "2";
                        break;
                    case "��������":
                        result += "3";
                        break;
                    case "�����":
                        result += "4";
                        break;
                    case "���������":
                        result += "5";
                        break;
                    case "����������":
                        result += "6";
                        break;
                    case "���������":
                        result += "7";
                        break;
                    case "�����������":
                        result += "8";
                        break;
                    case "���������":
                        result += "9";
                        break;
                }
                string value_3 = wordsInLine1[2];
                switch (value_3)
                {
                    case "����":
                        result += "1";
                        break;
                    case "���":
                        result += "2";
                        break;
                    case "���":
                        result += "3";
                        break;
                    case "������":
                        result += "4";
                        break;
                    case "����":
                        result += "5";
                        break;
                    case "�����":
                        result += "6";
                        break;
                    case "����":
                        result += "7";
                        break;
                    case "������":
                        result += "8";
                        break;
                    case "������":
                        result += "9";
                        break;
                }
            }
            else if (wordsInLine1.Length > 3)
            {
                textBox2.Text = "������ ����� �� ���������� ��� ��� �� ������ � ��������.\n";
            }

            for (int i = 0; i < wordsInLine1.Length; i++)
            {
                if (!(units.Contains(wordsInLine1[i])) && !(array_11_19.Contains(wordsInLine1[i])) && !(tens.Contains(wordsInLine1[i])) && !(hundreds.Contains(wordsInLine1[i])) && (wordsInLine1[i] != nul))
                {
                    textBox2.Text += $"������������ �����: {wordsInLine1[i]}.\r\n";
                }

                if (wordsInLine1[i] == nul)
                {
                    if (i - 1 > -1)
                    {
                        if (units.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"����� ������ \"����\" �� ����� ������ ����� ���������� �������.\r\n";
                        }
                        else if (array_11_19.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"����� ������ \"����\" �� ����� ������ ����� ������� 11-19.\r\n";
                        }
                        else if (tens.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"����� ������ \"����\" �� ����� ������ ����� ����������� �������.\r\n";
                        }
                        else if (hundreds.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"����� ������ \"����\" �� ����� ������ ����� ������� �����.\r\n";
                        }
                    }
                    if (i + 1 < wordsInLine1.Length)
                    {
                        if (units.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"����� ����� \"����\" �� ����� ������ ����� ���������� �������.\r\n";
                        }
                        else if (array_11_19.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"����� ����� \"����\" �� ����� ������ ����� ������� 11-19.\r\n";
                        }
                        else if (tens.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"����� ����� \"����\" �� ����� ������ ����� ����������� �������.\r\n";
                        }
                        else if (hundreds.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"����� ����� \"����\" �� ����� ������ ����� ������� �����.\r\n";
                        }
                    }
                }
                if (i - 1 > -1)
                {
                    if ((wordsInLine1[i] == wordsInLine1[i - 1]) && (wordsInLine1[i] == nul))
                    {
                        textBox2.Text += $"�� ����� ������ ��� ����.\r\n";
                    }
                    if (units.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ��� ����� ���������� �������.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ��� ����� ������� 11-19.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ��� ����� ����������� �������.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && hundreds.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ��� ����� ������� �����.\r\n";
                    }
                    if (units.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ������� 11-19 ����� ������ ���������� �������.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ���������� ������� ����� ������ ������� 11-19.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ����������� ������� ����� ������ ������� 11 - 19.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ���������� ������� ����� ������ ����������� �������.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ������� 11-19 ����� ������ ����������� �������.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ���������� ������� ����� ������ ������� �����.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ������� 11-19 ����� ������ ������� �����.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"�� ����� ������ ����� ����������� ������� ����� ������ ������� �����.\r\n";
                    }
                }
            }
            if (textBox2.Text == "")
            {
                string res = string.Join("", result);
                textBox2.Text = res;
            }
        }
    }
}




