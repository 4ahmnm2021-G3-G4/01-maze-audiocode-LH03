using UnityEngine;

public class FrogsInCauldron : MonoBehaviour
{
    public AudioSource frogDrop;
    public GameObject rotationSignCauldron;
    public GameObject ladle;
    bool[] frogHitCauldron = new bool[3];

    //When all the frogs are in the cauldron, the ladle is activated so that the Player can stir the potion
    private void OnCollisionEnter(Collision collision)
    {
        GameObject frog1 = GameObject.FindGameObjectWithTag("Frog 1");
        GameObject frog2 = GameObject.FindGameObjectWithTag("Frog 2");
        GameObject frog3 = GameObject.FindGameObjectWithTag("Frog 3");

        if (collision.gameObject.tag == "Frog 1")
        {
            frogHitCauldron[0] = true;
            frogDrop.Play();
            frog1.SetActive(false);
            frog1.transform.SetParent(null);
        }
        if (collision.gameObject.tag == "Frog 2")
        {
            frogHitCauldron[1] = true;
            frogDrop.Play();
            frog2.SetActive(false);
            frog2.transform.SetParent(null);
        }
        if (collision.gameObject.tag == "Frog 3")
        {
            frogHitCauldron[2] = true;
            frogDrop.Play();
            frog3.SetActive(false);
            frog3.transform.SetParent(null);
        }
        if (frogHitCauldron[0] & frogHitCauldron[1] & frogHitCauldron[2])
        {
            ladle.SetActive(true);
            rotationSignCauldron.SetActive(true);
        }
    }
}
