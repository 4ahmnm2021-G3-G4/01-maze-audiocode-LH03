using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public int counter;
    public Rigidbody key;

    [SerializeField] private Vector3 target = new Vector3(1f, 1f, 1f);
    [SerializeField] private float speed;
    private bool isDoorUnlocked = false;
    public GameObject exitDoor;
    public GameObject keyTransform;
    public GameObject keySetCollider;
    public Collider keyCountCollider;

    public UnlockDoor keyFits;



    private void OnTriggerEnter(Collider collision)
    {
        GameObject[] arrayColliders = GameObject.FindGameObjectsWithTag("Wall Collider");



        if (collision.gameObject.tag == "Key" & keyFits.isKeyinDoor)
        {
            //keyCollider.SetActive(false);
            Debug.Log("Works");
            counter++;
            Debug.Log(counter);
        }


        if (counter == 3)
        {
            isDoorUnlocked = true;
            arrayColliders[0].SetActive(false);
            arrayColliders[1].SetActive(false);
            arrayColliders[2].SetActive(false);
            arrayColliders[3].SetActive(false);
            keyTransform.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Key" & keyFits.isKeyinDoor)
        {
            keySetCollider.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (isDoorUnlocked)
            {
                //Debug.Log(target.ToString());
                exitDoor.transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            }

        }
    }
}
