using System.Xml.Serialization;

[XmlRoot("MyGun")]
public class Monster
{
    [XmlElement("MonsterName")]
    public string Name;
    public int ID;
    public float Health;
}
