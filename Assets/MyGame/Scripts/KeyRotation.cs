using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, 0.6f, 0f, Space.Self);
    }
}
