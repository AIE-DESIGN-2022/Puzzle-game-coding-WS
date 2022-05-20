using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    public int gil_Amount;
    public Text gil_Text;

    // Start is called before the first frame update
    void Start()
    {
        UpadateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGill(int _amount)
    {
        gil_Amount += _amount;
        UpadateText();
        

    }

    public void TakeGill(int _amount)
    {
        gil_Amount -= _amount;
        UpadateText();

    }

    private void UpadateText()
    {
        gil_Text.text = gil_Amount.ToString();
        
    }
}
