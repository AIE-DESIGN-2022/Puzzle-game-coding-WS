using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timertxt;
    public float timer = 0;
    public float minute = 0;
    public bool playing = true;

    // Start is called before the first frame update
    void Start()
    {
      timertxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playing == true)
        {


            timer += Time.deltaTime;
            //Time.deltaTime
            if (timertxt.text != null)
            {

            }

            timertxt.text = minute + ":" + timer.ToString("##.##");

            if (timer >= 60)
            {
                timer = timer - 60;
                minute += 1;
            }
        }
        else
        {
            Debug.Log("taryn");
        }
    }
}
