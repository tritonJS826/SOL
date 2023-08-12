using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "EnemiesPrefabsSheet", menuName = "Custom/EnemiesPrefabsSheet", order = 1)]
    public class EnemiesPrefabsSheet : ScriptableObject
    {
        public EnemySheet[] enemySheets;

        public GameObject GetPrefab(EnemyType type)
        {
            foreach (var enemySheet in enemySheets)
            {
                if (enemySheet.type == type)
                {
                    return enemySheet.prefab;
                }
            }

            return null;
        }
    }
}
