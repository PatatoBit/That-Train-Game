using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 0f;
    float distanceTravelled;

    void FixedUpdate() {
        distanceTravelled  += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);
    }

}
