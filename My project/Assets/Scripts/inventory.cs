using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public int Item = 0;
    public int SlotAb = 10;
    // Start is called before the first frame update
    void Start()
    {
        ItemCollector.OnItemCollected += UpdateInventory;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateInventory()
    {
        Item += 1;      // Add 1 to the "Item" count
        SlotAb -= 1;    // Subtract 1 from the "SlotAb" count

        // Print the updated values to the console
        Debug.Log("Inventory Updated: Item = " + Item + ", SlotAb = " + SlotAb);
    }
}
