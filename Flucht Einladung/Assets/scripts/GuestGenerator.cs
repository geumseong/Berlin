using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestGenerator : MonoBehaviour
{

    public GameObject guestPrefab;
    public GameObject startPoint;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateGuest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateGuest() {
        Vector3 startVector = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z);
        GameObject newGuest = Instantiate(guestPrefab);
        newGuest.transform.position = startVector;
    }
}
