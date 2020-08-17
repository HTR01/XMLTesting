using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

public class ReadMonster : MonoBehaviour
{
    string path;
    public static string monsterName;
    public static float monsterHealth;

    MonsterContainer monCont = new MonsterContainer();

    private void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "Monster.xml");
        monCont = XmlOperation.Deserialize<MonsterContainer>(path);
    }

    public static void Spawn(int monID, Vector3 monPos)
    {
        Instantiate();
    }
}
