using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inserimento_di_un_numero_in_un_vettore_ordinato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dichiarazione
            bool inserito = false;
            int[] v = new int[] { 2, 5,10, 16, 23, 27, 32, 37, 42, 50 };
            int num = Convert.ToInt32(textBox1.Text);
            int[] v2 = new int[v.Length+1];
            int k = 0;
            int i = 0;



            //esecuzione
            while (i < v.Length)
            {
                if (v[i] > num)
                {
                    if(inserito==false)
                    {
                        int temp = v[i];
                        v2[k] = num;
                        k++;
                        v2[k] = temp;
                        inserito = true;
                    }
                    else
                        v2[k] = v[i];
                }
                else 
                {
                    v2[k] = v[i];

                }
                k++;
                i++;
            }
            dataGridView1.RowCount = v2.Length;
            for (k = 0; k < v2.Length; k++)
                dataGridView1.Rows[k].Cells[0].Value = v2[k].ToString();

        }
    }
}
