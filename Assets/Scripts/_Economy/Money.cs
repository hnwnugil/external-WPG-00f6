using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public int money;
    public TextMeshProUGUI moneyText;
    
    void Start()
    {
        money = 0;
        moneyText.text = money.ToString();   
    }
    public void AddMoney(int amount)
    {
        money += amount;
        moneyText.text = money.ToString();
    }
    public void RemoveMoney(int amount)
    {
        if (money - amount >= 0)
        {
            money -= amount;
            moneyText.text = money.ToString();
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }
}