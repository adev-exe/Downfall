using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Helps stick camera on crabby
//For camera holder object
public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;

    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
