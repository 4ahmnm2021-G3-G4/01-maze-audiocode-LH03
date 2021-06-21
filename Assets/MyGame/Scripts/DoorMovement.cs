using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorCloseSound;
    public AudioSource startVoiceSound;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger Dooor" + col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            
            doorCloseSound.Play();
            startVoiceSound.Play();
            door.SetActive(true);
        }
    }
}
