using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int speed = 8000;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        // Vector3 dir = (Vector3) (speed *  0f,speed * -Input.GetAxis("Vertical") * Time.deltaTime);
        if(Input.GetKey(KeyCode.LeftArrow)){
            // Debug.Log("Player Moving Left");
            rb.AddForce(speed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            // Debug.Log("Player Moving Right");
            rb.AddForce(-speed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            // Debug.Log("Player Moving Down");
            rb.AddForce(0,0,speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            // Debug.Log("Player Moving Up");
            rb.AddForce(0,0,-speed*Time.deltaTime);
        }
    }
}