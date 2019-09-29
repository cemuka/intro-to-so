using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public ItemType type;
    public float attack;
    public Sprite icon;	

    public float GetPrice()
    {
        return attack * 40;
    }
}

public enum ItemType
{
    Dagger,
    Axe,
    Hammer,
    Potion
}
