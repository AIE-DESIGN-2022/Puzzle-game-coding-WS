using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timertxt;
    public float timer = 0;
    public float minute = 0;

    // Start is called before the first frame update
    void Start()
    {
        timertxt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // time = real world time
            timer += Time.deltaTime;
            
        if (timer >= 60)
        {
            timer = timer - 60;
            minute += 1;
            
        }
        timertxt.text = minute + ":" + timer.ToString("##.##");

    }
}
