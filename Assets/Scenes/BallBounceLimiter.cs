using UnityEngine;
public class BallBounceLimiter : MonoBehaviour
{
    public int maxBounces = 3;
    public float stopVelocity = 0.3f;
    private int bounceCount = 0;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, что это земля
        if (collision.gameObject.CompareTag("Wood"))
        {
            bounceCount++; if (bounceCount >= maxBounces)
            { // Гасим движение
                rb.velocity *= 0.3f;
                rb.angularVelocity *= 0.3f;
                // Если почти остановился — стопаем полностью
                if (rb.velocity.magnitude < stopVelocity)
                {
                    rb.velocity = Vector3.zero; rb.angularVelocity = Vector3.zero;
                }
            }
        }
    }
    // Вызывай это, когда игрок снова бросает мяч
    public void ResetBounces() { bounceCount = 0; }
}