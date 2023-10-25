using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.TerrainUtils;

public class Pieces : MonoBehaviour
{
    private Renderer renderer;

    private Vector3 screenPoint;
    private Vector3 offset;
    public bool canMove;
    public bool isSelected;
    public bool isAStaticPiece;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
        isSelected = true;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
        isSelected = false;
    }

    private void OnMouseDown()
    {
        if (canMove && !isAStaticPiece)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position -
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    private void OnMouseDrag()
    {
        if (canMove && !isAStaticPiece)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

}
