using UnityEngine;

namespace VStage.Core.Config
{
    /// <summary>
    /// Network connection and session configuration.
    /// 네트워크 연결 및 세션 설정을 관리합니다.
    /// </summary>
    [CreateAssetMenu(fileName = "NetworkConfig", menuName = "VStage/Config/Network Config")]
    public class NetworkConfig : ScriptableObject
    {
        [Header("Session Settings")] [Tooltip("The name of the Photon Fusion room to join")]
        public string defaultRoomName = "TestRoom";
        
        [Tooltip("Maximum number of players allowed in the session")]
        [Range(1, 50)]
        public int maxPlayers = 20;

        [Header("Connection")]
        [Tooltip("Connection timeout in seconds")]
        public float connectionTimeout = 30f;

        [Header("Performance Start")]
        [Tooltip("Delay in seconds before timeline starts after performance begins")]
        public float performanceStartDelay = 5f;
    }
}