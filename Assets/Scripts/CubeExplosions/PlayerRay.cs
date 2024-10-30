using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    [SerializeField] private Selectable CurrentSelectable;
    
    private void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Selectable selectable = hit.collider.gameObject.GetComponent<Selectable>();

                if (selectable)
                {
                    CurrentSelectable = selectable;
                    selectable.Select();
                }
            }
            
        }

    }
}
