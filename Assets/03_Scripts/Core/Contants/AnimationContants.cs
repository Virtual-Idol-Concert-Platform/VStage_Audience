namespace VStage.Core.Constants
{
    /// <summary>
    /// Animator parameter names and layer indices.
    /// 애니메이터 파라미터 이름과 레이어 인덱스를 정의합니다.
    /// </summary>
    public static class AnimationConstants
    {
// Animator Parameters
        public const string PARAM_IS_PLAYING = "IsPlaying";
        public const string PARAM_TIMELINE_TIME = "TimelineTime";
        public const string PARAM_IS_RECORDING = "IsRecording";
        
        // Animator Layers
        public const string LAYER_BASE = "Base";
        public const string LAYER_TIMELINE = "Timeline";
        public const string LAYER_GESTURE = "Gesture";

        // Shader Properties
        public const string SHADER_EMISSION_COLOR = "_EmissionColor";
        public const string SHADER_EMISSION_KEYWORD = "_EMISSION";
    }
}