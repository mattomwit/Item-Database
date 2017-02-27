using UnityEngine;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

public class Character : MonoBehaviour {

    public Inventory invent = new Inventory();
	// Use this for initialization
	void Start () {
        invent.CreateInventory(6);
    //    invent.SaveData();
        var serializerXML = new XmlSerializer(typeof(Inventory));
        var stream = new FileStream(Path.Combine(Application.dataPath, "Inventory.xml"), FileMode.Create);
        serializerXML.Serialize(stream, invent);
        stream.Close();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
