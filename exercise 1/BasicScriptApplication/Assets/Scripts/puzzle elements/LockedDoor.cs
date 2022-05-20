using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedDoor : MonoBehaviour
{
    public string keyName;
    public Text infoText;
    private InventoryManager _inventorySystem;
    public GameObject lockedDoor;
    private bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
      _inventorySystem = FindObjectOfType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey == true && Input.GetKeyDown(KeyCode.E))
        {
            lockedDoor.SetActive(false);
            infoText.text = "";
            _inventorySystem.UseItem(keyName);

            
        }
        if (hasKey == false && Input.GetKeyDown(KeyCode.E))
        {
            infoText.text = "locked";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        { 
            if(_inventorySystem.CheckInventoryforItem(keyName) == true)
            {
                infoText.text = "Press 'E' to open";
                hasKey = true;
            }
            else
            {
                infoText.text= "door is locked, find " + keyName + ".";
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        infoText.text = "";
    }
}
