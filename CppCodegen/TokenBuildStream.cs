
namespace JavaAST.CppCodegen
{
    public class TokenBuildStream
    {
        public void Add(params string[] tokens)
        {
            foreach (var token in tokens)
            {
                AddOne(token);
            }
        }

        public void AddIndent()
        {
            for (int i = 0; i < _indentLevel; i++)
            {
                for (int j = 0; j < TAB_WIDTH; j++)
                {
                    AddOne(Tokens.SPACE);
                }
            }
        }

        public void AddLine(params string[] tokens)
        {
            AddIndent();
            Add(tokens);
            AddOne(Tokens.ENDL);
        }

        public override string ToString()
        {
            return string.Concat(_internal.ToArray());
        }

        public void PushIndent()
        {
            ++_indentLevel;
        }

        public void PopIndent()
        {
            --_indentLevel;
        }

        protected List<string> _internal = new();
        protected int _indentLevel = 0;
        const int TAB_WIDTH = 4;

        void AddOne(string tokens)
        {
            _internal.Add(tokens);
        }
    }
}
