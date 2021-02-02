using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControler : MonoBehaviour
{
    public Transform Door;

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
        Door.GetComponent<Animator>().SetBool("open", true);
    }

    void OnTriggerExit(Collider other) 
    {
        Door.GetComponent<Animator>().SetBool("open", false);
    }
}
