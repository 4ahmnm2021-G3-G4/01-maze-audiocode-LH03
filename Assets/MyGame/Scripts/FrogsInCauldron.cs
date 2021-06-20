using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class FrogsInCauldron : MonoBehaviour
{
    public AudioSource frogDrop;

    public GameObject rotationSignCauldron;
    public GameObject ladle;
    //public GameObject StirCauldron;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject frog1 = GameObject.FindGameObjectWithTag("Frog 1");
        GameObject frog2 = GameObject.FindGameObjectWithTag("Frog 2");
        GameObject frog3 = GameObject.FindGameObjectWithTag("Frog 3");
        bool[] frogHitCauldron = new bool[3];

        if (collision.gameObject.tag == "Frog 1")
        {

            frogHitCauldron[0] = true;
            Debug.Log(frogHitCauldron[0] + "The frog was being hit");
            frogDrop.Play();
            frog1.SetActive(false);
        }
        if (collision.gameObject.tag == "Frog 2")
        {
            frogHitCauldron[1] = true;
            frogDrop.Play();
            frog2.SetActive(false);
        }
        if (collision.gameObject.tag == "Frog 3")
        {
            frogHitCauldron[2] = true;
            frogDrop.Play();
            frog3.SetActive(false);
        }
        if (frogHitCauldron[0])
        {
            ladle.SetActive(true);
            //StirCauldron.SetActive(true);
            timerIsRunning = true;
            rotationSignCauldron.SetActive(true);

        }

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
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    timerIsRunning = false;
                }

            }


        }
    }
}
