using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    private float speed = 1.5f;

    void FixedUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
