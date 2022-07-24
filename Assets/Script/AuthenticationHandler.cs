using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthenticationHandler : MonoBehaviour
{
    public GameObject startGrid;
    public GameObject userDetailGrid;
    public GameObject verificationGrid;
    public MessageHandler messageHandler;

    public void Start()
    {
        userDetailGrid.SetActive(false);
        verificationGrid.SetActive(false);
    }
    public void LoginButton()
    {
        verificationGrid.SetActive(true);
        startGrid.SetActive(false);
    }
    public void RegisterButton()
    {
        userDetailGrid.SetActive(true);
        startGrid.SetActive(false);
    }
    public void CancelButton()
    {
        startGrid.SetActive(true);
        userDetailGrid.SetActive(false);
        verificationGrid.SetActive(false);
    }
    public void SubmitButton()
    {
        verificationGrid.SetActive(true);
        userDetailGrid.SetActive(false);
    }
    public void VerifyButton()
    {        
        messageHandler.Message();
    }
}
