using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemInfo : MonoBehaviour
{
    public Text description;

    // Start is called before the first frame update
    void Start()
    {
        description = GetComponent<Text>();
        description.text = "This is a code test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
