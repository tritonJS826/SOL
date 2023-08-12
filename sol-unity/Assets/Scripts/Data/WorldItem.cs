using UnityEngine;

[ CreateAssetMenu( fileName = "WorldItem", menuName = "Custom/WorldItem", order = 1 ) ]
public class WorldItem : ScriptableObject
{
    public string id;
    public string name;
    public string description;
    public LevelItem[] levelItems;
}
