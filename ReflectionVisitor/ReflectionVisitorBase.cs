using System.Diagnostics.CodeAnalysis;
using Antlr4.Runtime.Tree;

using JavaAST.AntlrParser;

namespace JavaAST.ReflectionVisitor;

public struct Result
{
}

public abstract class ReflectionVisitorBase : AbstractParseTreeVisitor<Result>, IJava9ParserVisitor<Result>
{
    protected abstract void HandleIntermediateVisit(string methodName, [NotNull] dynamic context);


    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.literal"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLiteral([NotNull] Java9Parser.LiteralContext context)
    {
        var methodName = "VisitLiteral";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primitiveType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimitiveType([NotNull] Java9Parser.PrimitiveTypeContext context)
    {
        var methodName = "VisitPrimitiveType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.numericType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitNumericType([NotNull] Java9Parser.NumericTypeContext context)
    {
        var methodName = "VisitNumericType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.integralType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitIntegralType([NotNull] Java9Parser.IntegralTypeContext context)
    {
        var methodName = "VisitIntegralType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.floatingPointType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFloatingPointType([NotNull] Java9Parser.FloatingPointTypeContext context)
    {
        var methodName = "VisitFloatingPointType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.referenceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitReferenceType([NotNull] Java9Parser.ReferenceTypeContext context)
    {
        var methodName = "VisitReferenceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassOrInterfaceType([NotNull] Java9Parser.ClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassType([NotNull] Java9Parser.ClassTypeContext context)
    {
        var methodName = "VisitClassType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classType_lf_classOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassType_lf_classOrInterfaceType([NotNull] Java9Parser.ClassType_lf_classOrInterfaceTypeContext context)
    {
        var methodName = "VisitClassType_lf_classOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classType_lfno_classOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassType_lfno_classOrInterfaceType([NotNull] Java9Parser.ClassType_lfno_classOrInterfaceTypeContext context)
    {
        var methodName = "VisitClassType_lfno_classOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceType([NotNull] Java9Parser.InterfaceTypeContext context)
    {
        var methodName = "VisitInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceType_lf_classOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceType_lf_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lf_classOrInterfaceTypeContext context)
    {
        var methodName = "VisitInterfaceType_lf_classOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceType_lfno_classOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceType_lfno_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lfno_classOrInterfaceTypeContext context)
    {
        var methodName = "VisitInterfaceType_lfno_classOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeVariable"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeVariable([NotNull] Java9Parser.TypeVariableContext context)
    {
        var methodName = "VisitTypeVariable";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayType([NotNull] Java9Parser.ArrayTypeContext context)
    {
        var methodName = "VisitArrayType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.dims"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitDims([NotNull] Java9Parser.DimsContext context)
    {
        var methodName = "VisitDims";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeParameter"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeParameter([NotNull] Java9Parser.TypeParameterContext context)
    {
        var methodName = "VisitTypeParameter";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeParameterModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeParameterModifier([NotNull] Java9Parser.TypeParameterModifierContext context)
    {
        var methodName = "VisitTypeParameterModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeBound"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeBound([NotNull] Java9Parser.TypeBoundContext context)
    {
        var methodName = "VisitTypeBound";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.additionalBound"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAdditionalBound([NotNull] Java9Parser.AdditionalBoundContext context)
    {
        var methodName = "VisitAdditionalBound";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeArguments"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeArguments([NotNull] Java9Parser.TypeArgumentsContext context)
    {
        var methodName = "VisitTypeArguments";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeArgumentList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeArgumentList([NotNull] Java9Parser.TypeArgumentListContext context)
    {
        var methodName = "VisitTypeArgumentList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeArgument"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeArgument([NotNull] Java9Parser.TypeArgumentContext context)
    {
        var methodName = "VisitTypeArgument";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.wildcard"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitWildcard([NotNull] Java9Parser.WildcardContext context)
    {
        var methodName = "VisitWildcard";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.wildcardBounds"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitWildcardBounds([NotNull] Java9Parser.WildcardBoundsContext context)
    {
        var methodName = "VisitWildcardBounds";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.moduleName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitModuleName([NotNull] Java9Parser.ModuleNameContext context)
    {
        var methodName = "VisitModuleName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.packageName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPackageName([NotNull] Java9Parser.PackageNameContext context)
    {
        var methodName = "VisitPackageName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeName([NotNull] Java9Parser.TypeNameContext context)
    {
        var methodName = "VisitTypeName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.packageOrTypeName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPackageOrTypeName([NotNull] Java9Parser.PackageOrTypeNameContext context)
    {
        var methodName = "VisitPackageOrTypeName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.expressionName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExpressionName([NotNull] Java9Parser.ExpressionNameContext context)
    {
        var methodName = "VisitExpressionName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodName([NotNull] Java9Parser.MethodNameContext context)
    {
        var methodName = "VisitMethodName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.ambiguousName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAmbiguousName([NotNull] Java9Parser.AmbiguousNameContext context)
    {
        var methodName = "VisitAmbiguousName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.compilationUnit"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCompilationUnit([NotNull] Java9Parser.CompilationUnitContext context)
    {
        var methodName = "VisitCompilationUnit";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.ordinaryCompilation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitOrdinaryCompilation([NotNull] Java9Parser.OrdinaryCompilationContext context)
    {
        var methodName = "VisitOrdinaryCompilation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.modularCompilation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitModularCompilation([NotNull] Java9Parser.ModularCompilationContext context)
    {
        var methodName = "VisitModularCompilation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.packageDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPackageDeclaration([NotNull] Java9Parser.PackageDeclarationContext context)
    {
        var methodName = "VisitPackageDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.packageModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPackageModifier([NotNull] Java9Parser.PackageModifierContext context)
    {
        var methodName = "VisitPackageModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.importDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitImportDeclaration([NotNull] Java9Parser.ImportDeclarationContext context)
    {
        var methodName = "VisitImportDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.singleTypeImportDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSingleTypeImportDeclaration([NotNull] Java9Parser.SingleTypeImportDeclarationContext context)
    {
        var methodName = "VisitSingleTypeImportDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeImportOnDemandDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeImportOnDemandDeclaration([NotNull] Java9Parser.TypeImportOnDemandDeclarationContext context)
    {
        var methodName = "VisitTypeImportOnDemandDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.singleStaticImportDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSingleStaticImportDeclaration([NotNull] Java9Parser.SingleStaticImportDeclarationContext context)
    {
        var methodName = "VisitSingleStaticImportDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.staticImportOnDemandDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStaticImportOnDemandDeclaration([NotNull] Java9Parser.StaticImportOnDemandDeclarationContext context)
    {
        var methodName = "VisitStaticImportOnDemandDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeDeclaration([NotNull] Java9Parser.TypeDeclarationContext context)
    {
        var methodName = "VisitTypeDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.moduleDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitModuleDeclaration([NotNull] Java9Parser.ModuleDeclarationContext context)
    {
        var methodName = "VisitModuleDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.moduleDirective"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitModuleDirective([NotNull] Java9Parser.ModuleDirectiveContext context)
    {
        var methodName = "VisitModuleDirective";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.requiresModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitRequiresModifier([NotNull] Java9Parser.RequiresModifierContext context)
    {
        var methodName = "VisitRequiresModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassDeclaration([NotNull] Java9Parser.ClassDeclarationContext context)
    {
        var methodName = "VisitClassDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.normalClassDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitNormalClassDeclaration([NotNull] Java9Parser.NormalClassDeclarationContext context)
    {
        var methodName = "VisitNormalClassDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassModifier([NotNull] Java9Parser.ClassModifierContext context)
    {
        var methodName = "VisitClassModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeParameters"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeParameters([NotNull] Java9Parser.TypeParametersContext context)
    {
        var methodName = "VisitTypeParameters";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeParameterList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeParameterList([NotNull] Java9Parser.TypeParameterListContext context)
    {
        var methodName = "VisitTypeParameterList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.superclass"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSuperclass([NotNull] Java9Parser.SuperclassContext context)
    {
        var methodName = "VisitSuperclass";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.superinterfaces"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSuperinterfaces([NotNull] Java9Parser.SuperinterfacesContext context)
    {
        var methodName = "VisitSuperinterfaces";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceTypeList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceTypeList([NotNull] Java9Parser.InterfaceTypeListContext context)
    {
        var methodName = "VisitInterfaceTypeList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassBody([NotNull] Java9Parser.ClassBodyContext context)
    {
        var methodName = "VisitClassBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classBodyDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassBodyDeclaration([NotNull] Java9Parser.ClassBodyDeclarationContext context)
    {
        var methodName = "VisitClassBodyDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classMemberDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassMemberDeclaration([NotNull] Java9Parser.ClassMemberDeclarationContext context)
    {
        var methodName = "VisitClassMemberDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.fieldDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context)
    {
        var methodName = "VisitFieldDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.fieldModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFieldModifier([NotNull] Java9Parser.FieldModifierContext context)
    {
        var methodName = "VisitFieldModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableDeclaratorList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableDeclaratorList([NotNull] Java9Parser.VariableDeclaratorListContext context)
    {
        var methodName = "VisitVariableDeclaratorList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableDeclarator"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context)
    {
        var methodName = "VisitVariableDeclarator";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableDeclaratorId"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableDeclaratorId([NotNull] Java9Parser.VariableDeclaratorIdContext context)
    {
        var methodName = "VisitVariableDeclaratorId";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableInitializer"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableInitializer([NotNull] Java9Parser.VariableInitializerContext context)
    {
        var methodName = "VisitVariableInitializer";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannType([NotNull] Java9Parser.UnannTypeContext context)
    {
        var methodName = "VisitUnannType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannPrimitiveType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannPrimitiveType([NotNull] Java9Parser.UnannPrimitiveTypeContext context)
    {
        var methodName = "VisitUnannPrimitiveType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannReferenceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannReferenceType([NotNull] Java9Parser.UnannReferenceTypeContext context)
    {
        var methodName = "VisitUnannReferenceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannClassOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitUnannClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannClassType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannClassType([NotNull] Java9Parser.UnannClassTypeContext context)
    {
        var methodName = "VisitUnannClassType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitUnannClassType_lf_unannClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitUnannClassType_lfno_unannClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannInterfaceType([NotNull] Java9Parser.UnannInterfaceTypeContext context)
    {
        var methodName = "VisitUnannInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitUnannInterfaceType_lf_unannClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context)
    {
        var methodName = "VisitUnannInterfaceType_lfno_unannClassOrInterfaceType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannTypeVariable"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannTypeVariable([NotNull] Java9Parser.UnannTypeVariableContext context)
    {
        var methodName = "VisitUnannTypeVariable";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unannArrayType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context)
    {
        var methodName = "VisitUnannArrayType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodDeclaration([NotNull] Java9Parser.MethodDeclarationContext context)
    {
        var methodName = "VisitMethodDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodModifier([NotNull] Java9Parser.MethodModifierContext context)
    {
        var methodName = "VisitMethodModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodHeader"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodHeader([NotNull] Java9Parser.MethodHeaderContext context)
    {
        var methodName = "VisitMethodHeader";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.result"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitResult([NotNull] Java9Parser.ResultContext context)
    {
        var methodName = "VisitResult";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodDeclarator"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context)
    {
        var methodName = "VisitMethodDeclarator";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.formalParameterList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context)
    {
        var methodName = "VisitFormalParameterList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.formalParameters"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFormalParameters([NotNull] Java9Parser.FormalParametersContext context)
    {
        var methodName = "VisitFormalParameters";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.formalParameter"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFormalParameter([NotNull] Java9Parser.FormalParameterContext context)
    {
        var methodName = "VisitFormalParameter";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableModifier([NotNull] Java9Parser.VariableModifierContext context)
    {
        var methodName = "VisitVariableModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.lastFormalParameter"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLastFormalParameter([NotNull] Java9Parser.LastFormalParameterContext context)
    {
        var methodName = "VisitLastFormalParameter";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.receiverParameter"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitReceiverParameter([NotNull] Java9Parser.ReceiverParameterContext context)
    {
        var methodName = "VisitReceiverParameter";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.throws_"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitThrows_([NotNull] Java9Parser.Throws_Context context)
    {
        var methodName = "VisitThrows_";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.exceptionTypeList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExceptionTypeList([NotNull] Java9Parser.ExceptionTypeListContext context)
    {
        var methodName = "VisitExceptionTypeList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.exceptionType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExceptionType([NotNull] Java9Parser.ExceptionTypeContext context)
    {
        var methodName = "VisitExceptionType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodBody([NotNull] Java9Parser.MethodBodyContext context)
    {
        var methodName = "VisitMethodBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.instanceInitializer"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInstanceInitializer([NotNull] Java9Parser.InstanceInitializerContext context)
    {
        var methodName = "VisitInstanceInitializer";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.staticInitializer"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStaticInitializer([NotNull] Java9Parser.StaticInitializerContext context)
    {
        var methodName = "VisitStaticInitializer";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constructorDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstructorDeclaration([NotNull] Java9Parser.ConstructorDeclarationContext context)
    {
        var methodName = "VisitConstructorDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constructorModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstructorModifier([NotNull] Java9Parser.ConstructorModifierContext context)
    {
        var methodName = "VisitConstructorModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constructorDeclarator"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstructorDeclarator([NotNull] Java9Parser.ConstructorDeclaratorContext context)
    {
        var methodName = "VisitConstructorDeclarator";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.simpleTypeName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSimpleTypeName([NotNull] Java9Parser.SimpleTypeNameContext context)
    {
        var methodName = "VisitSimpleTypeName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constructorBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstructorBody([NotNull] Java9Parser.ConstructorBodyContext context)
    {
        var methodName = "VisitConstructorBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.explicitConstructorInvocation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExplicitConstructorInvocation([NotNull] Java9Parser.ExplicitConstructorInvocationContext context)
    {
        var methodName = "VisitExplicitConstructorInvocation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumDeclaration([NotNull] Java9Parser.EnumDeclarationContext context)
    {
        var methodName = "VisitEnumDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumBody([NotNull] Java9Parser.EnumBodyContext context)
    {
        var methodName = "VisitEnumBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumConstantList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumConstantList([NotNull] Java9Parser.EnumConstantListContext context)
    {
        var methodName = "VisitEnumConstantList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumConstant"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumConstant([NotNull] Java9Parser.EnumConstantContext context)
    {
        var methodName = "VisitEnumConstant";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumConstantModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumConstantModifier([NotNull] Java9Parser.EnumConstantModifierContext context)
    {
        var methodName = "VisitEnumConstantModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumBodyDeclarations"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumBodyDeclarations([NotNull] Java9Parser.EnumBodyDeclarationsContext context)
    {
        var methodName = "VisitEnumBodyDeclarations";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceDeclaration([NotNull] Java9Parser.InterfaceDeclarationContext context)
    {
        var methodName = "VisitInterfaceDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.normalInterfaceDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitNormalInterfaceDeclaration([NotNull] Java9Parser.NormalInterfaceDeclarationContext context)
    {
        var methodName = "VisitNormalInterfaceDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceModifier([NotNull] Java9Parser.InterfaceModifierContext context)
    {
        var methodName = "VisitInterfaceModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.extendsInterfaces"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExtendsInterfaces([NotNull] Java9Parser.ExtendsInterfacesContext context)
    {
        var methodName = "VisitExtendsInterfaces";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceBody([NotNull] Java9Parser.InterfaceBodyContext context)
    {
        var methodName = "VisitInterfaceBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceMemberDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceMemberDeclaration([NotNull] Java9Parser.InterfaceMemberDeclarationContext context)
    {
        var methodName = "VisitInterfaceMemberDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constantDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstantDeclaration([NotNull] Java9Parser.ConstantDeclarationContext context)
    {
        var methodName = "VisitConstantDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constantModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstantModifier([NotNull] Java9Parser.ConstantModifierContext context)
    {
        var methodName = "VisitConstantModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceMethodDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceMethodDeclaration([NotNull] Java9Parser.InterfaceMethodDeclarationContext context)
    {
        var methodName = "VisitInterfaceMethodDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.interfaceMethodModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInterfaceMethodModifier([NotNull] Java9Parser.InterfaceMethodModifierContext context)
    {
        var methodName = "VisitInterfaceMethodModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotationTypeDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotationTypeDeclaration([NotNull] Java9Parser.AnnotationTypeDeclarationContext context)
    {
        var methodName = "VisitAnnotationTypeDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotationTypeBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotationTypeBody([NotNull] Java9Parser.AnnotationTypeBodyContext context)
    {
        var methodName = "VisitAnnotationTypeBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotationTypeMemberDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotationTypeMemberDeclaration([NotNull] Java9Parser.AnnotationTypeMemberDeclarationContext context)
    {
        var methodName = "VisitAnnotationTypeMemberDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotationTypeElementDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotationTypeElementDeclaration([NotNull] Java9Parser.AnnotationTypeElementDeclarationContext context)
    {
        var methodName = "VisitAnnotationTypeElementDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotationTypeElementModifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotationTypeElementModifier([NotNull] Java9Parser.AnnotationTypeElementModifierContext context)
    {
        var methodName = "VisitAnnotationTypeElementModifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.defaultValue"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitDefaultValue([NotNull] Java9Parser.DefaultValueContext context)
    {
        var methodName = "VisitDefaultValue";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.annotation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAnnotation([NotNull] Java9Parser.AnnotationContext context)
    {
        var methodName = "VisitAnnotation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.normalAnnotation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitNormalAnnotation([NotNull] Java9Parser.NormalAnnotationContext context)
    {
        var methodName = "VisitNormalAnnotation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.elementValuePairList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitElementValuePairList([NotNull] Java9Parser.ElementValuePairListContext context)
    {
        var methodName = "VisitElementValuePairList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.elementValuePair"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitElementValuePair([NotNull] Java9Parser.ElementValuePairContext context)
    {
        var methodName = "VisitElementValuePair";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.elementValue"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitElementValue([NotNull] Java9Parser.ElementValueContext context)
    {
        var methodName = "VisitElementValue";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.elementValueArrayInitializer"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitElementValueArrayInitializer([NotNull] Java9Parser.ElementValueArrayInitializerContext context)
    {
        var methodName = "VisitElementValueArrayInitializer";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.elementValueList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitElementValueList([NotNull] Java9Parser.ElementValueListContext context)
    {
        var methodName = "VisitElementValueList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.markerAnnotation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMarkerAnnotation([NotNull] Java9Parser.MarkerAnnotationContext context)
    {
        var methodName = "VisitMarkerAnnotation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.singleElementAnnotation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSingleElementAnnotation([NotNull] Java9Parser.SingleElementAnnotationContext context)
    {
        var methodName = "VisitSingleElementAnnotation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayInitializer"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayInitializer([NotNull] Java9Parser.ArrayInitializerContext context)
    {
        var methodName = "VisitArrayInitializer";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableInitializerList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableInitializerList([NotNull] Java9Parser.VariableInitializerListContext context)
    {
        var methodName = "VisitVariableInitializerList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.block"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBlock([NotNull] Java9Parser.BlockContext context)
    {
        var methodName = "VisitBlock";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.blockStatements"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBlockStatements([NotNull] Java9Parser.BlockStatementsContext context)
    {
        var methodName = "VisitBlockStatements";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.blockStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBlockStatement([NotNull] Java9Parser.BlockStatementContext context)
    {
        var methodName = "VisitBlockStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.localVariableDeclarationStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLocalVariableDeclarationStatement([NotNull] Java9Parser.LocalVariableDeclarationStatementContext context)
    {
        var methodName = "VisitLocalVariableDeclarationStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.localVariableDeclaration"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLocalVariableDeclaration([NotNull] Java9Parser.LocalVariableDeclarationContext context)
    {
        var methodName = "VisitLocalVariableDeclaration";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.statement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStatement([NotNull] Java9Parser.StatementContext context)
    {
        var methodName = "VisitStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.statementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStatementNoShortIf([NotNull] Java9Parser.StatementNoShortIfContext context)
    {
        var methodName = "VisitStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.statementWithoutTrailingSubstatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStatementWithoutTrailingSubstatement([NotNull] Java9Parser.StatementWithoutTrailingSubstatementContext context)
    {
        var methodName = "VisitStatementWithoutTrailingSubstatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.emptyStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEmptyStatement([NotNull] Java9Parser.EmptyStatementContext context)
    {
        var methodName = "VisitEmptyStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.labeledStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLabeledStatement([NotNull] Java9Parser.LabeledStatementContext context)
    {
        var methodName = "VisitLabeledStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.labeledStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLabeledStatementNoShortIf([NotNull] Java9Parser.LabeledStatementNoShortIfContext context)
    {
        var methodName = "VisitLabeledStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.expressionStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExpressionStatement([NotNull] Java9Parser.ExpressionStatementContext context)
    {
        var methodName = "VisitExpressionStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.statementExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStatementExpression([NotNull] Java9Parser.StatementExpressionContext context)
    {
        var methodName = "VisitStatementExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.ifThenStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitIfThenStatement([NotNull] Java9Parser.IfThenStatementContext context)
    {
        var methodName = "VisitIfThenStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.ifThenElseStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitIfThenElseStatement([NotNull] Java9Parser.IfThenElseStatementContext context)
    {
        var methodName = "VisitIfThenElseStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.ifThenElseStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitIfThenElseStatementNoShortIf([NotNull] Java9Parser.IfThenElseStatementNoShortIfContext context)
    {
        var methodName = "VisitIfThenElseStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.assertStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAssertStatement([NotNull] Java9Parser.AssertStatementContext context)
    {
        var methodName = "VisitAssertStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.switchStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSwitchStatement([NotNull] Java9Parser.SwitchStatementContext context)
    {
        var methodName = "VisitSwitchStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.switchBlock"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSwitchBlock([NotNull] Java9Parser.SwitchBlockContext context)
    {
        var methodName = "VisitSwitchBlock";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.switchBlockStatementGroup"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSwitchBlockStatementGroup([NotNull] Java9Parser.SwitchBlockStatementGroupContext context)
    {
        var methodName = "VisitSwitchBlockStatementGroup";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.switchLabels"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSwitchLabels([NotNull] Java9Parser.SwitchLabelsContext context)
    {
        var methodName = "VisitSwitchLabels";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.switchLabel"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSwitchLabel([NotNull] Java9Parser.SwitchLabelContext context)
    {
        var methodName = "VisitSwitchLabel";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enumConstantName"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnumConstantName([NotNull] Java9Parser.EnumConstantNameContext context)
    {
        var methodName = "VisitEnumConstantName";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.whileStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitWhileStatement([NotNull] Java9Parser.WhileStatementContext context)
    {
        var methodName = "VisitWhileStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.whileStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitWhileStatementNoShortIf([NotNull] Java9Parser.WhileStatementNoShortIfContext context)
    {
        var methodName = "VisitWhileStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.doStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitDoStatement([NotNull] Java9Parser.DoStatementContext context)
    {
        var methodName = "VisitDoStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.forStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitForStatement([NotNull] Java9Parser.ForStatementContext context)
    {
        var methodName = "VisitForStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.forStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitForStatementNoShortIf([NotNull] Java9Parser.ForStatementNoShortIfContext context)
    {
        var methodName = "VisitForStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.basicForStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBasicForStatement([NotNull] Java9Parser.BasicForStatementContext context)
    {
        var methodName = "VisitBasicForStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.basicForStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBasicForStatementNoShortIf([NotNull] Java9Parser.BasicForStatementNoShortIfContext context)
    {
        var methodName = "VisitBasicForStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.forInit"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitForInit([NotNull] Java9Parser.ForInitContext context)
    {
        var methodName = "VisitForInit";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.forUpdate"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitForUpdate([NotNull] Java9Parser.ForUpdateContext context)
    {
        var methodName = "VisitForUpdate";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.statementExpressionList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitStatementExpressionList([NotNull] Java9Parser.StatementExpressionListContext context)
    {
        var methodName = "VisitStatementExpressionList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enhancedForStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnhancedForStatement([NotNull] Java9Parser.EnhancedForStatementContext context)
    {
        var methodName = "VisitEnhancedForStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.enhancedForStatementNoShortIf"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEnhancedForStatementNoShortIf([NotNull] Java9Parser.EnhancedForStatementNoShortIfContext context)
    {
        var methodName = "VisitEnhancedForStatementNoShortIf";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.breakStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitBreakStatement([NotNull] Java9Parser.BreakStatementContext context)
    {
        var methodName = "VisitBreakStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.continueStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitContinueStatement([NotNull] Java9Parser.ContinueStatementContext context)
    {
        var methodName = "VisitContinueStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.returnStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitReturnStatement([NotNull] Java9Parser.ReturnStatementContext context)
    {
        var methodName = "VisitReturnStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.throwStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitThrowStatement([NotNull] Java9Parser.ThrowStatementContext context)
    {
        var methodName = "VisitThrowStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.synchronizedStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitSynchronizedStatement([NotNull] Java9Parser.SynchronizedStatementContext context)
    {
        var methodName = "VisitSynchronizedStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.tryStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTryStatement([NotNull] Java9Parser.TryStatementContext context)
    {
        var methodName = "VisitTryStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.catches"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCatches([NotNull] Java9Parser.CatchesContext context)
    {
        var methodName = "VisitCatches";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.catchClause"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCatchClause([NotNull] Java9Parser.CatchClauseContext context)
    {
        var methodName = "VisitCatchClause";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.catchFormalParameter"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCatchFormalParameter([NotNull] Java9Parser.CatchFormalParameterContext context)
    {
        var methodName = "VisitCatchFormalParameter";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.catchType"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCatchType([NotNull] Java9Parser.CatchTypeContext context)
    {
        var methodName = "VisitCatchType";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.finally_"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFinally_([NotNull] Java9Parser.Finally_Context context)
    {
        var methodName = "VisitFinally_";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.tryWithResourcesStatement"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTryWithResourcesStatement([NotNull] Java9Parser.TryWithResourcesStatementContext context)
    {
        var methodName = "VisitTryWithResourcesStatement";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.resourceSpecification"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitResourceSpecification([NotNull] Java9Parser.ResourceSpecificationContext context)
    {
        var methodName = "VisitResourceSpecification";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.resourceList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitResourceList([NotNull] Java9Parser.ResourceListContext context)
    {
        var methodName = "VisitResourceList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.resource"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitResource([NotNull] Java9Parser.ResourceContext context)
    {
        var methodName = "VisitResource";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.variableAccess"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitVariableAccess([NotNull] Java9Parser.VariableAccessContext context)
    {
        var methodName = "VisitVariableAccess";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimary([NotNull] Java9Parser.PrimaryContext context)
    {
        var methodName = "VisitPrimary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray([NotNull] Java9Parser.PrimaryNoNewArrayContext context)
    {
        var methodName = "VisitPrimaryNoNewArray";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_arrayAccess"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lf_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lf_arrayAccessContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lf_arrayAccess";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_arrayAccess"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lfno_arrayAccessContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lfno_arrayAccess";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context)
    {
        var methodName = "VisitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classLiteral"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassLiteral([NotNull] Java9Parser.ClassLiteralContext context)
    {
        var methodName = "VisitClassLiteral";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassInstanceCreationExpression([NotNull] Java9Parser.ClassInstanceCreationExpressionContext context)
    {
        var methodName = "VisitClassInstanceCreationExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassInstanceCreationExpression_lf_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lf_primaryContext context)
    {
        var methodName = "VisitClassInstanceCreationExpression_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitClassInstanceCreationExpression_lfno_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lfno_primaryContext context)
    {
        var methodName = "VisitClassInstanceCreationExpression_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.typeArgumentsOrDiamond"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitTypeArgumentsOrDiamond([NotNull] Java9Parser.TypeArgumentsOrDiamondContext context)
    {
        var methodName = "VisitTypeArgumentsOrDiamond";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.fieldAccess"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFieldAccess([NotNull] Java9Parser.FieldAccessContext context)
    {
        var methodName = "VisitFieldAccess";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.fieldAccess_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFieldAccess_lf_primary([NotNull] Java9Parser.FieldAccess_lf_primaryContext context)
    {
        var methodName = "VisitFieldAccess_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.fieldAccess_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitFieldAccess_lfno_primary([NotNull] Java9Parser.FieldAccess_lfno_primaryContext context)
    {
        var methodName = "VisitFieldAccess_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayAccess"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayAccess([NotNull] Java9Parser.ArrayAccessContext context)
    {
        var methodName = "VisitArrayAccess";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayAccess_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayAccess_lf_primary([NotNull] Java9Parser.ArrayAccess_lf_primaryContext context)
    {
        var methodName = "VisitArrayAccess_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayAccess_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayAccess_lfno_primary([NotNull] Java9Parser.ArrayAccess_lfno_primaryContext context)
    {
        var methodName = "VisitArrayAccess_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodInvocation"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodInvocation([NotNull] Java9Parser.MethodInvocationContext context)
    {
        var methodName = "VisitMethodInvocation";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodInvocation_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodInvocation_lf_primary([NotNull] Java9Parser.MethodInvocation_lf_primaryContext context)
    {
        var methodName = "VisitMethodInvocation_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodInvocation_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodInvocation_lfno_primary([NotNull] Java9Parser.MethodInvocation_lfno_primaryContext context)
    {
        var methodName = "VisitMethodInvocation_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.argumentList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArgumentList([NotNull] Java9Parser.ArgumentListContext context)
    {
        var methodName = "VisitArgumentList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodReference"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodReference([NotNull] Java9Parser.MethodReferenceContext context)
    {
        var methodName = "VisitMethodReference";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodReference_lf_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodReference_lf_primary([NotNull] Java9Parser.MethodReference_lf_primaryContext context)
    {
        var methodName = "VisitMethodReference_lf_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.methodReference_lfno_primary"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMethodReference_lfno_primary([NotNull] Java9Parser.MethodReference_lfno_primaryContext context)
    {
        var methodName = "VisitMethodReference_lfno_primary";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.arrayCreationExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitArrayCreationExpression([NotNull] Java9Parser.ArrayCreationExpressionContext context)
    {
        var methodName = "VisitArrayCreationExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.dimExprs"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitDimExprs([NotNull] Java9Parser.DimExprsContext context)
    {
        var methodName = "VisitDimExprs";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.dimExpr"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitDimExpr([NotNull] Java9Parser.DimExprContext context)
    {
        var methodName = "VisitDimExpr";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.constantExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConstantExpression([NotNull] Java9Parser.ConstantExpressionContext context)
    {
        var methodName = "VisitConstantExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.expression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExpression([NotNull] Java9Parser.ExpressionContext context)
    {
        var methodName = "VisitExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.lambdaExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLambdaExpression([NotNull] Java9Parser.LambdaExpressionContext context)
    {
        var methodName = "VisitLambdaExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.lambdaParameters"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLambdaParameters([NotNull] Java9Parser.LambdaParametersContext context)
    {
        var methodName = "VisitLambdaParameters";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.inferredFormalParameterList"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInferredFormalParameterList([NotNull] Java9Parser.InferredFormalParameterListContext context)
    {
        var methodName = "VisitInferredFormalParameterList";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.lambdaBody"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLambdaBody([NotNull] Java9Parser.LambdaBodyContext context)
    {
        var methodName = "VisitLambdaBody";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.assignmentExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAssignmentExpression([NotNull] Java9Parser.AssignmentExpressionContext context)
    {
        var methodName = "VisitAssignmentExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.assignment"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAssignment([NotNull] Java9Parser.AssignmentContext context)
    {
        var methodName = "VisitAssignment";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.leftHandSide"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitLeftHandSide([NotNull] Java9Parser.LeftHandSideContext context)
    {
        var methodName = "VisitLeftHandSide";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.assignmentOperator"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAssignmentOperator([NotNull] Java9Parser.AssignmentOperatorContext context)
    {
        var methodName = "VisitAssignmentOperator";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.conditionalExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConditionalExpression([NotNull] Java9Parser.ConditionalExpressionContext context)
    {
        var methodName = "VisitConditionalExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.conditionalOrExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConditionalOrExpression([NotNull] Java9Parser.ConditionalOrExpressionContext context)
    {
        var methodName = "VisitConditionalOrExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.conditionalAndExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitConditionalAndExpression([NotNull] Java9Parser.ConditionalAndExpressionContext context)
    {
        var methodName = "VisitConditionalAndExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.inclusiveOrExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitInclusiveOrExpression([NotNull] Java9Parser.InclusiveOrExpressionContext context)
    {
        var methodName = "VisitInclusiveOrExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.exclusiveOrExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitExclusiveOrExpression([NotNull] Java9Parser.ExclusiveOrExpressionContext context)
    {
        var methodName = "VisitExclusiveOrExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.andExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAndExpression([NotNull] Java9Parser.AndExpressionContext context)
    {
        var methodName = "VisitAndExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.equalityExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitEqualityExpression([NotNull] Java9Parser.EqualityExpressionContext context)
    {
        var methodName = "VisitEqualityExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.relationalExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitRelationalExpression([NotNull] Java9Parser.RelationalExpressionContext context)
    {
        var methodName = "VisitRelationalExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.shiftExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitShiftExpression([NotNull] Java9Parser.ShiftExpressionContext context)
    {
        var methodName = "VisitShiftExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.additiveExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitAdditiveExpression([NotNull] Java9Parser.AdditiveExpressionContext context)
    {
        var methodName = "VisitAdditiveExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.multiplicativeExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitMultiplicativeExpression([NotNull] Java9Parser.MultiplicativeExpressionContext context)
    {
        var methodName = "VisitMultiplicativeExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unaryExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnaryExpression([NotNull] Java9Parser.UnaryExpressionContext context)
    {
        var methodName = "VisitUnaryExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.preIncrementExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPreIncrementExpression([NotNull] Java9Parser.PreIncrementExpressionContext context)
    {
        var methodName = "VisitPreIncrementExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.preDecrementExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPreDecrementExpression([NotNull] Java9Parser.PreDecrementExpressionContext context)
    {
        var methodName = "VisitPreDecrementExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.unaryExpressionNotPlusMinus"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitUnaryExpressionNotPlusMinus([NotNull] Java9Parser.UnaryExpressionNotPlusMinusContext context)
    {
        var methodName = "VisitUnaryExpressionNotPlusMinus";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.postfixExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPostfixExpression([NotNull] Java9Parser.PostfixExpressionContext context)
    {
        var methodName = "VisitPostfixExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.postIncrementExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPostIncrementExpression([NotNull] Java9Parser.PostIncrementExpressionContext context)
    {
        var methodName = "VisitPostIncrementExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.postIncrementExpression_lf_postfixExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPostIncrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostIncrementExpression_lf_postfixExpressionContext context)
    {
        var methodName = "VisitPostIncrementExpression_lf_postfixExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.postDecrementExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPostDecrementExpression([NotNull] Java9Parser.PostDecrementExpressionContext context)
    {
        var methodName = "VisitPostDecrementExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.postDecrementExpression_lf_postfixExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitPostDecrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostDecrementExpression_lf_postfixExpressionContext context)
    {
        var methodName = "VisitPostDecrementExpression_lf_postfixExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.castExpression"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitCastExpression([NotNull] Java9Parser.CastExpressionContext context)
    {
        var methodName = "VisitCastExpression";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }
    /// <summary>
    /// Visit a parse tree produced by <see cref="Java9Parser.identifier"/>.
    /// <para>
    /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
    /// on <paramref name="context"/>.
    /// </para>
    /// </summary>
    /// <param name="context">The parse tree.</param>
    /// <return>The visitor result.</return>
    public virtual Result VisitIdentifier([NotNull] Java9Parser.IdentifierContext context)
    {
        var methodName = "VisitIdentifier";
        HandleIntermediateVisit(methodName, context);
        return VisitChildren(context);
    }


}