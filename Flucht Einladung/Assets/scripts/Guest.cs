using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guest : MonoBehaviour
{

    public GameObject guestPrefab;
    public GameObject startPoint;
    public GameObject stopPoint;
    public GameObject guestStateObj;
    public int moveSpeed;
    bool moving = true;
    bool paperReceived;

    // Start is called before the first frame update
    void Start()
    {
        //paperReceived = guestStateObj.GetComponent<GuestStateManager>().paperReceived;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= stopPoint.transform.position.x && guestStateObj.GetComponent<GuestStateManager>().paperReceived == false) {
            guestStateObj.GetComponent<GuestStateManager>().moving = false;
        }
        else {
            guestStateObj.GetComponent<GuestStateManager>().moving = true;
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        }
    }

    void OnCollisionEnter2D(Collision2D collider) {
        if(collider.gameObject.tag == "guestRemover") {
            GameObject newGuest = Instantiate(gameObject);
            newGuest.transform.position = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z);
            guestStateObj.GetComponent<GuestStateManager>().paperReceived = false;
            Destroy(gameObject);
        }
    }
}

