using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Connector : MonoBehaviour
{
    public bool wasConnected;
    public GameObject puzzlePiece;
    public Connection connectionScript;
    private GameObject connection;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (wasConnected)
        {
            connection.transform.position = transform.position;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            wasConnected = false;
        }

        //puzzlePiece.transform.position = startPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Connection"))
        {
            connection = collision.gameObject;
            wasConnected = true;
            Debug.Log("Was Conected");
        }
    }
}
