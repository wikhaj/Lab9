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
        string info1 = "Zobowi¹zujê/zobowi¹zujemy siê samodzielnie wykonaæ pracê w zakresie wyspecyfikowanym ni¿ej. Wszystkie elementy (m.in. rysunki, tabele, cytaty, programy komputerowe, urz¹dzenia itp.), które zostan¹ wykorzystane w pracy, a nie bêd¹ mojego/naszego autorstwa bêd¹ w odpowiedni sposób zaznaczone i bêdzie podane Ÿród³o ich pochodzenia. \r\n\nJe¿eli w wyniku realizacji pracy zostanie dokonany wynalazek, wzór u¿ytkowy, wzór przemys³owy, znak towarowy, prawa do rozwi¹zañ przys³ugiwaæ bêd¹ Politechnice Poznañskiej. Prawo to zostanie uregulowane odrêbn¹ umow¹.\r\nOœwiadczam, i¿ o wyniku prac wskazanych powy¿ej, a tak¿e o innych, w tym tych, które mog¹ byæ przedmiotem tajemnicy Politechniki Poznañskiej, niezw³ocznie powiadomiê promotora pracy.\r\nZobowi¹zujê siê ponadto do zachowania w tajemnicy wszystkich informacji technicznych, technologicznych, organizacyjnych, uzyskanych w Politechnice Poznañskiej w okresie od daty rozpoczêcia realizacji prac do 5 lat od daty zakoñczenia wykonania prac";
        
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