using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string text = textBox1.Text;
            Program.artists.Add(text);
            Program.Save(text);
            MessageBox.Show("You added " + text + " to the list.");
            Close();
        }
    }
}
