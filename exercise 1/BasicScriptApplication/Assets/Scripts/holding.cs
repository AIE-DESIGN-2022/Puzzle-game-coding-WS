using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class holding : MonoBehaviour
{
    public Transform pickuppoint;
    private Text infoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Pickup")
        {
            if(Input.GetKey(KeyCode.E))            
            {
                infoText.text = "Press E to pick up ";
                Debug.Log("bum");
                //turn off pick up collider
                other.GetComponent<Collider>().enabled = false;
                //move object to pickup point
                other.transform.position = pickuppoint.position;
                //make child
             other.transform.parent = this.transform;
                infoText.text = "";
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
