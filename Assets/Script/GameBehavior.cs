using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
    
    //Destroy tower on clik, déplacer sur tower ?
    void OnMouseDown()
    {
        if (gameObject.tag == "Tower")
        {
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log(this.gameObject.name);
        }
    }
}
