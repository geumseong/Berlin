using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestStateManager : MonoBehaviour
{

    public bool paperReceived = false;
    public bool moving = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(paperReceived);
    }
}
