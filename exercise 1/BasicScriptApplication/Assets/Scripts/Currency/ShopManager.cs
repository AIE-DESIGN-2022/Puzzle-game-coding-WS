using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public string itemToUnlock;
    public int costOfItem;
    private InventoryManager _inventoryManager;
    private CurrencyManager _currencyManager;
    public Text infoText;
    private bool _isBuying;
    // Start is called before the first frame update
    void Start()
    {
        _currencyManager = FindObjectOfType<CurrencyManager>();
        _inventoryManager = FindObjectOfType<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
       if(_isBuying == true && CheckPlayerCurrency() == true) 
        {
            infoText.text = "Press Q to buy 'Bridge";
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //reduce amount of currency by item cost
                _currencyManager.TakeGill(costOfItem);
                //add item to iventory
                _inventoryManager.AssignInventoryItem(itemToUnlock);
            }
            
        }
        if (_isBuying == true && CheckPlayerCurrency() == false)
        {
            infoText.text = "You're too poor, ya need "+costOfItem+" Gil for a"+ itemToUnlock+ "!";
        }
        else
        {
            infoText.text = "Don't waste my time";
        }



    }

    private bool CheckPlayerCurrency()
    {
        if(_currencyManager.gil_Amount >= costOfItem)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _isBuying = true;
            CheckPlayerCurrency();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        infoText.text = "";
        _isBuying = false;
    }
}
