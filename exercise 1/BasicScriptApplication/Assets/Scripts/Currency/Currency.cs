using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public int Currency_value;
    private CurrencyManager _manager;
    

    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<CurrencyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.tag == "Player")
        {
            _manager.AddGill(Currency_value);
            Destroy(gameObject);
        } 
    }
}
