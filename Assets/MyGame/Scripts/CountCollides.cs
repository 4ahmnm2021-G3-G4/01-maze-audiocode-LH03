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
    public GameObject arrowSign;

    private void OnTriggerEnter(Collider collision)
    {
        //Counter counts the times the ladle hits the collider
        if (collision.gameObject.tag == "Ladle")
        {
            counter++;
            ladleHitsCauldron.Play();

            if (counter == 2)
            {
                rotationSign.SetActive(false);
            }

            //If the colliders was hit four times the key appears and the cauldron disappears
            if (counter == 4)
            {
                key.SetActive(true);
                keyAppears.Play();
                cauldron.SetActive(false);
                ladle.SetActive(false);
                arrowSign.SetActive(true);
            }

        }
    }
}

