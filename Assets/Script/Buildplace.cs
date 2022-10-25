using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
	public UIController UI;
	public int price;

	//la tower qu'on build
	public GameObject towerPrefab;
	Vector3 myVector;

    private void Start()
    {
		//Debug.Log("DebugBuildplace: " + UI.argentTexte.text);
	}

    void OnMouseUpAsButton() {
			myVector = new Vector3(0f, 0.55f, 0f);
			GameObject g = (GameObject)Instantiate(towerPrefab);
			g.transform.position = transform.position + myVector;
			UI.DecreaseMoney(price);
	}
	
}
