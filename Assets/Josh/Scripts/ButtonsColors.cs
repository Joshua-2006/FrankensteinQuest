using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class ButtonsColors : MonoBehaviour
{
    public int colorInt;
    public Sequence sequence;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetButton("Interact") && collision.CompareTag("Player"))
        {
        }
    }
}
