using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.42f, 0.6f, 0.26f, Space.Self);
    }
}
