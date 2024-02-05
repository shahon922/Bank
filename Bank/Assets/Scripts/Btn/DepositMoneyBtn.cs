using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositMoneyBtn : MonoBehaviour
{
    private int moveMoney = 0;


    public void DepositTenThousandWon()
    {
        moveMoney = 10000;

        if (GameManager.I.cash >= moveMoney)
        {
            GameManager.I.cash -= moveMoney;
            GameManager.I.balance += moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }
    }

    public void DepositThirtyThousandWon()
    {
        moveMoney = 30000;

        if (GameManager.I.cash >= moveMoney)
        {
            GameManager.I.cash -= moveMoney;
            GameManager.I.balance += moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }
    }

    public void DepositFiftyThousandWon()
    {
        moveMoney = 50000;

        if (GameManager.I.cash >= moveMoney)
        {
            GameManager.I.cash -= moveMoney;
            GameManager.I.balance += moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }
    }
}
