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
using System.Data.OleDb;

namespace Bulanık_Mantık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Excel'den oku
        //Önemli Not: Eğer Projede "OleDBConnectıon not provided..." hatası alınır ise comment olan sonu xlsx ile biten 'path' ve connectıon kullanılmalı... 
        //OleDb12 not provided hatasını projeyi diğer bilgisayarımda karşılaştım ve şu anki çözüm 2 bilgisayarda da çalıştığı için değiştirdim.

        // OleDb12..
        //private static string path = Directory.GetCurrentDirectory() + "\\Kurallar.xlsx";
        //private static OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0 Xml; HDR = YES';");

        private static string path = Directory.GetCurrentDirectory() + "\\Kurallar.xls";        
        private static OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties='Excel 8.0; HDR=Yes;IMEX=1';");

        DataTable dt = new DataTable();

        private string[] hassaslikDurum = new string[2] {"SAĞLAM",""};
        private string[] miktarDurum = new string[2] { "KÜÇÜK", "" };
        private string[] kirlilikDurum = new string[2] { "KÜÇÜK", "" };
        
        double valueHassaslik;
        double valueMiktar;
        double valueKirlilik;
        double agirlikDonusHizi;
        double agirlikSure;
        double agirlikDeterjan;


        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From [Sayfa1$]", connection);
            DataTable dt = new DataTable();            
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            valueHassaslik = Convert.ToDouble(numericHassaslik.Value);
            valueMiktar = Convert.ToDouble(numericMiktar.Value);
            valueKirlilik = Convert.ToDouble(numericKirlilik.Value);
            RulesChanged();
        }

        private void numericHassaslik_ValueChanged(object sender, EventArgs e)
        {
            valueHassaslik = Convert.ToDouble(numericHassaslik.Value);
            int index = 0;
            labelHassaslikDurum.Text = "";
            hassaslikDurum[1] = "";

            if(valueHassaslik>= 0 && valueHassaslik <= 4)
            {
                hassaslikDurum[index] = "sağlam";
                index++;
            }
            if (valueHassaslik >= 3 && valueHassaslik <= 7)
            {
                hassaslikDurum[index] = "orta";
                index++;
            }
            if (valueHassaslik >= 5.5 && valueHassaslik <= 14)
            {
                hassaslikDurum[index] = "hassas";
                index++;
            }
            labelHassaslikDurum.Text = hassaslikDurum[0].ToUpper() + " " + hassaslikDurum[1].ToUpper();
            RulesChanged();
        }

        private void numericMiktar_ValueChanged(object sender, EventArgs e)
        {
            valueMiktar = Convert.ToDouble(numericMiktar.Value);
            int index = 0;
            labelMiktarDurum.Text = "";

            if (valueMiktar >= 0 && valueMiktar <= 4)
            {
                miktarDurum[index] = "küçük";
                index++;
            }
            if (valueMiktar >= 3 && valueMiktar <= 7)
            {
                miktarDurum[index] = "orta";
                index++;
            }
            if (valueMiktar >= 5.5 && valueMiktar <= 14)
            {
                miktarDurum[index] = "büyük";
                index++;
            }
            labelMiktarDurum.Text = miktarDurum[0].ToUpper() +" "+ miktarDurum[1].ToUpper();
            RulesChanged();
        }

        private void numericKirlilik_ValueChanged(object sender, EventArgs e)
        {
            valueKirlilik = Convert.ToDouble(numericKirlilik.Value);
            int index = 0;
            labelKirlilikDurum.Text = "";
            
            if (valueKirlilik >= 0 && valueKirlilik <= 4.5)
            {
                kirlilikDurum[index] = "küçük";
                index++;
                labelKirlilikDurum.Text += "küçük-";
            }
            if (valueKirlilik >= 3 && valueKirlilik <= 7)
            {
                kirlilikDurum[index] = "orta";
                index++;
                labelKirlilikDurum.Text += "orta-";
            }
            if (valueKirlilik >= 5.5 && valueKirlilik <= 15)
            {
                kirlilikDurum[index] = "büyük";
                index++;
                labelKirlilikDurum.Text += "büyük";
            }
            labelKirlilikDurum.Text = kirlilikDurum[0].ToUpper() + " " + kirlilikDurum[1].ToUpper();
            RulesChanged();
        }

        private void RulesChanged()
        {           
            string query = "Select * From[Sayfa1$] Where (Hassaslık='" + hassaslikDurum[0] + "'";
            if(hassaslikDurum[1] != "")
            {
                query += "OR Hassaslık='" + hassaslikDurum[1] + "'";
            }
            query += ") AND (Miktar='" + miktarDurum[0] + "'";
            if (miktarDurum[1] != "")
            {
                query += "OR Miktar='" + miktarDurum[1] + "'";
            }
            query += ") AND (Kirlilik='" + kirlilikDurum[0] + "'";
            if (kirlilikDurum[1] != "")
            {
                query += "OR Kirlilik='" + kirlilikDurum[1] + "'";
            }
            query += ")";
            dataGridTetiklenen.DataSource = null;
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridTetiklenen.DataSource = dt;

            Mamdani();
        }

        private void Mamdani()
        {
            double[] min = new double[dt.Rows.Count];
            textBox1.Text = "";
            for (int i = 0; i < dataGridTetiklenen.RowCount; i++)
            {
                double fxhassaslik = fxHassaslik(dt.Rows[i][0].ToString());
                double fxmiktar = fxMiktar(dt.Rows[i][1].ToString());
                double fxkirlilik = fxKirlilik(dt.Rows[i][2].ToString());
                min[i] = Math.Min(Math.Min(fxhassaslik,fxmiktar),fxkirlilik);
                textBox1.Text += min[i].ToString() + Environment.NewLine;
            }

            
            IDictionary<string, double> donusHizi_dict = new Dictionary<string, double>() { { "hassas", -1 }, { "normal hassas", -1 }, { "orta", -1 }, { "normal güçlü", -1 }, { "güçlü", -1 } };
            IDictionary<string, double> sure_dict = new Dictionary<string, double>()      { { "kısa", -1 }, { "normal kısa", -1 }, { "orta", -1 }, { "normal uzun", -1 }, { "uzun", -1 } };
            IDictionary<string, double> deterjan_dict = new Dictionary<string, double>()  { { "çok az", -1 }, { "az", -1 }, { "orta", -1 }, { "fazla", -1 }, { "çok fazla", -1 } };

            // MAX HESAPLAMA Hesaplama
            for (int i = 0; i < min.Length; i++)
            {
                if(donusHizi_dict[dt.Rows[i][3].ToString()] <= min[i])
                {
                    donusHizi_dict[dt.Rows[i][3].ToString()] = min[i];
                }

                if (sure_dict[dt.Rows[i][4].ToString()] <= min[i])
                {
                    sure_dict[dt.Rows[i][4].ToString()] = min[i];
                }

                if (deterjan_dict[dt.Rows[i][5].ToString()] <= min[i])
                {
                    deterjan_dict[dt.Rows[i][5].ToString()] = min[i];
                }

            }

            //-1 değeri olanları temizle
            donusHizi_dict = donusHizi_dict.Where(p => p.Value != -1).ToDictionary(p => p.Key, p => p.Value);
            sure_dict = sure_dict.Where(p => p.Value != -1).ToDictionary(p => p.Key, p => p.Value);
            deterjan_dict = deterjan_dict.Where(p => p.Value != -1).ToDictionary(p => p.Key, p => p.Value);


            Centroid(donusHizi_dict,sure_dict,deterjan_dict);

        }

        private void Centroid(IDictionary<string, double> donusHizi, IDictionary<string, double> sure, IDictionary<string, double> deterjan)
        {
            double toplam=0;
            double z = 0;
            foreach (var item in donusHizi)
            {
                toplam += item.Value;
                switch (item.Key)
                {
                    case "hassas":
                        z += item.Value * -1.15;
                        break;
                    case "normal hassas":
                        z += item.Value * 2.75;
                        break;
                    case "orta":
                        z += item.Value * 5;
                        break;
                    case "normal güçlü":
                        z += item.Value * 7.25;
                        break;
                    case "güçlü":
                        z += item.Value * 11.85;
                        break;
                }
            }
            agirlikDonusHizi = z / toplam;
            toplam = 0;
            z = 0;
            foreach (var item in sure)
            {
                toplam += item.Value;
                switch (item.Key)
                {
                    case "kısa":
                        z += item.Value * 23.79;
                        break;
                    case "normal kısa":
                        z += item.Value * 39.9;
                        break;
                    case "orta":
                        z += item.Value * 57.5;
                        break;
                    case "normal uzun":
                        z += item.Value * 75.1;
                        break;
                    case "uzun":
                        z += item.Value * 102.15;
                        break;
                }
            }
            agirlikSure = z / toplam;
            toplam = 0;
            z = 0;
            foreach (var item in deterjan)
            {
                toplam += item.Value;
                switch (item.Key)
                {
                    case "çok az":
                        z += item.Value * 10;
                        break;
                    case "az":
                        z += item.Value * 85;
                        break;
                    case "orta":
                        z += item.Value * 150;
                        break;
                    case "fazla":
                        z += item.Value * 215;
                        break;
                    case "çok fazla":
                        z += item.Value * 290;
                        break;
                }
            }
            agirlikDeterjan = z / toplam;
            toplam = 0;
            z = 0;
            textBox2.Text = "";
            textBox2.Text += "Dönüş Hızı Centroid: " + agirlikDonusHizi.ToString() + Environment.NewLine;
            textBox2.Text += "Süre Centroid: " + agirlikSure.ToString() + Environment.NewLine;
            textBox2.Text += "Deterjan Centroid: " + agirlikDeterjan.ToString() + Environment.NewLine;
        }


        double fxHassaslik(string durum)
        {
            if (durum == "sağlam") return Yamuk(-4, -1.5, 2, 4, valueHassaslik);
            else if (durum == "orta") return Ucgen(3, 5, 7, valueHassaslik);
            else return Yamuk(5.5, 8, 12.5, 14, valueHassaslik);
        }

        double fxMiktar(string durum)
        {
            if (durum == "küçük") return Yamuk(-4, -1.5, 2, 4, valueMiktar);
            else if (durum == "orta") return Ucgen(3, 5, 7, valueMiktar);
            else return Yamuk(5.5, 8, 12.5, 14, valueMiktar);
        }

        double fxKirlilik(string durum)
        {
            if (durum == "küçük") return Yamuk(-4.5, -2.5, 2, 4.5, valueKirlilik);
            else if (durum == "orta") return Ucgen(3, 5, 7, valueKirlilik);
            else return Yamuk(5.5, 8, 12.5, 15, valueKirlilik);
        }


        // üçgen yamuk Y ekseni hesapla
        private double Ucgen(double startangle, double midangle, double endangle, double value)
        {
            if(value >= startangle && value <= midangle)
            {
                return (value - startangle) / (midangle - startangle);
            }
            else if (value >= midangle && value <= endangle)
            {
                return (value - midangle) / (midangle - endangle) + 1;
            }
            else
            {
                return -1;
            }
        }

        private double Yamuk(double start, double firstEdge , double secondEdge, double end, double value)
        {
            if (value >= start && value <= firstEdge)
            {
                return (value - start) / (firstEdge - start);
            }
            else if (value >= firstEdge && value <= secondEdge)
            {
                return 1;
            }
            else if (value >= secondEdge && value <= end)
            {
                return (value - secondEdge) / (secondEdge - end) + 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
