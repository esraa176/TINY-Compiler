using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TINY_Compiler
{
    public static class TINY_Compiler
    {
        public static Scanner TINY_Scanner = new Scanner();
        public static Parser TINY_Parser = new Parser();
        public static List<Token> TokenStream = new List<Token>();
        public static Node treeroot;

        public static void Start_Compiling(string SourceCode) //character by character
        {
            //Scanner
            TINY_Scanner.StartScanning(SourceCode);
            //Parser
            TINY_Parser.StartParsing(TokenStream);
            treeroot = TINY_Parser.root;
        } 
    }
}
