using ItemSystem.ItemData.Features.UseFeatures;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// 게임에서 사용할 수 있는 아이템을 나타내는 인터페이스
/// </summary>
namespace ItemSystem.ItemData.Interfaces
{
    /// <summary>
    /// 아이템이 사용 가능한지 여부를 나타내는 인터페이스
    /// </summary>
    public interface IUsable
    {
        public IUseFeature UseFeature { get; set; }

        public void UseItem()
        {
            Debug.Log("아이템을 사용합니다.");
        }
    }
}