using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazir_Komut_Calismalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] sehirler = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(sehirler, 0);

            object[] sehirler2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(sehirler2, 0);
            
            foreach (var item in listBox2.Items)
            {
                if (sehirler.Contains(item)==sehirler2.Contains(item))
                {
                    listBox3.Items.Add(item);
                }

            }
            
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object[] sehirler = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(sehirler, 0);

            object[] sehirler2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(sehirler2, 0);

            

            foreach (var item in listBox2.Items)
            {
                if (sehirler.Contains(item)!=sehirler2.Contains(item))
                {
                    listBox3.Items.Add(item);
                    
                }

                else
                {
                    MessageBox.Show("Aynı Olan Elemanlarınız Var" + "\n" + item + "\n");
                }


            }
           

        }
    }
}
