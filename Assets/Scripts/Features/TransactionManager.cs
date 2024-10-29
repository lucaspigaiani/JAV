using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransactionManager
{
    public static void RegisterTransaction(float value, TransactionType type)
    {
        if (value < 0)
        {
            Debug.LogError("Transaction value cannot be negative.");
            return;
        }

        DataHandler.AddTransaction(value, type);
    }

    public static float GetTotalSales()
    {
        return DataHandler.totalSales;
    }

    public static int GetSalesQuantity()
    {
        return DataHandler.salesQuantity;
    }

    public static float GetTotalDonations()
    {
        return DataHandler.totalDonations;
    }

    public static int GetDonationsQuantity()
    {
        return DataHandler.donationsQuantity;
    }
}
