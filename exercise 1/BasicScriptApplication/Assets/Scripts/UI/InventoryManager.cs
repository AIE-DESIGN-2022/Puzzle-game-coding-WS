using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryManager : MonoBehaviour
{
    public List<string> inventoryItemsNames;
    public Text inventoryListText;
    private int  x = 0;
    public GameObject inventoryPanel;



    // Start is called before the first frame update
    void Start()
    {
        // turn off panel at game start
       inventoryPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeInHierarchy);
        }
    }

    public void AssignInventoryItem(string _itemPickup)
    {
        // on item pickup  finds game objects name 
        inventoryItemsNames.Add(_itemPickup);
        UpdateInventoryText();
    }

    public void UpdateInventoryText()
    {   
        // everytime the function is called clears the list 
        inventoryListText.text = "";

        //adds each item in inventoryItemNames into text box
        foreach (string _name in inventoryItemsNames)
        {
            inventoryListText.text +=  _name + "\n";
            
        }
    }
    public bool CheckInventoryforItem(string _itemToCheck)
    {
     //check each item in iventory till a name matches
     foreach (string _Item in inventoryItemsNames)
        {
            //check if names match 
            if(_Item == _itemToCheck)
            {
                return true;
            }
        }
     return false;
    }
    public void UseItem(string _itemToCheck)
    {
        bool _FoundItem = false;
        foreach(string _Item in inventoryItemsNames)
        {
            if (_Item == _itemToCheck && Input.GetKeyDown(KeyCode.E))
            {
                _FoundItem = true;
            }
            
        }
        if (_FoundItem == true)
        {
            inventoryItemsNames.Remove(_itemToCheck);
            UpdateInventoryText();


        }
        
    }
}

