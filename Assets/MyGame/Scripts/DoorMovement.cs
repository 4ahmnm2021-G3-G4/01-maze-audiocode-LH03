using UnityEngine;

public class DoorMovement : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorCloseSound;
    public AudioSource startVoiceSound;

    // When the Player enters the trigger, the entry door closes and audio is being played
    void OnTriggerEnter(Collider col)
    {
    
        if (col.gameObject.tag == "Player")
        {
            
            doorCloseSound.Play();
            startVoiceSound.Play();
            door.SetActive(true);
        }
    }
}
