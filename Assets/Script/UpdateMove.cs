using UnityEngine;

public class UpdateMove : MonoBehaviour
{
    private float speed = 1.0f;

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
