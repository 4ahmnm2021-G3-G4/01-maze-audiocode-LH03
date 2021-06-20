using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int counter;
    public Rigidbody key;

    private Vector3 target = new Vector3(-4.39f, 1.653f, 2.3f);
    private float speed = 1f;
    public bool isDoorUnlocked = false;
    public GameObject exitDoor;
    public GameObject keyTransform;
    public GameObject keySetCollider;
    public Collider keyCountCollider;

    public UnlockDoor keyFits;
    public AudioSource keyTurnSound;
    public AudioSource winSound;
    public AudioSource openDoor;

    public MeshRenderer keyholeCollider;
    public GameObject keyHoleCover;



    private void OnTriggerEnter(Collider collision)
    {
        GameObject[] arrayColliders = GameObject.FindGameObjectsWithTag("Wall Collider");



        if (collision.gameObject.tag == "Key" & keyFits.isKeyinDoor)
        {
            //keyCollider.SetActive(false);
            counter++;
            Debug.Log("Counter " + counter);
            keyTurnSound.Play();
            keySetCollider.SetActive(false);
        }


        if (counter == 3)
        {
            isDoorUnlocked = true;
            keyTransform.SetActive(false);
            openDoor.Play();
            winSound.Play();
            exitDoor.SetActive(false);
            keyHoleCover.SetActive(false);
            keyHoleCover.SetActive(false);
        }
    }

}
