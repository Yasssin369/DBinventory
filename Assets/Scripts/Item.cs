using UnityEngine;
[CreateAssetMenu(fileName ="New Item", menuName ="Assets/Item")]
public class Item : ScriptableObject
{
    public int itemID;
    public string itemName;
    [TextArea]
    public string itemDescription;
    public Sprite itemSprite;
    public string itemMass;
    public string itemSpeed;
    public string itemMaxSpeed;

}
