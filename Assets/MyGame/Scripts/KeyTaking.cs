using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTaking : MonoBehaviour
{
    public KeyRotation rotateKey;
    public GameObject cauldronPackage;
    public GameObject findExitDoor;
    public AudioSource keyInHand;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rotateKey.enabled = false;
            cauldronPackage.SetActive(false);
            findExitDoor.SetActive(true);
            keyInHand.Play();

        }
    }
}
