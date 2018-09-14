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
namespace WFApp
{
    public partial class Form1 : Form
    {
        CategoryRepository repo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string param = textBox1.Text;
            
            var result = await Task.Factory.StartNew(() => repo.GetAll()
                        .Where(x => x.CategoryName.ToLower().Contains(param.ToLower())).ToList());
            foreach (var i in result)
                listBox1.Items.Add($"{i.CategoryId} - {i.CategoryName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repo = new CategoryRepository();
        }
    }
}
