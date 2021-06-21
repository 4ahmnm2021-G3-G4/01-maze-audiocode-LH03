using UnityEngine;

public class FrogsInCauldron : MonoBehaviour
{
    public AudioSource frogDrop;
    public GameObject rotationSignCauldron;
    public GameObject ladle;
    bool[] frogHitCauldron = new bool[3];

    private void OnCollisionEnter(Collision collision)
    {
        GameObject frog1 = GameObject.FindGameObjectWithTag("Frog 1");
        GameObject frog2 = GameObject.FindGameObjectWithTag("Frog 2");
        GameObject frog3 = GameObject.FindGameObjectWithTag("Frog 3");

        if (collision.gameObject.tag == "Frog 1")
        {
            frogHitCauldron[0] = true;
            Debug.Log(frogHitCauldron[0] + "The frog 1 was being hit");
            frogDrop.Play();
            frog1.SetActive(false);
            frog1.transform.SetParent(null);
        }
        if (collision.gameObject.tag == "Frog 2")
        {
            frogHitCauldron[1] = true;
            Debug.Log(frogHitCauldron[1] + "The frog 2 was being hit");
            frogDrop.Play();
            frog2.SetActive(false);
            frog2.transform.SetParent(null);
        }
        if (collision.gameObject.tag == "Frog 3")
        {
            frogHitCauldron[2] = true;
            Debug.Log(frogHitCauldron[2] + "The frog 3 was being hit");
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
