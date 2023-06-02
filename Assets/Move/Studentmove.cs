using UnityEngine;

public class Studentmove : MonoBehaviour {
    private float speed = 15f;
    private float moveRange = 4f;

    // 캐릭터 충돌 범위를 설정할 변수
    public float collisionBoxWidth = 1f;
    public float collisionBoxHeight = 1f;

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

    private void OnDrawGizmos() {
        // 충돌 범위를 시각적으로 나타내기 위해 Gizmos를 사용
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(collisionBoxWidth, collisionBoxHeight, 0f));
    }
}
