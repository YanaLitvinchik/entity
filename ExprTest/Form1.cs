using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using LinqKit;

namespace ExprTest
{
    public partial class Form1 : Form
    {
        GoodRepository db = new GoodRepository();
        public Form1()
        {
            InitializeComponent();
            more5.CheckedChanged += button1_Click;
            pricem5000.CheckedChanged += button1_Click;
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
         //   dgGoods.DataSource = db.GetAll().Select(x =>new { x.GoodName, x.Price}).ToList();
            dgGoods.DataSource = db.GetAll().ToList();
        }

        private void more5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var predicate = PredicateBuilder.New<Good>(true);

            if (more5.Checked)
                predicate.And(x => x.GoodCount > 5);
            if (pricem5000.Checked)
                predicate.And(x => x.Price > 5000);
           // label1.Text = predicate.ToString();
            dgGoods.DataSource = db.GetAll().Where(predicate).ToList();
        }

        private void dgGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
