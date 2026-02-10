using UnityEngine;
using Valve.VR.InteractionSystem;

public class BallResetOnThrow : MonoBehaviour
{
    private BallBounceLimiter limiter;

    void Awake()
    {
        limiter = GetComponent<BallBounceLimiter>();
    }

    void OnDetachFromHand(Hand hand)
    {
        limiter.ResetBounces();
    }
}
