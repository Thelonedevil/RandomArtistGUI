﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.github.thelonedevil.RandomArtistGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 f = new Form2();
            f.Location = getOffset();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            MessageBox.Show("Your Random Artist: " + Program.random());

        }

       private Point getOffset(){
            Point loc = Location;
            loc.X = loc.X + ((int.Parse(loc.X.ToString())/100) *20);
            loc.Y = loc.Y - ((int.Parse(loc.Y.ToString())/100) *20);
            return loc;
        }
        
    }
}
