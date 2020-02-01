using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDescription : MonoBehaviour
{
    public Text description;
    public GameObject CurrentItemOnCanvas;
    // Start is called before the first frame update
    void Start()
    {
        description = GetComponent<Text>();
        CurrentItemOnCanvas = GameObject.FindGameObjectWithTag("Item");
        


    }

    // Update is called once per frame
    void Update()
    {
        description.text = CurrentItemOnCanvas.GetComponent<BuyItems>().ItemDescription;
    }
}
