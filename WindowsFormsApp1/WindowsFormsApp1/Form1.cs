using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class orden_btn : Form
    {
        public orden_btn()
        {
            InitializeComponent();
        }

        private void ejecutara_btn_Click(object sender, EventArgs e)
        {
            //Arreglo
            int[] arra1 = new int[5];

            arra1[0] = 10;
            arra1[1] = 20;
            arra1[2] = 30;
            arra1[3] = 40;
            arra1[4] = 50;

            int[] arra2 = new int[] { 1, 2, 3, 4, 5 };
            //---------------------------------
            int[] arra3 = { 1, 2, 3, 4, 5 };

            string[] dias_semana = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i = 0; i < arra1.Length; i++)
            {
                dias_listBox.Items.Add(arra1[i]);
            }

            foreach (var y in dias_semana)
            {
                Semana_listbox.Items.Add(y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 5, 1, 7, 8, 10, 2, 4 };

            //Ordenar de menor a mayor 
            Array.Sort(valores);

            //Ordenar de menor a mayor 
            Array.Reverse(valores);
            foreach (var item in valores)
            {
                ordenarlistbox.Items.Add(item);
            }


        }

        private void max_min_btn_Click(object sender, EventArgs e)
        {
            int[] valores = new int[] { 3, 5, 1, 7, 8, 10, 2, 4 };

            int ValMax = valores[0];
            int valmin = valores[0];

            for (int i = 1; i < valores.Length; i++)
            {
                if (valores[i]>ValMax)
                {
                    ValMax = valores[i];

                }

                if (valores[i] < valmin)
                {
                    valmin = valores[i];

                }
            }

            MessageBox.Show("Valor máximo:  " + ValMax + "/ Valor mínimo:  " + valmin);
                
        }
    }
}
