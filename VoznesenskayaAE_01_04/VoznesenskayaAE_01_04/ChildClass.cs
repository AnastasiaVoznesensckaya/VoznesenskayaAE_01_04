using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoznesenskayaAE_01_04
{
    public class ChildClass :Computer
    {
        public int P { get; set; }//объём винчестера (Гб)
        public double Qp { get; set; }//качество класса потомка
        //конструктор класса
        public ChildClass (string NameCPU, double Frequency, double SizeRAM, int P) :base(NameCPU, Frequency, SizeRAM)
        {
            this.NameCPU = NameCPU;
            this.Frequency = Frequency;
            this.SizeRAM = SizeRAM;
            this.P = P;
        }
        //функция вычисления качества класса потомка
        public override double Calculate ()
        {
            Q = (0.3 * Frequency) + SizeRAM;
            return Qp = Q + 0.5 * P;
        }
        //функция вывода информации
        public override string Print ()
        {
            return base.Print() + $"Qp: {Qp}";
        }
    }
}
