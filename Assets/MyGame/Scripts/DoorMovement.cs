using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMovement : MonoBehaviour
{


    [SerializeField] private Vector3 target = new Vector3(1, 1, 1);
    [SerializeField] private float speed = 0.1f;
    private bool isPlayerThroughDoor = false;
    public GameObject door;
    public Collider doorCollider;
    public AudioSource doorCloseSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isPlayerThroughDoor = true;
            doorCollider.enabled = false;
        }
        // Moves the object to target position

    }

    void Update()
    {
        if (isPlayerThroughDoor)
        {
            //Debug.Log(target.ToString());
            door.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            doorCloseSound.Play();
        }

    }


}
