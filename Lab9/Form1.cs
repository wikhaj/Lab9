using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Lab9
{
    public partial class Form1 : Form
    {
        List<String> text = new List<String>();
        string info1 = "Zobowi�zuj�/zobowi�zujemy si� samodzielnie wykona� prac� w zakresie wyspecyfikowanym ni�ej. Wszystkie elementy (m.in. rysunki, tabele, cytaty, programy komputerowe, urz�dzenia itp.), kt�re zostan� wykorzystane w pracy, a nie b�d� mojego/naszego autorstwa b�d� w odpowiedni spos�b zaznaczone i b�dzie podane �r�d�o ich pochodzenia. \r\n\nJe�eli w wyniku realizacji pracy zostanie dokonany wynalazek, wz�r u�ytkowy, wz�r przemys�owy, znak towarowy, prawa do rozwi�za� przys�ugiwa� b�d� Politechnice Pozna�skiej. Prawo to zostanie uregulowane odr�bn� umow�.\r\nO�wiadczam, i� o wyniku prac wskazanych powy�ej, a tak�e o innych, w tym tych, kt�re mog� by� przedmiotem tajemnicy Politechniki Pozna�skiej, niezw�ocznie powiadomi� promotora pracy.\r\nZobowi�zuj� si� ponadto do zachowania w tajemnicy wszystkich informacji technicznych, technologicznych, organizacyjnych, uzyskanych w Politechnice Pozna�skiej w okresie od daty rozpocz�cia realizacji prac do 5 lat od daty zako�czenia wykonania prac";
        
        public Form1()
        {
            InitializeComponent();
            header1.Text = "Karta\npracy dyplomowej ";
            info.Text = info1;
            timer.Interval = (10 * 1000);


            /*text = get_string_TextBoxes();
            *//*foreach (var item in text)
                MessageBox.Show("ok");*//*
            timer.Start();*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var regex_string = new Regex("^[a-zA-Z]*$");


            if (!regex_string.IsMatch(text_kierunek.Text)) 
            {
                MessageBox.Show("zle");
            }
        }
        public List<String> get_string_TextBoxes()
        {
            List<String> textBoxes = new List<String>();
            var regex_index = new Regex("text_index"+"^[0-9]*$").ToString;
            var regex_data = new Regex("text_data" + "^[0-9]*$").ToString;

            foreach (Control c in Controls)
            {

                TextBox box = c as TextBox;
                if (!String.Equals(box.Name,regex_index) || !String.Equals(box.Name, regex_data))
                {
                    textBoxes.Add(box.Name);
                }
                    
            }
            return textBoxes;
        }

        private void text_index2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }
    

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}