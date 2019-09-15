using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemData[] inventory;
    
    int index = 0;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))    
        {
            NextItemInfo();
        }
    }
    
    public void NextItemInfo()
    {
        if (index == inventory.Length)
        {
            index = 0;
        }

        Debug.Log("Item name: " + inventory[index].name);
        Debug.Log ("Attack power: " + inventory[index].attack);

        switch(inventory[index].type)
        {
            case ItemType.Axe: 
            Debug.Log("Item type: Axe"); 
            break;

            case ItemType.Dagger: 
            Debug.Log("Item type: Dagger");
            break;

            case ItemType.Staff: 
            Debug.Log("Item type: Staff");
            break;

            case ItemType.Sword: 
            Debug.Log("Item type: Sword"); 
            break;
        }
        Debug.Log("Item price: " + inventory[index].GetPrice());

        index ++;
    }
		
}