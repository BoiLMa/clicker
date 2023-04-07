using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    //This script manages all the code related to the buttons

    [SerializeField] private PlayerVariables playerVariables;
    public static int MoneyIncrement = 1;
    public TMP_Text TotalMoneyCounter;
    public List<GameObject> Upgrades = new List<GameObject>();

    private void Start()
    {
        for (int i = 1; i < Upgrades.Count; i++)
        {
            Upgrades[i].SetActive(false);
        }
    }

    private void Update()
    {
        TotalMoneyCounter.text = playerVariables.TotalMoney.ToString() + " $ Inkomsten";
    }

    public void GainMoney()
    {
        playerVariables.TotalMoney += MoneyIncrement;
    }
    //geen idee wat je wou doen maar je kan er een list voor gebruiken

    public void GetItem(Item _ItemType)
    {
        //hier zet je de volgende op true
        for (int i = 0; i < Upgrades.Count; i++)
		{
            if (Upgrades[i] == _ItemType.gameObject)
			{
                Upgrades[i + 1].SetActive(true);
			}
		}

        //en hier increased hij het geld enzo
        playerVariables.TotalMoney -= _ItemType.Price;
        MoneyIncrement += _ItemType.IncreasementRate;
    }
}
