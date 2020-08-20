using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int monID;

    public string Name;
    public int ID;
    public float Health;

    private void Start()
    {
        Name = ReadMonster.monsterName[monID];
        ID = ReadMonster.monsterID[monID];
        Health = ReadMonster.monsterHealth[monID];
    }
}