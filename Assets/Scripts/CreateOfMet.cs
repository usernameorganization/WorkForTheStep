using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateOfMet : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;
    public GameObject prefab7;
    float x, y, z;
    int r;
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
        for (int i = 0; i < 100; i++)
        {
            r = random.Next(1, 7);
            x = random.Next(-200, 540);
            y = random.Next(-200, 540);
            z = random.Next(-200, 540);
            if (r == 1)
            {
                Instantiate(prefab1, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 2)
            {
                Instantiate(prefab2, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 3)
            {
                Instantiate(prefab3, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 4)
            {
                Instantiate(prefab4, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 5)
            {
                Instantiate(prefab5, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 6)
            {
                Instantiate(prefab6, new Vector3(x, y, z), Quaternion.identity);
            }
            if (r == 7)
            {
                Instantiate(prefab7, new Vector3(x, y, z), Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
       
            
    }
}
