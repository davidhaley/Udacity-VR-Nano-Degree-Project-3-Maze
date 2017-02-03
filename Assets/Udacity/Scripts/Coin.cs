using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    public GameObject coinPoofPrefab;

    private void Update()
    {
        transform.Rotate(Vector3.up * (150f * Time.deltaTime));
    }

    public void OnCoinClicked() {
        GameObject.Instantiate(coinPoofPrefab, transform.position, Quaternion.Euler(-90f,0f,0f));
        GameObject.Destroy(this.gameObject);
    }

}
