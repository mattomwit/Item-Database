using System;
using System.Xml;
using System.Xml.Serialization;

[Serializable]
public class Item {
    public Item()
    {
        Ammount = 1;
        ID = 111;
        ItemType = ItemType.weapon;
        ItemName = "dagger";
    }
    public Item(int ammount, int id, ItemType itemtype, string itemName)
    {
        Ammount = ammount;
        ID = id;
        ItemType = itemtype;
        ItemName = itemName;
    }

//	[XmlAttribute("Ammount")]
	public int Ammount;
//  [XmlAttribute("ID")]
	public int ID;

	public ItemType ItemType;
//	[XmlAttribute("ItemName")]
	public string ItemName;

}



public enum ItemType{
//[XmlEnum(Name="Weapon")]
	weapon,
//			[XmlEnum(Name="Armor")]
	armor,
//			[XmlEnum(Name="shield")]
	shield,
//			[XmlEnum(Name="Consumable")]
	consumable,
//			[XmlEnum(Name="Ammo")]
	ammo,
//			[XmlEnum(Name="QuestItem")]
	questItem
}