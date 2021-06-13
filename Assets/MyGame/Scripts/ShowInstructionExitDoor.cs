using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInstructionExitDoor : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    public GameObject InsertKeySign;
    public GameObject WinSign;

    public OpenDoor openedDoor;
    public CollectFrogs collectedFrogs;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" & openedDoor.isDoorUnlocked)
        {
            timerIsRunning = true;
            timeRemaining = 10;
            WinSign.SetActive(true);
        }

        if (col.gameObject.tag == "Player" & collectedFrogs.areFrogsCollected)
        {
            timerIsRunning = true;
            InsertKeySign.SetActive(true);
            timeRemaining = 10;
        }
    }

    public void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                InsertKeySign.SetActive(false);
                WinSign.SetActive(false);
            }

        }
    }
}
