using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBot : MonoBehaviour
{

    public float speed = 1;
    public float UITimer = 1;
    public GameObject UIPose;
    Transform UIPos;
    public bool display = false;

    // Start is called before the first frame update
    void Start()
    {
        UIPos = UIPose.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (display == false)
            UITimer -= Time.deltaTime;

        if (UITimer <= 0 && display == false)
        {
            display = true;
        }

        if (UITimer > 0)
            transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
