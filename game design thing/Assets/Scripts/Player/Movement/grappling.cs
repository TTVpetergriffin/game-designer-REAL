public class grappling : MonoBehaviour
{
    public Transform targetObject;
    public float moveSpeed = 5f;

    private void Update()
    {
        // Determine the distance between the player and the target object
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // Calculate the interpolation value as a fraction of the distance
        float interpolationValue = Mathf.Clamp01(distance / moveSpeed);

        // Use Lerp to smoothly move the player towards the object's position
        transform.position = Vector3.Lerp(transform.position, targetObject.position, interpolationValue * Time.deltaTime * moveSpeed);
    }
}