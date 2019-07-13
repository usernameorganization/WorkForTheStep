using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOfShip : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit, 100))
            { 
                if (hit.collider.tag == "Rock")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}