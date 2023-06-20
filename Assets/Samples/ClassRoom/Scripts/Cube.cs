using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHET;

public class Cube : MonoBehaviour
{
    private Vector3 origin;

    public Transform Destination;

    public float time = .5f;
    // Using the Start method to store its original position
    private void Start() {
        //origin = this.transform.position;
        origin = this.transform.position; 
    }

    public Direction GetDirection()
    {
        if (this.name == "left")
            return Direction.LEFT;
        else if (this.name == "up")
            return Direction.UP;
        else if (this.name == "down")
            return Direction.DOWN;
        else
            return Direction.RIGHT;
    }

    /**
    * Returns the cube back to its original position on front of the classroom
    * @input void
    * @output void
    */
    public void PositionReset()
    {
        LeanTween.move(this.gameObject, this.origin, time);
        this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }

    public Vector3 GetOriginalPosition()
    {
        return origin;
    }
}
