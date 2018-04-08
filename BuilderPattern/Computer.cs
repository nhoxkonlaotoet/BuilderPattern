using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Computer
    {
        // required parameters
        private string HDD;
        private string RAM;
        // optional parameters
        private string chip;
        private bool isGraphicsCardEnabled;
        private bool isBluetoothEnabled;
        public string getHDD()
        {
            return HDD;
        }
        public string getRAM()
        {
            return RAM;
        }
        public string getChip()
        {
            return chip;
        }
        public bool IsGraphicsCardEnabled()
        {
            return isGraphicsCardEnabled;
        }
        public bool IsBluetoothEnabled()
        {
            return isBluetoothEnabled;
        }
        public Computer(ComputerBuilder builder)
        {
          
            HDD = builder.HDD;
            RAM = builder.RAM;
            chip = builder.chip;
            isGraphicsCardEnabled = builder.isGraphicsCardEnabled;
            isBluetoothEnabled = builder.isBluetoothEnabled;
        }
        
         public override string ToString()
        {
            return "Computer [HDD=" + HDD + ", RAM=" + RAM + ",Chip="+chip+", isGraphicsCardEnabled=" + isGraphicsCardEnabled
                + ", isBluetoothEnabled=" + isBluetoothEnabled + "]";
        }
        // Builder Class
        public class ComputerBuilder
        {
            // required parameters
            public string HDD;
            public string RAM;
            // optional parameters
            public string chip;
            public bool isGraphicsCardEnabled;
            public bool isBluetoothEnabled;
            public ComputerBuilder(string hdd, string ram)
            {
                HDD = hdd;
                RAM = ram;
            }
            public ComputerBuilder setChip(string chip)
            {
                this.chip = chip;
                return this;
            }
            public ComputerBuilder setGraphicsCardEnabled(bool isGraphicsCardEnabled)
            {
                this.isGraphicsCardEnabled = isGraphicsCardEnabled;
                return this;
            }
            public ComputerBuilder setBluetoothEnabled(bool isBluetoothEnabled)
            {
                this.isBluetoothEnabled = isBluetoothEnabled;
                return this;
            }
            public Computer build()
            {
                return new Computer(this);
            }
        }
    }
}
