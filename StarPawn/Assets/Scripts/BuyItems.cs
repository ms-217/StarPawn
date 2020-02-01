using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Xml.Linq;

public class Ctrl : MonoBehaviour
{
    public static bool ShowText = false;
    public static Sprite ItemSprite;
    public static string Name;
    public static string Rarity;   // Calc repair cost
    public static string ItemDescription;  // From dictionary
    public static int Risk;        // RNG
    public static int BaseAskPrice;   // From dictionary
    public static int PriceRange;  // Dictionary +- this amount
    public static int SellPrice;   // Dictionary
    public static int SellTime;    // Dictionary in seconds

    private static System.Random R = new System.Random();
    private static List<ItemConstant> PossibleItems;
    private struct ItemConstant
    {
        public string Name { get; }
        public string Path { get; }
        public string Description { get; }
        public int BaseAskPrice { get; }
        public int PriceRange { get; }
        public int SellPrice { get; }
        public int SellTime { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Display name of Item</param>
        /// <param name="path">Name of sprite file</param>
        /// <param name="desc">Description of Item</param>
        /// <param name="baseAskPrice"></param>
        /// <param name="priceRange"></param>
        /// <param name="sellPrice"></param>
        /// <param name="sellTime"></param>
        public ItemConstant(string name, string path, string desc, int baseAskPrice, int priceRange, int sellPrice, int sellTime)
        {
            Name = name;
            Path = path;
            Description = desc;
            BaseAskPrice = baseAskPrice;
            PriceRange = priceRange;
            SellPrice = sellPrice;
            SellTime = sellTime;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    ///     On object load. Do RNG here
    /// </summary>
    public void MakeItem()
    {
        int rand;
        rand = R.Next(0, PossibleItems.Count);

        var si = PossibleItems[rand];

        Name = si.Name;
        ItemDescription = si.Description;
        // ItemSprite = Resources.Load();
    }

    /// <summary>
    ///     Initialize static values in dictionary
    ///     Call only once on game load
    /// </summary>
    public static void InitDict()
    {
        PossibleItems = new List<ItemConstant>();
        const string PATH = "Text/Items";

        // Order: Name, Desc, BasePrice, PriceRange, SellPrice, TimeToSell
        PossibleItems.Add(new ItemConstant("Gun", "Gun", "It's a gun", 200, 50, 225, 60));

        var r = Resources.Load(PATH) as TextAsset;
        var s = new MemoryStream(r.bytes);
        var xd = XDocument.Load(s);

        // Go though hiearchy here using foreach
    }
}
