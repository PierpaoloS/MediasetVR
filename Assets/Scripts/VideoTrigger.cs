using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTrigger : MonoBehaviour
{
    //public GameObject tvLight;
    public GameObject videoIntroduttivo;
    public GameObject videoGF;
    public GameObject videoGreenScreen;
    public GameObject videoPalinsesto;

    public GameObject videoInnovazione1;
    public GameObject videoInnovazione2;
    public GameObject videoInnovazione3;

    public GameObject AIButton;
    public GameObject DVBButton;
    public GameObject DTTButton;

    public GameObject greenSObjects;
    public GameObject onAirBox;
   // public GameObject sigla; 

    //public float secPali = 14f;
    //public float secGF = 14f;
    //public float secGreen = 14f;


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
            Invoke("SetFalseIntro", 19.0f);
        }
        else if (other.gameObject.CompareTag("GrandeFratello"))
        {
            Debug.Log("Play Video Grande Fratello");
            videoGF.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGreenScreen.SetActive(false);
            Invoke("SetFalseGF", 13.0f);
        }
        else if (other.gameObject.CompareTag("PalinsestoCircle"))
        {
            Debug.Log("Play Video Palinsesto");
            videoPalinsesto.SetActive(true);
            Invoke("SetFalsePali", 15.0f);
        }
        else if (other.gameObject.CompareTag("GreenScreenCircle"))
        {
            Debug.Log("Play Video GreenScreen");
            videoGreenScreen.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGF.SetActive(false);
            greenSObjects.SetActive(true);
            Invoke("SetFalseGreen", 21.0f);
            Invoke("ShowOnAirBox", 12.0f);
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
            AIButton.SetActive(false);
            DVBButton.SetActive(false);
            DTTButton.SetActive(false);
            greenSObjects.SetActive(false);
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

    void SetFalseIntro()
    {
       videoIntroduttivo.SetActive(false);       
    }

    void ShowOnAirBox()
    {
       onAirBox.SetActive(true);   
      // sigla.SetActive(true);    
    }

}
