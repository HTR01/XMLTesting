using UnityEngine;
using System.IO;

public class Serializer : MonoBehaviour
{
    private void Start()
    {
        MonsterContainer monsterContainer = new MonsterContainer();

        monsterContainer.monsterContainer.Add(new Monster
        {
            Name = "Goblin",
            ID = 0,
            Health = 50f
        });

        monsterContainer.monsterContainer.Add(new Monster
        {
            Name = "Ogre",
            ID = 1,
            Health = 100f
        });

        XmlOperation.Serialize(monsterContainer, Path.Combine(Application.persistentDataPath, "Monster.xml"));
    }
}
