using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFrogs : MonoBehaviour
{
    bool[] frog = new bool[3];
    public AudioSource frog1;
    public AudioSource frog2;
    public AudioSource frog3;
    public GameObject cauldron;
        
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Frog 1")
        {
            frog[0] = true;
            frog1.Stop();
        }

        if (collision.gameObject.tag == "Frog 2")
        {
            frog[1] = true;
            frog2.Stop();
        }

        if (collision.gameObject.tag == "Frog 3")
        {
            frog[2] = true;
            frog3.Stop();
        }

        if (frog[0] & frog[1] & frog[2])
        {
            cauldron.SetActive(true);
        }
    }
}
