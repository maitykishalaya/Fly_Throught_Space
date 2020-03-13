
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{

    void Update()
    {
        Vector2 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -2.35f, 2.35f);
        //viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y - objectHeight);
        transform.position = viewPos;
    }
}