using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace vb6.net.CSharp
{
    public class VB6CSharpClass : VB6CSharpModuleBase
    {
        public VB6CSharpClass(VB6CSharpContext context) : base(context) { }

        public override void Build()
        {
            var ns = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("TestNamespace"));
            ns.AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")));

            var clazz = SyntaxFactory.ClassDeclaration("TestClass");
            clazz.AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));

        }
    }
}
