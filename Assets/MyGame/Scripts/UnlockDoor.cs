using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public Rigidbody key;
    public bool isKeyinDoor = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            Debug.Log("Works");
            key.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            isKeyinDoor = true;
        }


    }
}

