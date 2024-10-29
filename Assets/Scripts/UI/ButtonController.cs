using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Refer�ncias para os outros scripts ou controladores
    public AnnotationHandler annotationHandler;
    public ImageHandler imageHandler;
    public DisplayManager displayManager;

    // M�todo para o bot�o de Venda
    public void OnSellButtonClick()
    {
        Debug.Log("Sell button clicked.");
        // Chama o m�todo do TransactionManager para registrar uma venda
        TransactionManager.RegisterTransaction(2f, TransactionType.Sale);
        displayManager.UpdateUI();
    }

    // M�todo para o bot�o de Doa��o
    public void OnDonateButtonClick()
    {
        Debug.Log("Donate button clicked.");
        // Chama o m�todo do TransactionManager para registrar uma doa��o
        float donationValue = displayManager.GetDonationInputValue();
        Debug.Log($"Donation Value: {donationValue}");
        TransactionManager.RegisterTransaction(donationValue, TransactionType.Donation);
        displayManager.UpdateUI();
        displayManager.ClearDonationInput();
    }

    // M�todo para o bot�o de Anota��es
    public void OnAnnotationButtonClick()
    {
        Debug.Log("Annotation button clicked.");
        // Chama o m�todo para abrir a tela de anota��es
        //TODO: mostrar o painel de anota��es
       // annotationHandler.ToggleAnnotations();
    }

    // M�todo para o bot�o de QR Code
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
