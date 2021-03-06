﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnableObjects so;
    private GameObject _parentObject;
    public List<SpawnableObjects> listSO;

    private void Awake()
    {
        _parentObject = new GameObject();
        StartCoroutine(StartSpawnLoop());
    }

    IEnumerator StartSpawnLoop()
    {
        for (int i = 0; i < 50; i++)
        {
            for (int x = 0; x < 50; x++)
            {
                so.prefabPosition = new Vector3(i,0,x);
                so.Spawner(_parentObject);
            }
            yield return null;
        }
    }
}
