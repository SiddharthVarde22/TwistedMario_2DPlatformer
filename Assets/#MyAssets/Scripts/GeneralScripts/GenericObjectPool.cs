using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericObjectPool<T> where T : class
{
    class PooledObjectDetails<T>
    {
        public T objectInPool;
        public bool isActive;
    }

    private List<PooledObjectDetails<T>> poolOfObjects = new List<PooledObjectDetails<T>>();

    public virtual T GetObjectFromPool()
    {
        if(poolOfObjects.Count > 0)
        {
            PooledObjectDetails<T> inactiveObject = poolOfObjects.Find(objectInPool => !objectInPool.isActive);

            if(inactiveObject != null)
            {
                inactiveObject.isActive = true;
                return inactiveObject.objectInPool;
            }
        }

        return null;
    }

    public virtual void ReturnObjectToPool(T objectToAddToPool)
    {
        PooledObjectDetails<T> returningObject = null;
        returningObject = poolOfObjects.Find(currentObject => currentObject.objectInPool.Equals(objectToAddToPool));

        if(returningObject != null)
        {
            returningObject.isActive = false;
        }
        else
        {
            returningObject = new PooledObjectDetails<T>();
            returningObject.objectInPool = objectToAddToPool;
            returningObject.isActive = false;
            poolOfObjects.Add(returningObject);
        }
    }
}
