using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindB_Click(object sender, EventArgs e)
        {
            FindTB2.Clear();
            string path = @"C:\Users\bakun\source\repos\zad3\Books.txt";
                foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(FindTB1.Text))
                {
                    FindTB2.Text += line + Environment.NewLine;
                }
            }
        } 
//Perfect job
        
    }
}
