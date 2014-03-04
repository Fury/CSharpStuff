using Les1_3_dll;
using Les1_3_dll.deel2;
using Les1_3_dll.deel3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Les1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Maand maand = new Maand{ Maandnr= 3,Jaar = 2014};

            Console.WriteLine(maand.ToString());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MediaFile mf = new MediaFile { fileInfo = new FileInfo(openFileDialog1.FileName) };
                propertyGrid1.SelectedObject = mf;
                propertyGrid2.SelectedObject = mf.fileInfo;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
