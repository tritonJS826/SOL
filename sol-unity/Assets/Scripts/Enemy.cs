using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private EnemyItem _enemyItem;

    private const float Speed = 1f;
    public Transform losePosition;
    
    public void Initialize(EnemyItem enemyItem)
    {
        _enemyItem = enemyItem;
    }


    private void Update()
    {
        if (losePosition == null)
        {
            return;
        }
        if (losePosition.position.y > transform.position.y)
        {
            print("Loose");
            throw new Exception ("Loose");
        }

        transform.position += Vector3.down * (Speed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
       GameUI.Instance.FillQuestion(_enemyItem.question);
    }


    public void SetLosePosition(Transform position)
    {
        losePosition = position;
    }
}
