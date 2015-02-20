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
        private int answerSeven;
        private int answerEight;
        private int answerNine;
        private int answerTen;
        private int answerEleven;
        private int answerTwelve;

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
            foreach (int indexChecked in checkedListBox7.CheckedIndices)
            {
                answerSeven = indexChecked;
            }
            foreach (int indexChecked in checkedListBox8.CheckedIndices)
            {
                answerEight = indexChecked;
            }
            foreach (int indexChecked in checkedListBox9.CheckedIndices)
            {
                answerNine = indexChecked;
            }
            foreach (int indexChecked in checkedListBox10.CheckedIndices)
            {
                answerTen = indexChecked;
            }
            foreach (int indexChecked in checkedListBox11.CheckedIndices)
            {
                answerEleven = indexChecked;
            }
            foreach (int indexChecked in checkedListBox12.CheckedIndices)
            {
                answerTwelve = indexChecked;
            }
            // !!! Добавить foreach с {} чтобы переводить галочки в цифры
        }


        private void displayAdvice()
        {

            string[] minAdvice = { "Для повышения конкурентоспособности увеличивайте ассортимент продукции", "Чтобы компенсировать невозможность модернизации увеличивайте ассортимент продукции", "Ввиду отрицательного отношения правительства старайтесь соблюдать законы", "Регулируйте ассортимент вашей продукции в соответствии с продукцией конкурентов", "Для привлечения квалифицированного персонала проводите гибкую политику вознаграждения", "Внимательней следите за пожеланиями клиентов" , "Необходимо оптимизировать ваши рыночные возможности" , "Уделите внимание отделу стратегического планирования" , "Способствуйте уменьшению финансовых издержек" , "Сосредоточьте усилия на поиске менеджеров высокой квалификации" , "Старайтесь найти способы поставить клиентам сопутствующие товары" , "Запустите рекламную кампанию вашей продукции"};
            string[] maxAdvice = { "Занимайте свободные сегменты рынка", "Модернизируйте производство", "Благосклонность правительства позволит вам получить выгодный кредит на развитие", "Следуйте вкусам потребителей", "Высокая квалификация персонала позволит вам расширить объём производства", "Высокая репутация фирмы поспособствует открытию нового филиала" , "Вам нужно поглотить кого-нибудь из конкурентов" , "Планируйте вашу деятельность так чтобы ослабить конкурентов" ,  "Отсутствие финансовых издержек позволит увеличить объём производства" , "Высокая квалиикация менеджеров позволит уделять внимание деталям процесса деятельности фирмы" , "Расширение ассортимента сопутствующих товаров выведет вас в лидеры рынка" , "Старайтесь сотрудничать с вашими конкурентами"};
            // !!! Добавить максимальный и минимальный советы

            int[] answers = { answerOne, answerTwo, answerThree, answerFour, answerFive, answerSix, answerSeven, answerEight, answerNine, answerTen, answerEleven, answerTwelve };
            // !!! Добавить новую переменную в массив Answers

            int[] minAdviceToChoose = { 0, 5 }; //number, value
            int[] minAdviceToChoose2 = { 0, 5 }; //number, value
            int[] maxAdviceToChoose = { 0, 0 }; //number, value
            int[] maxAdviceToChoose2 = { 0, 0 }; //number, value

            for (int answerNumber = 0; answerNumber < 12; answerNumber++)
            // !!! Увеличить цифру, она должна соответствовать числу вопросов
            {
                if (minAdviceToChoose[1] > answers[answerNumber])
                {
                    minAdviceToChoose2[0] = minAdviceToChoose[0];
                    minAdviceToChoose2[1] = minAdviceToChoose[1];
                    minAdviceToChoose[0] = answerNumber;
                    minAdviceToChoose[1] = answers[answerNumber];
                }
                else if (minAdviceToChoose2[1] > answers[answerNumber])
                {
                    minAdviceToChoose2[0] = answerNumber;
                    minAdviceToChoose2[1] = answers[answerNumber];
                }

                if (maxAdviceToChoose[1] < answers[answerNumber])
                {
                    maxAdviceToChoose2[0] = maxAdviceToChoose[0];
                    maxAdviceToChoose2[1] = maxAdviceToChoose[1];
                    maxAdviceToChoose[0] = answerNumber;
                    maxAdviceToChoose[1] = answers[answerNumber];
                }
                else if (maxAdviceToChoose2[1] < answers[answerNumber])
                {
                    maxAdviceToChoose2[0] = answerNumber;
                    maxAdviceToChoose2[1] = answers[answerNumber];
                }
            }

            this.label5.Text = minAdvice[minAdviceToChoose[0]];
            this.label25.Text = minAdvice[minAdviceToChoose2[0]];
            this.label14.Text = maxAdvice[maxAdviceToChoose[0]];
            this.label27.Text = maxAdvice[maxAdviceToChoose2[0]];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label9.Visible = false;
            if (checkedListBox1.SelectedItems.Count == 1 && checkedListBox2.SelectedItems.Count == 1 && checkedListBox3.SelectedItems.Count == 1 && checkedListBox4.SelectedItems.Count == 1 && checkedListBox5.SelectedItems.Count == 1 && checkedListBox6.SelectedItems.Count == 1 && checkedListBox7.SelectedItems.Count == 1 && checkedListBox8.SelectedItems.Count == 1 && checkedListBox9.SelectedItems.Count == 1 && checkedListBox10.SelectedItems.Count == 1 && checkedListBox11.SelectedItems.Count == 1 && checkedListBox12.SelectedItems.Count == 1)
            //Добавить проверку галочки в каждом вопросе
            {
                gatherAnswers();
                displayAdvice();
            }
            else
            {
                this.label5.Text = "Вам нужно поставить галочку напротив каждого ответа";
            }
            //this.label5.Text = answerOne.ToString() + answerTwo.ToString() + answerThree.ToString() + etc;
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
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox6.Items.Count; itemToUncheck++)
            {
                checkedListBox6.SetItemChecked(itemToUncheck, false);
            }
        }

        // !!! Добавить проверку для нового вопроса, чтобы была только одна галочка в ответах

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Text = "";
            this.label14.Text = "";
            this.label27.Text = "";
            this.label25.Text = "";
        }

        private void checkedListBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox7.Items.Count; itemToUncheck++)
            {
                checkedListBox7.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox8.Items.Count; itemToUncheck++)
            {
                checkedListBox8.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox9.Items.Count; itemToUncheck++)
            {
                checkedListBox9.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox10.Items.Count; itemToUncheck++)
            {
                checkedListBox10.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox11.Items.Count; itemToUncheck++)
            {
                checkedListBox11.SetItemChecked(itemToUncheck, false);
            }
        }

        private void checkedListBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int itemToUncheck = 0; itemToUncheck < checkedListBox12.Items.Count; itemToUncheck++)
            {
                checkedListBox12.SetItemChecked(itemToUncheck, false);
            }
        }

        
        

       
    }
}
