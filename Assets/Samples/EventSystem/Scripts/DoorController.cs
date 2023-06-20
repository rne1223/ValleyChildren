using UnityEngine;

public class DoorController : MonoBehaviour
{

    public int id;
    public float heightPoint = 2f;
    public float startingPoint = .7f;
    public float time = 1f;
    // Start is called before the first frame update
    void Start() {
        EventSystem.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        EventSystem.current.onDoorwayTriggerExit += OnDoorwayExit;
    }

    private void OnDoorwayOpen(int id) {
        if(id == this.id) {
            LeanTween.moveLocalY(gameObject, heightPoint, time).setEaseOutQuad();
        }
    }
    private void OnDoorwayExit(int id) {
        if(id == this.id) {
            LeanTween.moveLocalY(gameObject, startingPoint, time).setEaseInQuad();
        }
    }

    private void OnDestroy() {
        
        EventSystem.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
        EventSystem.current.onDoorwayTriggerExit -= OnDoorwayExit;
    }
}
