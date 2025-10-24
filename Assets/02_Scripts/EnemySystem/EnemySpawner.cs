using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private List<Transform> spawnPoints; // 스폰 포인트	
    private List<GameObject> enemyPrefabs; // 적 프리팹	
    private float spawnerInterval; // 적 생성주기	
    private List<Enemy> activeEnemies; // 생성한 적 리스트	


    // 타이머 갱신
    private void Update()
    {
        
    }

    // 적 생성	
    private void SpawnEnemy(Enum EnemyType)
    {
        //
    }

    // 웨이브 종료시 삭제	
    private void ClearEnemies()
    {
        //
    }


}
