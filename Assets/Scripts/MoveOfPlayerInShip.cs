using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOfPlayerInShip : MonoBehaviour
{
    public float MouseX = 3f;


    private Quaternion originalRot;
    private float rotX;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.freezeRotation = true;
        }
        originalRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rotX += Input.GetAxis("Mouse X") * MouseX;

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);

        transform.localRotation = originalRot * xQuaternion;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * 10;
        }
        

    }
    
}
