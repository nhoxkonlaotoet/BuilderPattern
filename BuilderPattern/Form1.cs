using BuilderPattern.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuilderPattern
{
    public partial class Form1 : Form
    {
        public const string NAME_NONE = "None";
        public const string TYPE_HELMET = "Helmet";
        public const string TYPE_WEAPON = "Weapon";
        public const string TYPE_SHOES = "Shoes";

        List<People> lstPeople = new List<People>();
        List<Weapon> lstWp = new List<Weapon>();
        List<Helmet> lstHm = new List<Helmet>();
        List<Shoes> lstSh = new List<Shoes>();
        string type = "none";
        // temp variable
        Weapon wp;
        Helmet hm;
        Shoes sh;

        public Form1()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            btnHelmet.Tag = TYPE_HELMET;
            btnShoes.Tag = TYPE_SHOES;
            btnWeapon.Tag = TYPE_WEAPON;
            lstWp.Add(new Weapon(-1, NAME_NONE, 0, 0, null));
            lstWp.Add(new Weapon(0, "Rìu axe", 80, 11, Image.FromFile("Images/axe.png")));
            lstWp.Add(new Weapon(1, "Gươm", 70, 8, Image.FromFile("Images/sword.png")));
            lstWp.Add(new Weapon(2, "Bazoka", 140, 5, Image.FromFile("Images/bazooka.png")));
            lstWp.Add(new Weapon(3, "Đô la thần chưởng", 1000, 10, Image.FromFile("Images/money-bag.png")));
            lstWp.Add(new Weapon(4, "Giáo", 100, 2, Image.FromFile("Images/spear.png")));

            lstHm.Add(new Helmet(-1, NAME_NONE, 0, null));
            lstHm.Add(new Helmet(0, "Nón cấp 1", 80, Image.FromFile("Images/santa.png")));
            lstHm.Add(new Helmet(1, "Nón cấp 2", 80, Image.FromFile("Images/helmet.png")));
            lstHm.Add(new Helmet(2, "Nón cấp 3", 80, Image.FromFile("Images/cap.png")));


            lstSh.Add(new Shoes(-1, NAME_NONE, 0, 0, null));
            lstSh.Add(new Shoes(0, "Giày cấp 3", 60, 60, Image.FromFile("Images/shoe.png")));
            lstSh.Add(new Shoes(1, "Giày sneaker", 40, 45, Image.FromFile("Images/sneaker.png")));
            lstSh.Add(new Shoes(2, "Guốc đỏ", 30, 30, Image.FromFile("Images/high-heel.png")));
            //.Select(n=>n.Name).ToList<string>();

            lstPeople.Add(new People.PeopleBuilder()
                .setId(0)
                .setName("BOT cute")
                .setHP(823)
                .setWeapon(lstWp[1])
                .setShoes(lstSh[2]).build());
            lstPeople.Add(new People.PeopleBuilder()
               .setId(1)
               .setName("BOT mập")
               .setHP(3248)
               .setWeapon(lstWp[4])
               .setHelmet(lstHm[2])
               .setShoes(lstSh[1]).build());
            lstPeople.Add(new People.PeopleBuilder()
                           .setId(2)
                           .setName("BOT lùn")
                           .setHP(2000)
                           .setWeapon(lstWp[5])
                           .setHelmet(lstHm[1]).build());


            //Weapon wp = (Weapon)listBox1.Items[0];
            //MessageBox.Show(wp.Name);
        }
        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            People.PeopleBuilder builder = new People.PeopleBuilder()
               .setId(lstPeople.Count)
               .setName(txtName.Text)
                .setHP(1000);

            builder.setWeapon(wp);

            builder.setHelmet(hm);

            builder.setShoes(sh);


            People p1 = builder.build();
            lstPeople.Add(p1);
            //panel1.people = p1;
            //panel1.Refresh();
            foreach (People p in lstPeople)
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (type)
            {
                case TYPE_HELMET:
                    if (((Helmet)listBox1.SelectedItem).Name == NAME_NONE)
                        hm = null;
                    else
                        hm = (Helmet)listBox1.SelectedItem;
                    panel1.helmet = hm;
                    break;
                case TYPE_WEAPON:
                    if (((Weapon)listBox1.SelectedItem).Name == NAME_NONE)
                        wp = null;
                    else
                        wp = (Weapon)listBox1.SelectedItem;
                    panel1.weapon = wp;
                    break;
                case TYPE_SHOES:
                    if (((Shoes)listBox1.SelectedItem).Name == NAME_NONE)
                        sh = null;
                    else
                        sh = (Shoes)listBox1.SelectedItem;
                    panel1.shoes = sh;
                    break;
                default: break;


            }
            panel1.Refresh();

        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            type = ((Button)sender).Tag.ToString();

            switch (type)
            {
                case TYPE_HELMET:
                    listBox1.DataSource = lstHm;
                    break;
                case TYPE_WEAPON:
                    listBox1.DataSource = lstWp;
                    break;
                case TYPE_SHOES:
                    listBox1.DataSource = lstSh;
                    break;
                default: break;
            }
        }
    }


}