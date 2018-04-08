using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    public class Weapon
    {
        int id;
        string name;
        double power;
        double weight;
        Image img;
        public Weapon(int id, string name, double power, double weight, Image img)
        {
            this.id = id;
            this.name = name;
            this.power = power;
            this.weight = weight;
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

        public double Power
        {
            get
            {
                return power;
            }

            set
            {
                power = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
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
            return "Weapon: [id]=" + id + ", [name]=" + name + ", [power]=" + power + ", [weight]=" + weight + ", [image]=" + img;
        }

        public void draw(Graphics g, Size size)
        {
            if (img != null)
                //g.DrawImage(Image.FromFile("Images/sword.png"), size.Width / 2 - 50 - 10, size.Height / 4 + 30 + 50 - 10);
                g.DrawImage(img, new Rectangle(size.Width / 2 - 50 - 64, size.Height / 4 + 30 + 50 - 64, 80,80));
        }
    }
}
