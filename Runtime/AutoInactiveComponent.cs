using UnityEngine;

namespace Kogane.Internal
{
    [DefaultExecutionOrder( -1000 )]
    [DisallowMultipleComponent]
    internal sealed class AutoInactiveComponent : MonoBehaviour
    {
        // 非アクティブにしたゲームオブジェクトを Instantiate で複製した時に
        // 複製したゲームオブジェクトが非アクティブにならないようにフラグを実装しています
        [SerializeField][HideInInspector] private bool m_isExecuted;

        private void Awake()
        {
            if ( m_isExecuted ) return;

            gameObject.SetActive( false );

            m_isExecuted = true;
        }
    }
}