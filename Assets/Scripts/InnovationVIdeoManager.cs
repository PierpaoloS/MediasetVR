using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnovationVIdeoManager : MonoBehaviour
{
    public GameObject video1;
    public GameObject video2;
    public GameObject video3;
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
        if (other.gameObject.CompareTag("Video1"))
        {
            Debug.Log("Triggerata scirtta 1");
            video1.SetActive(true);
            video2.SetActive(false);
            video3.SetActive(false);
            Invoke("SetFalseVideo1", 76.0f);
        }
        else if (other.gameObject.CompareTag("Video2"))
        {
            Debug.Log("Triggerata scirtta 2");
            video1.SetActive(false);
            video2.SetActive(true);
            video3.SetActive(false);
            Invoke("SetFalseVideo2", 158.0f);
        }
        else if (other.gameObject.CompareTag("Video3"))
        {
            Debug.Log("Triggerata scirtta 3");
            video1.SetActive(false);
            video2.SetActive(false);
            video3.SetActive(true);
            Invoke("SetFalseVideo3", 30.0f);
        }
        
    }
     void SetFalseVideo1()
    {
        video1.SetActive(false);       
    }

    void SetFalseVideo2()
    {
        video2.SetActive(false);       
    }

    void SetFalseVideo13()
    {
       video3.SetActive(false);       
    }
}
