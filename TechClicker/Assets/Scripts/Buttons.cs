using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    //This script manages all the code related to the buttons

    public GameObject Player;
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
        TotalMoneyCounter.text = Player.GetComponent<PlayerVariables>().TotalMoney.ToString() + " R";
    }
    public void MainButton()
    {
        Player.GetComponent<PlayerVariables>().TotalMoney += MoneyIncrement;
    }
    //ik weet niet hoe je dit dynamisch zou moeten maken
    //de bedoeling is dat de er word gekeken welke knop er word in gedrukt en dan de 
    //volgende knop setactive op true zet.
    /*public void GetItem()
    {
        ReturnButton(gameObject.GetComponent<Button>());
    }
    public Button ReturnButton(Button _clickedButton)
    {
        return _clickedButton;
    }*/
}
