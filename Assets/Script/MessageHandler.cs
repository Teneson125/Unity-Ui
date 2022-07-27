using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MessageHandler : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;
    public GameObject messageGrid;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI messageText;
    public AuthenticationHandler authenticationHandler;
    public AnimationCurve animationCurve;

    private float timeDuration = 0.5f;
    private Vector3 startPos = new Vector3(0, -Screen.height, 0);
    private Vector3 endPos = new Vector3(0, 0, 0);
    private float currentTime;
    private string method;

    private void Start()
    {
        box.position = new Vector3(0, -Screen.height, 0);   
        messageGrid.SetActive(false);
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        float t = currentTime / timeDuration;
        box.localPosition = Vector3.Lerp(startPos, endPos, animationCurve.Evaluate(t));

    }

    public void Message(string titleText, string messageText, string method)
    {
        messageGrid.SetActive(true);
        this.titleText.text = titleText;
        this.messageText.text = messageText;
        this.method = method;
    }

    public void CloseMessage()
    {
        currentTime = 0f;
        startPos = new Vector3(0, 0, 0);
        endPos = new Vector3(0, -Screen.height, 0);
        Invoke("HideMessage", timeDuration);
        Invoke(method, 0f);
    }
    private void HideMessage()
    {
        currentTime = 0f;
        box.position = new Vector3(0, -Screen.height, 0);
        startPos = new Vector3(0, -Screen.height, 0);
        endPos = new Vector3(0, 0, 0);
        messageGrid.SetActive(false);
    }
    
    private void Hi()
    {
        authenticationHandler.startGrid.SetActive(false);
        authenticationHandler.verificationGrid.SetActive(false);
        authenticationHandler.userDetailGrid.SetActive(false);

        SceneManager.LoadScene(1);
    }
    private void Hello()
    {
        Debug.Log("hello");
    }

}
