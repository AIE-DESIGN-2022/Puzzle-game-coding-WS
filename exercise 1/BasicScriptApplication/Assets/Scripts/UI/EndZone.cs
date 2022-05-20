using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{
    public GameObject endZonepanel;
    private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        endZonepanel.SetActive(false);
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
          endZonepanel.SetActive(true);
            Debug.Log("ankles");
        }  
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
