using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

public class ReadMonster : MonoBehaviour
{
    public static GameObject[] monster;

    string path;
    public static List<string> monsterName = new List<string>(3);
    public static List<int> monsterID = new List<int>(3);
    public static List<float> monsterHealth = new List<float>(3);

    MonsterContainer monCont = new MonsterContainer();

    private void Awake()
    {
        path = Path.Combine(Application.persistentDataPath, "Monster.xml");
        monCont = XmlOperation.Deserialize<MonsterContainer>(path);
    }

    private void Start()
    {
        monsterName.Add(monCont.monsterContainer[0].Name);
        monsterName.Add(monCont.monsterContainer[1].Name);
        monsterName.Add(monCont.monsterContainer[2].Name);
        monsterID.Add(monCont.monsterContainer[0].ID);
        monsterID.Add(monCont.monsterContainer[1].ID);
        monsterID.Add(monCont.monsterContainer[2].ID);
        monsterHealth.Add(monCont.monsterContainer[0].Health);
        monsterHealth.Add(monCont.monsterContainer[1].Health);
        monsterHealth.Add(monCont.monsterContainer[2].Health);
    }
}