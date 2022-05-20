using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Vector3 checkpoint;
    public GameObject player;
    private Color coloratcheck;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (checkpoint != null)
        {
            player.GetComponent<Renderer>().material.color = coloratcheck;
            col.transform.position = checkpoint;
        }
    }

    private void Start()
    {
        checkpoint = player.transform.position;
    }

     public void UpdateCheckpoint(Vector3 newpos, Color playercolor)
    {
        checkpoint = newpos;
        coloratcheck = playercolor;
    }
}
