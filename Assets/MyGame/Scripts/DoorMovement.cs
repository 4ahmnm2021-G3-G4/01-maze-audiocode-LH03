using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorMovement : MonoBehaviour
{


    [SerializeField] private Vector3 target = new Vector3(0, 0, 2.3f);
    [SerializeField] private float speed = 0.001f;
    private bool isPlayerThroughDoor = false;
    public GameObject door;
    public Collider doorCollider;
    public AudioSource doorCloseSound;
    public GameObject CollectFrogsSign;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnTriggetrDoor" + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            
            isPlayerThroughDoor = true;
            doorCollider.enabled = false;
            //CollectFrogsSign.SetActive(true);
            doorCloseSound.Play();
            timerIsRunning = true;
        }
        // Moves the object to target position

    }

    void Update()
    {
        if (isPlayerThroughDoor)
        {
            //Debug.Log(target.ToString());
            door.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }

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
                CollectFrogsSign.SetActive(false);

            }

        }


    }
}
