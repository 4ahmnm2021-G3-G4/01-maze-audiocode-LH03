using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public Rigidbody key;
    public bool isKeyinDoor = false;
    public AudioSource insertKeyDoor;
    public AudioSource winSound;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            key.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            isKeyinDoor = true;
            insertKeyDoor.Play();
        }
    }
}

