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
    public bool isSelected;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        isSelected = puzzlePiece.GetComponent<Pieces>().isSelected;
        /*if (wasConnected)
        {
            connection.transform.position = transform.position;
        }*/

        if (Input.GetKeyDown(KeyCode.E) && isSelected)
        {
            puzzlePiece.GetComponent<Pieces>().canMove = true;
            //transform.parent.SetParent(null);
        }

        //puzzlePiece.transform.position = startPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        /* if (collision.gameObject.CompareTag("Connection"))
        {
            connection = collision.gameObject;
            wasConnected = true;
            Debug.Log("Was Conected");
        }*/

        if (collision.gameObject.CompareTag("Connection"))
        {
            /*var newParent = new GameObject();
            newParent.gameObject.name = "Connected Pieces";
            newParent.transform.SetParent(collision.transform.parent.parent); // Get the parent of the current gameobject the collider is attached to
            collision.transform.parent.SetParent(newParent.transform); // Doing .parent because this is the child collider
            transform.parent.SetParent(newParent.transform);*/

            puzzlePiece.GetComponent<Pieces>().canMove = false;
            //puzzlePiece.transform.position
            //collision.gameObject.GetComponent<Connection>().puzzlePiece.GetComponent<Pieces>().canMove = false;
        }
    }
}
