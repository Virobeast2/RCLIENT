using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericSpawnerSpawnList : ScriptableObject
{
    [SerializeField]
    public System.Collections.Generic.List<GenericSpawnInstance> _spawnList;

    public System.Collections.Generic.List<GenericSpawnInstance> GetCopy()
    {
        System.Collections.Generic.List<GenericSpawnInstance> list = new System.Collections.Generic.List<GenericSpawnInstance>(this._spawnList.Count);
        foreach (GenericSpawnInstance instance in this._spawnList)
        {
            list.Add(instance.Clone());
        }
        return list;
    }

    [Serializable]
    public class GenericSpawnInstance
    {
        public bool forceStaticInstantiate;
        public int numToSpawnPerTick = 1;
        public string prefabName = string.Empty;
        public System.Collections.Generic.List<GameObject> spawned;
        public int targetPopulation;
        public bool useNavmeshSample = true;

        public GenericSpawnerSpawnList.GenericSpawnInstance Clone()
        {
            return new GenericSpawnerSpawnList.GenericSpawnInstance { prefabName = this.prefabName, targetPopulation = this.targetPopulation, numToSpawnPerTick = this.numToSpawnPerTick, forceStaticInstantiate = this.forceStaticInstantiate, spawned = new System.Collections.Generic.List<GameObject>() };
        }

        public int GetNumActive()
        {
            return this.spawned.Count;
        }
    }
}

