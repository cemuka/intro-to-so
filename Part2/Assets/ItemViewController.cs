using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemViewController : MonoBehaviour
{
    public Inventory inventoryHolder;
    public Transform inventoryViewParent;
    public GameObject itemViewPrefab;

    private void Start() 
    {
        foreach (var item in inventoryHolder.inventory)
        {
            var itemGO = GameObject.Instantiate(itemViewPrefab, inventoryViewParent);
            itemGO.GetComponent<ItemView>().InitItem(item);
        }
    }
}
