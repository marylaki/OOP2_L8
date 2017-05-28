using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace OOP_Laba_7
{
    public partial class Form1 : Form
    {
        UNIVER u = new UNIVER();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        //добавить
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student sdnt = new Student();
                sdnt.familya = fam.Text; fam.Clear();
                sdnt.name = nam.Text; nam.Clear();
                sdnt.otchestvo = otch.Text; otch.Clear();
                sdnt.pol = comboBox1.Text;
                sdnt.BDay = bday.Value;
                if (radioButton1.Checked) sdnt.curs = Convert.ToInt32(radioButton1.Text);
                if (radioButton2.Checked) sdnt.curs = Convert.ToInt32(radioButton2.Text);
                if (radioButton3.Checked) sdnt.curs = Convert.ToInt32(radioButton3.Text);
                if (radioButton4.Checked) sdnt.curs = Convert.ToInt32(radioButton4.Text);
                if (radioButton5.Checked) sdnt.curs = Convert.ToInt32(radioButton5.Text);
                sdnt.special = listBox1.Text;
                sdnt.gruppa = Convert.ToInt32(grup.Text); grup.Clear();
                sdnt.avg_note = Convert.ToDouble(avg_note.Value);
                sdnt.telephon = tel.Text; tel.Clear();
                sdnt.adress.city = city.Text; city.Clear();
                sdnt.adress.index = index.Text; index.Clear();
                sdnt.adress.street = strit.Text; strit.Clear();
                sdnt.adress.flat = flat.Text; flat.Clear();
                sdnt.adress.house = house.Text; house.Clear();
                u.students.Add(sdnt);
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
                inf.Rows.Add(stnt);
                status.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("Проверте корректность данных!");

            }
        }
        //запись
        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            status.Text = "Запись в файл";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    XmlSerializer seril = new XmlSerializer(typeof(UNIVER));
                    seril.Serialize(myStream, u);
                    MessageBox.Show("Соранено в xml файле!");
                    myStream.Close();
                }
            }
            status.Text = "";
        }
        //чтение
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            status.Text = "Чтение из файла";
            XmlSerializer seril = new XmlSerializer(typeof(UNIVER));
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                u = (UNIVER)seril.Deserialize(sr);
                sr.Close();
            }
            inf.Rows.Clear();
            foreach (Student sdnt in u.students)
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
                inf.Rows.Add(stnt);
            }
            status.Text = "";
        }

        private void grup_TextChanged(object sender, EventArgs e)
        {

        }

        private void grup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void index_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void house_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void flat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void otch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void fam_Validating(object sender, CancelEventArgs e)
        {
            if (fam.Text == "") fam.BackColor = Color.Red;
            else fam.BackColor = Color.White;

        }

        private void nam_Validating(object sender, CancelEventArgs e)
        {
            if (nam.Text == "") nam.BackColor = Color.Red;
            else nam.BackColor = Color.White;
        }

        private void otch_Validating(object sender, CancelEventArgs e)
        {
            if (otch.Text == "") otch.BackColor = Color.Red;
            else otch.BackColor = Color.White;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text != "Мужской"&& comboBox1.Text != "Женский") comboBox1.BackColor = Color.Red;
            else comboBox1.BackColor = Color.White;
        }

        private void grup_Validating(object sender, CancelEventArgs e)
        {
            if (grup.Text == "") grup.BackColor = Color.Red;
            else grup.BackColor = Color.White;
        }

        private void city_Validating(object sender, CancelEventArgs e)
        {
            if (city.Text == "") city.BackColor = Color.Red;
            else city.BackColor = Color.White;
        }

        private void index_Validating(object sender, CancelEventArgs e)
        {
            if (index.Text.Length <5) index.BackColor = Color.Red;
            else index.BackColor = Color.White;
        }

        private void strit_Validating(object sender, CancelEventArgs e)
        {
            if (strit.Text == "") strit.BackColor = Color.Red;
            else strit.BackColor = Color.White;
        }

        private void house_Validating(object sender, CancelEventArgs e)
        {
            if (house.Text == "" || house.Text.Length > 4) house.BackColor = Color.Red;
            else house.BackColor = Color.White;
        }

        private void flat_Validating(object sender, CancelEventArgs e)
        {
            if (flat.Text == ""|| flat.Text.Length>4) flat.BackColor = Color.Red;
            else flat.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            fam.Focus();
            nam.Focus();
            otch.Focus();
            bday.Focus();
            comboBox1.Focus();
            
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            { label5.ForeColor = Color.Red; }
            else label5.ForeColor = Color.Black;
            tel.Focus();
            listBox1.Focus();
            grup.Focus();
            avg_note.Focus();
            tel.Focus();
            city.Focus();
            index.Focus();
            strit.Focus();
            flat.Focus();
            house.Focus();
            button1.Focus();

        }

        private void tel_Validating(object sender, CancelEventArgs e)
        {
            if (tel.Text.Length < 13) tel.BackColor = Color.Red;
            else tel.BackColor = Color.White;
        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {
            if (listBox1.Text == "") label6.ForeColor = Color.Red;
            else label6.ForeColor = Color.Black;
        }

        private void фИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 poisk = new Form2(this);
            poisk.index = 1;
            poisk.u = u;
            poisk.label1.Text = "ФИО";
            poisk.Show();
            status.Text = "Поиск по ФИО";
        }

        private void поСпециальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 poisk = new Form2(this);
            poisk.index = 2;
            poisk.u = u;
            poisk.label1.Text = "Специальнсть";
            poisk.Show();
            status.Text = "Поиск по специальноси";
        }

        private void поКурсуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 poisk = new Form2(this);
            poisk.index = 3;
            poisk.u = u;
            poisk.label1.Text = "курс";
            poisk.Show();
            status.Text = "Поиск по курсу";
        }

        private void поСреднемуБалуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 poisk = new Form2(this);
            poisk.index = 4;
            poisk.u = u;
            poisk.label1.Text = "средний бал";
            poisk.Show();
            status.Text = "Поиск по среденему балу";
        }

        private void поГодуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.students.Sort((s1, s2) =>
            {
                return s1.curs.CompareTo(s2.curs);
            });
            inf.Rows.Clear();
            foreach(var sdnt in u.students)
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
                inf.Rows.Add(stnt);
            }
        }

        private void поСреднемуБалуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            u.students.Sort((s1, s2) =>
            {
                return s2.avg_note.CompareTo(s1.avg_note);
            });
            inf.Rows.Clear();
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
                inf.Rows.Add(stnt);
            }
        }

        private void поКурсуИСреденемуБалуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.students.Sort((s1, s2) =>
            {
               if(s1.curs==s2.curs) return s2.avg_note.CompareTo(s1.avg_note);
                else return s1.curs.CompareTo(s2.curs);
            });
            inf.Rows.Clear();
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
                inf.Rows.Add(stnt);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laba 8 version 07.05.2917\nLakevich Mariya.");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();

            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void поФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            фИОToolStripMenuItem_Click(sender, e);
        }

        private void поСпецальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            поСпециальностиToolStripMenuItem_Click(sender, e);
        }

        private void поКурсуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            поКурсуToolStripMenuItem_Click(sender, e);
        }

        private void поСреднемуБалуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            поСреднемуБалуToolStripMenuItem_Click(sender, e);
        }

        private void курсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            поГодуToolStripMenuItem_Click(sender, e);
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            поСреднемуБалуToolStripMenuItem1_Click(sender, e);

        }

        private void куToolStripMenuItem_Click(object sender, EventArgs e)
        {
            поКурсуИСреденемуБалуToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fam.Clear();
            fam.BackColor = Color.White;
            nam.Clear();
            nam.BackColor = Color.White;
            otch.Clear();
            otch.BackColor = Color.White;
            bday.Text ="";
            comboBox1.Text = "";
            comboBox1.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            tel.Clear();
            tel.BackColor = Color.White;
            grup.Clear();
            grup.BackColor = Color.White;
            avg_note.Value=avg_note.Minimum;
            avg_note.BackColor = Color.White;
            city.Clear();
            city.BackColor = Color.White;
            index.Clear();
            index.BackColor = Color.White;
            strit.Clear();
            strit.BackColor = Color.White;
            flat.Clear();
            flat.BackColor = Color.White;
            house.Clear();
            house.BackColor = Color.White;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            u.students.Clear();
            inf.Rows.Clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            u.students.RemoveAt(inf.CurrentRow.Index);
            inf.Rows.Remove(inf.CurrentRow);
        }
    }
}
