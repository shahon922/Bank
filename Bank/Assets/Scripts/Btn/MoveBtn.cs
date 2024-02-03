using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBtn : MonoBehaviour
{
    public GameObject move;
    public GameObject diposit;
    public GameObject withdrawal;

    public void MoveDiposit()
    {
        move.SetActive(false);
        diposit.SetActive(true);
    }

    public void MoveWithdrawal()
    {
        move.SetActive(false);
        withdrawal.SetActive(true);
    }

    public void DipositBack()
    {
        diposit.SetActive(false);
        move.SetActive(true);
    }

    public void WithdrawalBack()
    {
        withdrawal.SetActive(false);
        move.SetActive(true);
    }
}
