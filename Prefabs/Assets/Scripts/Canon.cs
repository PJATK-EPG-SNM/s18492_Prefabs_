using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
public float period = 1;
private float lastBallTime;

public Canonball prefab;
public Transform startTrasform;

public float rotationSpeed = 50;
private float direction = -1;

    // Start is called before the first frame update
    void Start()
    {
        lastBallTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       // lastBallTime = lastBallTime + Time.deltaTime;
       lastBallTime += Time.deltaTime;
       if(lastBallTime > period) {
        lastBallTime = 0;
        //stworzenie obiektu z prefabu
        Instantiate(prefab, startTrasform.position, startTrasform.rotation);
       
	   }
       if(lastBallTime > period / 2) {
        float rotationValue = rotationSpeed * direction * Time.deltaTime;
        Vector3 rotateVector = new Vector3(0,0, rotationValue);
        startTrasform.Rotate(rotateVector);
        if(startTrasform.rotation.z < -0.999 || startTrasform.rotation.z > 0) {
         direction*= -1;  
		}
	   }
    }
}
