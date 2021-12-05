using JavaAST.PaseTreeReflection;

namespace JavaAST.CppCodegen
{
    public class CodeGenerator
    {
        public string Header { get { return _header.ToString(); } }
        public string Implementation { get { return _source.ToString(); } }
        public CodeGenerator(UnitDefinition unit)
        {
            _unit = unit;

            BuildHeader();
        }


        void BuildHeader()
        {
            _header.AddPragmaOnce();
            _header.AddInclude("runtime.h");

            _header.AddNewLine();

            foreach (var classDefinition in _unit.Classes)
            {
                BuildClassDeclaration(classDefinition);
            }
        }

        void BuildClassDeclaration(ClassDefinition classDefinition)
        {
            _header.AddLine(Tokens.CLASS, Tokens.SPACE, classDefinition.Name!, Tokens.SPACE, Tokens.BRACE_OPEN);
            _header.AddLine(Tokens.PUBLIC, Tokens.COLON);
            _header.AddNewLine();
            _header.PushIndent();

            foreach (var childClassDefinition in classDefinition.Classes)
            {
                BuildClassDeclaration(childClassDefinition);
            }

            _header.PopIndent();
            _header.AddLine(Tokens.BRACE_CLOSE, Tokens.SEMICOLON);
        }

        UnitDefinition _unit;

        SourceBuilder _header = new();
        SourceBuilder _source = new();
    }
}
