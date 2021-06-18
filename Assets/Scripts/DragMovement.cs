using UnityEngine;

public class DragMovement : MonoBehaviour
{
    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                                                                        Input.mousePosition.y,
                                                                        Camera.main.WorldToScreenPoint(transform.position).z));
    }
}
