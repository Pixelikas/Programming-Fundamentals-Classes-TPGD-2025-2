using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    
    private Vector2 moveDirection;
    private float moveSpeed;

    public void Initialize(Vector2 direction, float speed)
    {
        moveDirection = direction;
        moveSpeed = speed;
    }

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }

}
