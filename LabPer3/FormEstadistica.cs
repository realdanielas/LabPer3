using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPer3
{
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();
        }

        public Random alter = new Random();
        public List<int> myData = new List<int>();
        public List<int> sortedData;

        private void FormEstadistica_Load(object sender, EventArgs e)
        {

        }

        private void generarBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                // myData.Add(alter.Next(0, 100));
                //myData.Add(5);

            }
            myData.Add(5);
            myData.Add(6);
            myData.Add(8);
            myData.Add(7);
            myData.Add(3);
            myData.Add(2);
            myData.Add(7);
            myData.Add(7);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //MEDIA------------------------------------------------------------------------------------

            this.tboxMedia.Text = myData.Average().ToString();

            //MEDIANA----------------------------------------------------------------------------------

            /* tBoxMediana.Text = estad.Media(estad.Numero, estad.Cantidad).ToString();
             double mediana = 0;

             string[] lines = tBox1.Lines;

             var sort = from s in lines
                        orderby s
                        select s;
             tBox1.Lines = sort.ToArray();


             int pos = estad.Cantidad / 2;
             if (estad.Cantidad % 2 == 0)
             {
                 mediana = (((double)tBox1.Items[pos - 1] + (double)tBox1.Items[pos]) / 2.0);
             }
             else
             {
                 mediana = (double)tBox1.Items[pos];
             }
             tBoxMediana.Text = mediana.ToString();*/ //<----TRASH CODE BUT IT'S COMMENTED JUST IN CASE

            string[] lines = tBox1.Lines;

            var sort = from s in lines
                       orderby s
                       select s;
            tBox1.Lines = sort.ToArray();

            double mediana = myData[(myData.Count / 2 + 1)];

            tBoxMediana.Text = mediana.ToString();

            //MODA-------------------------------------------------------------------------------------
            int numberMax = myData[0];
            int timesMax = 0;


            int i = 0;
            while (i < myData.Count)
            {

                int timesNumber = 0;
                int j = 0;
                while (j < myData.Count)
                {
                    if (myData[j].ToString() == myData[i].ToString()) timesNumber++;
                    j++;
                }
                if (timesNumber > timesMax)
                {
                    numberMax = myData[i];
                    timesMax = timesNumber;
                }
                i++;

            }
            this.tBoxModa.Text = numberMax.ToString();

            //DESVIACION TIPICA----------------------------------------------------------------------------

            double dtSum = 0;
            int l = 0;
            while (l < myData.Count)
            {

                dtSum += myData[l];
                l++;

            }
            double mean = dtSum / myData.Count;

            double finalDTSum = 0;
            l = 0;

            while (l < myData.Count)
            {
                finalDTSum += Math.Pow(myData[l] - mean, 2);
                l++;

            }
            finalDTSum /= myData.Count;

            double desviacion = Math.Sqrt(finalDTSum);
            Double des = Math.Round((Double)desviacion, 4);
            this.tBoxDS.Text = des.ToString();
        }

        private void MostrarListaBTN_Click(object sender, EventArgs e)
        {
            this.tBox1.Text = "";

            foreach (int numero in myData)
            {
                this.tBox1.Text += numero.ToString() + "  -  ";

            }
        }

        private void SortedDataBTN_Click(object sender, EventArgs e)
        {
            //LISTA PERO ORDENADA
            sortedData = myData.OrderBy(x => x).ToList();

            foreach (int numero in sortedData)
            {
                this.tBoxSortedData.Text += numero.ToString() + "  -  ";

            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            myData.Clear();
            tBox1.Clear();
            tboxMedia.Clear();
            tBoxMediana.Clear();
            tBoxModa.Clear();
            tBoxDS.Clear();
            tBoxSortedData.Clear();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
