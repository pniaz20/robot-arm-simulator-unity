using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class SwitchLight : MonoBehaviour
{
    void start() { }
    void update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.DownArrow)) this.GetComponent<Light>().enabled = false;
    }
}