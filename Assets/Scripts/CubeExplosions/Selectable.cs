using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    [SerializeField] private Explosion ExplosionPrefab;
    [SerializeField] private Creator CreatorPrefab;
    public void Select()
    {
        
        Explosion explosion = Instantiate(ExplosionPrefab);
        Creator creator = Instantiate(CreatorPrefab);

        explosion.Explode();
        creator.Create();
        gameObject.SetActive(false);
      
    }


}
