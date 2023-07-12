using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAnimationTrigger : MonoBehaviour
{
    public float sec = 14f;
    //public MyController MyController;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

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
            Invoke("SetActive", 14.0f);  
        }
    }

    void SetActive()
    {
        Button1.SetActive(true);
        Button2.SetActive(true);  
        Button3.SetActive(true);       
    }
}
