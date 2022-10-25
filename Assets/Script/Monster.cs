using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Monster : MonoBehaviour

{
    UIController UI;
    public int argent;
    Animator animator;

    void Start()
    {
        //UI = GetComponent<UIController>();
        animator = GetComponent<Animator>();
        //Navigate to castle
        GameObject castle = GameObject.Find("Castle");
        if (castle)
        {
            GetComponent<NavMeshAgent>().destination = castle.transform.position;
        }

        Debug.Log("DebugMonstre: " + UI.argentTexte.text);
    }

    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.name == "Castle")
        {
            col.GetComponentInChildren<Health>().Decrease();
            animator.SetTrigger("die");
            Destroy(gameObject, 1.5f);
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Debug01 :" + argent);
        UI.IncreaseMoney(argent);
        Debug.Log("Debug02 :" + argent);
    }
}
