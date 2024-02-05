using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBtn : MonoBehaviour
{
    public int moneyBtn = 0;
    public static int moveMoney = 0;

    public void ClickMoneyBtn()
    {
        switch(moneyBtn)
        {
            case 0:
                moveMoney = 10000;
                break;
            case 1:
                moveMoney = 30000;
                break;
            case 2:
                moveMoney = 50000;
                break;
        }
    }
    
}
