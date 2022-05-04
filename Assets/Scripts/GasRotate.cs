using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasRotate : MonoBehaviour
{ 
    private float rotationSpeed = 1;
    private float height = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(rotate());
    }

   public IEnumerator rotate()
    { 
        transform.Rotate(new Vector3(0, 1, 10));
        // transform.Translate(new Vector3(0, Mathf.Sin(Time.deltaTime) / 100 * height, 0));
        
        yield return new WaitForSeconds(10);
    }
    //  void FixedUpdate()
    // {
    //     transform.Rotate(new Vector3(1, rotationSpeed, 25));
    //     transform.Translate(new Vector3(0, Mathf.Sin(Time.time) / 100 * height, 0));
    // }
}