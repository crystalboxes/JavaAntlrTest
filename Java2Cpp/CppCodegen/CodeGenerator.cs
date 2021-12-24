using Java2Cpp.PaseTreeReflection;

namespace Java2Cpp.CppCodegen
{
    public class CodeGenerator
    {
        public string Header { get { return _header.ToString(); } }
        public string Implementation { get { return _source.ToString(); } }
        public CodeGenerator(UnitDefinition unit, string name = "Program")
        {
            _unit = unit;
            _name = name;

            BuildHeader();
            BuildImplementation();
        }

        void BuildHeader()
        {
            _header.AddLine($"/* {_name}.h */");
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
            _header.PushIndent();

            foreach (var childClassDefinition in classDefinition.Classes)
            {
                BuildClassDeclaration(childClassDefinition);
            }

            foreach (var field in classDefinition.Fields)
            {
                BuildFieldDeclaration(field);
            }

            foreach (var method in classDefinition.Methods)
            {
                BuildMethodDeclaration(method);
            }

            _header.PopIndent();
            _header.AddLine(Tokens.BRACE_CLOSE, Tokens.SEMICOLON);
        }

        void BuildMethodDeclaration(MethodDefinition methodDefinition)
        {
            _header.AddLine(new CppTypeResolver(methodDefinition.Result).Representation, Tokens.SPACE, methodDefinition.Name!,
            Tokens.PAREN_OPEN, TransformArgumentsList(methodDefinition.Arguments), Tokens.PAREN_CLOSE, Tokens.SEMICOLON);
        }

        string TransformArgumentsList(ArgumentListDefinition args)
        {
            if (args.Entries.Count == 0)
            {
                return "";
            }
            return args.Entries.Select(x => $"{new CppTypeResolver(x.Type).Representation} {x.Name}").Aggregate((acc, x) => $"{acc}, {x}")!;
        }

        void BuildFieldDeclaration(FieldDefinition fieldDefinition)
        {
            _header.AddLine(new CppTypeResolver(fieldDefinition.Type).Representation, Tokens.SPACE,
                fieldDefinition.VariableDeclarators.Select(x => x.Name).Aggregate((acc, x) => $"{acc}, {x}")!, Tokens.SEMICOLON);
        }

        void BuildImplementation()
        {
            _source.AddInclude($"{_name}.h", true);
            _source.AddNewLine();
            foreach (var classDefinition in _unit.Classes)
            {
                var className = classDefinition.Name;
                foreach (var method in classDefinition.Methods)
                {
                    _source.AddLine(new CppTypeResolver(method.Result).Representation, Tokens.SPACE, className!, Tokens.DOUBLE_COLON, method.Name!, Tokens.PAREN_OPEN,
                        TransformArgumentsList(method.Arguments), Tokens.PAREN_CLOSE, Tokens.SPACE, Tokens.BRACE_OPEN);
                    _source.AddLine(Tokens.BRACE_CLOSE);
                    _source.AddNewLine();
                }
            }
        }

        void BuildMethodImplementation()
        {

        }


        UnitDefinition _unit;
        string _name;
        SourceBuilder _header = new();
        SourceBuilder _source = new();
    }
}
