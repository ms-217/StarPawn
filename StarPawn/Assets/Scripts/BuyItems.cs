using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuyItems : MonoBehaviour
{
    public GameObject[] itemsArr;
    public GameObject currentItem;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = (new System.Random()).Next(0, 2);

        currentItem = itemsArr[rand];

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
