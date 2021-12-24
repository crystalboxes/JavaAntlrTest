
using JavaAST.PaseTreeReflection;

namespace JavaAST.CppCodegen
{
    public class CppTypeResolver : TokenBuildStream
    {
        public CppTypeResolver(TypeDefinition? type)
        {
            _type = type;
        }

        public string Representation
        {
            get
            {
                // TODO -> Transform types
                var name = _type?.Name!;
                switch (_type?.Name!)
                {
                    case "String":
                        return "std::string";
                    default:
                        return name;
                }
            }
        }

        TypeDefinition? _type;
    }
}