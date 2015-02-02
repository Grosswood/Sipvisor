using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipvisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.label5.Text = "";
        }

        private int answerOne;
        private int answerTwo;
        private int answerThree;
        private int answerFour;
        private int answerFive;
        private int answerSix;
        
        //New comment
        // !!! Добавить новую переменную


        private void gatherAnswers()
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                answerOne = indexChecked;
            }
            foreach (int indexChecked in checkedListBox2.CheckedIndices)
            {
                answerTwo = indexChecked;
            }
            foreach (int indexChecked in checkedListBox3.CheckedIndices)
            {
                answerThree = indexChecked;
            }
            foreach (int indexChecked in checkedListBox4.CheckedIndices)
            {
                answerFour = indexChecked;
            }
            foreach (int indexChecked in checkedListBox5.CheckedIndices)
            {
                answerFive = indexChecked;
            }
            foreach (int indexChecked in checkedListBox6.CheckedIndices)
            {
                answerSix = indexChecked;
            }
            // !!! Добавить foreach с {} чтобы переводить галочки в цифры
        }


        private void displayAdvice()
        {

            string[] minAdvice = { "Увеличивайте ассортимент продукции", "Увеличивайте ассортимент продукции", "Старайтесь соблюдать законы", "Следите за продукцией конкурентов", "Повысить зарплату","Старайтесь повысить репутацию" };
            string[] maxAdvice = { "Занимайте свободные сегменты рынка", "Модернизируйте производство", "Возьмите кредит на развитие", "Следуйте вкусам потребителей", "Расширяйте объём производства", "Откройте филиал" };
            // !!! Добавить максимальный и минимальный советы

            int[] answers = { answerOne, answerTwo, answerThree, answerFour, answerFive,answerSix };
            // !!! Добавить новую перменную в массив Answers

            int[] minAdviceToChoose = { 0, 5 }; //number, value
            int[] maxAdviceToChoose = { 0, 0 }; //number, value

            for (int answerNumber = 0; answerNumber < 6; answerNumber++)
                // !!! Увеличить ццфру, она должна соответствовать числу вопросов
            {
                if (minAdviceToChoose[1] > answers[answerNumber])
                {
                    minAdviceToChoose[0] = answerNumber;
                    minAdviceToChoose[1] = answers[answerNumber];
                }
                if (maxAdviceToChoose[1] < answers[answerNumber])
                {
                    maxAdviceToChoose[0] = answerNumber;
                    maxAdviceToChoose[1] = answers[answerNumber];
                }
            }

            this.label5.Text = minAdvice[minAdviceToChoose[0]] + " и " + maxAdvice[maxAdviceToChoose[0]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label9.Visible = false;
            if (checkedListBox1.SelectedItems.Count == 1 && checkedListBox2.SelectedItems.Count == 1 && checkedListBox3.SelectedItems.Count == 1 && checkedListBox4.SelectedItems.Count == 1)
            {
                gatherAnswers();
                displayAdvice();
            }
            else
            {
                this.label5.Text = "Вам нужно поставить галочку напротив каждого ответа";
            }
            //this.label5.Text = answerOne.ToString() + answerTwo.ToString() + answerThree.ToString() + answerFour.ToString();
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox1.Items.Count; itemToUncheck++)
            {
                checkedListBox1.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox2.Items.Count; itemToUncheck++)
            {
                checkedListBox2.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox3.Items.Count; itemToUncheck++)
            {
                checkedListBox3.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox4.Items.Count; itemToUncheck++)
            {
                checkedListBox4.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox5.Items.Count; itemToUncheck++)
            {
                checkedListBox5.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox5.Items.Count; itemToUncheck++)
            {
                checkedListBox5.SetItemChecked(itemToUncheck, false);
            }
        }
        
        // !!! Добавить проверку для нового вопроса, чтобы была только одна галочка в ответах

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
