using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movment = new Vector3 (moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        transform.Translate(movment);
    }
}
