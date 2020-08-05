using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    class Kromozom
    {
        public double[] genList = new double[30];
        public double fitness;
        public int populationNumber = 0;
        public double probability;
        public double Probability { get { return probability; } set { probability = value; } }

        public Kromozom(double[] _kromozom)
        {
            genList = _kromozom;
            Evaluation();          
        }

        public void Evaluation()
        {
            for (int i = 0; i < 29; i++)
            {
                this.fitness = this.fitness + (100.0 * Math.Pow((genList[i+1] - genList[i] * genList[i]), 2) + Math.Pow(genList[i] - 1, 2));
            }           
        }
    }
}
