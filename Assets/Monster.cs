using System.Xml.Serialization;

[XmlRoot("MyGun")]
public class Monster
{
    [XmlElement("GunName")]
    public string Name;
    public int ID;
    public float Health;
}
