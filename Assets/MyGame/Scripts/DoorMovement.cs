using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public GameObject door;
    public Collider doorCollider;
    public AudioSource doorCloseSound;
    public AudioSource startVoiceSound;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            doorCollider.enabled = false;
            doorCloseSound.Play();
            startVoiceSound.Play();
        }
    }
}
