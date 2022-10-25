using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public UnityEngine.UIElements.Button startWave;
    public Spawn fnWave;
    public Label argentTexte;
    private int currentInt;
    private string currentString;

    void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        startWave = root.Q<UnityEngine.UIElements.Button>("StartWave");
        argentTexte = root.Q<Label>("currentMoney");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("argentTexte "+argentTexte.text);

        startWave.clicked += StartWavePressed;
    }


    void StartWavePressed()
    {
        fnWave.LaunchWave();
        Debug.Log(argentTexte.text);
    }

    public void IncreaseMoney(int moneyFromMonster)
    {
            Debug.Log("Debug0 :" + moneyFromMonster);
            Debug.Log("Debug1 :" + argentTexte.text);
            currentString = argentTexte.text;
            Debug.Log("Debug2 :" + currentString);
            int.TryParse(currentString, out currentInt);
            Debug.Log("Debug3 :" + currentInt);
            argentTexte.text = $"{currentInt + moneyFromMonster}";
    }

    public void DecreaseMoney(int moneyToDecrease)
    {
        currentString = argentTexte.text;
        int.TryParse(currentString, out currentInt);
        argentTexte.text = $"{currentInt - moneyToDecrease}";
    }
}
