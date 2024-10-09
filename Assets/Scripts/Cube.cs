using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Make a cube with gizmos
    void Update()
    {
        //"Backward" face
        Debug.DrawLine(new Vector3(1,0,5), new Vector3(1,5,5), Color.yellow);
        Debug.DrawLine(new Vector3(1,0,5), new Vector3(6,0,5), Color.yellow);
        Debug.DrawLine(new Vector3(1,5,5), new Vector3(6,5,5), Color.yellow);
        Debug.DrawLine(new Vector3(6,0,5), new Vector3(6,5,5), Color.yellow);

        //Left face
        Debug.DrawLine(new Vector3(1,0,5),new Vector3(1,0,10), Color.yellow);
        Debug.DrawLine(new Vector3(1,0,10),new Vector3(1,5,10), Color.yellow);
        Debug.DrawLine(new Vector3(1,5,10),new Vector3(1,5,5), Color.yellow);
        Debug.DrawLine(new Vector3(1,5,10),new Vector3(1,5,5), Color.yellow);

        //Right face
        Debug.DrawLine(new Vector3(6, 0, 5), new Vector3(6, 0, 10), Color.yellow);
        Debug.DrawLine(new Vector3(6, 0, 10), new Vector3(6, 5, 10), Color.yellow);
        Debug.DrawLine(new Vector3(6, 5, 10), new Vector3(6, 5, 5), Color.yellow);
        Debug.DrawLine(new Vector3(6, 5, 5), new Vector3(6, 0, 5), Color.yellow);

        //Forward face
        Debug.DrawLine(new Vector3(6, 0, 10), new Vector3(1, 0, 10),Color.yellow);
        Debug.DrawLine(new Vector3(6, 5, 10), new Vector3(1, 5, 10),Color.yellow);


    }
}
