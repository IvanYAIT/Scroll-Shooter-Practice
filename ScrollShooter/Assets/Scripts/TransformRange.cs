using UnityEngine;

public class TransformRange : MonoBehaviour
{
    [SerializeField] private Transform lowerLeft;
    [SerializeField] private Transform upperRight;

    public Vector2 RandomInRange() =>
        new Vector2(
            Random.Range(lowerLeft.position.x, upperRight.position.x),
            Random.Range(lowerLeft.position.y, upperRight.position.y)
            );
}

