using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PassiveIncome : MonoBehaviour
{
    [SerializeField] private PlayerVariables playerVariables;
    List<Item> Items = new List<Item>();
    private float nextIncrease = 2f;
    private float cooldown = 2f;

    void Update()
    {
        if(Time.time > nextIncrease)
        {
            //voor elke item dat gekocht is increased de totalmoney waarde
            //de code werkt mogelijk nog niet
            foreach (Item i in Items)
            {
                if (i.Purchased)
                {
                    playerVariables.TotalMoney += i.IncreasementRate;
                    Debug.Log("money added");
                }
            }
            nextIncrease = Time.time + cooldown;
        }   
    }
}
