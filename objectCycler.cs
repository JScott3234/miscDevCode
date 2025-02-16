using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jase Scott ---- (405) 697-4272 if you need to contact me or jase.scott@okstate.edu

// For a VR project involving the Department of Interior Design at OKState

public class ObjectCycler : MonoBehaviour
{
    public GameObject open; // will be the "current" object
    public GameObject half;
    public GameObject closed; 
    private int current = 0;
    
    void Start()
    {
        open.SetActive(true);
        half.SetActive(false);
        closed.SetActive(false);
        Debug.Log("Open: " + open);
        Debug.Log("Half: " + half);
        Debug.Log("Closed " + closed);
    }

    private void load(GameObject a, bool state){
        
    }


    public void cycle(){
        Debug.Log("Current before: " + current);
        switch(current){
            case 0: open.SetActive(false); half.SetActive(true); current = 1; Debug.Log("Cycle to half."); break; // switches from open to half
            case 1: half.SetActive(false); closed.SetActive(true); current = 2; Debug.Log("Cycle to closed."); break; // switches from half to closed
            case 2: closed.SetActive(false); open.SetActive(true); current = 0; Debug.Log("Cycle to open."); break; // switches from closed to open
            default: Debug.Log("Something didn't work"); break;
        }
        Debug.Log("Current after: " + current);
    }

}
