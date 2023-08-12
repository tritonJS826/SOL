using UnityEngine;

public class GameManager : MonoBehaviour
{
   [SerializeField] private WorldItem worldItem;
   [SerializeField] private EnemyWaveGenerator enemyWaveGenerator;
   
   
   

   private void Start()
   {
      enemyWaveGenerator.Initialize(worldItem.levelItems[0]);
   }
}
