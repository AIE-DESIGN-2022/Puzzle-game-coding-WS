using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private KillZone killzone;

    
    private void Start()
    {
        killzone = FindObjectOfType<KillZone>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("checkpoint");
            Color playercolor = other.gameObject.GetComponent<Renderer>().material.color;
            killzone.UpdateCheckpoint(this.transform.position, playercolor);
        }
    }
}
