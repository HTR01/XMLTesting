using System.Collections.Generic;
using System.Xml.Serialization;

public class MonsterContainer
{
    [XmlArray("Monsters")]
    [XmlArrayItem("MyMonster")]
    public List<Monster> monsterContainer = new List<Monster>();
}
