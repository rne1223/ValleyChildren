using UnityEngine;
using UnityEngine.SceneManagement;

public class Test: MonoBehaviour
{
    public Arrow arrow;

    public Cube[] cubes;

    private int setScore = 0;

    public static int[] testScore = new int[7];
    private int level = 0;

    private int i = 0;
    private int j = 0;

    public void CubeGrab()
    {
        //Debug.Log("Cube Release");
    }

    public void CubeRelease()
    {
        //Debug.Log("Cube Release");
        foreach (var cube in cubes)
        {
            // Check which cube is out of postion
            if (cube.transform.position != cube.GetOriginalPosition())
            {
                if (arrow.GetDirection() == cube.GetDirection())
                {
                    Debug.Log("Got it right");
                    setScore++;
                    testScore[level]++;
                    arrow.Rotate();
                }
                else
                {
                    Debug.Log("Got it wrong");
                    setScore--;
                    arrow.Rotate();
                }
                i++;

                if(i == 5)
                {
                    Debug.Log(setScore);
                    i = 0;
                    if(setScore > 0)
                    {
                        arrow.RotateShrink();
                        if (arrow.getSize() > 21)
                        {
                            level++;
                        }
                    }
                    else
                    {
                        arrow.RotateGrow();
                        if (arrow.getSize() < 152)
                        {
                            level--;
                        }
                    }
                    setScore = 0;
                    j++;
                }

                cube.PositionReset();
                if(j == 10)
                {

                    SceneManager.LoadScene("Samples/ClassRoom/Graph/Results");
                }
                break;
            }
        }
    }
}
