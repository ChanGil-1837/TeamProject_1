using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    private Enum type; // 적 타입	
    private float maxHP; // 최대 체력
    private float currentHP; // 현재 체력
    private float moveSpeed; // 이동 속도
    private int damage; // 공격력
    // private Reward reward; // 보상???

    private void Awake()
    {
        // 적 상태 설정
    }

    private void Update()
    {
        // 이동 구현
        MoveToPlayer();
    }

    // 플레이어로 이동
    private void MoveToPlayer()
    {
        
    }

    // 공격주기 갱신
    private void AttackToPlayer()
    {

    }

    private void Die()
    {
        
    }
}
