using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Masukpintu : MonoBehaviour
{
    private bool bolehmasuk;
    private string scenetoload;

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.GetComponent<PintuKamar>())
        {
            scenetoload = "RuangTengah";
            bolehmasuk = true;  
        }
        else if (col.GetComponent<PintuTengah>())
        {
            scenetoload = "KamarAwal2";
            bolehmasuk = true;  
        }
        else if (col.GetComponent<PintuTengah2>())
        {
            scenetoload = "Kamarmandi";
            bolehmasuk = true;
        }
        else if (col.GetComponent<PintuTengah3>())
        {
            scenetoload = "Kamarmandi";
            bolehmasuk = true;
        }
        else if (col.GetComponent<Pintukamarmandi>())
        {
            scenetoload = "RuangTengah";
            bolehmasuk = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col) 
    {
        if (col.GetComponent<PintuKamar>() || col.GetComponent<PintuTengah>())
        {
            bolehmasuk = false;
        }
    }
    private void Update() 
    {
        if (bolehmasuk && Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(scenetoload);
        }
    }
}
