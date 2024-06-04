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
            scenetoload = "2";
            bolehmasuk = true;  
        }
        else if (col.GetComponent<PintuTengah>())
        {
            scenetoload = "1.5";
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
