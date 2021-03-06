using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CarMovement : MonoBehaviour
{
    public float speed = 0;
    //public TextMeshProUGUI countText;
    //public GameObject winText;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    
    //private int count;
  
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
      
      //count = 0;
      //SetCountText();
      
      //winText.SetActive(false);
        
    }
    
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food")) {
          other.gameObject.SetActive(false);
          
          //count++;
          //SetCountText();
        }
    }
}
