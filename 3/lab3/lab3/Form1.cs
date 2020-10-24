using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            QueuingSystem smo = new QueuingSystem(double.Parse(textBox_p.Text), double.Parse(textBox_p1.Text), double.Parse(textBox_p2.Text));
            int ticksCount = int.Parse(textBox_ticks.Text);

            for (int i = 0; i < ticksCount - 1; i++)
                smo.GenerateNextState();
            
            if (double.Parse(textBox_p1.Text) >= 1)
            {
           //     smo.Counter1 = 0;
            }

            if (double.Parse(textBox_p2.Text) >= 1)
            {
            //    colAplication += T2;
            }
            textBox_block.Text = (smo.P111 / (double)ticksCount).ToString(); // Pбл - вероятность блокировки
            textBox_k1.Text = (smo.Counter1/(double) ticksCount).ToString(); // Коэффициент загрузки канала 1
            textBox_k2.Text = (smo.Counter2 /(double)ticksCount).ToString(); // Коэффициент загрузки канала 2
            
            textBox_P000.Text = (smo.P000 / (double)ticksCount).ToString(); // P000
            textBox_P001.Text = (smo.P001 / (double)ticksCount).ToString(); // P001
            textBox_P010.Text = (smo.P010/ (double)ticksCount).ToString(); // P010
            textBox_P011.Text = (smo.P011 / (double)ticksCount).ToString(); // P011
            textBox_P111.Text = (smo.P111 / (double)ticksCount).ToString(); // P111

            textBox_A.Text = (smo.AdmissionCounter / (double)ticksCount).ToString(); 
            textBox_Lo.Text = (smo.P111 / (double)ticksCount).ToString(); // Lo
            textBox_Wo.Text = (smo.P111/ (double)smo.AdmissionCounter ).ToString(); // Wo
            textBox_Lc.Text = ((smo.P001+smo.P010+2*smo.P011+3*smo.P111)/ (double)ticksCount).ToString(); // P011
            textBox_Wc.Text = (smo.colAplication /  (double)smo.AdmissionCounter ).ToString(); // Wc
            

            label_k1.Text = "Количество тактов с занятым каналом 1: " + smo.Counter1.ToString();
            label_k2.Text = "Количество тактов с занятым каналом 2: " + smo.Counter2.ToString();
            label_ticks.Text = "Количество тактов: " + ticksCount.ToString();
        }
        
    }
}
