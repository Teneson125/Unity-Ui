using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthenticationHandler : MonoBehaviour
{
    [SerializeField]
    public GameObject startGrid;
    [SerializeField]
    public GameObject userDetailGrid;
    [SerializeField]
    public GameObject verificationGrid;

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
    public void VerificationButton()
    {
        verificationGrid.SetActive(true);
        userDetailGrid.SetActive(false);
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
}
