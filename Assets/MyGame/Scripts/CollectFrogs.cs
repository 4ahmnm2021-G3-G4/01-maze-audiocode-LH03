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
    public AudioSource cauldronBubbling;

    public GameObject DropFrogsIntoCauldron;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    public bool areFrogsCollected;

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
            cauldronBubbling.Play();
            DropFrogsIntoCauldron.SetActive(true);
            timerIsRunning = true;
            areFrogsCollected = true;
        }

        //if (frog[2])
        //{
        //    cauldron.SetActive(true);
        //    cauldronBubbling.Play();
        //    DropFrogsIntoCauldron.SetActive(true);
        //    timerIsRunning = true;
        //    areFrogsCollected = true;
        //}

        void Update()
        {
            if (timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    DropFrogsIntoCauldron.SetActive(false);
                    timeRemaining = 0;
                    timerIsRunning = false;
                }

 
            }
        }
    }
}