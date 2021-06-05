using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogCroak : MonoBehaviour
{
    public AudioSource frogCroak;
    public GameObject basket;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Sound off");
            frogCroak.Stop();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
