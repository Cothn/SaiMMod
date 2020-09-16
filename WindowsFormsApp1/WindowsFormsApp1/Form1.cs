using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApplication1;
using ZedGraph;

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        private LemerRandomSequence LemerRandom;
        private List<double> RandomSequence;
        const int SEQUENCE_MAX_LENGTH = 2000000;
        
        public Form1()
        {
            InitializeComponent();
        }
        
                
        private int findPeriod()
        {
            RandomSequence = new List<double>();

            for (int i = 0; i < SEQUENCE_MAX_LENGTH; i++)
                RandomSequence.Add(LemerRandom.Next());

            double Xv = LemerRandom.CurrentX();

            // find period
            int i1 = -1, i2 = -1;
            bool flag =  false;
            for (int i = 0; i < RandomSequence.Count; i++)
            {
                if (RandomSequence[i] == Xv)
                {
                    if (!flag)
                    {
                        flag = true;
                        i1 = i;
                    }
                    else
                    {
                        i2 = i;
                        break;
                    }
                }
            }
            int period = i2 - i1;


            // Find aperiod length
            int i3 = 0;      
            while (RandomSequence[i3] != RandomSequence[i3 + period]) 
                i3++; 
            int aperiod = i3 + period;

            RandomSequence.RemoveRange(aperiod, RandomSequence.Count - aperiod);
            
            if (i2 == -1 || i1 == -1) textBox_period.Text = "Period unfind";
            else
            {
                textBox_period.Text = period.ToString();        // Период
                textBox_no_period.Text = aperiod.ToString();    // Длина участка апериодичности
            }

            return period;
        }

        
        private void drawHistogram()
        {
            int N = RandomSequence.Count;
            double xMin=0.0, xMax = RandomSequence[0];
            
            // Получаем участок для отрисовки
            GraphPane pane = zedGraphControl1.GraphPane;

            // Очищаем холст
            pane.CurveList.Clear();

            const int columnCount = 20;
            
            
            for (int i = 0; i < RandomSequence.Count; i++)
            {
                if (RandomSequence[i] < xMin)
                    xMin = RandomSequence[i];
                if (RandomSequence[i] > xMax)
                    xMax = RandomSequence[i];
            }
            //double columnLength = (xMax - xMin)/columnCount;
            //double columnLength = (xMax - xMin+ 0.1)/columnCount;
            double columnLength = 1.0/columnCount;
            
            double[] frequency = new double[columnCount]; // Частота попаданий в интервал (высота столбца)
            double[] X_values = new double[columnCount];  // Значения по оси x
            
            //X_values[0] = 0.0245;
            X_values[0] = 0.005;
            for (int i = 1; i < columnCount; i++)
                X_values[i] = X_values[i - 1] + columnLength;
            
            for (int i = 0; i < columnCount; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if ((RandomSequence[j] >= i * columnLength) && (RandomSequence[j] < (i + 1) * columnLength))
                        frequency[i] ++;
                }
                frequency[i] /= N;
            }


            BarItem bar = pane.AddBar("Гистограмма", X_values, frequency, Color.DarkGreen);

            // !!! Расстояния между кластерами (группами столбиков) гистограммы = 0.0
            // У нас в кластере только один столбик.
            pane.BarSettings.MinClusterGap = 0.0f;

            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 1;
            pane.XAxis.Scale.AlignH = AlignH.Center;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

        
        private void getStatValues()
        {
            double Mx = 0;
            for (int i = 0; i < RandomSequence.Count; i++)
                Mx += RandomSequence[i];
            Mx = Mx / RandomSequence.Count;
            textBox_Mx.Text = Mx.ToString();

            double D = 0;
            for (int i = 0; i < RandomSequence.Count; i++)
                D += (RandomSequence[i] - Mx) * (RandomSequence[i] - Mx);
            D /= (RandomSequence.Count - 1);
            textBox_D.Text = D.ToString();

            textBox_sko.Text = (Math.Sqrt(D)).ToString();

        }
        
        private void checkUniformityIndirect()
        {
            int K = 0, N = RandomSequence.Count;

            for (int i = 0; i < N; i += 2)
            {
                if (i + 1 >= N) break;
                
                if (RandomSequence[i] * RandomSequence[i] + RandomSequence[i + 1] * RandomSequence[i + 1] < 1.0)
                    K++;
            }

            textBox_2kn.Text = (2 * (double)K / N).ToString();
        }

        private void saveSequence(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < RandomSequence.Count; i++)
            {
                sw.WriteLine(RandomSequence[i].ToString());
            }
            sw.Close();
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            LemerRandom = new LemerRandomSequence(double.Parse(textBox_a.Text), double.Parse(textBox_m.Text), double.Parse(textBox_R0.Text));
            
            findPeriod();
            drawHistogram();
            
            getStatValues();
            checkUniformityIndirect();

            /*
            //find a, m, R0 fo period >= 50000
            double a = 1000, r0 = 3571, m = 100000;
            LemerRandom = new LemerRandomSequence(a, m, r0);
            while (findPeriod() < 50000)
            {

                m++;
                if (m > 1000000)
                {
                    m = 1000;
                    a++;
                    if (a > 10000)
                    {

                        a = 1;
                        r0++;
                        if (r0 > 10000)
                        {
                            break;
                        }
                    }
                }
                LemerRandom = new LemerRandomSequence(a, m, r0);
            }
            textBox_a.Text = a.ToString();
            textBox_m.Text = m.ToString();
            textBox_R0.Text = r0.ToString();
            */
            
            saveSequence("LemerRandomSequence.txt");
            RandomSequence.Clear();
            LemerRandom.Reset();
        }

        private void label6_Click(object sender, EventArgs e)
        {
return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
    }
}