using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Explosion ExplosionPrefab;
    public void Select()
    {
        EventManager.OnCubeSelected();
    }

    public void CubeExplode()
    {
        Explosion explosion = Instantiate(ExplosionPrefab);
        explosion.Explode();
    }

    public void DestroyCube()
    {
        gameObject.SetActive(false);
    }

    
}
