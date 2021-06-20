using UnityEngine;

public class KeyTaking : MonoBehaviour
{
    public GameObject cauldronPackage;
    public AudioSource keyInHand;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cauldronPackage.SetActive(false);
            keyInHand.Play();
        }
    }
}
