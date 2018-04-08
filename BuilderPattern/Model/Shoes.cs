using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    public class Shoes
    {
        int id;
        string name;
        double speed;
        double armor;
        Image img;

        public Shoes(int id, string name, double speed, double armor,Image img)
        {
            this.id = id;
            this.name = name;
            this.speed = speed;
            this.armor = armor;
            this.img = img;
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

        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
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
        public string ToS1tring() { return name; }
        public override string ToString()
        {
            return "Shoes: [id]=" + id + ", [name]=" + name + ",[speed]="+speed+", [armor]=" + armor + ",  [image]=" + Img;
        }
        public void draw(Graphics g, Size size)
        {
            if (img != null)
                g.DrawImage(img, size.Width / 2 - 50 - 30, size.Height / 4 + 25 + 100 + 50 - 10,160,50);
         
        }
    }
}
