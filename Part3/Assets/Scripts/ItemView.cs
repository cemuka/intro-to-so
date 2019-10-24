using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    public Button button;
    public Image itemIcon;

    private ItemData itemData;

    public void InitItem(ItemData item, Action<ItemData> callback)
    {
        this.itemData = item;
        itemIcon.sprite = itemData.icon;

        button.onClick.AddListener(() => callback(itemData) );
    }
}
