using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropP : MonoBehaviour
{
    GameObject guestManagerObj;
    public GameObject paperSlot;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    void Awake(){
        guestManagerObj = GameObject.Find("GuestStateManager");
    }
    void Start(){
        resetPosition = this.transform.localPosition;
    }

    void Update(){
        
        if(moving){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
        }

    }

    private void OnMouseDown(){
        if (Input.GetMouseButtonDown(0) && guestManagerObj.GetComponent<GuestStateManager>().moving == false){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            
            moving = true;
        }
    }

    private void OnMouseUp(){
        moving = false;

        if(Mathf.Abs(this.transform.localPosition.x - paperSlot.transform.localPosition.x) <= 2.5f 
        && Mathf.Abs(this.transform.localPosition.y - paperSlot.transform.localPosition.y) <= 1.5f) {
            if(guestManagerObj.GetComponent<GuestStateManager>().guestStatus == false) {
                guestManagerObj.GetComponent<GuestStateManager>().gg++;
                Debug.Log(
                    guestManagerObj.GetComponent<GuestStateManager>().rr
                    + "rr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rd
                    + "rd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rg
                    + "rg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().wr
                    + "wr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wd
                    + "wd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wg
                    + "wg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().gr
                    + "gr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gd
                    + "gd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gg
                    + "wg"
                );
            }
            else if(guestManagerObj.GetComponent<GuestStateManager>().rightGuest == true) {
                guestManagerObj.GetComponent<GuestStateManager>().rg++;
                Debug.Log(
                    guestManagerObj.GetComponent<GuestStateManager>().rr
                    + "rr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rd
                    + "rd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rg
                    + "rg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().wr
                    + "wr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wd
                    + "wd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wg
                    + "wg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().gr
                    + "gr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gd
                    + "gd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gg
                    + "wg"
                );
            }
            else {
                guestManagerObj.GetComponent<GuestStateManager>().wg++;
                Debug.Log(
                    guestManagerObj.GetComponent<GuestStateManager>().rr
                    + "rr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rd
                    + "rd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().rg
                    + "rg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().wr
                    + "wr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wd
                    + "wd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().wg
                    + "wg\n" +
                    guestManagerObj.GetComponent<GuestStateManager>().gr
                    + "gr : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gd
                    + "gd : " +
                    guestManagerObj.GetComponent<GuestStateManager>().gg
                    + "gg"
                );
            }
            guestManagerObj.GetComponent<GuestStateManager>().paperReceived = true;
            guestManagerObj.GetComponent<GuestStateManager>().moving = true;
            //this.transform.localPosition = new Vector3(paperSlot.transform.localPosition.x, paperSlot.transform.localPosition.y, paperSlot.transform.localPosition.z);
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
        else{
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
