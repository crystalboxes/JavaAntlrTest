namespace JavaAST.CppCodegen
{
    public class SourceBuilder : TokenBuildStream
    {
        public void AddNewLine()
        {
            Add(Tokens.ENDL);
        }
        public void AddPragmaOnce()
        {
            AddLine(Tokens.HASH, Tokens.PRAGMA, Tokens.SPACE, "once");
        }

        public void AddInclude(string path, bool quotes = false)
        {
            AddLine(Tokens.HASH, Tokens.INCLUDE, Tokens.SPACE, quotes ? Tokens.DOUBLE_QUOTE : Tokens.LT, path, quotes ? Tokens.DOUBLE_QUOTE : Tokens.GT);
        }

    }
}