using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuyItems : MonoBehaviour
{
    public GameObject[] itemsArr;
    public GameObject currentItem;
    public string Name;
    public string Rarity;
    public string ItemDescription;
    public int Risk;
    public int RepairCost;
    public int Price;

    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = (new System.Random()).Next(0, 2);

        currentItem = itemsArr[rand];
        ItemDescription = "This is a Crystal";
        Risk = "";
        Name = "";
        Rarity = "";
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
