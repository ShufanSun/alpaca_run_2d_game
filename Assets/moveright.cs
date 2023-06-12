using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveright : MonoBehaviour
{
   

    public float moveSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }
}
