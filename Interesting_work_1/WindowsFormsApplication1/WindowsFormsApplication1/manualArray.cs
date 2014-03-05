using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class manualArray : Form
    {
        public manualArray()
        {
            InitializeComponent();
        }

        private void SizeOfArray_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateArray_Click(object sender, EventArgs e)
        {
            ManualArray();
        }

        public void ManualArray()
        {
            string s = ArrayInput.Text;
            string[] arrstring = new string[1];
            if (s != "")
            {
                arrstring = s.Split(' ');
            }
            int[] mas = new int[arrstring.Length];
            for (int i = 0; i < arrstring.Length; i++)
            {
                mas[i] = Convert.ToInt32(arrstring[i]);
            }
        }
    }
}
