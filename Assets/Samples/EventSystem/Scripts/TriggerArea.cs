using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entering Door:" + id);
        // Fire the OpenDoor Event
        EventSystem.current.DoorwayTriggerEnter(id);
    }

    private void OnTriggerExit(Collider other) {
        
        Debug.Log("Exiting Door:" + id);
        // Fire the CloseDoor Event
        EventSystem.current.DoorwayTriggerExit(id);
    }
    
}
