using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLinePlayer : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;
    //public Rigidbody2D rb;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> muisPositions;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            CreateLine();
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 TenmMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(Vector2.Distance(TenmMousePos, muisPositions[muisPositions.Count -1]) > .1f)
            {
                UpdateLine(TenmMousePos);
            }
        }
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        //rb = currentLine.GetComponent<Rigidbody2D>(); //rigidbody toevoegen?
        //rb.isKinematic = true;
        muisPositions.Clear();
        muisPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        muisPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, muisPositions[0]);
        lineRenderer.SetPosition(1, muisPositions[1]);
        edgeCollider.points = muisPositions.ToArray();
        currentLine.tag = "Lines"; //weghalen alle lines bij restart level door tag
    }

    void UpdateLine(Vector2 newMuisposition)
    {
        muisPositions.Add(newMuisposition);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newMuisposition);
        edgeCollider.points = muisPositions.ToArray();

    }


}
