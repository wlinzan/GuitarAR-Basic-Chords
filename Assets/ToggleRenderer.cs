using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRenderer : MonoBehaviour
{

    //echoAR echo;

    public void VisibilityOn() {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if(rend.enabled)
            rend.enabled = false;
        else
            rend.enabled = true;
    }

    public void VisibilityOff() {

        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }
    
}
