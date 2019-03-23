using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Save_and_view : Form
    {
        List<Surf_country> Savelistbox = new List<Surf_country> ();

        public Save_and_view()
        {
            InitializeComponent();
        }
        private void saveload(object sender EventArgs e)
        {
            SavelistBox = registerandreadclass.Read();
        }
        private void viewbutton_Click(object sender, EventArgs e)
        {
            Surf_country s;
            Form1 Radd = new Form1();

            s = add.Getnew();
            if (s != null)
                SavelistBox.Radd(s);

        }
    }
}
