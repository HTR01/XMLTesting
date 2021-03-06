﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] monsters;

    public void SpawnGoblin()
    {
        Instantiate(monsters[0]);
    }

    public void SpawnOgre()
    {
        Instantiate(monsters[1]);
    }
    public void SpawnTroll()
    {
        Instantiate(monsters[2]);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnGoblin();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnOgre();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnTroll();
        }
    }
}