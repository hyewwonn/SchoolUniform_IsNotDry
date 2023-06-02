using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyanggyuTmove : MonoBehaviour
{
    private float speed = 3f;
    private float dspeed = 0.8f;
    private bool isMoving = true;

    void Update()
    {
        if (isMoving){
            // 캐릭터 앞으로 이동
            transform.Translate(Vector3.down * dspeed * Time.deltaTime); // 아래쪽으로 dspeed만큼

            // 캐릭터 좌우 이동
            transform.Translate(Vector3.right * speed * Time.deltaTime); // 오른쪽으로 speed만큼
            if (transform.position.x >= 3.5f) // 오른쪽 끝에 도달
            {
                transform.rotation = Quaternion.Euler(new Vector3(0,180,0)); // 좌표를 180도 회전시켜 오브젝트의 좌우가 바뀌도록
            }
            else if (transform.position.x <= -3.5f) // 왼쪽 끝에 도달
            {
                transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
            }

            if (transform.position.y <= -10f) // 화면에서 보이지 않으면 정지
            {
                isMoving = false;
            }
        }
    }
}
