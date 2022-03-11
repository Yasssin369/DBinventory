using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tester : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemDescription;
    public TextMeshProUGUI itemMass;
    public TextMeshProUGUI itemSpeed;
    public TextMeshProUGUI itemMaxSpeed;
    public Image itemSprite;
    //  [Space]
    //  public int searchItemByID;

    private void Awake()
    {
        GetItem();
    }
    public void GetItem()
    {
        SetUI(DataBase.GetItem(DataBase.instance.index));
    }
    public void SetUI(Item i)
    {
        itemName.text = i.itemName;
        itemDescription.text = i.itemDescription;
        itemMass.text ="Mass : " + i.itemMass;
        itemSpeed.text ="Speed : " + i.itemSpeed;
        itemMaxSpeed.text ="MaxSpeed : " + i.itemMaxSpeed;
        itemSprite.sprite = i.itemSprite;
    }
}
