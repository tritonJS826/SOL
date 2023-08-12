using System;
using System.Collections;
using Data;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyWaveGenerator : MonoBehaviour
{

     [SerializeField] private GameObject parent;
     [SerializeField] private EnemiesPrefabsSheet enemiesPrefabsSheet;
     [SerializeField] private Transform spawnPosition;
     [SerializeField] private float spawnRadius;
     [SerializeField] private Transform losePosition;


     public void Initialize(LevelItem levelItem)
     {
          foreach (var waveItem in levelItem.waveItems)
          {
               StartCoroutine(StartWave(waveItem));
          }
     }




     IEnumerator StartWave(WaveItem waveItem)
     {
          yield return new WaitForSeconds(waveItem.time/1000);
          
          for (int i = 0; i < waveItem.enemies.Length; i++)
          {
               var enemyItem = waveItem.enemies[i];
               GameObject enemy = Instantiate(enemiesPrefabsSheet.GetPrefab(enemyItem.type), parent.transform);
               enemy.transform.position = new Vector3(Random.Range(-spawnRadius,spawnRadius), spawnPosition.position.y, 0);
               
               enemy.GetComponent<Enemy>().Initialize(enemyItem);
               enemy.GetComponent<Enemy>().SetLosePosition(losePosition);
          }
     }
     
     
     
}