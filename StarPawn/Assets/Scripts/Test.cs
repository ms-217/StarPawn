using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    public GameObject[] itemsArr;
    public GameObject currentItem;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = (new System.Random()).Next(0, 1);

       // Item = gameObject.Getcomponet.itemsArr[rand];
    }

    // Update is called once per frame
    void Update()
    {

    }
}

