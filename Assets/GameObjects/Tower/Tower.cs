using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    int cost = 30;

    public bool CreateTower(Tower tower, Vector3 position)
    {
        Bank bank = FindObjectOfType<Bank>();

        if(bank == null)
        {
            return false;
        }

        if(bank.CurrentBalance >= cost){
            Instantiate(tower.gameObject, position, Quaternion.identity);
            bank.Withdrawal(cost);
            return true;
        }

        return false;
    }
}
