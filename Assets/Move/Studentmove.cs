using UnityEngine;

public class Studentmove : MonoBehaviour {
    private float speed = 15f;
    private float moveRange = 4f;

    private void Update() {
        float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            playerMove = -speed * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            playerMove = speed * Time.deltaTime;
        }

        float targetXPosition = transform.position.x + playerMove;
        targetXPosition = Mathf.Clamp(targetXPosition, -moveRange, moveRange);

        transform.position = new Vector3(targetXPosition, transform.position.y, transform.position.z);
    }
}
