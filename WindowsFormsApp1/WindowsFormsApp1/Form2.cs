using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WpfApplication1;
using ZedGraph;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        
        private double[] RandomSequence;
        public Form2()
        {
            InitializeComponent();
            radioButton_uniform.Checked = true;
        }
        
        // Вычисление математического ожидания, дисперсии и СКО
        private void CalculateStatValues()
        {
            double Mx = RandomSequence.Sum() / RandomSequence.Length;
            textBox_Mx.Text = Mx.ToString();

            double Dx = RandomSequence.Sum(t => (t - Mx) * (t - Mx)) / (RandomSequence.Length - 1);
            textBox_Dx.Text = Dx.ToString();

            textBox_sko.Text = (Math.Sqrt(Dx)).ToString();
        }

                // Построить гистограмму
        private void DrawHistogram()
        {
            List<double> numbers = new List<double>(RandomSequence);
            numbers.Sort();

            const int intervalsCount = 20;
            double width = numbers.Last() - numbers.First();

            double widthOfInterval = width / intervalsCount;

            double[] heights = new double[intervalsCount];    // Высота столбцов гистограммы
            double[] X_values = new double[intervalsCount];  // Значение по оси x

            X_values[0] = 0.0245 * width + numbers.First();
            for (int i = 1; i < intervalsCount; i++)
                X_values[i] = X_values[i - 1] + widthOfInterval;

            double xLeft = numbers.First();           // Начало диаграммы по оси x
            double xRight = xLeft + widthOfInterval;  // Конец текущего интервала по оси x
            int j = 0;
            for (int i = 0; i < intervalsCount; i++)
            {
                while (j < numbers.Count && xLeft <= numbers[j] && xRight > numbers[j])
                {
                    heights[i] ++;
                    j++;
                }
                heights[i] /= numbers.Count;
                xLeft = xRight;
                xRight += widthOfInterval;
            }

            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.XAxis.Title.Text = "Значение величины";
            pane.YAxis.Title.Text = "Частота попадания в интервал";
            pane.Title.Text = "Гистограмма непрерывного распределения";

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            BarItem bar = pane.AddBar("", X_values, heights, Color.DarkGreen);
            
            // !!! Расстояния между кластерами (группами столбиков) гистограммы = 0.0
            // У нас в кластере только один столбик.
            pane.BarSettings.MinClusterGap = 0.0f;

            pane.XAxis.Scale.Min = numbers.First();
            pane.XAxis.Scale.Max = numbers.Last();
            pane.XAxis.Scale.AlignH = AlignH.Center;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }
        
        // Равномерное распределение
        private void UniformDistrib()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));

            int N = int.Parse(textBox3.Text);// Количество генерируемых чисел
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            RandomSequence = new double[N];

            for (int i = 0; i < N; i++)
                RandomSequence[i] = a + (b - a) * rand.Next();

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Равномерное распределение\r\na = " + a.ToString() + ", b = " + b.ToString() + ", N = " + N.ToString();
        }
        
        // Гауссовское распределение
        private void GaussRaspred()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));
            int N = int.Parse(textBox4.Text);          // Количество генерируемых чисел
            double m = double.Parse(textBox1.Text);    // Мат. ожидание
            double sko = double.Parse(textBox2.Text);  // СКО
            int n = int.Parse(textBox3.Text);          // Число суммируемых равномерно распределённых чисел

            RandomSequence = new double[N];
            for (int i = 0; i < N; i++)
            {
                double tmp = 0;
                for (int j = 0; j < n; j++)
                    tmp += rand.Next();

                RandomSequence[i] = m + sko*Math.Sqrt(12.0/n)*(tmp - (double) n/2);
            }

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Гауссовское распределение\r\nm = " + m.ToString() + ", σ = " + sko.ToString() + ", N = " + N.ToString();
        }
        
        // Экспоненциальное распределение
        private void ExponentialRaspred()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));
            int N = int.Parse(textBox2.Text);          // Количество генерируемых чисел
            double λ = double.Parse(textBox1.Text);    // Параметр экспоненциального распределения

            RandomSequence = new double[N];
            for (int i = 0; i < N; i++)
                RandomSequence[i] = - Math.Log(rand.Next()) / λ;

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Экспоненциальное распределение\r\nλ = " + λ.ToString() + ", N = " + N.ToString();
        }
        
        // Гамма-распределение
        private void GammaRaspred()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));
            int N = int.Parse(textBox3.Text);          // Количество генерируемых чисел
            int η = int.Parse(textBox1.Text);   
            double λ = double.Parse(textBox2.Text);

            RandomSequence = new double[N];
            for (int i = 0; i < N; i++)
            {
                double tmp = 1;
                for (int j = 0; j < η; j++)
                    tmp *= rand.Next();

                RandomSequence[i] = -Math.Log(tmp) / λ;
            }

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Гамма-распределение\r\nη = " + η.ToString() + ", λ = " + λ.ToString() + ", N = " + N.ToString();
        }

        
        // Треугольное распределение
        private void TriangleRaspred()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));
            int N = int.Parse(textBox3.Text);
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            RandomSequence = new double[N];

            for (int i = 0; i < N; i++)
            {
                double R1 = rand.Next();
                double R2 = rand.Next();
                RandomSequence[i] = a + (b - a) * Math.Max(R1, R2);
            }
                

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Треугольное распределение\r\na = " + a.ToString() + ", b = " + b.ToString() + ", N = " + N.ToString();
        }
        
        private void SimpsonRaspred()
        {
            LemerRandomSequence rand = new LemerRandomSequence(ulong.Parse(textBox_a.Text), ulong.Parse(textBox_m.Text), ulong.Parse(textBox_R0.Text));
            int N = int.Parse(textBox3.Text);
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            RandomSequence = new double[N];

            for (int i = 0; i < N; i++)
                RandomSequence[i] = a/2 + (b/2 - a/2)*rand.Next() + a/2 + (b/2 - a/2)*rand.Next();

            CalculateStatValues();
            DrawHistogram();
            distNameLabel.Text = "Распределение Симпсона\r\na = " + a.ToString() + ", b = " + b.ToString() + ", N = " + N.ToString();
        }

        
        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (radioButton_uniform.Checked)
                UniformDistrib();
            
            else if (radioButton_gauss.Checked)
                GaussRaspred();
            
            else if (radioButton_exp.Checked)
                ExponentialRaspred();
            
            else if (radioButton_gamma.Checked)
                GammaRaspred();
            
            else if (radioButton_triangle.Checked)
                TriangleRaspred();
            
            else if (radioButton_simpson.Checked)
                SimpsonRaspred();
        }

        private void radioButton_uniform_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_uniform.Checked) return;
            label1.Text = "a = "; textBox1.Text = "5";
            label2.Text = "b = "; textBox2.Text = "10";
            label3.Text = "N = "; textBox3.Text = "10000";
        }
        
         private void radioButton_gauss_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_gauss.Checked)
            {
                label1.Text = "m = ";
                textBox1.Text = "5";
                label2.Text = "σ = ";
                textBox2.Text = "10";
                label3.Text = "n = ";
                textBox3.Text = "6";
                label4.Text = "N = ";
                textBox4.Text = "10000";
                label4.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }
            
        }

        private void radioButton_exp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_exp.Checked)
            {
                label1.Text = "λ = "; textBox1.Text = "10";
                label2.Text = "N = "; textBox2.Text = "10000";
                label3.Visible = false;
                textBox3.Visible = false;
            }
            else
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
            
        }

        private void radioButton_gamma_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_gamma.Checked) return;
            label1.Text = "η = "; textBox1.Text = "18";
            label2.Text = "λ = "; textBox2.Text = "2,5";
            label3.Text = "N = "; textBox3.Text = "10000";
        }

        private void radioButton_triangle_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_triangle.Checked) return;
            label1.Text = "a = "; textBox1.Text = "3";
            label2.Text = "b = "; textBox2.Text = "9";
            label3.Text = "N = "; textBox3.Text = "10000";
        }

        private void radioButton_simpson_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton_simpson.Checked) return;
            label1.Text = "a = "; textBox1.Text = "18";
            label2.Text = "b = "; textBox2.Text = "30";
            label3.Text = "N = "; textBox3.Text = "10000";
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}