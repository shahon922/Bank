using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitdrawalMoneyBtn : MonoBehaviour
{
    private int moveMoney = 0;


    public void WithdrawalTenThousandWon()
    {
        moveMoney = 10000;

        if (GameManager.I.balance >= moveMoney)
        {
            GameManager.I.cash += moveMoney;
            GameManager.I.balance -= moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }
    }

    public void WithdrawalThirtyThousandWon()
    {
        moveMoney = 30000;

        if (GameManager.I.balance >= moveMoney)
        {
            GameManager.I.cash += moveMoney;
            GameManager.I.balance -= moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }

    }

    public void WithdrawalFiftyThousandWon()
    {
        moveMoney = 50000;

        if (GameManager.I.balance >= moveMoney)
        {
            GameManager.I.cash += moveMoney;
            GameManager.I.balance -= moveMoney;
            GameManager.I.cashNumTxt.text = GameManager.I.cash.ToString();
            GameManager.I.balanceNumTxt.text = GameManager.I.balance.ToString();
        }
        else
        {
            GameManager.I.Tribe.SetActive(true);
        }
    }
}
