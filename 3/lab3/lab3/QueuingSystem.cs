﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class QueuingSystem
    {
        private readonly Random _rand, _rand1, _rand2;
        private readonly double _p, _p1, _p2;
        
        public int colAplication { get; private set; }    // Состояние очереди  {0, 1}
        
        public int queryCounter { get; private set; }       // Счётчик  поступлений в очередь

        public byte J { get; private set; }    // Состояние очереди  {0, 1}
        public byte T1 { get; private set; }   // Состояние канала 1 {0, 1}
        public byte T2 { get; private set; }   // Состояние канала 2 {0, 1}

        public int AdmissionCounter { get; private set; }  // Счётчик поступлений заявок
        public int Counter1 { get; private set; }       // Счётчик занятости канала 1
        public int Counter2 { get; private set; }       // Счётчик занятости канала 2
        
        public int P000 { get; private set; }      
        public int P001 { get; private set; }    
        public int P010 { get; private set; }    
        public int P011 { get; private set; }    
        public int P111 { get; private set; }    

        public QueuingSystem(double p, double p1, double p2)
        {
            J = 0;
            T1 = 0;
            T2 = 0;
            //BlockCounter = 0;
            colAplication = 0;
            AdmissionCounter = 0;
            queryCounter = 0;
            Counter1 = 0;
            Counter2 = 0;
            P000 = 0;
            P001 = 0;
            P010 = 0;
            P011 = 0;
            P111 = 0;
            _rand = new Random();
            _rand1 = new Random(101);
            _rand2= new Random(4242440);
            _p = p;     // Вероятность не выдачи заявки
            _p1 = p1;   // Вероятность не обслуживания заявки каналом 1
            _p2 = p2;   // Вероятность не обслуживания заявки каналом 2
        }

        // Была ли не выдана заявка
        private bool IsNoRequest()
        {
            return _rand.NextDouble() < _p;
        }

        // Была ли не обслужена заявка каналом 1
        private bool IsNoService1()
        {
            return _rand1.NextDouble() < _p1;
        }

        // Была ли не обслужена заявка каналом 2
        private bool IsNoService2()
        {
            return _rand2.NextDouble() < _p2;
        }


        public void GenerateNextState()
        {
            colAplication += J;
            if (_p1 < 1)
            {
                colAplication += T1;
            }

            if (_p2 < 1)
            {
                colAplication += T2;
            }
            if (J == 0)
            {
                if (T1 == 0)
                {
                    if (T2 == 0)
                    {
                        P000++;
                    }
                    else
                    {
                        P001++;
                    }
                }
                else
                {
                    if (T2 == 0)
                    {
                        P010++;
                    }
                    else
                    {
                        P011++;
                    }
                }
            }
            else
            {
                P111++;
            }
            
            
            if (T1 == 1) // Если в канале 1 есть заявка
            {
                if (IsNoService1()) Counter1++;
                else T1 = 0;
            }
                
            if (T2 == 1) // Если в канале 2 есть заявка
            {
                if (IsNoService2()) Counter2++;
                else T2 = 0;
            }
            
            if(J == 1) // Если есть заявка в очереди
            {
                if (T1 == 0)
                {
                    J = 0;
                    T1 = 1;
                    Counter1++;
                }
                else if (T2 == 0)
                {
                    J = 0;
                    T2 = 1;
                    Counter2++;
                }
            }
            
            

            if (IsNoRequest()) // Если источник не выдал заявку
                return;
            
            

            if (J == 0) // Если нет заявок в очереди
            {
                AdmissionCounter++;
                if (T1 == 0)
                {
                    T1 = 1;
                    Counter1++;
                }
                else if (T2 == 0)
                {
                    T2 = 1;
                    Counter2++;
                }
                else
                {
                    J = 1;
                    queryCounter++;
                }
            }
            else        // Если есть заявка в очереди
            {
                //BlockCounter++; // Увеличиваем счётчик блокировок
                return;                  
            }
        }
    }
}
