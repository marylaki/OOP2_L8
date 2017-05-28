using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;

namespace OOP_Laba_7
{
    public partial class Form2 : Form
    {
        public UNIVER u = new UNIVER();
        public UNIVER search = new UNIVER();
        public int index = 0;
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 parental;
        public Form2(Form1 parent)
        {
            this.parental = parent;
            InitializeComponent();
        }
        /*Поиск в зависимости от ранее вбраного пункта*/
        private void button1_Click(object sender, EventArgs e)
        {
           result.Rows.Clear();
            search.students.Clear();
            if (index==1)
            {
                foreach (var sdnt in u.students)
                {
                    String[] stnt = new String[9];
                    stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                    stnt[1] = sdnt.pol;
                    stnt[2] = sdnt.BDay.ToShortDateString();
                    stnt[3] = sdnt.curs.ToString();
                    stnt[4] = sdnt.special;
                    stnt[5] = sdnt.gruppa.ToString();
                    stnt[6] = sdnt.avg_note.ToString();
                    stnt[7] = sdnt.telephon;
                    stnt[8] = sdnt.adress.ToString();
                    if (stnt[0].Contains(textBox1.Text))
                    {
                        result.Rows.Add(stnt);
                        search.students.Add(sdnt);
                    }
                }

                //Regex regex = new Regex(@" Д");
                //foreach (var sdnt in u.students)
                //{
                //     if (regex.Match(textBox1.Text) == regex.Match(sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo))
                //     {

                //         String[] stnt = new String[9];
                //         stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                //         stnt[1] = sdnt.pol;
                //         stnt[2] = sdnt.BDay.ToShortDateString();
                //         stnt[3] = sdnt.curs.ToString();
                //         stnt[4] = sdnt.special;
                //         stnt[5] = sdnt.gruppa.ToString();
                //         stnt[6] = sdnt.avg_note.ToString();
                //         stnt[7] = sdnt.telephon;
                //         stnt[8] = sdnt.adress.ToString();
                //         result.Rows.Add(stnt);
                //         search.students.Add(sdnt);
                //      }
                //    //    }
                //    //}

                //}


            }
            if (index == 2)
            {
                foreach (var sdnt in u.students)
                {
                    String[] stnt = new String[9];
                    stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                    stnt[1] = sdnt.pol;
                    stnt[2] = sdnt.BDay.ToShortDateString();
                    stnt[3] = sdnt.curs.ToString();
                    stnt[4] = sdnt.special;
                    stnt[5] = sdnt.gruppa.ToString();
                    stnt[6] = sdnt.avg_note.ToString();
                    stnt[7] = sdnt.telephon;
                    stnt[8] = sdnt.adress.ToString();
                    if (stnt[4]==textBox1.Text)
                    {
                        result.Rows.Add(stnt);
                        search.students.Add(sdnt);
                    }
                }
            }
            if (index == 3)
            {
                foreach (var sdnt in u.students)
                {
                    String[] stnt = new String[9];
                    stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                    stnt[1] = sdnt.pol;
                    stnt[2] = sdnt.BDay.ToShortDateString();
                    stnt[3] = sdnt.curs.ToString();
                    stnt[4] = sdnt.special;
                    stnt[5] = sdnt.gruppa.ToString();
                    stnt[6] = sdnt.avg_note.ToString();
                    stnt[7] = sdnt.telephon;
                    stnt[8] = sdnt.adress.ToString();
                    if (stnt[3] == textBox1.Text)
                    {
                        result.Rows.Add(stnt);
                        search.students.Add(sdnt);
                    }
                }
            }
            if (index == 4)
            {
                Regex reg = new Regex(@"-");
                int k = (reg.Match(textBox1.Text)).Index;
                foreach (var sdnt in u.students)
                {
                    String[] stnt = new String[9];
                    stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                    stnt[1] = sdnt.pol;
                    stnt[2] = sdnt.BDay.ToShortDateString();
                    stnt[3] = sdnt.curs.ToString();
                    stnt[4] = sdnt.special;
                    stnt[5] = sdnt.gruppa.ToString();
                    stnt[6] = sdnt.avg_note.ToString();
                    stnt[7] = sdnt.telephon;
                    stnt[8] = sdnt.adress.ToString();
                    if (k > 0)
                    {
                        int min = Convert.ToInt32(textBox1.Text.Substring(0, k));
                        int max = Convert.ToInt32(textBox1.Text.Substring(k + 1, (textBox1.Text.Length - k - 1)));
                        if (sdnt.avg_note >= min && sdnt.avg_note <= max)
                        {
                            result.Rows.Add(stnt);
                            search.students.Add(sdnt);
                        }
                    }
                    else
                    {
                        if(textBox1.Text!="")
                        {
                            if (sdnt.avg_note == Convert.ToInt32(textBox1.Text))
                            {
                                result.Rows.Add(stnt);
                                search.students.Add(sdnt);
                            }
                        }
                    }
                    
                }
            }
        }
        /*Сохранение результатов*/
        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    XmlSerializer seril = new XmlSerializer(typeof(UNIVER));
                        seril.Serialize(myStream, search);
                        MessageBox.Show("Соранено в xml файле!");
                    myStream.Close();
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            parental.status.Text = "";
        }
    }
}
