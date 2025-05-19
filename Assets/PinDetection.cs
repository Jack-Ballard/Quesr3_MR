using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinDetection : MonoBehaviour
{
    public GameObject Pin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        Instantiate(Pin, transform.position, transform.rotation);
    }

}
