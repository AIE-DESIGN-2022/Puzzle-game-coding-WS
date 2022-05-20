using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotatesPlatform : MonoBehaviour
{
    public float red;
    public float green;
    public float blue;
    public float speed = 5;
    public GameObject rotating;
    private bool leveractive = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!GetComponent<Collider>().isTrigger)
        {
            Debug.LogWarning("Collider on " + transform.name + " is not set to \"Is Trigger\", please update and restart");

        }
    }

    // Update is called once per frame
    void Update()
    {
       if(leveractive == true)
        {
            rotating.transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        } 
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Box")
        {
            if (col.gameObject.GetComponent<Renderer>().material.color == new Color(red, green, blue))
            {
                leveractive = true;
                Debug.Log("Switch activated");

            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        leveractive = false;

    }
}
