using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_Laba_7
{
    
    [Serializable]
    public class Student
    {
        public String familya { set; get; }
        public String name { set; get; }
        public String otchestvo { set; get; }
        public DateTime BDay;
        public int curs { set; get; }
        public String special { set; get; }
        public int gruppa { set; get; }
        public double avg_note { set; get; }
        public String pol { set; get; }
        public Adress adress=new Adress();
        public String telephon { set; get; }
        public Student()
        {
           
        }
    }
    [Serializable]
    public class Adress
    {

        public String city { set; get; }
        public  String index { set; get; }
        public String street { set; get; }
        public String house { set; get; }
        public String flat { set; get; }
        public Adress()
        {

        }
        public Adress(String c, String i, String s, String h, String f)
        {
            city = c;
            index = i;
            street = s;
            house = h;
            flat = f;
        }
        public override String ToString()
        {
            return "г." + city + " (" + index + ") ул." + street + " д." + house + " кв." + flat;
        }
    }
    [Serializable]
    public class UNIVER
    {
        public List<Student> students =new List<Student>();
        public UNIVER()
        {
            
        }
    }
}
