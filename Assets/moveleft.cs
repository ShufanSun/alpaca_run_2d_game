using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float moveSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
