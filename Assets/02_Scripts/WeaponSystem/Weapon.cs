using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum WeaponType
{
    Normal,
    Multi,
    Bounce,
}

public class Weapon : MonoBehaviour
{
    //[Header("")]
    //[SerializeField]

    private WeaponType type;

    private float damage;

    private float baseInterval;
    private float currentInterval;

    private int level;

    private Projectile projectilePrefab;
    private int projectileCount;

    private int poolSize;
    private Queue<Projectile> projectilePool = new();


    void InitializePool()
    {
        // ����ü Ǯ �ʱ�ȭ
    }

    private Projectile NewProjectile()
    {
        // ���ο� ����ü ����
        return null;
    }
    private Projectile GetBulletFromPool()
    {
        // Ǯ���� ����ü ����
        return null;
    }
    public void ReturnToPool(Projectile projectile)
    {
        // ����ü Ǯ ��ȯ
    }


    public void Attack(Vector2 dir)
    {
        // ����ü �߻�
    }

    public void TickTime(float deltaTime)
    {
        // ���� �ֱ� ����
    }

    public void UpgradeWeapon()
    {
        // ���׷��̵� ��ġ ����
    }
}
