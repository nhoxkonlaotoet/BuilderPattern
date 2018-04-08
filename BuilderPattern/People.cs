using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Model;
using System.Drawing;
namespace BuilderPattern
{
    public class People
    {
        int id;
        string name;
        double hp;
        Weapon weapon;
        Helmet helmet;
        Shoes shoes;
        public People(PeopleBuilder builder)
        {

            id = builder.id;
            name = builder.name;
            hp = builder.hp;
            weapon = builder.weapon;
            helmet = builder.helmet;
            shoes = builder.shoes;
        }
        public int Id() { return id; }
        public string Name() { return name; }
        public double HP() { return hp; }
        public Weapon Weapon() { return weapon; }
        public Helmet Helmet() { return helmet; }
        public Shoes Shoes() { return shoes; }
        public override string ToString()
        {
            return "[id]=" + id + ";\n[name]=" + name + ";\n[hp]=" + hp + ";\n[weapon]=" + weapon + ";\n[helmet]=" + helmet + ";\n[shoes]=" + shoes;

        }
        public void draw(Graphics g, Size size)
        {
            //if (weapon != null)
            //    if (weapon.Img != null)
            //        g.DrawImage(weapon.Img, size.Width / 2 - 50 - 10, size.Height / 4 + 30 + 50 - 10);
            //if (shoes != null)
            //    if (shoes.Img != null)
            //        g.DrawImage(shoes.Img, size.Width / 2 - 50 - 10, size.Height / 4 + 25 + 100 + 50 - 10);
            //if(helmet!=null)
            //    if(helmet.Img!=null)
            //        g.DrawImage(helmet.Img, size.Width / 2 - 25, size.Height / 4 - 40, 50, 25);
        }
        public class PeopleBuilder
        {
            public int id;
            public string name;
            public double hp;
            public Weapon weapon;
            public Helmet helmet;
            public Shoes shoes;
            //public PeopleBuilder(int id, string name, double hp)
            //{
            //    this.id = id;
            //    this.name = name;
            //    this.hp = hp;
            //}
            public PeopleBuilder setId(int id)
            {
                this.id = id;
                return this;
            }
            public PeopleBuilder setName(string name)
            {
                this.name = name;
                return this;
            }
            public PeopleBuilder setHP(double hp)
            {
                this.hp = hp;
                return this;
            }
            public PeopleBuilder setWeapon(Weapon weapon)
            {
                this.weapon = weapon;
                return this;
            }
            public PeopleBuilder setHelmet(Helmet helmet)
            {
                this.helmet = helmet;
                return this;
            }
            public PeopleBuilder setShoes(Shoes shoes)
            {
                this.shoes = shoes;
                return this;
            }
            public People build()
            {
                return new People(this);
            }
        }
    }
}
