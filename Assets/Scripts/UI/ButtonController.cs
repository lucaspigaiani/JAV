using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Referências para os outros scripts ou controladores
    public AnnotationHandler annotationHandler;
    public ImageHandler imageHandler;
    public DisplayManager displayManager;

    // Método para o botão de Venda
    public void OnSellButtonClick()
    {
        Debug.Log("Sell button clicked.");
        // Chama o método do TransactionManager para registrar uma venda
        TransactionManager.RegisterTransaction(2f, TransactionType.Sale);
        displayManager.UpdateUI();
    }

    // Método para o botão de Doação
    public void OnDonateButtonClick()
    {
        Debug.Log("Donate button clicked.");
        // Chama o método do TransactionManager para registrar uma doação
        float donationValue = displayManager.GetDonationInputValue();
        Debug.Log($"Donation Value: {donationValue}");
        TransactionManager.RegisterTransaction(donationValue, TransactionType.Donation);
        displayManager.UpdateUI();
        displayManager.ClearDonationInput();
    }

    // Método para o botão de Anotações
    public void OnAnnotationButtonClick()
    {
        Debug.Log("Annotation button clicked.");
        // Chama o método para abrir a tela de anotações
        //TODO: mostrar o painel de anotações
       // annotationHandler.ToggleAnnotations();
    }

    // Método para o botão de QR Code
    public void OnQRCodeButtonClick()
    {
        Debug.Log("QR Code button clicked.");
        // Exibe o QR code carregado pelo ImageHandler
        imageHandler.ShowImage();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
