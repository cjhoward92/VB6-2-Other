namespace vb6.net.VB6.Controls
{
    public enum StartupPosition
    {
        Manual = 0,
        CenterOwner = 1,
        CenterScreen = 2,
        WindowsDefault = 3
    }

    public class Form : Control
    {
        public string Caption { get; set; }
        public int ClientHeight { get; set; }
        public int ClientLeft { get; set; }
        public int ClientTop { get; set; }
        public int ClientWidth { get; set; }
        public string LinkTopic { get; set; }
        public int ScaleHeight { get; set; }
        public int ScaleWidth { get; set; }
        public StartupPosition StartupPosition { get; set; }
    }
}
