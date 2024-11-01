// using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesFactory : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private int minCubesToSpawn = 2;
    [SerializeField] private int maxCubesToSpawn = 7;
    [SerializeField] private int minPosition = -10;
    [SerializeField] private int maxPosition = 11;

    

    private void Start()
    {
        EventManager.CubeSelected += OnSelected;
    }

    private void OnDestroy()
    {
        EventManager.CubeSelected -= OnSelected;
    }
    private void OnSelected()
    {
        CreateCube();
    }

    private void CreateCube()
    {
        int count = Random.Range(minCubesToSpawn, maxCubesToSpawn);

        for (int i = 0; i < count; i++)
        {
            int x = Random.Range(minPosition, maxPosition);
            int y = 1;
            int z = Random.Range(minPosition, maxPosition);

            Vector3 position = new Vector3(x, y, z);

            Instantiate(Prefab, position, Quaternion.identity);
        }
    }


}
