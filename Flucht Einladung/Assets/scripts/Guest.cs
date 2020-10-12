using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guest : MonoBehaviour
{

    public GameObject policeGuest;
    public GameObject normalGuest;
    public GameObject startPoint;
    public GameObject stopPoint;
    GameObject guestStateObj;
    public int moveSpeed;
    bool moving = true;
    bool paperReceived;

    // Start is called before the first frame update
    void Awake()
    {
        //paperReceived = guestStateObj.GetComponent<GuestStateManager>().paperReceived;
        guestStateObj = GameObject.Find("GuestStateManager");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().moving);
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
            //GameObject newGuest = Instantiate(gameObject);
            //newGuest.transform.position = new Vector3(startPoint.transform.position.x, startPoint.transform.position.y, startPoint.transform.position.z);
            if(guestStateObj.GetComponent<GuestStateManager>().guestStatus == true && guestStateObj.GetComponent<GuestStateManager>().rightGuest == true) {
                guestStateObj.GetComponent<GuestStateManager>().rightGuestCount++;
                guestStateObj.GetComponent<GuestStateManager>().totalGuestCount++;
            }
            if(guestStateObj.GetComponent<GuestStateManager>().guestStatus == true && guestStateObj.GetComponent<GuestStateManager>().rightGuest == false) {
                guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount++;
                guestStateObj.GetComponent<GuestStateManager>().totalGuestCount++;
            }
            if(guestStateObj.GetComponent<GuestStateManager>().guestStatus == false) {
                guestStateObj.GetComponent<GuestStateManager>().policeGuestCount++;
            }
            if(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount < 20) {
                if(Random.Range(1, 11) > 2) {
                    if(Random.Range(1, 21) < 8) {
                        if(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount < 7) {
                            GameObject newGuest = normalGuest;
                            guestStateObj.GetComponent<GuestStateManager>().guestStatus = true;
                            guestStateObj.GetComponent<GuestStateManager>().rightGuest = true;
                            guestStateObj.GetComponent<GuestStateManager>().SpawnGuest(newGuest);
                            Debug.Log(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount +" : "+ guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount);
                            //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount);
                        }
                        else if(guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount < 13){
                            GameObject newGuest = normalGuest;
                            guestStateObj.GetComponent<GuestStateManager>().guestStatus = true;
                            guestStateObj.GetComponent<GuestStateManager>().rightGuest = false;
                            guestStateObj.GetComponent<GuestStateManager>().SpawnGuest(newGuest);
                            Debug.Log(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount +" : "+ guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount);
                            //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount);
                        }
                    }
                    else {
                        if(guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount < 13) {
                            GameObject newGuest = normalGuest;
                            guestStateObj.GetComponent<GuestStateManager>().guestStatus = true;
                            guestStateObj.GetComponent<GuestStateManager>().rightGuest = false;
                            guestStateObj.GetComponent<GuestStateManager>().SpawnGuest(newGuest);
                            Debug.Log(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount +" : "+ guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount);
                            //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount);
                        }
                        else if(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount < 7) {
                            GameObject newGuest = normalGuest;
                            guestStateObj.GetComponent<GuestStateManager>().guestStatus = true;
                            guestStateObj.GetComponent<GuestStateManager>().rightGuest = true;
                            guestStateObj.GetComponent<GuestStateManager>().SpawnGuest(newGuest);
                            Debug.Log(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount +" : "+ guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount);
                            //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount);
                        }
                    }
                }
                else {
                    GameObject newGuest = policeGuest;
                    guestStateObj.GetComponent<GuestStateManager>().guestStatus = false;
                    guestStateObj.GetComponent<GuestStateManager>().SpawnGuest(newGuest);
                    //Debug.Log(guestStateObj.GetComponent<GuestStateManager>().totalGuestCount);
                    Debug.Log(guestStateObj.GetComponent<GuestStateManager>().rightGuestCount +" : "+ guestStateObj.GetComponent<GuestStateManager>().wrongGuestCount);
                }
            }
            else {
                Debug.Log("Game Ended");
                guestStateObj.GetComponent<GuestStateManager>().ShowEnding();
            }
            guestStateObj.GetComponent<GuestStateManager>().paperReceived = false;
            Destroy(gameObject);
        }
    }
}

