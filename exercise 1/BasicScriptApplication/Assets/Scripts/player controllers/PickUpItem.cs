using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public Transform pickuppoint;
    public Text infoText;
    private InventoryManager _inventorySystem;

    // Start is called before the first frame update
    void Start()
    {
        // makes sure the info text box is clear at the start of the game.
        infoText.text = "";
        // looks for object with the Inventory System script. 
        _inventorySystem = FindObjectOfType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        // checks if the object colliding is tag player
        if(other.gameObject.tag == "Pickup")
        {
            infoText.text = "press 'E' to pick up.";
            // ask for player to press E
            if (Input.GetKey(KeyCode.E))            
            {
               /* //turn off pick up collider
                other.GetComponent<Collider>().enabled = false;
                //move object to pickup point
                other.transform.position = pickuppoint.position;
                //make child
                other.transform.parent = this.transform; */

                Debug.Log("grabbed");
                infoText.text = "";
                // calls into Inventory System to assign inventory item
                _inventorySystem.AssignInventoryItem(other.gameObject.name);
                Destroy(other.gameObject);
            }
           

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("numpty");
            infoText.text = "";
        }
    }
}
