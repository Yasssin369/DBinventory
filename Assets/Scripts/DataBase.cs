using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DataBase : MonoBehaviour
{
    public ItemDataBase items;
    public static DataBase instance;
    public GameObject vehiclePreFab;
    public  int index;
    public GameObject button;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
   
    public static Item GetItem(int index)
    {
        //  return instance.items.allItems.FirstOrDefault(i => i.itemID == ID);
        return instance.items.allItems.ElementAt(index);

    }
    public void PopulateDB()
    {
        button.SetActive (false);
        for (int i = 0; i < items.allItems.Count; i++)
        {
                index = i;
                Instantiate(vehiclePreFab, new Vector3(0, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
      
        }
    }
}
