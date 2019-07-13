using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOfShip : MonoBehaviour
{
    

    public float timersecond;
    public float secondgametime = 2.5f;
    public float secondgametimereset = 2.5f;

    public float MouseX = 3f;
    public float MouseY = 3f;

    private Quaternion originalRot;
    private float rotX;
    private float rotY;

    public int speed = 10;
    public double petrol = 100;



    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.freezeRotation = true;
        }
        originalRot = transform.rotation;
    }
    private void Update()
    {
        rotX += Input.GetAxis("Mouse X") * MouseX;
        rotY += Input.GetAxis("Mouse Y") * MouseY;

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, Vector3.left);

        transform.localRotation = originalRot * xQuaternion * yQuaternion;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime;
        }



        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            if ((petrol <= 100) && (petrol > 0))
            {
                speed = 10;
                transform.position += transform.forward * Time.deltaTime * speed;
                petrol -= 0.3;

            }
        }



        if (petrol <= 0)
        {
            if (secondgametime >= 2.5)
            {
                timersecond += 0.05f;
            }
            if (secondgametime >= 2.5)
            {
                secondgametime = secondgametimereset;
            }
            if (timersecond >= 40)
            {
                petrol = 100;
                timersecond = 0;
            }

        }
        
    }
    private void ComeInShip()
    {
        
    }
}

