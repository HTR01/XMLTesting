using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

public class ReadMonster : MonoBehaviour
{
    public static GameObject[] monster;

    public static int listLength;

    string path;
    public static List<string> monsterName = new List<string>(listLength);
    public static List<int> monsterID = new List<int>(listLength);
    public static List<float> monsterHealth = new List<float>(listLength);

    MonsterContainer monCont = new MonsterContainer();

    private void Awake()
    {
        path = Path.Combine(Application.persistentDataPath, "Monster.xml");
        monCont = XmlOperation.Deserialize<MonsterContainer>(path);
    }

    private void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            monsterName.Add(monCont.monsterContainer[i].Name);
            monsterID.Add(monCont.monsterContainer[i].ID);
            monsterHealth.Add(monCont.monsterContainer[i].Health);
        }
    }
}