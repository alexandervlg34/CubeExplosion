using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    //[SerializeField] private float scale;


    public void Create()
    {
        int count = Random.Range(2, 7);

        for (int i = 0; i < count; i++)
        {
            int x = Random.Range(-10, 11);
            int y = 1;
            int z = Random.Range(-10, 11);

            Vector3 position = new Vector3(x,y,z);

            Instantiate(Prefab, position, Quaternion.identity);
            
            /*
            scale /= 2;
            Prefab.transform.localScale = new Vector3(scale,scale,scale);
            */



            /*
            int color = Random.Range(0, 4);
            switch (color)
            {
                case 0:
                    Prefab.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case 1:
                    Prefab.GetComponent<Renderer>().material.color = Color.green;
                    break;
                case 2:
                    Prefab.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                case 3:
                    Prefab.GetComponent<Renderer>().material.color = Color.blue;
                    break;
            }
            */
        }
    }

}
