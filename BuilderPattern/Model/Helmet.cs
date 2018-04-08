using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    public class Helmet
    {
        int id;
        string name;
        double armor;
        Image img;
        public Helmet(int id, string name, double armor, Image img)
        {
            this.id = id;
            this.name = name;
            this.armor = armor;
            this.img = img;
        }
        public Image Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Armor
        {
            get
            {
                return armor;
            }

            set
            {
                armor = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public  string ToS1tring() { return name; }
        public override string ToString()
        {
            return "Helmet: [id]=" + id + ", [name]=" + name + ", [armor]=" + armor + ",  [image]=" + img;
        }
        public void draw(Graphics g, Size size)
        {
            if(img!=null)
                g.DrawImage(img, size.Width / 2 - 25, size.Height / 4 - 45, 50, 50);
        }
    }
}
