using UnityEngine;
using TMPro;

public class Mathcontroller : MonoBehaviour
{


    public TextMeshProUGUI voresText;
    public int startingNumber = 10;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      currentNumber = startingNumber;
        updatenumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void minusNumber(int numberToMinus) 
    {
        currentNumber = currentNumber - numberToMinus;
        updatenumber();
    }

    public void plusnumber(int numberToPlus) 
    {
        currentNumber = currentNumber + numberToPlus;
        updatenumber();
    }

    public void updatenumber() 
    {
        voresText.text = currentNumber.ToString(); 
    }
}
