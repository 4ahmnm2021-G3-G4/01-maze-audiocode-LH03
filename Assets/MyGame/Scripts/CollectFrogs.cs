using UnityEngine;

public class CollectFrogs : MonoBehaviour
{
    bool[] frog = new bool[3];
    public AudioSource soundFrog1;
    public AudioSource soundFrog2;
    public AudioSource soundFrog3;
    public GameObject cauldron;
    public AudioSource cauldronBubbling;
    public Transform basket;
    public bool areFrogsCollected;

    public GameObject frog1;
    public GameObject frog2;
    public GameObject frog3;

    //When the frogs are being thrown into the basket, they get parented to the basket, so that they stay in the basket while the Player teleports
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == frog1)
        {
            frog[0] = true;
            soundFrog1.Stop();
            frog1.transform.SetParent(basket);
        }
        if (collision.gameObject == frog2)
        {
            frog[1] = true;
            soundFrog2.Stop();
            frog2.transform.SetParent(basket);
        }
        if (collision.gameObject == frog3)
        {
            frog[2] = true;
            soundFrog3.Stop();
            frog3.transform.SetParent(basket);
        }

        if (frog[0] & frog[1] & frog[2])
        {
            cauldron.SetActive(true);
            cauldronBubbling.Play();
            areFrogsCollected = true;
        }
    }

    //When the frogs are leave the trigger, they get unparented from the basket
    private void OnTriggerExit(Collider collision)
    {
        frog1.transform.SetParent(null);
        frog2.transform.SetParent(null);
        frog3.transform.SetParent(null);
    }
}