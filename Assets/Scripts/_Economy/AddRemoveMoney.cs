using UnityEngine;

public class AddRemoveMoney : MonoBehaviour
{
    public GameObject money;
    Money moneyScript;
    public int amount;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            money = GameObject.Find("Money");
            moneyScript = money.GetComponent<Money>();
            moneyScript.AddMoney(amount);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            money = GameObject.Find("Money");
            moneyScript = money.GetComponent<Money>();
            moneyScript.RemoveMoney(amount);
        }
    }
}
