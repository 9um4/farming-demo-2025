using UnityEngine;

namespace ItemSystem.ItemData
{
    public abstract class ItemData : MonoBehaviour
    {
        #region Common Data
        [Header("Common Data")]
        [SerializeField] private Material material;
        [SerializeField] private string itemName;
        [SerializeField] private string itemDescription;
        #endregion
    }

}

