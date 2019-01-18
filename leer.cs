using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\Usuario\Downloads\EJ_CFDI_DIC_2018\2837_1543448409246.xml");
           // dataSet.ReadXml(@"C:\Users\Usuario\AppData\Local\Temp\7zEC66F9EB2\Books.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView2.DataSource = dataSet.Tables[1];
            dataGridView3.DataSource = dataSet.Tables[2];
            dataGridView4.DataSource = dataSet.Tables[4];
            dataGridView5.DataSource = dataSet.Tables[5];
           // dataGridView6.DataSource = dataSet.Tables[6];
            dataGridView7.DataSource = dataSet.Tables[7];
           // dataGridView8.DataSource = dataSet.Tables[8];
            dataGridView9.DataSource = dataSet.Tables[9];
           // dataGridView10.DataSource = dataSet.Tables[3];
            //dataGridView11.DataSource = dataSet.Tables[11];
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
