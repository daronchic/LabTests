using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int[] uArray;
        public string[] uArrayF;
        public int uSize;
        string ThData; //Переменная для времени
        string ThTime; //Переменная для даты
        int state;
        DateTime ThToday = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) //Выбираем режим "Создание массива"
        {
            groupBox1.Text = "Создание Массива";
            ManualInput.Visible = true;
            button4.Text = "Создать";
            button4.Visible = true;
            HelpMessage.Visible = false;
            state = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //Выбираем режим "Загрузка массива"
        {
            groupBox1.Text = "Загрузка Массива";
            ManualInput.Visible = true;
            button4.Text = "Загрузить";
            button4.Visible = true;
            HelpMessage.Visible = true;
            output.Visible = false;
            state = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

                string s = ManualInput.Text;
                string[] arrstring;
                switch (state)
                {
                    case 0:
                        s = ManualInput.Text;
                        arrstring = new string[1];
                        if (s != "")
                        {
                            arrstring = s.Split(' ');
                        }
                        uArray = new int[arrstring.Length];
                        try
                        {
                            for (int i = 0; i < arrstring.Length; i++)
                            {
                                uArray[i] = Convert.ToInt32(arrstring[i]);
                            }
                            toolStripStatusLabel1.Text = "Массив успешно создан! Размер " + uArray.Length;
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Неверные данные, повторите ввод!");
                            toolStripStatusLabel1.Text = "При создании массива возникли ошибки";
                        }
                        break;
                    case 1:
                        if (loadData())
                        {
                            s = ManualInput.Text;
                            arrstring = new string[1];
                            if (s != "")
                            {
                                arrstring = s.Split(' ');
                            }
                            uArray = new int[arrstring.Length];
                            try
                            {
                                for (int i = 0; i < arrstring.Length; i++)
                                {
                                    uArray[i] = Convert.ToInt32(arrstring[i]);
                                }
                                toolStripStatusLabel1.Text = "Массив успешно создан! Размер " + uArray.Length;
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show("Неверные данные, повторите ввод!");
                                toolStripStatusLabel1.Text = "При создании массива возникли ошибки";
                            }
                        }
                        else
                        {
                            break;
                        }
                        break;

                    default:

                        break;
                }

            
        } //Выполнение задания. При нажатии будет выведен результат

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                HelpMessage.Visible = false;
                //1 Анализ массива, выявление наличия четных элементов
                //  прохождим по массиву
                //  если модуль от деления на два равен нулю то
                //               запоминаем его значение
                //               прибавляем к каждому последующему четному числу
                //               иначе выполняем операцию замены чисел на знак $
                if (uArray.Length > 1)
                {
                    output.ResetText();
                    output.Visible = true;
                    int temp = 1;
                    for (int i = 0; i < uArray.Length; i++)
                    {
                        if (uArray[i] % 2 == 0 && temp == 1)
                        {
                            temp = uArray[i];
                        }
                        else if (uArray[i] % 2 == 0 && temp != 1)
                        {
                            uArray[i] += temp;
                        }
                    }
                    if (temp == 1) //Четных чисел нет, заменяем на доллар!
                    {
                        uArrayF = new string[uArray.Length];
                        for (int i = 0; i < uArray.Length; i++)
                        {
                            uArrayF[i] = "$";
                            output.Text = output.Text + uArrayF[i] + " ";
                        }
                    }
                    else // Четные были, выводим массив!
                    {
                        for (int i = 0; i < uArray.Length; i++)
                            output.Text = output.Text + uArray[i] + " ";
                    }
                    toolStripStatusLabel1.Text = "Выполнено!";
                    fileOutput();
                }
                else
                {
                    toolStripStatusLabel1.Text = "Безсмысленная операция, пересоздайте массив и пересмотрите свои взгляды на жизнь...";
                }
            }
            catch (Exception a)
            {
                toolStripStatusLabel1.Text = "Глупо работать с несуществующим массивом...";
            }

        }

        void fileOutput() // Сохраняем результаты в файл, при этом старые выводы не затираются.
        {
            if (checkBox1.Checked)
            {

                
                ThData = ThToday.Date.ToLongDateString();
                ThTime = ThToday.ToLocalTime().ToShortTimeString();

                StreamWriter write_text;  //Класс для записи в файл
                FileInfo file = new FileInfo("output.txt");
                write_text = file.AppendText(); //Дописываем инфу в файл, если файла не существует он создастся
                write_text.WriteLine("Results");
                write_text.WriteLine(ThData + " " + ThTime);
                write_text.WriteLine("-----------------------------");
                write_text.WriteLine("Source array: ");
                write_text.WriteLine(ManualInput.Text);
                write_text.WriteLine("Output array: ");
                write_text.WriteLine(output.Text); //Записываем в файл текст из текстового поля
                write_text.WriteLine("-----------------------------");
                write_text.Close(); // Закрываем файл
                toolStripStatusLabel1.Text = toolStripStatusLabel1.Text + " результаты выведены в файл!";
            }
        }
        bool loadData() // Загрузка данных из файла
        {
            try
            {
                StreamReader streamReader = new StreamReader("Array.txt"); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла

                while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                {
                    str += streamReader.ReadLine(); //В переменную str по строчно записываем содержимое файла
                }

                ManualInput.Text = str;
                toolStripStatusLabel1.Text = "Данные успешно загружены!";
                return true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Файл не существует!");
                toolStripStatusLabel1.Text = "Файл не существует, создайте файл с именем Array.txt";
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Text = "Опции";
        }


    }
}

