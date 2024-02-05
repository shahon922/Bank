using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBtn : MonoBehaviour
{
    public static int moveMoney = 0;

    public void TenThousandWon()
    {
        moveMoney = 10000;
    }

    public void ThirtyThousandWon()
    {
        moveMoney = 30000;
    }

    public void FiftyThousandWon()
    {
        moveMoney = 50000;
    }

}
