using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rd_Tesla_CheckedChanged(object sender, EventArgs e)
        {

            if (ch_Fiyat.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Model X");
                cbx_Model.Items.Add("Model Y");
                cbx_Model.Items.Add("Model S");
                ch_Kirlilik.Checked = false;
                ch_Performans.Checked = false;
            }
            else if (ch_Performans.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Model S");
                cbx_Model.Items.Add("Model Y");
                cbx_Model.Items.Add("Model X");
                ch_Fiyat.Checked = false;
                ch_Kirlilik.Checked = false;
            }
            else if (ch_Kirlilik.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Model X");
                cbx_Model.Items.Add("Model S");
                cbx_Model.Items.Add("Model Y");
                ch_Fiyat.Checked = false;
                ch_Performans.Checked = false;
            }

        }
        private void rd_Mazda_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Fiyat.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Mazda 6");
                cbx_Model.Items.Add("Mazda 3");
                cbx_Model.Items.Add("Mazda 5");

                ch_Kirlilik.Checked = false;
                ch_Performans.Checked = false;
            }
            else if (ch_Performans.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Mazda 6");
                cbx_Model.Items.Add("Mazda 5");
                cbx_Model.Items.Add("Mazda 3");
                ch_Fiyat.Checked = false;
                ch_Kirlilik.Checked = false;
            }
            else if (ch_Kirlilik.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Mazda 5");
                cbx_Model.Items.Add("Mazda 3");
                cbx_Model.Items.Add("Mazda 6");
                ch_Fiyat.Checked = false;
                ch_Performans.Checked = false;
            }

        }
        private void rd_Honda_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Fiyat.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("CR-V");
                cbx_Model.Items.Add("Civic");
                cbx_Model.Items.Add("City");
                ch_Kirlilik.Checked = false;
                ch_Performans.Checked = false;
            }
            else if (ch_Performans.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("Civic");
                cbx_Model.Items.Add("CR-V");
                cbx_Model.Items.Add("City");
                ch_Fiyat.Checked = false;
                ch_Kirlilik.Checked = false;
            }
            else if (ch_Kirlilik.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("City");
                cbx_Model.Items.Add("Civic");                
                cbx_Model.Items.Add("CR-V");                
                ch_Fiyat.Checked = false;
                ch_Performans.Checked = false;
            }

        }
        private void rd_Volvo_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Fiyat.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("S90");
                cbx_Model.Items.Add("XC90");
                cbx_Model.Items.Add("S60");                
                ch_Kirlilik.Checked = false;
                ch_Performans.Checked = false;
            }
            else if (ch_Performans.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("XC90");
                cbx_Model.Items.Add("S60");
                cbx_Model.Items.Add("S90"); 
                ch_Fiyat.Checked = false;
                ch_Kirlilik.Checked = false;
            }
            else if (ch_Kirlilik.Checked)
            {
                cbx_Model.Items.Clear();
                cbx_Model.Items.Add("S60");
                cbx_Model.Items.Add("S90");                
                cbx_Model.Items.Add("XC90");
                ch_Fiyat.Checked = false;
                ch_Performans.Checked = false;
            }
            
        }
    }
}
