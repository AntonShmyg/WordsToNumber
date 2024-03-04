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
            string nul = "ноль";
            string[] units = new string[9] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] array_11_19 = new string[9] { "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] tens = new string[9] { "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] hundreds = new string[9] { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
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
                    case "ноль":
                        result += "0";
                        break;
                    case "один":
                        result += "1";
                        break;
                    case "два":
                        result += "2";
                        break;
                    case "три":
                        result += "3";
                        break;
                    case "четыре":
                        result += "4";
                        break;
                    case "пять":
                        result += "5";
                        break;
                    case "шесть":
                        result += "6";
                        break;
                    case "семь":
                        result += "7";
                        break;
                    case "восемь":
                        result += "8";
                        break;
                    case "девять":
                        result += "9";
                        break;
                    case "одиннадцать":
                        result += "11";
                        break;
                    case "двенадцать":
                        result += "12";
                        break;
                    case "тринадцать":
                        result += "13";
                        break;
                    case "четырнадцать":
                        result += "14";
                        break;
                    case "пятнадцать":
                        result += "15";
                        break;
                    case "шестнадцать":
                        result += "16";
                        break;
                    case "семнадцать":
                        result += "17";
                        break;
                    case "восемнадцать":
                        result += "18";
                        break;
                    case "девятнадцать":
                        result += "19";
                        break;
                    case "десять":
                        result += "10";
                        break;
                    case "двадцать":
                        result += "20";
                        break;
                    case "тридцать":
                        result += "30";
                        break;
                    case "сорок":
                        result += "40";
                        break;
                    case "пятьдесят":
                        result += "50";
                        break;
                    case "шестьдесят":
                        result += "60";
                        break;
                    case "семьдесят":
                        result += "70";
                        break;
                    case "восемьдесят":
                        result += "80";
                        break;
                    case "девяносто":
                        result += "90";
                        break;
                    case "сто":
                        result += "100";
                        break;
                    case "двести":
                        result += "200";
                        break;
                    case "триста":
                        result += "300";
                        break;
                    case "четыреста":
                        result += "400";
                        break;
                    case "пятьсот":
                        result += "500";
                        break;
                    case "шестьсот":
                        result += "600";
                        break;
                    case "семьсот":
                        result += "700";
                        break;
                    case "восемьсот":
                        result += "800";
                        break;
                    case "девятьсот":
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
                        case "двадцать":
                            result += "2";
                            break;
                        case "тридцать":
                            result += "3";
                            break;
                        case "сорок":
                            result += "4";
                            break;
                        case "пятьдесят":
                            result += "5";
                            break;
                        case "шестьдесят":
                            result += "6";
                            break;
                        case "семьдесят":
                            result += "7";
                            break;
                        case "восемьдесят":
                            result += "8";
                            break;
                        case "девяносто":
                            result += "9";
                            break;
                        case "сто":
                            result += "10";
                            break;
                        case "двести":
                            result += "20";
                            break;
                        case "триста":
                            result += "30";
                            break;
                        case "четыреста":
                            result += "40";
                            break;
                        case "пятьсот":
                            result += "50";
                            break;
                        case "шестьсот":
                            result += "60";
                            break;
                        case "семьсот":
                            result += "70";
                            break;
                        case "восемьсот":
                            result += "80";
                            break;
                        case "девятьсот":
                            result += "90";
                            break;
                    }
                }
                else
                {
                    switch (value)
                    {
                        case "двадцать":
                            result += "2";
                            break;
                        case "тридцать":
                            result += "3";
                            break;
                        case "сорок":
                            result += "4";
                            break;
                        case "пятьдесят":
                            result += "5";
                            break;
                        case "шестьдесят":
                            result += "6";
                            break;
                        case "семьдесят":
                            result += "7";
                            break;
                        case "восемьдесят":
                            result += "8";
                            break;
                        case "девяносто":
                            result += "9";
                            break;
                        case "сто":
                            result += "1";
                            break;
                        case "двести":
                            result += "2";
                            break;
                        case "триста":
                            result += "3";
                            break;
                        case "четыреста":
                            result += "4";
                            break;
                        case "пятьсот":
                            result += "5";
                            break;
                        case "шестьсот":
                            result += "6";
                            break;
                        case "семьсот":
                            result += "7";
                            break;
                        case "восемьсот":
                            result += "8";
                            break;
                        case "девятьсот":
                            result += "9";
                            break;
                    }
                }

                string value1 = wordsInLine1[1];
                switch (value1)
                {
                    case "один":
                        result += "1";
                        break;
                    case "два":
                        result += "2";
                        break;
                    case "три":
                        result += "3";
                        break;
                    case "четыре":
                        result += "4";
                        break;
                    case "пять":
                        result += "5";
                        break;
                    case "шесть":
                        result += "6";
                        break;
                    case "семь":
                        result += "7";
                        break;
                    case "восемь":
                        result += "8";
                        break;
                    case "девять":
                        result += "9";
                        break;
                    case "одиннадцать":
                        result += "11";
                        break;
                    case "двенадцать":
                        result += "12";
                        break;
                    case "тринадцать":
                        result += "13";
                        break;
                    case "четырнадцать":
                        result += "14";
                        break;
                    case "пятнадцать":
                        result += "15";
                        break;
                    case "шестнадцать":
                        result += "16";
                        break;
                    case "семнадцать":
                        result += "17";
                        break;
                    case "восемнадцать":
                        result += "18";
                        break;
                    case "девятнадцать":
                        result += "19";
                        break;
                    case "десять":
                        result += "10";
                        break;
                    case "двадцать":
                        result += "20";
                        break;
                    case "тридцать":
                        result += "30";
                        break;
                    case "сорок":
                        result += "40";
                        break;
                    case "пятьдесят":
                        result += "50";
                        break;
                    case "шестьдесят":
                        result += "60";
                        break;
                    case "семьдесят":
                        result += "70";
                        break;
                    case "восемьдесят":
                        result += "80";
                        break;
                    case "девяносто":
                        result += "90";
                        break;
                }
            }
            else if (wordsInLine1.Length == 3)
            {
                string value_1 = wordsInLine1[0];
                switch (value_1)
                {
                    case "сто":
                        result += "1";
                        break;
                    case "двести":
                        result += "2";
                        break;
                    case "триста":
                        result += "3";
                        break;
                    case "четыреста":
                        result += "4";
                        break;
                    case "пятьсот":
                        result += "5";
                        break;
                    case "шестьсот":
                        result += "6";
                        break;
                    case "семьсот":
                        result += "7";
                        break;
                    case "восемьсот":
                        result += "8";
                        break;
                    case "девятьсот":
                        result += "9";
                        break;
                }
                string value_2 = wordsInLine1[1];
                switch (value_2)
                {
                    case "двадцать":
                        result += "2";
                        break;
                    case "тридцать":
                        result += "3";
                        break;
                    case "сорок":
                        result += "4";
                        break;
                    case "пятьдесят":
                        result += "5";
                        break;
                    case "шестьдесят":
                        result += "6";
                        break;
                    case "семьдесят":
                        result += "7";
                        break;
                    case "восемьдесят":
                        result += "8";
                        break;
                    case "девяносто":
                        result += "9";
                        break;
                }
                string value_3 = wordsInLine1[2];
                switch (value_3)
                {
                    case "один":
                        result += "1";
                        break;
                    case "два":
                        result += "2";
                        break;
                    case "три":
                        result += "3";
                        break;
                    case "четыре":
                        result += "4";
                        break;
                    case "пять":
                        result += "5";
                        break;
                    case "шесть":
                        result += "6";
                        break;
                    case "семь":
                        result += "7";
                        break;
                    case "восемь":
                        result += "8";
                        break;
                    case "девять":
                        result += "9";
                        break;
                }
            }
            else if (wordsInLine1.Length > 3)
            {
                textBox2.Text = "Такого числа не существует или оно не входит в диапазон.\n";
            }

            for (int i = 0; i < wordsInLine1.Length; i++)
            {
                if (!(units.Contains(wordsInLine1[i])) && !(array_11_19.Contains(wordsInLine1[i])) && !(tens.Contains(wordsInLine1[i])) && !(hundreds.Contains(wordsInLine1[i])) && (wordsInLine1[i] != nul))
                {
                    textBox2.Text += $"Неправильное слово: {wordsInLine1[i]}.\r\n";
                }

                if (wordsInLine1[i] == nul)
                {
                    if (i - 1 > -1)
                    {
                        if (units.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"Перед числом \"ноль\" не может стоять число единичного формата.\r\n";
                        }
                        else if (array_11_19.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"Перед числом \"ноль\" не может стоять число формата 11-19.\r\n";
                        }
                        else if (tens.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"Перед числом \"ноль\" не может стоять число десятичного формата.\r\n";
                        }
                        else if (hundreds.Contains(wordsInLine1[i - 1]))
                        {
                            textBox2.Text += $"Перед числом \"ноль\" не может стоять число формата сотен.\r\n";
                        }
                    }
                    if (i + 1 < wordsInLine1.Length)
                    {
                        if (units.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"После числа \"ноль\" не может стоять число единичного формата.\r\n";
                        }
                        else if (array_11_19.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"После числа \"ноль\" не может стоять число формата 11-19.\r\n";
                        }
                        else if (tens.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"После числа \"ноль\" не может стоять число десятичного формата.\r\n";
                        }
                        else if (hundreds.Contains(wordsInLine1[i + 1]))
                        {
                            textBox2.Text += $"После числа \"ноль\" не может стоять число формата сотен.\r\n";
                        }
                    }
                }
                if (i - 1 > -1)
                {
                    if ((wordsInLine1[i] == wordsInLine1[i - 1]) && (wordsInLine1[i] == nul))
                    {
                        textBox2.Text += $"Не могут стоять два нуля.\r\n";
                    }
                    if (units.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не могут стоять два числа единичного формата.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не могут стоять два числа формата 11-19.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не могут стоять два числа десятичного формата.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && hundreds.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не могут стоять два числа формата сотен.\r\n";
                    }
                    if (units.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число формата 11-19 перед числом единичного формата.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число единичного формата перед числом формата 11-19.\r\n";
                    }
                    if (array_11_19.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число десятичного формата перед числом формата 11 - 19.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число единичного формата перед числом десятичного формата.\r\n";
                    }
                    if (tens.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число формата 11-19 перед числом десятичного формата.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && units.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число единичного формата перед числом формата сотен.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && array_11_19.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число формата 11-19 перед числом формата сотен.\r\n";
                    }
                    if (hundreds.Contains(wordsInLine1[i]) && tens.Contains(wordsInLine1[i - 1]))
                    {
                        textBox2.Text += $"Не может стоять число десятичного формата перед числом формата сотен.\r\n";
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




