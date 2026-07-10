namespace OpenTabletDriver.Plugin.Tablet
{
    public interface ITabletReport : IAbsolutePositionReport
    {
        uint Pressure { set; get; }
        public float ScaledPressure { set; get; }
        bool[] PenButtons { set; get; }
    }
}
