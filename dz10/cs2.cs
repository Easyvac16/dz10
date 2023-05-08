using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    public class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double CurrentVolume { get; set; }
        public List<Item> Contents { get; set; }

        public event EventHandler<ItemEventArgs> ItemAdded;

        public void AddItem(Item item)
        {
            if (CurrentVolume + item.Volume <= Volume)
            {
                Contents.Add(item);
                CurrentVolume += item.Volume;
                OnItemAdded(new ItemEventArgs(item, $"Item {item.Name} added to backpack"));
            }
            else
            {
                throw new Exception("Not enough space in backpack");
            }
        }

        protected virtual void OnItemAdded(ItemEventArgs e)
        {
            ItemAdded?.Invoke(this, e);
        }

        public Backpack()
        {
            Contents = new List<Item>();
        }

        public void SetColor(string color)
        {
            Color = color;
        }

        public void SetBrand(string brand)
        {
            Brand = brand;
        }

        public void SetManufacturer(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public void SetFabric(string fabric)
        {
            Fabric = fabric;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }

        public void SetVolume(double volume)
        {
            Volume = volume;
        }

        public void PrintContents()
        {
            Console.WriteLine($"Backpack contents ({CurrentVolume}/{Volume} volume used):");
            foreach (var item in Contents)
            {
                Console.WriteLine($"- {item.Name} ({item.Volume} volume)");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }
    }

    public class ItemEventArgs : EventArgs
    {
        public Item Item { get; }
        public string Message { get; }

        public ItemEventArgs(Item item, string message)
        {
            Item = item;
            Message = message;
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            var backpack = new Backpack();
            backpack.SetColor("Blue");
            backpack.SetBrand("Nike");
            backpack.SetManufacturer("China");
            backpack.SetFabric("Polyester");
            backpack.SetWeight(0.5);
            backpack.SetVolume(10);

            backpack.ItemAdded += (sender, e) =>
            {
                Console.WriteLine(e.Message);
            };

            var item1 = new Item { Name = "Water Bottle", Volume = 1 };
            var item2 = new Item { Name = "Notebook", Volume = 2 };
            var item3 = new Item { Name = "Pencil Case", Volume = 0.5 };
            var item4 = new Item { Name = "Lunch Box", Volume = 3 };
            var item5 = new Item { Name = "Jacket", Volume = 4 };

            try
            {
                backpack.AddItem(item1);
                backpack.AddItem(item2);
                backpack.AddItem(item3);
                backpack.AddItem(item4);
                backpack.AddItem(item5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            backpack.PrintContents();
        }
    }
}
