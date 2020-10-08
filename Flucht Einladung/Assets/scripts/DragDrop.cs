﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    public GameObject paperSlot;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

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
        if (Input.GetMouseButtonDown(0)){
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

        if(Mathf.Abs(this.transform.localPosition.x - paperSlot.transform.localPosition.x) <= 1.5f 
        && Mathf.Abs(this.transform.localPosition.y - paperSlot.transform.localPosition.y) <= 1.5f) {
            this.transform.localPosition = new Vector3(paperSlot.transform.localPosition.x, paperSlot.transform.localPosition.y, paperSlot.transform.localPosition.z);
        }
        else{
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
