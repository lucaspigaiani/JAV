using UnityEngine;
using System.Globalization;
using TMPro;

public class CurrencyFormatter : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI displayText;

    public void FormatInputToCurrency()
    {
        if (float.TryParse(inputField.text, out float value))
        {
            CultureInfo brazilianCulture = new CultureInfo("pt-BR");
            string tempValue = value.ToString("C", brazilianCulture);
            inputField.text = tempValue;
        }
        else
        {
            displayText.text = "Invalid input";
        }
    }

    public float ConvertCurrencyStringToFloat(string formattedValue)
    {
        // Remove "R$", espaços e substitui vírgula por ponto
        string sanitizedValue = formattedValue.Replace("R$", "");

        // Tenta converter para float
        if (float.TryParse(sanitizedValue, out float result))
        {
            return result; // Retorna o valor em float
        }
        else
        {
            Debug.LogWarning("Invalid currency format.");
            return 0f; // Retorna 0 em caso de erro
        }
    }
}
