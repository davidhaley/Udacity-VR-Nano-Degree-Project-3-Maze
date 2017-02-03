using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    public GameObject keyPoofPrefab;
    public GameObject wayPointPortal;
    private Transform cameraTransform;
    [HideInInspector] public bool hasKey = false;

    void Update()
	{
        transform.Rotate(Vector3.up * (100f * Time.deltaTime));
    }

	public void OnKeyClicked()
	{
        var distance = Distance();

        if (distance <= 10f)
        {
            InstantiateKeyPoof();
            hasKey = true;
            InstantiateWaypointPortal();
        }
        else
        {
            Debug.Log("Do you really think your arms are that long?");
        }
    }

    private void InstantiateWaypointPortal()
    {
        var instantiatedWayPointPortal = GameObject.Instantiate(wayPointPortal, new Vector3(-5f,2f,63.1f), Quaternion.Euler(0f, 0f, 0f)) as GameObject;
        instantiatedWayPointPortal.transform.localScale = new Vector3(5f, 5f, 5f);
    }

    private void InstantiateKeyPoof()
    {
            GameObject.Instantiate(keyPoofPrefab, transform.position, Quaternion.Euler(-90f, 0f, 0f));
            GameObject.Destroy(this.gameObject);
    }

    private float Distance()
    {
        cameraTransform = Camera.main.GetComponent<Transform>();
        return Vector3.Distance(cameraTransform.position, transform.position);
    }
}
