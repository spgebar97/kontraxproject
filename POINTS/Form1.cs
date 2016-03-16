using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using POINTS.DAL;
using System.Data.Entity;

namespace POINTS
{
    public partial class Form1 : Form
    {

        //SqlConnection sc = new SqlConnection//("Data Source=SKOCHETKOV\SQLEXPRESS;Initial Catalog=Points;Integrated Security=True");
       // SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PointsEntities1 db = new PointsEntities1();
            var events = db.EVENTS.ToList();

            var A = from a in db.STATUS
                    where a.STATUS_ID == 1
                    select a;

            var b = db.STATUS.Where(x => x.STATUS_ID == 1);

            dataGridView1.DataSource = events;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }
    }
}
