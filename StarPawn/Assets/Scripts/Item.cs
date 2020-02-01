using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float speed = 5;
    public GameObject itemPose;
    Transform itemPos;
    public bool reachedDest = false;
    public float itemTimer = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        itemPos = itemPose.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (reachedDest == false)
            itemTimer -= Time.deltaTime;

        if (itemTimer <= 0 && reachedDest == false)
        {
            //thing;
            reachedDest = true;
        }

        if (itemTimer > 0)
            transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
