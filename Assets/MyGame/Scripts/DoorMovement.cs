using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    private bool isPlayerThroughDoor = false;
    public GameObject door;
    public Collider doorCollider;
    public AudioSource doorCloseSound;
    public AudioSource startVoiceSound;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnTriggetrDoor" + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            isPlayerThroughDoor = true;
            doorCollider.enabled = false;
            doorCloseSound.Play();
            startVoiceSound.Play();
        }
    }
}
