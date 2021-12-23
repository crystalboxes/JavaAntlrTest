using System.Diagnostics;
using System.Drawing;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using JavaAST.AntlrParser;
using JavaAST.PaseTreeReflection;
using Pastel;

namespace JavaAST.ReflectionLoader
{
    internal class ReflectionVisitor : ReflectionVisitorLogged
    {
        public ReflectionVisitor(ReflectionVisitorConfig config, int depth) : base(config, depth)
        {
        }
        protected override ReflectionVisitorBase CreateChild(ReflectionVisitorConfig config, int depth) => new ReflectionVisitor(config, depth);

        public override Result VisitClassModifier(Java9Parser.ClassModifierContext context)
        {
            var classDefinition = (Owner as ClassDefinition)!;
            classDefinition.Modifiers.Add(context.Start.Text);
            return VisitChildren(context);
        }


        public override Result VisitClassDeclaration(Java9Parser.ClassDeclarationContext context)
        {
            var classDefinition = new ClassDefinition();
            classDefinition.Parent = Owner;
            if (Owner is ClassDefinition)
            {
                (Owner as ClassDefinition)!.Classes.Add(classDefinition!);
            }
            else if (Owner is UnitDefinition)
            {
                (Owner as UnitDefinition)!.Classes.Add(classDefinition!);
            }

            NextOwner = classDefinition;

            return VisitChildren(context);
        }

        public override Result VisitIdentifier(Java9Parser.IdentifierContext context)
        {
            if (Owner is ClassDefinition)
            {
                var classDefinition = Owner as ClassDefinition;
                if (classDefinition!.Name == null)
                {
                    classDefinition.Name = context.Start.Text;
                }
            }
            else if (Owner is MethodDefinition)
            {
                var methodDefinition = (Owner as MethodDefinition)!;
                // Method definition comes with name nulled.
                // Visit  identifier would be called later one when the list of args is parsed
                if (methodDefinition.Name == null)
                {
                    methodDefinition.Name = context.Start.Text;
                }
            }
            else if (Owner is VariableDeclaratorDefinition)
            {
                var variableDeclarator = (Owner as VariableDeclaratorDefinition)!;
                variableDeclarator.Name = context.Start.Text;
            }
            return VisitChildren(context);
        }

        public override Result VisitMethodDeclaration(Java9Parser.MethodDeclarationContext context)
        {
            var classDefinition = (Owner as ClassDefinition)!;
            var methodDefinition = new MethodDefinition();
            methodDefinition.Parent = Owner;

            classDefinition.Methods.Add(methodDefinition);
            NextOwner = methodDefinition;
            return VisitChildren(context);
        }
        public override Result VisitUnannType([NotNull] Java9Parser.UnannTypeContext context)
        {
            return VisitRootTypeContext(context);
        }
        public override Result VisitResult([NotNull] Java9Parser.ResultContext context) { return VisitRootTypeContext(context); }

        Result VisitRootTypeContext([NotNull] ParserRuleContext context)
        {

            if (Owner is TypeDefinition)
            {
                return VisitChildren(context);
            }

            var typeDefinition = new TypeDefinition();
            typeDefinition.Parent = Owner;

            // Collect result
            var startToken = context.Start;
            var endToken = context.Stop;
            var typeName = startToken.InputStream.GetText(new Interval(startToken.StartIndex, endToken.StopIndex));
            typeDefinition.Name = typeName;

            if (Owner is MethodDefinition)
            {
                var methodDefinition = (Owner as MethodDefinition)!;
                methodDefinition.Result = typeDefinition;
            }
            else if (Owner is FieldDefinition)
            {
                var fieldDefinition = (Owner as FieldDefinition)!;
                fieldDefinition.Type = typeDefinition;
            }
            else if (Owner is VariableDeclaratorDefinition)
            {
                var variableDeclarator = (Owner as VariableDeclaratorDefinition)!;
                variableDeclarator.Type = typeDefinition;
            }

            NextOwner = typeDefinition;
            return VisitChildren(context);
        }

        public override Result VisitMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context)
        {
            var methodDefinition = (Owner as MethodDefinition)!;
            methodDefinition.Name = context.Start.Text;
            return VisitChildren(context);
        }
        public override Result VisitUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context)
        {
            if (Owner is TypeDefinition)
            {
                var typeDefinition = (Owner as TypeDefinition)!;
                typeDefinition.IsArrayType = true;
            }
            return VisitChildren(context);
        }

        public override Result VisitIntegralType([NotNull] Java9Parser.IntegralTypeContext context)
        {
            if (Owner is TypeDefinition)
            {
                var typeDefinition = (Owner as TypeDefinition)!;
                typeDefinition.IntegralTypeName = context.Start.Text;
            }
            return VisitChildren(context);
        }

        public override Result VisitUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context)
        {
            if (Owner is TypeDefinition)
            {
                var typeDefinition = (Owner as TypeDefinition)!;
                typeDefinition.IsInterfaceType = true;
            }
            return VisitChildren(context);
        }

        public override Result VisitFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context)
        {
            var fieldDefinition = new FieldDefinition();
            fieldDefinition.Parent = Owner;


            var classDefinition = (Owner as ClassDefinition)!;
            classDefinition.Fields.Add(fieldDefinition);
            NextOwner = fieldDefinition;

            return VisitChildren(context);
        }

        public override Result VisitVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context)
        {
            if (Owner is FieldDefinition)
            {
                var fieldDefinition = (Owner as FieldDefinition)!;
                var variableDeclarator = new VariableDeclaratorDefinition();
                variableDeclarator.Parent = fieldDefinition;

                fieldDefinition.VariableDeclarators.Add(variableDeclarator);
                NextOwner = variableDeclarator;
            }

            return VisitChildren(context);
        }

        public override Result VisitFormalParameter([NotNull] Java9Parser.FormalParameterContext context)
        {

            if (Owner is ArgumentListDefinition)
            {
                var argumentList = (Owner as ArgumentListDefinition)!;
                var variableDeclarator = new VariableDeclaratorDefinition();
                variableDeclarator.Parent = Owner;
                argumentList.Arguments.Add(variableDeclarator);
                NextOwner = variableDeclarator;
            }

            return VisitChildren(context);
        }

        public override Result VisitFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context)
        {
            var argumentList = new ArgumentListDefinition();

            var methodDefinition = (Owner as MethodDefinition)!;
            methodDefinition.Arguments = argumentList;

            argumentList.Parent = methodDefinition;
            NextOwner = argumentList;

            return VisitChildren(context);
        }


    }
}
