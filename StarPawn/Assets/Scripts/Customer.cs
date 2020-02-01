using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    public float speed = 4;
    public float customerTimer = 1;
    public GameObject custpose;
    Transform custpos;
    public bool spawnedItem = false;
    public GameObject Item;

    void spawnItem()
    {
        Instantiate(Item, custpos.position, custpos.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        custpos = custpose.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnedItem == false)
            customerTimer -= Time.deltaTime;

        if(customerTimer <= 0 && spawnedItem == false)
        {
            spawnItem();
            spawnedItem = true;
        }

        if(customerTimer > 0)
            transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
