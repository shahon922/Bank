using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public Text cashNumTxt;
    public Text balanceNumTxt;

    public MoneyBtn moneyBtn;
    public GameObject Tribe;

    int cash = 100000;
    int balance = 50000;


    private void Awake()
    {
        I = this;
    }


    void Start()
    {
        moneyBtn = GetComponent<MoneyBtn>();
        cashNumTxt.text = cash.ToString();
        balanceNumTxt.text = balance.ToString();
        Tribe.SetActive(false);
    }

   
    void Update()
    {
        
    }

    public void Deposit()
    {
        if(1 == 1)
        {

        }
        else
        {
            Tribe.SetActive(true);
        }
    }

    public void Withdrawal()
    {
        if (1 == 1)
        {

        }
        else
        {
            Tribe.SetActive(true);
        }
    }
}
