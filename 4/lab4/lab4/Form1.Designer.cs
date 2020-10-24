namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_intensity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ch1 = new System.Windows.Forms.TextBox();
            this.label_denialCount1 = new System.Windows.Forms.Label();
            this.label_denial = new System.Windows.Forms.Label();
            this.textBox_denial1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_queue1 = new System.Windows.Forms.TextBox();
            this.textBox_queue2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ch2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_denial2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_denialCount2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_denial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_denialCount = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl_a = new ZedGraph.ZedGraphControl();
            this.textBox_step = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_λmax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_λmin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество заявок:";
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonSimulate.Location = new System.Drawing.Point(36, 367);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(201, 38);
            this.buttonSimulate.TabIndex = 1;
            this.buttonSimulate.Text = "Запустить имитацию";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(199, 25);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(116, 23);
            this.textBox_number.TabIndex = 2;
            this.textBox_number.Text = "1000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интенсивность источника, λ =";
            // 
            // textBox_intensity
            // 
            this.textBox_intensity.Location = new System.Drawing.Point(199, 55);
            this.textBox_intensity.Name = "textBox_intensity";
            this.textBox_intensity.Size = new System.Drawing.Size(116, 23);
            this.textBox_intensity.TabIndex = 4;
            this.textBox_intensity.Text = "5,0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Интенсивность канала первой фазы, μ1 =";
            // 
            // textBox_ch1
            // 
            this.textBox_ch1.Location = new System.Drawing.Point(294, 179);
            this.textBox_ch1.Name = "textBox_ch1";
            this.textBox_ch1.Size = new System.Drawing.Size(68, 23);
            this.textBox_ch1.TabIndex = 6;
            this.textBox_ch1.Text = "5,0";
            // 
            // label_denialCount1
            // 
            this.label_denialCount1.AutoSize = true;
            this.label_denialCount1.Location = new System.Drawing.Point(17, 125);
            this.label_denialCount1.Name = "label_denialCount1";
            this.label_denialCount1.Size = new System.Drawing.Size(147, 15);
            this.label_denialCount1.TabIndex = 7;
            this.label_denialCount1.Text = "Количество отказов 1: ???";
            // 
            // label_denial
            // 
            this.label_denial.AutoSize = true;
            this.label_denial.Location = new System.Drawing.Point(17, 150);
            this.label_denial.Name = "label_denial";
            this.label_denial.Size = new System.Drawing.Size(49, 15);
            this.label_denial.TabIndex = 8;
            this.label_denial.Text = "Pотк1 =";
            // 
            // textBox_denial1
            // 
            this.textBox_denial1.Location = new System.Drawing.Point(78, 147);
            this.textBox_denial1.Name = "textBox_denial1";
            this.textBox_denial1.ReadOnly = true;
            this.textBox_denial1.Size = new System.Drawing.Size(119, 23);
            this.textBox_denial1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Длина очереди первой фазы, n1 =";
            // 
            // textBox_queue1
            // 
            this.textBox_queue1.Location = new System.Drawing.Point(294, 149);
            this.textBox_queue1.Name = "textBox_queue1";
            this.textBox_queue1.Size = new System.Drawing.Size(68, 23);
            this.textBox_queue1.TabIndex = 11;
            this.textBox_queue1.Text = "2";
            // 
            // textBox_queue2
            // 
            this.textBox_queue2.Location = new System.Drawing.Point(294, 225);
            this.textBox_queue2.Name = "textBox_queue2";
            this.textBox_queue2.Size = new System.Drawing.Size(68, 23);
            this.textBox_queue2.TabIndex = 15;
            this.textBox_queue2.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Длина очереди второй фазы, n2 =";
            // 
            // textBox_ch2
            // 
            this.textBox_ch2.Location = new System.Drawing.Point(294, 254);
            this.textBox_ch2.Name = "textBox_ch2";
            this.textBox_ch2.Size = new System.Drawing.Size(68, 23);
            this.textBox_ch2.TabIndex = 13;
            this.textBox_ch2.Text = "5,0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Интенсивность канала второй фазы, μ2 =";
            // 
            // textBox_denial2
            // 
            this.textBox_denial2.Location = new System.Drawing.Point(78, 209);
            this.textBox_denial2.Name = "textBox_denial2";
            this.textBox_denial2.ReadOnly = true;
            this.textBox_denial2.Size = new System.Drawing.Size(119, 23);
            this.textBox_denial2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pотк2 =";
            // 
            // label_denialCount2
            // 
            this.label_denialCount2.AutoSize = true;
            this.label_denialCount2.Location = new System.Drawing.Point(17, 187);
            this.label_denialCount2.Name = "label_denialCount2";
            this.label_denialCount2.Size = new System.Drawing.Size(147, 15);
            this.label_denialCount2.TabIndex = 16;
            this.label_denialCount2.Text = "Количество отказов 2: ???";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(417, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 438);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_denial);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label_denialCount);
            this.tabPage1.Controls.Add(this.textBox_denial2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label_denialCount2);
            this.tabPage1.Controls.Add(this.textBox_number);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_intensity);
            this.tabPage1.Controls.Add(this.label_denialCount1);
            this.tabPage1.Controls.Add(this.label_denial);
            this.tabPage1.Controls.Add(this.textBox_denial1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Имитация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_denial
            // 
            this.textBox_denial.Location = new System.Drawing.Point(314, 187);
            this.textBox_denial.Name = "textBox_denial";
            this.textBox_denial.ReadOnly = true;
            this.textBox_denial.Size = new System.Drawing.Size(119, 23);
            this.textBox_denial.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pотк =";
            // 
            // label_denialCount
            // 
            this.label_denialCount.AutoSize = true;
            this.label_denialCount.Location = new System.Drawing.Point(260, 165);
            this.label_denialCount.Name = "label_denialCount";
            this.label_denialCount.Size = new System.Drawing.Size(138, 15);
            this.label_denialCount.TabIndex = 19;
            this.label_denialCount.Text = "Количество отказов: ???";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl_a);
            this.tabPage2.Controls.Add(this.textBox_step);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox_λmax);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox_λmin);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание А";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl_a
            // 
            this.zedGraphControl_a.Location = new System.Drawing.Point(13, 110);
            this.zedGraphControl_a.Name = "zedGraphControl_a";
            this.zedGraphControl_a.ScrollGrace = 0D;
            this.zedGraphControl_a.ScrollMaxX = 0D;
            this.zedGraphControl_a.ScrollMaxY = 0D;
            this.zedGraphControl_a.ScrollMaxY2 = 0D;
            this.zedGraphControl_a.ScrollMinX = 0D;
            this.zedGraphControl_a.ScrollMinY = 0D;
            this.zedGraphControl_a.ScrollMinY2 = 0D;
            this.zedGraphControl_a.Size = new System.Drawing.Size(526, 295);
            this.zedGraphControl_a.TabIndex = 24;
            // 
            // textBox_step
            // 
            this.textBox_step.Location = new System.Drawing.Point(86, 45);
            this.textBox_step.Name = "textBox_step";
            this.textBox_step.Size = new System.Drawing.Size(38, 23);
            this.textBox_step.TabIndex = 5;
            this.textBox_step.Text = "0,5";
            this.textBox_step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.Location = new System.Drawing.Point(12, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(383, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Входной поток и потоки обслуживаний - простейшие.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.Location = new System.Drawing.Point(12, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "с шагом          .";
            // 
            // textBox_λmax
            // 
            this.textBox_λmax.Location = new System.Drawing.Point(537, 16);
            this.textBox_λmax.Name = "textBox_λmax";
            this.textBox_λmax.Size = new System.Drawing.Size(38, 23);
            this.textBox_λmax.TabIndex = 3;
            this.textBox_λmax.Text = "6";
            this.textBox_λmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label10.Location = new System.Drawing.Point(502, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "до";
            // 
            // textBox_λmin
            // 
            this.textBox_λmin.Location = new System.Drawing.Point(455, 15);
            this.textBox_λmin.Name = "textBox_λmin";
            this.textBox_λmin.Size = new System.Drawing.Size(38, 23);
            this.textBox_λmin.TabIndex = 1;
            this.textBox_λmin.Text = "1";
            this.textBox_λmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(382, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Зависимости Pотк, Pотк1, Pотк2 при изменении λ от ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab4.Properties.Resources.Снимок;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 438);
            this.Controls.Add(this.textBox_queue1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ch1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_queue2);
            this.Controls.Add(this.textBox_ch2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №4. Вариант 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_intensity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ch1;
        private System.Windows.Forms.Label label_denialCount1;
        private System.Windows.Forms.Label label_denial;
        private System.Windows.Forms.TextBox textBox_denial1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_queue1;
        private System.Windows.Forms.TextBox textBox_queue2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ch2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_denial2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_denialCount2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_denial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_denialCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_step;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_λmax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_λmin;
        private ZedGraph.ZedGraphControl zedGraphControl_a;
    }
}

