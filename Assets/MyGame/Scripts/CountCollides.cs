using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollides : MonoBehaviour
{

    public int counter;
    public GameObject key;
    public GameObject rotationSign;
    public AudioSource keyAppears;
    public AudioSource ladleHitsCauldron;
    public GameObject cauldron;
    public GameObject ladle;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ladle")
        {
            counter++;
            ladleHitsCauldron.Play();

            if (counter == 2)
            {
                rotationSign.SetActive(false);
            }

            if (counter == 4)
            {
                //Debug.Log("It works");
                key.SetActive(true);
                keyAppears.Play();
                cauldron.SetActive(false);
                ladle.SetActive(false);

            }

        }
    }
}

