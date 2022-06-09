using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;


namespace System
{
    public static class ISyntaxOperatorExtensions
    {
        public static int GetIndexForPublicAccessModifer(this ISyntaxOperator _,
            SyntaxTokenList modifiers)
        {
            var output = modifiers.GetIndexForPublicAccessModifer();
            return output;
        }
    }
}
