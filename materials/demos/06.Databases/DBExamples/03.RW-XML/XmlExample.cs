using System;
using System.Collections.Generic;
using System.Xml;

class Item
{
    public string Type { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class XmlExample
{
    static List<Item> items = new List<Item>();

    static void Main()
    {
        ReadItems("./items.xml");
        PrintItems();
    }
    
    static void ReadItems(string filename)
    {
        Item item;
        using (XmlReader reader = XmlReader.Create(filename))
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "item":
                            item = new Item();
                            item.Type = reader.GetAttribute("type");
                            ReadItem(reader, item);
                            items.Add(item);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    static void ReadItem(XmlReader reader, Item item)
    {
        while (reader.Read())
        {
            if (reader.IsStartElement())
            {
                switch (reader.Name)
                {
                    case "name":
                        if (reader.Read())
                        {
                            item.Name = reader.Value;
                        }
                        break;
                    case "price":
                        if (reader.Read())
                        {
                            item.Price = double.Parse(reader.Value);
                        }
                        break;
                    default:
                        break;
                }
            }

            if (reader.NodeType == XmlNodeType.EndElement && 
                reader.Name == "item")
            {
                return;
            }
        }
    }

    static void PrintItems()
    {
        foreach (Item item in items)
        {
            Console.WriteLine("{0} - {1} - {2}",
                item.Name,
                item.Type,
                item.Price);
        }
    }
}