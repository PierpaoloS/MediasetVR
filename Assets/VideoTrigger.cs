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
        }
        else if (other.gameObject.CompareTag("GrandeFratello"))
        {
            Debug.Log("Play Video Grande Fratello");
            //tvLight.SetActive(true);
            videoGF.SetActive(true);
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
        }
    }
}
