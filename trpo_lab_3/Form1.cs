using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trpo_lab_3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                dgvRes.Rows.Add();
            }           
            
        }

        int countCompare=0, countShift=0, findIndex=0;

        private void printRes(int numstr)
        {
            dgvRes.Rows[numstr - 1].Cells[0].Value = countCompare;
            dgvRes.Rows[numstr - 1].Cells[1].Value = countShift;
            dgvRes.Rows[numstr - 1].Cells[2].Value = findIndex;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rbSimple.Checked)
            {
                simple();
                printRes(1);
            }
            else
                if (rbBayerM.Checked)
                {
                    BayerMoore();
                    printRes(2);
                }
                else
                    {
 
                    }
        }
        private void simple()
        {
            countCompare = 0; 
            countShift = 0;
            findIndex = -1;
            string source = txbxStrSource.Text.Trim();
            string substr = txbxSubstr.Text.Trim();
            bool find = false;
            for (int i = 0; i < (source.Length-substr.Length+1) && !find; i++)
            {

                find = true;
                for (int j = 0; j < substr.Length && find; j++)
                {
                    if (source[i+j] != substr[j])                    
                        find = false;
                    countCompare++;
                }
                countShift = i + 1;
                if (find)
                {
                    findIndex = i+1;                   
                }
            }
        }
        private void BayerMoore()
        {
            countCompare = 0;
            countShift = 0;
            findIndex = -1;
            string source = txbxStrSource.Text.Trim();
            string substr = txbxSubstr.Text.Trim();
            Dictionary<char, int> shiftTable = new Dictionary<char, int>();
            //формируем таблицу сдвигов. сначала все символы входной строки = длина подстроки
            for (int i = 0; i < source.Length; i++)
            {
                if(!shiftTable.ContainsKey(source[i]))
                  shiftTable.Add(source[i], substr.Length);
            }
            //затем все символы подстроки, меняем сдвиг символа на соответствующий сдвиг, или добавляем его в таблицу
            for (int i = 0; i < substr.Length; i++)
            {
                if (shiftTable.ContainsKey(substr[i]))
                    shiftTable[substr[i]] = substr.Length - i - 1;
                else
                {
                    shiftTable.Add(substr[i], substr.Length - i - 1);
                }
            }
            int indexSource = substr.Length;
            int indexSubstr = substr.Length;

            while (indexSource <= source.Length && indexSubstr > 0)
            {
                if (source[indexSource - 1] == substr[indexSubstr - 1]) //сравнение справа налево
                {
                    indexSource--;
                    indexSubstr--;
                }
                else
                {
                    if (indexSubstr == substr.Length) // сдвиг по таблице сдвигов соответствующего символа
                        indexSource += shiftTable[source[indexSource - 1]];
                    else
                        indexSource += substr.Length - indexSubstr + 1;
                    indexSubstr = substr.Length;
                    countShift++;
                }
                countCompare++;
            }
            if (indexSubstr == 0)
            {
               findIndex= indexSource + 1;               
            }

        }
    }
}
