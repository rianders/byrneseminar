using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectClicker : MonoBehaviour
{
    public GameObject objectactive;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Physics.Raycast(cameraRay, out hit, distance, layer, QueryTriggerInteraction.Ignore);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider != null && hit.collider.gameObject  == this.gameObject)
                {
                    OpenCanvas(hit.collider.gameObject);
                }
            }
        }
    }

    void OpenCanvas(GameObject activeGO)
    {
        objectactive.SetActive(true);
    }
}
