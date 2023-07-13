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
            //tvLight.SetActive(true);
            videoIntroduttivo.SetActive(true);
            videoGF.SetActive(false);
            videoGreenScreen.SetActive(false);
        }
        else if (other.gameObject.CompareTag("GrandeFratello"))
        {
            Debug.Log("Play Video Grande Fratello");
            //tvLight.SetActive(true);
            videoGF.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGreenScreen.SetActive(false);
        }
        else if (other.gameObject.CompareTag("PalinsestoCircle"))
        {
            Debug.Log("Play Video Palinsesto");
            //tvLight.SetActive(true);
            videoPalinsesto.SetActive(true);
        }
        else if (other.gameObject.CompareTag("GreenScreenCircle"))
        {
            Debug.Log("Play Video GreenScreen");
            //tvLight.SetActive(true);
            videoGreenScreen.SetActive(true);
            videoIntroduttivo.SetActive(false);
            videoGF.SetActive(false);
        }
    }
    void OnTriggerExit(Collider other)
    {
            videoIntroduttivo.SetActive(false);
            videoGF.SetActive(false);
            videoGreenScreen.SetActive(false);
            //videoPalinsesto.SetActive(false);
            videoInnovazione1.SetActive(false);
            videoInnovazione2.SetActive(false);
            videoInnovazione3.SetActive(false);
    }
}
