using UnityEngine;

namespace CM.ObjectCreation
{
	public class GameObjectCreator : IObjectCreator<GameObject>
	{
		public GameObject CloneObject(GameObject clonableObject)
		{
			return Object.Instantiate(clonableObject);
		}

		public void DestroyObject(GameObject destroyableObject)
		{
			Object.Destroy(destroyableObject);
		}
	}
}