using System;

namespace VoznesenskayaAE_01_04
{
    public class Computer
    {
        //наименование процессора
        public string NameCPU { get; set; }
        //тактовая частота процессора (МГц)
        public double Frequency { get; set; }
        //объем оперативной памяти (Мб)
        public double SizeRAM { get; set; }
        //Q = (0,3·частота) + память
        public double Q { get; set; }

        //Конструктор класса
        public Computer (string NameCPU, double Frequency, double SizeRAM)
        {
            this.NameCPU = NameCPU;
            this.Frequency = Frequency;
            this.SizeRAM = SizeRAM;
        }

        //Функция вычисления качества
        public virtual double Calculate ()
        {
            return Q = (0.3 * Frequency) + SizeRAM;
        }
        //Функция вывода информации
        public virtual string Print ()
        {
            return $"Название: {NameCPU} Тактовая частота процессора (МГц): {Frequency} Объем оперативной памяти (Мб): {SizeRAM} Q: {Q}";
        }
    }
}
