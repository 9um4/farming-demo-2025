using UnityEngine;

namespace ItemSystem
{
    public abstract class AbstractItemData: MonoBehaviour
    {
        #region Common Data
        [Header("Common Data")]
        [SerializeField] private Material material;
        [SerializeField] private string itemName;
        [SerializeField] private string itemDescription;
        #endregion
    }

}

