using UnityEngine;
using ItemSystem.ItemData;

namespace ItemSystem
{
    /// <summary>
    /// 아이템 스택을 나타내는 클래스
    /// </summary>
    [System.Serializable]
    public class ItemStack: MonoBehaviour
    {
        /// <summary>
        /// 기본적 ItemData
        /// </summary>
        private AbstractItemData itemData;

        /// <summary>
        /// Item의 개수
        /// </summary>
        private int itemCount;

        /// <summary>
        /// 지정된 ItemData를 사용하여 새로운 ItemStack을 생성하고, Item의 개수를 1로 초기화
        /// </summary>
        /// <param name="itemData">이 스택과 연관된 ItemData입니다.</param>
        public ItemStack(AbstractItemData itemData)
        {
            this.itemData = itemData;
            this.itemCount = 1;
        }

        public ItemStack(AbstractItemData itemData, int itemCount)
        {
            this.itemData = itemData;
            this.itemCount = itemCount;
        }
    }
}