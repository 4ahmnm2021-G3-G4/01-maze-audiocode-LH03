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

    private void OnCollisionEnter(Collision collision)
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
}