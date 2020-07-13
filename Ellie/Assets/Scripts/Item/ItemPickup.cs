using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    Item item;

    void PickUp()
    {
        Debug.Log("Adding " + item.name + " to inventory.");
        Inventory.instance.Add(item);
    }
}
