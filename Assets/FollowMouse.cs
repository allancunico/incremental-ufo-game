using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.position = Vector3.Lerp(transform.position, mousePosition, speed * Time.deltaTime);         
    }
}
