using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System;

[Serializable]
//[XmlRoot("InventoryClass")]
public class Inventory {
    //[XmlArray("Inventory")]
    //[XmlAttribute("Item")]
    public List<Item> inventory = new List<Item>();
	

    public void CreateInventory(int number)
    {
        Item item = new Item(3, 666, ItemType.armor, "DemonArmor");
        inventory.Add(item);
        for (int i =0; i < number; i++)
        {
            item = new Item();
            inventory.Add(item);
        }
        item = new Item(4, 616, ItemType.consumable, "Potion");
        inventory.Add(item);
    }

    public void LoadData()
    {
        var serializerXML = new XmlSerializer(typeof(Inventory));
        var stream = new FileStream(Path.Combine(Application.dataPath,"Inventory.xml"),FileMode.Open);
        var container = serializerXML.Deserialize(stream) as Inventory;
        stream.Close();
    }

    public void SaveData()
    {
        var serializerXML = new XmlSerializer(typeof(Inventory));
        var stream = new FileStream(Path.Combine(Application.dataPath, "Inventory.xml"), FileMode.Create);
        serializerXML.Serialize(stream,this);
        stream.Close();
    }

}
