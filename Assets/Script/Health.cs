using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    TextMesh tm;

    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    void Update()
    {
        //Face camera
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.position).normalized;
    }

    public int Current()
    {
        return tm.text.Length;
    }

    public void Decrease()
    {
        if (Current() > 1)
            tm.text = tm.text.Remove(tm.text.Length - 1);
        else
        {
            Destroy(transform.parent.gameObject);
        }
    }
    

}
