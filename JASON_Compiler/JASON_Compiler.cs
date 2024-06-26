﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASON_Compiler
{
    public static class JASON_Compiler
    {
        public static List<string> Lexemes = new List<string>();
        public static Scanner Jason_Scanner = new Scanner();
        public static Parser Jason_Parser = new Parser();
        public static List<Token> TokenStream = new List<Token>();
        public static Node treeroot;

        public static void Start_Compiling(string SourceCode) //character by character
        {
            //Scanner
            Jason_Scanner.StartScanning(SourceCode);
            //Parser
            Jason_Parser.StartParsing(TokenStream);
            treeroot = Jason_Parser.root;
        }

        static void SplitLexemes(string SourceCode)
        {
            string[] Lexemes_arr = SourceCode.Split(' ');
            for (int i = 0; i < Lexemes_arr.Length; i++)
            {
                if (Lexemes_arr[i].Contains("\r\n"))
                {
                    Lexemes_arr[i] = Lexemes_arr[i].Replace("\r\n", string.Empty);
                }
                Lexemes.Add(Lexemes_arr[i]);
            }

        }
    }
}
