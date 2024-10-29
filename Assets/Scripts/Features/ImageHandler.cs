using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageHandler : MonoBehaviour
{
    public Image displayImage;  // Referência ao componente Image onde a imagem será exibida
    public GameObject imagePanel;  // Painel ou objeto que contém o Image para exibição

    // Carrega uma imagem da galeria e aplica ao componente Image
    public void UploadImage(Texture2D imageTexture)
    {
        if (imageTexture != null)
        {
            Sprite newSprite = Sprite.Create(imageTexture, new Rect(0, 0, imageTexture.width, imageTexture.height), new Vector2(0.5f, 0.5f));
            displayImage.sprite = newSprite;
        }
    }

    // Exibe o painel de imagem na tela
    public void ShowImage()
    {
        if (imagePanel != null)
        {
            imagePanel.SetActive(true);
        }
    }

    // Oculta o painel de imagem na tela
    public void HideImage()
    {
        if (imagePanel != null)
        {
            imagePanel.SetActive(false);
        }
    }
}