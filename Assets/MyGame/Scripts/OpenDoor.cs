using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int counter;
    public Rigidbody key;

    public bool isDoorUnlocked = false;
    public GameObject exitDoor;
    public GameObject keyTransform;
    public GameObject keySetCollider;
    public Collider keyCountCollider;

    public UnlockDoor keyFits;
    public AudioSource keyTurnSound;
    public AudioSource winSound;
    public AudioSource openDoor;
    public AudioSource youHaveWonSound;

    public MeshRenderer keyholeCollider;
    public GameObject keyHoleCover;
    public GameObject arrowSign;

    private void OnTriggerExit(Collider collision)
    {
        GameObject[] arrayColliders = GameObject.FindGameObjectsWithTag("Wall Collider");

        if (collision.gameObject.tag == "Key" & keyFits.isKeyinDoor)
        {
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
            keyholeCollider.enabled = false;
            winSound.Play();
            arrowSign.SetActive(false);
            youHaveWonSound.Play();
        }
    }
}
