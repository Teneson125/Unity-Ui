using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageHandler : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;
    public GameObject messageGrid;

    public void Start()
    {
        messageGrid.SetActive(false);
    }

    public void Message()
    {
        messageGrid.SetActive(true);

        background.alpha = 0;
        background.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -Screen.height);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;

    }

    public void CloseMessage()
    {
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(DisableMessageGrid);

    }

    private void DisableMessageGrid()
    {
        messageGrid.SetActive(false);
    }
    
}
