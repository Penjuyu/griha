using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10;
    public float rotSpeed = 100;
    public float jumpSpeed = 30; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float movX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotY = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        float movY = 0;
        if (Input.GetButtonDown("Jump"))
        {
            movY = jumpSpeed * Time.deltaTime;
        }
        transform.Translate(movX, movY, movZ);
        transform.Rotate(0, rotY, 0);
    }    

    void OnCollisionEnter(Collision collision)
    {        
      if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
            GetComponent<Renderer>().material.color = Color.red; //получаем компонент
            Time.timeScale = 0;// останавливает время в игре
        }


    }
}
