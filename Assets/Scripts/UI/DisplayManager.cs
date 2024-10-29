using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayManager : MonoBehaviour
{
    public CurrencyFormatter currencyFormatter;

    // Text references for UI elements
    public TextMeshProUGUI totalSalesText;
    public TextMeshProUGUI donationsDisplayText;
    public TextMeshProUGUI annotationDisplayText;
    public TMP_InputField donateInput;

    public TextMeshProUGUI totalText;

    // Update total amount in the UI
    public void UpdateSalesDisplay(int salesQuantity)
    {
        totalSalesText.text = salesQuantity.ToString();
        Debug.Log("Total display updated.");
    }

    // Update donations amount in the UI
    public void UpdateDonnationsDisplay(int donationsQuantity)
    {
        donationsDisplayText.text = donationsQuantity.ToString(); ;
        Debug.Log("donations display updated.");
    }

    // Update annotation text
    public void UpdateAnnotationDisplay(string annotation)
    {
        annotationDisplayText.text = annotation;
        Debug.Log("Annotation display updated.");
    }

    // Clear annotation display text
    public void ClearAnnotationDisplay()
    {
        annotationDisplayText.text = "";
        Debug.Log("Annotation display cleared.");
    }

    public void UpdateUI()
    {
        UpdateSalesDisplay(TransactionManager.GetSalesQuantity());
        UpdateDonnationsDisplay(TransactionManager.GetDonationsQuantity());
        float total = TransactionManager.GetTotalSales() + TransactionManager.GetTotalDonations();
        UpdateTotalText(total);
    }

    public float GetDonateInput() 
    {
        //donateInput.text;
        return 0; 
    }

    public void UpdateTotalText(float total) 
    {
        totalText.text = $"R$ {total}";
    }

    public float GetDonationInputValue() 
    {
       return currencyFormatter.ConvertCurrencyStringToFloat(donateInput.text);
    }

    public void ClearDonationInput() 
    {
        donateInput.text = null;
    }
}
