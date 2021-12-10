using System.Diagnostics;
using System.Drawing;
using Antlr4.Runtime;
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
                methodDefinition.Name = context.Start.Text;
            }
            return VisitChildren(context);
        }


        public override Result VisitMethodDeclaration(Java9Parser.MethodDeclarationContext context)
        {
            var classDefinition = (Owner as ClassDefinition)!;
            var methodDefinition = new MethodDefinition();
            classDefinition.Methods.Add(methodDefinition);
            NextOwner = methodDefinition;
            return VisitChildren(context);
        }
    }
}
