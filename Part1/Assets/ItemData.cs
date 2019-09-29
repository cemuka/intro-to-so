using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType type;
    public float attack;		

    public float GetPrice()
    {
        return attack * 40;
    }
}

public enum ItemType
{
    Dagger,
    Axe,
    Sword,
    Staff
}
