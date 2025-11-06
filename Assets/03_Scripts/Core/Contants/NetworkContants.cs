namespace VStage.Core.Constants
{
    /// <summary>
    /// Network-related constant values.
    /// 네트워크 관련 상수 값들을 정의합니다.
    /// </summary>
    public static class NetworkConstants
    {
        // Photon Fusion Session
        public const string DEFAULT_SESSION_NAME = "VStageRoom";
        
        // Network Prefab Paths
        public const string PLAYER_PREFAB_PATH = "Prefabs/Network/VTUBER";
        public const string HOST_AVATAR_PREFAB_PATH = "Prefabs/Network/Artist_Shinano";

        // Network Layers
        public const string AVATAR_ANIMATOR_LAYER = "Avatar";
        public const string TIMELINE_LAYER = "Timeline";
    }
}