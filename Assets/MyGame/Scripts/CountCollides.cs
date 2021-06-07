using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollides : MonoBehaviour
{

    public int counter;
    public GameObject key;
    public GameObject invisibleKeyStand;
    public GameObject rotationSign;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ladle")
        {
            counter++;

            if (counter == 2)
            {
                rotationSign.SetActive(false);
            }

            if (counter == 4)
            {
                //Debug.Log("It works");
                key.SetActive(true);
                invisibleKeyStand.SetActive(true);
            }

        }
    }
}

