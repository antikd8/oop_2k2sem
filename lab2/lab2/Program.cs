using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlatForm());
        }
    }

    public interface IOperations
    {
        double CountCost();
    }

    [Serializable]
    [XmlRoot(Namespace = "lab2")]
    [XmlType("flat")]
    public class Flat : IOperations
    {
        public Flat(double footage, int year, string material,int floor, bool kitchen,
            bool balcony, bool basement, bool livingRoom, bool bathroom, Address address)
        {
            Footage = footage;
            Year = year;
            Material = material;
            Floor = floor;
            Kitchen = kitchen;
            Balcony = balcony;
            Basement = basement;
            LivingRoom = livingRoom;
            Bathroom = bathroom;
            this.address = address;
        }

        public Flat() { }
        [XmlElement(ElementName = "footage")]
        public double Footage { get; set; }
        [XmlIgnore]
        public int AmountOfRooms { get; set; }
        [XmlIgnore]
        public bool Kitchen { get; set; }
        [XmlIgnore]
        public bool LivingRoom { get; set; }
        [XmlIgnore]
        public bool Bathroom { get; set; }
        [XmlIgnore]
        public bool Balcony { get; set; }
        [XmlIgnore]
        public bool Basement { get; set; }
        [XmlElement(ElementName = "Year_of_foundation")]
        public int Year { get; set; }
        [XmlElement(ElementName = "Material_of_building")]
        public string Material { get; set; } = "none";
        [XmlElement(ElementName ="Floor")]
        public int Floor { get; set; }
        [XmlElement(ElementName ="Cost_of_flat")]
        public double Cost { get; set; }
        public Address address { get; set; }


        public double CountCost()
        {
            double resultCost = 0;
            resultCost += Footage * 1100;
            resultCost += Floor * 50;
            if (Material == "Кирпич")
                resultCost += 5500;
            if (Material == "Дерево")
                resultCost += 1500;
            if (Material == "Блоки")
                resultCost += 2800;
            if (Material == "Бетонные плиты")
                resultCost += 3400;
            if (Material == string.Empty)
                MessageBox.Show("Выберите материал дома!");
            if (Footage < 5)
                MessageBox.Show("Выберите метраж квартиры!");
            resultCost += AmountOfRooms * 1000;
            if (LivingRoom)
                resultCost += 1000;
            if (Kitchen)
                resultCost += 750;
            if (Balcony)
                resultCost += 800;
            if (Basement)
                resultCost += 1000;
            resultCost += Year * 0.5;
            return resultCost;
        }
    }
    [Serializable]
    public class Address
    {
        public Address() { }
        public Address(string country, string district, string street, string houseNumber, string flatNumber)
        {
            Country = country;
            District = district;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
        }
        public string Country { get; set; } = "none";
        [XmlElement(ElementName = "District")]
        public string District { get; set; } = "none";
        public string Street { get; set; } = "none";
        [XmlElement(ElementName = "Number_of_house")]
        public string HouseNumber { get; set; } = "none";
        [XmlElement(ElementName = "Number_of_flat")]
        public string FlatNumber { get; set; } = "none";
    }
    [Serializable]
    public class Room
    {
        [XmlElement(ElementName ="Name_of_room")]
        public string Name { get; set; }
        [XmlElement(ElementName ="Footage_of_room")]
        public double Footage { get; set; }
        [XmlElement(ElementName ="Amount_of_windows")]
        public int AmountWindows { get; set; }
        [XmlElement(ElementName ="Side_of_windows")]
        public string SideWindows { get; set; }
    }

    public static class XmlSerializeWrapper
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T obj;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                obj = (T)formatter.Deserialize(fs);
            }
            return obj;
        }
    }


}
