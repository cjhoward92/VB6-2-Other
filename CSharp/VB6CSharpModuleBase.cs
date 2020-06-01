using Antlr4.Runtime.Misc;

namespace vb6.net.CSharp
{
    public abstract class VB6CSharpModuleBase : IVB6Module
    {
        protected VB6CSharpContext context;

        protected VB6CSharpModuleBase([NotNull] VB6CSharpContext context)
        {
            this.context = context;
        }

        public abstract void Build();
    }
}
