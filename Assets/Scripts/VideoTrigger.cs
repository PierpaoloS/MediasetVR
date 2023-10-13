using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public GameObject videoIntroduttivo;
    public GameObject videoGF;
    public GameObject videoPalinsesto;
    
    // Parte GreenScreen

    public GameObject videoGreenScreen;
    public GameObject siglaTG;
    public GameObject areaGF;
    public GameObject areaPalinsesto;
    public GameObject videoGobbo;
    public GameObject videoTG5;
    public GameObject greenSObjects;
    public GameObject onAirBox;
    public GameObject smartScreen1;
    public GameObject smartScreen2;

    // Parte Innovazione

    public GameObject videoInnovazione1;
    public GameObject videoInnovazione2;
    public GameObject videoInnovazione3;

    public GameObject AIButton;
    public GameObject DVBButton;
    public GameObject DTTButton;

    // Gestione Tempi Video

    public float secFalseIntro = 18.2f;
    public float secFalsePali = 14.0f;
    public float secFalseGF = 14.0f;
    public float secFarlseGreen = 22.0f;
    public float secTrueGreenStuff = 22.0f;
    public float secTrueSigla = 22.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TVCircle"))
        {
            Debug.Log("Play Video Introduttivo");
            videoIntroduttivo.SetActive(true);
            videoGF.SetActive(false);
            videoGreenScreen.SetActive(false);
            Invoke("SetFalseIntro", secFalseIntro);

            //test1.Play();
        }
        else if (other.gameObject.CompareTag("GrandeFratello"))
        {
            Debug.Log("Play Video Grande Fratello");
            videoGF.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGreenScreen.SetActive(false);
            Invoke("SetFalseGF", secFalseGF);
        }
        else if (other.gameObject.CompareTag("PalinsestoCircle"))
        {
            Debug.Log("Play Video Palinsesto");
            videoPalinsesto.SetActive(true);
            Invoke("SetFalsePali", secFalsePali);
        }
        else if (other.gameObject.CompareTag("GreenScreenCircle"))
        {
            Debug.Log("Play Video GreenScreen");
            videoGreenScreen.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGF.SetActive(false);
            areaGF.SetActive(false);
            areaPalinsesto.SetActive(false);
            greenSObjects.SetActive(true);
            Invoke("SetFalseGreen", secFarlseGreen);
            Invoke("ShowOnAirBox", secTrueGreenStuff);
            Invoke("ShowSmartScreens", secTrueGreenStuff);
            Invoke("StartSigla", secTrueSigla);
        }
    }
    void OnTriggerExit(Collider other)
    {
            videoIntroduttivo.SetActive(false);
            videoGF.SetActive(false);
            videoGreenScreen.SetActive(false);
            videoInnovazione1.SetActive(false);
            videoInnovazione2.SetActive(false);
            videoInnovazione3.SetActive(false);
            videoPalinsesto.SetActive(false);
            AIButton.SetActive(false);
            DVBButton.SetActive(false);
            DTTButton.SetActive(false);
            greenSObjects.SetActive(false);
            if (other.gameObject.CompareTag("GreenScreenCircle"))
            {
                areaPalinsesto.SetActive(true);
                areaGF.SetActive(true);
            }
            
    }

    void SetFalsePali()
    {
        videoPalinsesto.SetActive(false);       
    }

    void SetFalseGF()
    {
        videoGF.SetActive(false);       
    }

    void SetFalseGreen()
    {
       videoGreenScreen.SetActive(false);       
    }

    void StartSigla()
    {
       siglaTG.SetActive(true); 
       videoTG5.SetActive(true);  
       videoGobbo.SetActive(true);     
    }

    void SetFalseIntro()
    {
       videoIntroduttivo.SetActive(false);       
    }

    void ShowOnAirBox()
    {
       onAirBox.SetActive(true);      
    }

    void ShowSmartScreens()
    {
        smartScreen1.SetActive(true);
        smartScreen2.SetActive(true);
    }

}
