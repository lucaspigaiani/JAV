using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataHandler
{
    public static float totalSales = 0f;
    public static int salesQuantity = 0;

    public static float totalDonations = 0f;
    public static int donationsQuantity= 0;

    public static void LoadData()
    {
        totalSales = PlayerPrefs.GetFloat("TotalSales", 0f);
        totalDonations = PlayerPrefs.GetFloat("TotalDonations", 0f);
    }

    public static void SaveData()
    {
        PlayerPrefs.SetFloat("TotalSales", totalSales);
        PlayerPrefs.SetFloat("SalesQuantity", salesQuantity);

        PlayerPrefs.SetFloat("TotalDonations", totalDonations);
        PlayerPrefs.SetFloat("DonationsQuantity", donationsQuantity);
        PlayerPrefs.Save();
    }

    public static void AddTransaction(float value, TransactionType type)
    {
        if (type == TransactionType.Sale)
        {
            totalSales += value;
            salesQuantity++;
        }
        else if (type == TransactionType.Donation)
        {
            totalDonations += value;
            donationsQuantity++;
        }
        SaveData();
    }
}