using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassPractice
{
    internal class Bike
    {
        // fields 
        // brand
        // type
        // color
        // number of wheels 
        string _brand;
        string _type;
        string _color;
        int _wheels;

        // properties
        public string Brand
        { get { return _brand; } set {  _brand = value; } }
        public string Type
        { get { return _type; } set { _type = value; } }
        public string Color
        { get { return _color; } set { _type = value; } }
        public int Wheels
        { get { return _wheels; } set { _wheels = value; } }
    }
}
