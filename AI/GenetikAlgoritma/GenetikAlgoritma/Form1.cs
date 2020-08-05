using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public partial class Form1 : Form
    {
        private List<Kromozom> populationList = new List<Kromozom>();
        private List<Kromozom> EliteList = new List<Kromozom>();
        private List<Kromozom> temporaryList = new List<Kromozom>();
        private Random rnd = new Random();
        private int nextGenerationCount = 0;
        private int graphInt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private double RandomUret()
        {
            return rnd.NextDouble() * (30 - (-30)) + -30; ;
        }

        private void CreatePopulation()
        {
            int sayac = 0;
            while (sayac < populationSizeBox.Value)
            {
                double[] dizi = new double[30];
                for (int j = 0; j < dizi.Length; j++)
                {
                    dizi[j] = RandomUret();
                }
                Kromozom birey = new Kromozom(dizi);
                populationList.Add(birey);
                sayac++;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            CreatePopulation();

            while (nextGenerationCount <= Convert.ToInt32(jenerasyonBox.Value))
            {
                Selection();
                CrossOver();
                nextGenerationCount = nextGenerationCount + 1;
            }
        }

        private void Selection()
        {
            EliteList = populationList.OrderBy(o => o.fitness).Take(Convert.ToInt32(seckinlikBox.Value)).ToList();
            chart1.Series["fitness"].Points.AddXY(graphInt, EliteList[0].fitness);
            chart1.Update();
            graphInt++;
        }

        private void CrossOver()
        {
            temporaryList.AddRange(populationList); //liste2 for crossover
            populationList.Clear();
            populationList.AddRange(EliteList);

            while (temporaryList.Count != 0)
            {
                Kromozom parent1 = temporaryList[carkifelek(temporaryList)];
                temporaryList.Remove(parent1);
                Kromozom parent2 = temporaryList[carkifelek(temporaryList)];
                temporaryList.Remove(parent2);
                
                if (rnd.NextDouble() < Convert.ToDouble(crossOverBox.Value))
                {
                    double[] childGen = new double[30];
                    double[] childGen2 = new double[30];
                    for (int i = 0; i < 30; i++)
                    {
                        if (i < 15)
                        {
                            childGen[i] = parent1.genList[i];
                            childGen2[i] = parent2.genList[i];
                        }
                        else
                        {
                            childGen[i] = parent2.genList[i];
                            childGen2[i] = parent1.genList[i];
                        }
                        childGen[i] = Mutation(childGen[i]);
                        childGen2[i] = Mutation(childGen2[i]);
                    }

                    Kromozom child = new Kromozom(childGen);
                    Kromozom child2 = new Kromozom(childGen2);
                    populationList.Add(child);
                    populationList.Add(child2);
                }
                else
                {
                    populationList.Add(parent1);
                    populationList.Add(parent2);
                }              
            }          
        }
        //Mutasyon
        private double Mutation(double gen)
        {
            if (rnd.NextDouble() < Convert.ToDouble(mutationRateBox.Value))
            {
                return RandomUret();
            }
            return gen;
        }

        //RULET
        private double calculateTotal(List<Kromozom> list)
        {
            double total = 0;
            foreach (Kromozom item in list)
            {
                total = total + (1 / item.fitness);
            }
            return total;
        }

        //RULET
        private int carkifelek(List<Kromozom> list) // P[i] = Fitness[i] / Total ,       Fitness[i] = 1 / F_obj[i]
        {           
            double random = rnd.NextDouble();
            double carkToplam = 0;
            int index = 0;

            double total = calculateTotal(list);
            foreach (Kromozom item in list)
            {
                item.probability = (1 / item.fitness) / total;
            }

            foreach (var item in list)
            {
                carkToplam = carkToplam + item.probability;
                if (carkToplam > random | index == list.Count - 1)
                    break;
                else
                    index++;
            }

            return index;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.Interval = 20;
        }
    }
}