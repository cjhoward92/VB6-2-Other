namespace vb6.net.VB6
{
    public abstract class VersionedModule : Module
    {
        public decimal Version { get; set; }
        public VersionedModuleAttributes VersionedModuleAttributes { get; set; }
    }
}
