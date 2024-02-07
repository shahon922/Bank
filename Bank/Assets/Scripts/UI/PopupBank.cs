using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    [SerializeField] private Text userName;
    [SerializeField] private Text balance;
    [SerializeField] private Text cash;
    [SerializeField] private GameObject Tribe;

    private void Start()
    {
        Refresh();
    }

    public void Deposit(int money)
    {
        if(!GameManager.I.User.Deposit(money))
        {
            Tribe.SetActive(true);
            return;
        }
        Refresh();
    }

    public void Withdrawal(int money)
    {
        if (!GameManager.I.User.Withdrawal(money))
        {
            Tribe.SetActive(true);
            return;
        }
        Refresh();
    }

    public void InputDeposit(InputField inputField)
    {
        Deposit(int.Parse(inputField.text));
    }

    public void InputWithdrawal(InputField inputField)
    {
        Withdrawal(int.Parse(inputField.text));
    }

    private void Refresh()
    {
        userName.text = GameManager.I.User.Name;
        balance.text = GameManager.I.User.Balance.ToString();
        cash.text = GameManager.I.User.Cash.ToString();
    }
}
