using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
    public bool wasConnected;
    public GameObject puzzlePiece;
    public Connection connectionScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Connector"))
        {
            Debug.Log("Was Conected");
            wasConnected = true;
            ConnectPieces(collision);
        }
    }

    void ConnectPieces(Collision collision)
    {
        collision.transform.position = transform.position;
    }
}
