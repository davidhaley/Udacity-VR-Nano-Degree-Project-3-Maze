using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    [HideInInspector] public bool locked = true;
    public float openSpeed;
    public Key key;
    public AudioSource audioSource;

    void Update() {
        if (!locked)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(10f, 11.5f, 23.02f), Time.deltaTime * openSpeed);
        }
    }

    public void OnDoorClicked()
    {
        if (key.hasKey)
        {
            locked = false;
        }
        else
        {
            Debug.Log("You don't have the key!");
        }
    }
}
