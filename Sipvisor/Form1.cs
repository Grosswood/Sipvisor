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

        //Variables for answers

        private int answerOne;
        private int answerTwo;
        private int answerThree;
        private int answerFour;

        //Converting position of checked boxes into int variables created above

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
        }

        //Chooses advices by answers

        private void displayAdvice()
        {

            string[] minAdvice = { "Увеличивайте ассортимент продукции", "Расширяйте ассортимент продукции", "Старайтесь соблюдать законы", "Следите за продукцией конкурентов" };
            string[] maxAdvice = { "Занимайте свободные сегменты рынка", "Модернизируйте производство", "Возьмите кредит на развитие", "Следуйте вкусам потребителей" };

            int[] answers = { answerOne, answerTwo, answerThree, answerFour };
            
            int[] minAdviceToChoose = { 0, 5 }; //number, value
            int[] maxAdviceToChoose = { 0, 0 }; //number, value

            for (int answerNumber = 0; answerNumber < 4; answerNumber++)
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


        //Uncheck other boxes on check
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
    }
}
