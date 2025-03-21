public static class SpeedMode
{
    //달리기속도배율
    public const float RunningSpeed = 1.5f;
    //느려진속도배율
    public const float SlowSpeed = 0.5f;
    //기본속도배율
    public const float NormalSpeed = 1.0f;
    
    //속도를 바꿔주는 메소드
    public static float ChangeSpeed(MoveMode mode)
    {
        if (mode == MoveMode.Running)
        {
            return RunningSpeed;
        }
        else if (mode == MoveMode.Slow)
        {
            return SlowSpeed;
        }
        else
        {
            return NormalSpeed;
        }
    }
}