using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texteMoche : MonoBehaviour
{
    TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        //Face camera
        transform.forward = Camera.main.transform.forward;
    }
}
