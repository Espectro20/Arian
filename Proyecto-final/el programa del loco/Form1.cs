using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace el_programa_del_loco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public Random q = new Random();
        public int n1, n2, n3, n4, n5;
        public double numero;
        public double dinero;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public double dinero1;

        private void button1_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
        }

        public double dinero2;
        public double dinero3;

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(txtNumero.Text);
            dinero = Convert.ToDouble(txtDinero.Text);

            n1 = q.Next(0, 99);
            n2 = q.Next(0, 99);
            n3 = q.Next(0, 99);


            txtn1.Text = n1.ToString();
            txtn2.Text = n2.ToString();
            txtn3.Text = n3.ToString();

            dinero1 = dinero * 20;
            txtPremio1.Text = dinero1.ToString();

            dinero2 = dinero * 10;
            txtPremio2.Text = dinero2.ToString();

            dinero3 = dinero * 5;
            txtPremio3.Text = dinero3.ToString();

            if (numero > 100)
            {
                MessageBox.Show("El numero debe ser entre 0 y 100");
            }
            if (numero == n1)
            {
                MessageBox.Show("Ganaste en priner lugar");
            }
            if (numero == n2)
            {
                MessageBox.Show("Ganaste en segundo lugar");
            }
            if (numero == n3)
            {
                MessageBox.Show("Ganaste en tercer lugar");
            }

            int n = dtgv.Rows.Add();

            dtgv.Rows[n].Cells[0].Value = n1;
            dtgv.Rows[n].Cells[1].Value = n2;
            dtgv.Rows[n].Cells[2].Value = n3;
            dtgv.Rows[n].Cells[3].Value = DateTime.Now;

            int u1 = 0;


            foreach (DataGridViewRow row in this.dtgv.Rows)
            {
                u1 = Convert.ToInt32(row.Cells[0].Value);
            }


            int k = dataGridView1.Rows.Add();

            dataGridView1.Rows[k].Cells[0].Value = u1;
           
            /*
            foreach (DataGridViewRow row in this.dtgv.Rows)
            {

                textBox1.Text = (row.Cells[0].Value.ToString();
                foreach (DataGridViewRow ro in this.dataGridView1.Rows)
                {
                    int cs = Convert.ToInt32(row.Cells[0].Value);
                    int c = Convert.ToInt32(row.Cells[0].Value);

                    if ( cs == c)
                        {

                        MessageBox.Show(cs.ToString());

                    }
                }*/
            var dg = dataGridView1;
            int filas = dg.Rows.Count;
            int con = 0;
            int valor;

            try
            {


                for (int i = 0; i <= filas; i++)
                {
                    valor = Convert.ToInt32(dg.Rows[i].Cells[0].Value);
                    for (int j = 0; j <= filas + 1; j++)
                    {

                        if (valor == Convert.ToInt32(dg.Rows[j].Cells[0].Value))
                        {
                            con++;
                            txtrepetido.Text = valor.ToString();
                            dataGridView1.Rows.Add(txtrepetido.Text, con);
                        }
                        else if (con > 1)
                        {
                            txtrepetido.Text = valor.ToString();
                            dataGridView1.Rows.Add(txtrepetido.Text, con);








                        }



                    }





                }
            }
            catch
            {

            }
        } }




        }



  