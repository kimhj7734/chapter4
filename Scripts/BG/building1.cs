using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class building1 : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float scrollAmount;

    // 이동속도
    [SerializeField] private float moveSpeed;

    // 이동방향
    [SerializeField] private Vector3 moveDirection;

    private void Update() {
    
        // 이미지가 moveDirection 방향으로 moveSpeed의 속도로 이동
        // 피연산자(+=)는 Vector3 에서만 사용가능함. (Vector2 사용불가)
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 배경이 설정된 범위를 벗어나면 위치 재지정.
        if (transform.position.x <= -scrollAmount) {
            transform.position = target.position - moveDirection * scrollAmount;
        }
    }
}

