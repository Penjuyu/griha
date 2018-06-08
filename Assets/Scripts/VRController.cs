using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))] // зависимость от объекта
public class VRController : MonoBehaviour
{
    public Transform cam;
    public float speed = 3;
    public float toggleAngle = 45;
    Rigidbody body; // вводим переменную (ссылка на объект)
    bool isMoving;
	void Start ()
    {
        body = GetComponent<Rigidbody>(); // если у объетка есть rigitbody, то он находит его
	}
	
	
	void FixedUpdate ()
    {
        isMoving = cam.eulerAngles.x >= toggleAngle && cam.eulerAngles.x <= 90;
       if (isMoving)
        
      
        {

            Vector3 forward = cam.TransformDirection(Vector3.forward);
            body.velocity = forward * speed;
        }

	}
}
