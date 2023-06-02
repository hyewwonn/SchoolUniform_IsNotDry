using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    private void Update()
    {
        if (!gameEnded)
        {
            // 캐릭터와 적 충돌 감지
            if (isCollisionDetected())
            {
                EndGame();
            }
        }
    }

    private bool isCollisionDetected()
    {
        // 캐릭터와 충돌한 모든 적을 가져옴
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.5f);
        
        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Enemy")) // "Enemy" 태그를 가진 적과 충돌한 경우
            {
                return true;
            }
        }

        return false;
    }

    public void EndGame()
    {
        gameEnded = true;
        Debug.Log("게임 종료");
        // 게임 종료 처리 로직을 추가하세요
    }
}
