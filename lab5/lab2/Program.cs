using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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

    public interface IFactory
    {
        IProperty setProperty();
    }

    public interface IProperty
    {
        string Property { get; }
    }

    public class SallingFlat : IProperty
    {
        public string Property => "Квартира продается!";
    }

    public class NotSallingFlat : IProperty
    {
        public string Property => "Квартира не продается!";
    }

    public class SallingFactory : IFactory
    {
        public IProperty setProperty()
        {
            return new SallingFlat();
        }
    }

    public class NotSallingFactory : IFactory
    {
        public IProperty setProperty()
        {
            return new NotSallingFlat();
        }
    }

    public sealed class Singletone
    {
        private static Singletone instance;
        private Singletone() { }
        private static Singletone GetInstance()
        {
            return instance ?? (instance = new Singletone());
        }
        public static void Design(Form form)
        {
            form.BackColor = Color.Beige;
            form.Font = new Font("Times New Roman", 10, FontStyle.Italic);
            form.Size = new Size(1200, 700);
        }
    }

    public interface Prototype
    {
        Prototype Clone();
    }

    //паттерн Adapter
    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }

    class Target
    {
        public virtual void Request()
        { }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        { }
    }

    //паттерн Decorator
    abstract class FlatDecorator : Flat
    {
        protected Flat flat;
        public FlatDecorator(string flatName, Flat flat) : base(flatName)
        {
            this.flat = flat;
        }

    }

    class HomeFlat : FlatDecorator
    {
        public HomeFlat(Flat flat) : base("Домашний адрес", flat) { }
    }

    class FathersFlat : FlatDecorator
    {
        public FathersFlat(Flat flat) : base("Квартира отца", flat) { }
    }


    // паттерн Strategy
    interface IRepair
    {
        void Repair();
    }

    class BrickRepair : IRepair
    {
        public void Repair()
        {
            MessageBox.Show("Ремонт кирпичами!");
        }
    }

    class WoodReapir : IRepair
    {
        public void Repair()
        {
            MessageBox.Show("Ремонт деревом!");
        }
    }

    class BlocksRepair : IRepair
    {
        public void Repair()
        {
            MessageBox.Show("Ремонт блоками!");
        }
    }

    class PlatesRepair : IRepair
    {
        public void Repair()
        {
            MessageBox.Show("Ремонт плитами!");
        }
    }

    public interface IOperations
    {
        double CountCost();
    }

    public enum SearchType
    {
        searchYear = 0,
        searchDistrict,
        searchRooms
    }

    //член паттерна State
    public enum FlatState
    {
        salling = 0,
        notsalling,
        repairing
    }

    [Serializable]
    [XmlRoot(Namespace = "lab2")]
    [XmlType("flat")]
    public class Flat : IOperations, Prototype
    {
        public Flat(double footage, int amounOfRooms, int year, string material, int floor, bool kitchen,
            bool balcony, bool basement, bool livingRoom, bool bathroom, string property, Address address)
        {
            Footage = footage;
            AmountOfRooms = amounOfRooms;
            Year = year;
            Material = material;
            Floor = floor;
            Kitchen = kitchen;
            Balcony = balcony;
            Basement = basement;
            LivingRoom = livingRoom;
            Bathroom = bathroom;
            Property = property;
            this.address = address;
        }


        public Flat(double footage, int amounOfRooms, int year, string material, int floor, bool kitchen,
            bool balcony, bool basement, bool livingRoom, bool bathroom, string property, FlatState flatState, Address address)
        {
            Footage = footage;
            AmountOfRooms = amounOfRooms;
            Year = year;
            Material = material;
            Floor = floor;
            Kitchen = kitchen;
            Balcony = balcony;
            Basement = basement;
            LivingRoom = livingRoom;
            Bathroom = bathroom;
            Property = property;
            this.address = address;
            this.flatState = flatState;
        }

        public Flat(string flatName)
        {
            FlatName = flatName;
        }
        [XmlElement(ElementName = "flat_state")]
        public FlatState flatState { get; set; }

        public Flat() { }
        [XmlElement(ElementName = "footage")]
        [Required]
        [Range(1, 300, ErrorMessage = "Диапазон площади 300 м^2")]
        public double Footage { get; set; }
        [Required(AllowEmptyStrings = true)]
        [XmlElement(ElementName = "amount_of_rooms")]
        [RegularExpression(@"\d+", ErrorMessage = "Неверно введено кол-во комнат")]
        public int AmountOfRooms { get; set; }
        [XmlElement(ElementName = "address_name")]
        public string FlatName { get; set; }
        [XmlElement(ElementName = "kitchen")]
        public bool Kitchen { get; set; }
        [XmlElement(ElementName = "living_room")]
        public bool LivingRoom { get; set; }
        [XmlElement(ElementName = "bathroom")]
        public bool Bathroom { get; set; }
        [XmlElement(ElementName = "balcony")]
        public bool Balcony { get; set; }
        [XmlElement(ElementName = "basement")]
        public bool Basement { get; set; }
        [XmlElement(ElementName = "Year_of_foundation")]
        public int Year { get; set; }
        [XmlElement(ElementName = "Material_of_building")]
        [Required(ErrorMessage = "Отсутствует материал")]
        public string Material { get; set; } = "none";
        [XmlElement(ElementName = "Floor")]
        public int Floor { get; set; }
        [XmlElement(ElementName = "Cost_of_flat")]
        public double Cost { get; set; }
        [XmlElement(ElementName = "Property")]
        public string Property { get; set; }
        [Required]
        public Address address { get; set; }
        [Index]
        public string ZipCode { get; set; }

        public string RepairType { get; set; }


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
        public TreeNode TakeElementTree()
        {
            TreeNode name = new TreeNode("Квартира");
            name.Nodes.Add("Метраж: " + Footage);
            name.Nodes.Add("Этаж: " + Floor);
            name.Nodes.Add("Кол-во комнат: " + AmountOfRooms);
            name.Nodes.Add("Год: " + Year);
            name.Nodes.Add("Адрес: ");
            name.Nodes.Add("Район:" + address.District);
            name.Nodes.Add("Улица:" + address.Street);
            name.Nodes.Add("Номер дома: " + address.HouseNumber);
            name.Nodes.Add("Номер квартиры: " + address.FlatNumber);
            name.Nodes.Add("Индекс: " + address.Index);
            return name;
        }

        public Prototype Clone()
        {
            return new Flat(
                this.Footage,
                this.AmountOfRooms,
                this.Year,
                this.Material,
                this.Floor,
                this.Kitchen,
                this.Balcony,
                this.Basement,
                this.LivingRoom,
                this.Bathroom,
                this.Property,
                this.address);
        }
    }

    public abstract class AddressBuilder
    {
        public Address address { get; private set; }
        public void CreateAddress()
        {
            address = new Address();
        }
        public abstract void setCountry(string counrty);
        public abstract void setDistrict(string district);
        public abstract void setStreet(string street);
        public abstract void setHouseNumber(string hiuseNumber);
        public abstract void setFlatNumber(string flatNumber);
    }

    public class Address1 : AddressBuilder
    {
        public override void setCountry(string counrty)
        {
            address.Country = counrty;
        }

        public override void setDistrict(string district)
        {
            address.District = district;
        }

        public override void setFlatNumber(string flatNumber)
        {
            address.FlatNumber = flatNumber;
        }

        public override void setHouseNumber(string houseNumber)
        {
            address.HouseNumber = houseNumber;
        }

        public override void setStreet(string street)
        {
            address.Street = street;
        }
    }

    public class MakeAddress
    {
        public Address Make(AddressBuilder builder)
        {
            builder.CreateAddress();
            builder.setCountry(FlatForm.country);
            builder.setDistrict(FlatForm.district);
            builder.setFlatNumber(FlatForm.flatNumber);
            builder.setHouseNumber(FlatForm.houseNumber);
            builder.setStreet(FlatForm.street);
            return builder.address;
        }
    }

    [Serializable]
    public class Address
    {
        public Address() { }
        public Address(string country, string district, string street, string houseNumber, string flatNumber, string index)
        {
            Country = country;
            District = district;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
            Index = index;
        }
        public string Country { get; set; } = "none";
        [XmlElement(ElementName = "District")]
        public string District { get; set; } = "none";
        public string Street { get; set; } = "none";
        [XmlElement(ElementName = "Number_of_house")]
        public string HouseNumber { get; set; } = "none";
        [XmlElement(ElementName = "Number_of_flat")]
        public string FlatNumber { get; set; } = "none";
        [XmlElement(ElementName = "Postal_code")]
        public string Index { get; set; }
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
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                obj = (T)serializer.Deserialize(fs);
            }
            return obj;
        }
    }

}
