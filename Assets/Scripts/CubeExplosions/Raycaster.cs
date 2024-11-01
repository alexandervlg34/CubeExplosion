using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    private void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Cube cubeSelectable = hit.collider.gameObject.GetComponent<Cube>();

                if (cubeSelectable)
                {
                    cubeSelectable.Select();
                    cubeSelectable.CubeExplode();
                    cubeSelectable.DestroyCube();
                }
            }

        }

    }
}
