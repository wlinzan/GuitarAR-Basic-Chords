using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour
{

    //echoAR echo;

    void Start(){
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
    }
    
}
