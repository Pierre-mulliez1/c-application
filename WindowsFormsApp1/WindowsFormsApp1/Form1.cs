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
    public partial class Form1 : Form
    {
        //declare variable
        double wave;
        Surf_country s;
        decimal cost;
        double weather;


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("please select a country by doubleclicking in the list provided");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear all button, listbox, input data
            wavetextBox.Text = "";
            pricelabel.Text = "";
            Temperaturelabel.Text = "";
            ResultlistBox.Items.Clear();
            fallradioButton.Checked = false;
            springradioButton.Checked = false;
            winterradioButton.Checked = false;
            summerradioButton.Checked = false;
            coralcheckBox.Checked = false;
            sandcheckBox.Checked = false;
            allcheckBox.Checked = false;
            rockcheckBox.Checked = false;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            //message if the wave backend text is left as null
            if (!double.TryParse(wavetextBox.Text, out wave))
            {
                MessageBox.Show("please enter a correct height");
            }
            else
            {
                double wave = double.Parse(wavetextBox.Text);


                {
                    /*all the configuration to find the place depending on criteria
                    https://www.booksurfcamps.com/news/surf-seasons-wave-riding */

                    try
                    {

                        //declare the possible outcome using the surfcountry class
                        Surf_country a, b, c, d, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v;
                        a = new Surf_country("Brasil", 30, 1500m);
                        b = new Surf_country("Costa Rica", 29, 900m);
                        c = new Surf_country("Portugal", 25, 1100m);
                        d = new Surf_country("Guadeloupe", 25, 1100m);
                        f = new Surf_country("Morocco", 25, 1100m);
                        g = new Surf_country("south Africa", 25, 1100m);
                        h = new Surf_country("Indonesia", 25, 1100m);
                        i = new Surf_country("Australia", 25, 1100m);
                        j = new Surf_country("sri Lanka", 25, 1100m);
                        k = new Surf_country("Thailand", 25, 1100m);
                        l = new Surf_country("Fiji", 18, 1100m);
                        m = new Surf_country("The Phillipines", 18, 1100m);
                        n = new Surf_country("Spain", 18, 1100m);
                        o = new Surf_country("UK", 18, 1100m);
                        p = new Surf_country("California", 18, 1100m);
                        q = new Surf_country("Hawaii", 18, 1100m);
                        r = new Surf_country("Costa Rica", 18, 1100m);
                        s = new Surf_country("Mexico", 18, 1100m);
                        t = new Surf_country("Peru", 18, 1100m);
                        u = new Surf_country("Chile", 18, 1100m);
                        v = new Surf_country("Nicaragua", 18, 1100m);

                   
                        if (springradioButton.Checked && wave <= 1 && coralcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(a.Country);

                        }
                        else if (springradioButton.Checked && wave <= 2 && wave > 1 && sandcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(b.Country);
                        }
                        else if (springradioButton.Checked && wave > 2 && rockcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(c.Country);
                        }
                        else if (springradioButton.Checked && wave > 2 && sandcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(d.Country);
                        }
                        else if (springradioButton.Checked && wave > 2 && allcheckBox.Checked)
                        {
                            //reuse existent variable 
                            ResultlistBox.Items.Add(c.Country);
                            ResultlistBox.Items.Add(d.Country);

                        }
                        else if (summerradioButton.Checked && wave <= 1 && coralcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(f.Country);
                        }
                        else if (summerradioButton.Checked && wave <= 2 && wave > 1 && rockcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(g.Country);
                        }
                        else if (summerradioButton.Checked && wave <= 1 && coralcheckBox.Checked)
                        {
                            ResultlistBox.Items.Add(h.Country);
                        }
                        else if (summerradioButton.Checked && wave <= 1 && allcheckBox.Checked)
                        {
                            //reuse existent variable 
                            ResultlistBox.Items.Add(f.Country);
                            ResultlistBox.Items.Add(h.Country);

                        }




                        else
                        {
                            //if there is no place found
                            ResultlistBox.Items.Add("no country match yet");
                        }



                    }
                    //just in case
                    catch
                    {
                        MessageBox.Show("error");
                    }



                    //if no season selected 
                    if (!(springradioButton.Checked || fallradioButton.Checked || summerradioButton.Checked || winterradioButton.Checked))
                    {
                        MessageBox.Show("please select a season");

                    }

                    //if no beach selected
                    if (!(sandcheckBox.Checked || rockcheckBox.Checked || coralcheckBox.Checked || allcheckBox.Checked))
                    {
                        MessageBox.Show("please select a beach style");

                    }

                    //reset after the result

                    fallradioButton.Checked = false;
                    springradioButton.Checked = false;
                    winterradioButton.Checked = false;
                    summerradioButton.Checked = false;
                    coralcheckBox.Checked = false;
                    sandcheckBox.Checked = false;
                    allcheckBox.Checked = false;
                    rockcheckBox.Checked = false;
                    wavetextBox.Text = "";




                }
            }
        }
        //find the cost for a week corresponding to the selected country

        public void ResullisttboxSelectedindex_DoubleClick(object sender, EventArgs e)

        {
           
            List<Surf_country> Resultlistbox = new List<Surf_country>();
            // resultbox.Selectedindex(s.getDisplayText);
          

            /*  string Country;
              decimal Price;
              double Temperature; */

            if (ResultlistBox.SelectedIndex != -1)
            {

                cost = s.Price;
                weather = s.Temperature;

                pricelabel.Text = cost.ToString("c");
                Temperaturelabel.Text = weather.ToString("");

                MessageBox.Show("ok");

            }
        }
        /* I cannot write surf.temperature = temperaturelabel.text as it violate the class condition for temperature; double
        I can neither write temperaturelabel.Text as a double as the convert method is not possible neither declaring a variable 
        and make it .tostring when equal to the Temperaturelabel.Text ie it says 'use of unsassigned variable'*/
        public void button5_Click(object sender, EventArgs e)
        { /*


            List<Surf_country> =  (list<Surf_country> s in ResultlistBox) ;
            s.Surf_Country = new Surf_country;
            s.Country = ResultlistBox.Items;
            s.Temperature = temp;
            s.Price = price;
            */
            Surf_country s;
            registerandreadclass Radd = new registerandreadclass();

            s = Radd.GetNew();
            if (s != null)
                SavelistBox.add;
           // registerandreadclass reg = new registerandreadclass();
            
            pricelabel.Text = cost.ToString("c");
            Temperaturelabel.Text = weather.ToString();

            

            // complcation with the savelistbox and resultlistbox
            if (ResultlistBox != null)
            {
                registerandreadclass.Save(Surf_country);
                

                ResultlistBox.Items.Clear();
            }



        }
        public Surf_country Getnew()
        {
            this.ShowDialog();
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

 