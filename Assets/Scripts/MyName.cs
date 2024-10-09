using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    //Using: Make my name with gizmos

    void Update()
    {
        //First R
        Debug.DrawLine(new Vector2(0,0),new Vector2(0,4), Color.green);
        Debug.DrawLine(new Vector2(0,4),new Vector2(2, 2), Color.green);
        Debug.DrawLine(new Vector2(2,2),new Vector2(0, 2), Color.green);
        Debug.DrawLine(new Vector2(0,2),new Vector2(2, 0), Color.green);

        //O
        Debug.DrawLine(new Vector2(3,0),new Vector2(3,4), Color.green);
        Debug.DrawLine(new Vector2(3,4),new Vector2(5,4), Color.green);
        Debug.DrawLine(new Vector2(5,4),new Vector2(5,0), Color.green);
        Debug.DrawLine(new Vector2(5,0),new Vector2(3,0), Color.green);

        //G
        Debug.DrawLine(new Vector2(6, 0), new Vector2(6, 4), Color.green);
        Debug.DrawLine(new Vector2(6, 4), new Vector2(8, 4), Color.green);
        Debug.DrawLine(new Vector2(6, 0), new Vector2(8, 0), Color.green);
        Debug.DrawLine(new Vector2(8, 0), new Vector2(8, 2), Color.green);
        Debug.DrawLine(new Vector2(8, 2), new Vector2(7, 2), Color.green);

        //E
        Debug.DrawLine(new Vector2(9,0), new Vector2(9,4), Color.green);
        Debug.DrawLine(new Vector2(9,4), new Vector2(11,4), Color.green);
        Debug.DrawLine(new Vector2(9,2), new Vector2(11,2), Color.green);
        Debug.DrawLine(new Vector2(9,0), new Vector2(11,0), Color.green);
        Debug.DrawLine(new Vector2(9,0), new Vector2(11,0), Color.green);

        //Second R
        Debug.DrawLine(new Vector2(12, 0), new Vector2(12, 4), Color.green);
        Debug.DrawLine(new Vector2(12, 4), new Vector2(14, 2), Color.green);
        Debug.DrawLine(new Vector2(14, 2), new Vector2(12, 2), Color.green);
        Debug.DrawLine(new Vector2(12, 2), new Vector2(14, 0), Color.green);

        //Happy Face
        Debug.DrawLine(new Vector2(16,1),new Vector2(16,0),Color.red);
        Debug.DrawLine(new Vector2(16,0),new Vector2(19,0),Color.red);
        Debug.DrawLine(new Vector2(19,0),new Vector2(19,1),Color.red);
        Debug.DrawLine(new Vector2(17,4),new Vector2(17,2),Color.red);
        Debug.DrawLine(new Vector2(18,4),new Vector2(18,2),Color.red);


    }
}
