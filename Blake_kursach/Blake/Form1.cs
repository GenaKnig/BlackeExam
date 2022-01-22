using BlakeSharpDemo;
using Convector;
using System;
using System.Text;
using System.Windows.Forms;

namespace Blake
{
    public partial class Form1 : Form
    {
        
        

         
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "AlisaGet";
            textBox2.Text = "Bobafet";
            textBoxHello.Text = "AlisaGet";
            textBoxCroc.Text = "Крок 1: Відправка повідомлення для початку автентифікацій";
            Blacy.Random33();
            textBoxKeyA.Text = Blacy.key;
            textBoxKeyB.Text = Blacy.key;
            button1.Enabled = false;
            buttonMeesegHesh.Enabled = false;
            button2.Enabled = false;
            buttonHesh.Enabled = false;
            buttonHesh2.Enabled = false;
            buttonPorivnRR.Enabled = false;
            Peredacha.Enabled = false;
            buttonMesseng.Enabled = false;
            buttonMesseng2.Enabled = false;

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            buttonMesseng.Enabled = true;
            textBoxNumber2.Text = textBoxNumber.Text;
            textBoxCroc.Text = "Крок 4: Створення Алісою повідомлення";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peredacha.Enabled = true;
            Blacy.Random32();
            textBoxNumber.Text = Blacy.sea2;
            textBoxCroc.Text = "Крок 3: Передача псевдовипадкового числа Алісі";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonHesh.Enabled = true;
            textBoxMesseng.Text = Blacy.sea;
            textBoxCroc.Text = "Крок 5: Гешування повідомлення";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonHesh2.Enabled = true;
            textBoxMesseng2.Text = Blacy.sea;
            textBoxCroc.Text = "Крок 8: Гешування повідомлення Боба";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            buttonMeesegHesh.Enabled = true;
            Blacy.HashString(Blacy.sea);
            textBoxHesh.Text = MemUtil.ByteArrayToHexString(Blacy.Hash256);
            textBoxCroc.Text = "Крок 6:  Передача гешу Аліси повідомленям Бобу";
        }
       
        private void buttonHesh2_Click(object sender, EventArgs e)
        {
            buttonPorivnRR.Enabled = true;
            Blacy.HashString2();
            textBoxHesh2.Text = MemUtil.ByteArrayToHexString(Blacy.Hash2566);
            textBoxCroc.Text = "Крок 9: Порівння гешу Аліси та Боба";
        }
        public void ShowSuccefulMessage(string message)
        {
            Action action = () =>
            {
                MessageBox.Show(this, message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            Invoke(action);
        }
        public void ShowErrorMessage(string message)
        {
            Action action = () =>
            {
                MessageBox.Show(this, message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Invoke(action);
        }
        private void buttonPorivnRR_Click(object sender, EventArgs e)
        {
            if (textBoxMH.Text == textBoxHesh2.Text)
            {
                ShowSuccefulMessage("Порівння пройшло успішно");
                textBoxCroc.Text = "Крок 10: Автентифікація пройдена успішно";
            }
            else { ShowErrorMessage("Порівння не пройшло"); textBoxCroc.Text = "Крок 9: Автентифікація не пройдена,  В цій програмі немає того гешу,геш в іншій програмі!";}
            button2.Enabled = true;
        }

        private void textBoxKeyA_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBoxHello2.Text = "AlisaGet";
            textBoxCroc.Text = "Крок 2: Генерація псевдовипадкового числа";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
        }

        private void buttonMeesegHesh_Click(object sender, EventArgs e)
        {
            buttonMesseng2.Enabled = true;
           
            textBoxCroc.Text = "Крок 7: Створення Бобом повідомлення";
            textBoxMH.Text =textBoxHesh.Text ;

        }

        private void textBoxHello_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
