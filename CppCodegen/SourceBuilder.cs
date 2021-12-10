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

        public void AddInclude(string path)
        {
            AddLine(Tokens.HASH, Tokens.INCLUDE, Tokens.SPACE, Tokens.LT, path, Tokens.GT);
        }

       
    }
}