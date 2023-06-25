using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoTrigger : MonoBehaviour
{
    public GameObject tvLight;
    //public GameObject videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        tvLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TVCircle"))
        {
            Debug.Log("Triggera Luce");
            tvLight.SetActive(true);
        }
        
    }
}
