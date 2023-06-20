using UnityEngine; // Use to display debug messages
using TMPro;
using CHET;

public class Arrow : MonoBehaviour
{
    public TextMeshPro arr;

    /** 
     * Returns the direction that the arrow is pointing to
     * 
     * @input  void
     *
     * @return string  (up,down,left,right)
    **/ 
    public void Start() {
        // Rotate to a random direction when starts
        RotateTo(RandomDirection.GetDirection());
    }

    public Direction GetDirection()
    {
        float zAngle = arr.rectTransform.rotation.eulerAngles.z;

        switch (zAngle)
        {
            case 90:
                return Direction.DOWN;
            case 180:
                return Direction.RIGHT;
            case 270:
                return Direction.UP;
            default:
                return Direction.LEFT;
        }
    }

    /** 
     * Rotates the arrow to a random direction
     * between up, down, left or right
     * 
     * @input enum (up,down,left,right)
     *
     * @return void 
    */ 
    private void RotateTo(Direction direction)
    {
        //Debug.Log("Rotating Arrow " + direction);
        Quaternion tmp = arr.rectTransform.rotation;

        switch (direction)
        {
            case Direction.DOWN:
                tmp = Quaternion.Euler(0, 180, 90);
                break;
            case Direction.RIGHT:
                tmp = Quaternion.Euler(0, 180, 180);
                break;
            case Direction.UP:
                tmp = Quaternion.Euler(0, 180, 270);
                break;
            case Direction.LEFT:
                tmp = Quaternion.Euler(0, 180, 0);
                break;
        }

        arr.rectTransform.rotation = tmp;
    }

    private void Shrink()
    {
        
        float arrowSize = arr.fontSize;
        if(arrowSize > 21)
        {
            if (arrowSize == 108)
            {
                arrowSize += 1f;
            }
            arrowSize -= 22f;
        }
        arr.fontSize = arrowSize;
    }

    private void Grow()
    {
        float arrowSize = arr.fontSize;
        if (arrowSize < 152)
        {
            if (arrowSize == 87)
            {
                arrowSize -= 1f;
            }
            arrowSize += 22f;
        }
        arr.fontSize = arrowSize;
    }

    /** 
     * RandomRotates the arrow by passing a random direction to rotatate(direction) method
     * 
     * @input void  
     *
     * @return void 
     **/
    public void RotateShrink()
    {
        //Debug.Log("Rotating Arrow to a random direction");
        RotateTo(RandomDirection.GetDirection());
        Shrink();
    }

    public void RotateGrow()
    {
        //Debug.Log("Rotating Arrow to a random direction");
        RotateTo(RandomDirection.GetDirection());
        Grow();
    }

    public float getSize()
    {
        return arr.fontSize;
    }

    // Just rotate the arrow and don't shrink it
    public void Rotate()
    {
        RotateTo(RandomDirection.GetDirection());
    }
}
