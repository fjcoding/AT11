using System;
using CodeCrackerMain;
using Xunit;

namespace CodeCrackerMain.Tests
{
    public class CodeTest
    {
        private readonly Decripter _decripter;
        private readonly Encripter _encripter;
        private readonly Code _code;
        public CodeTest()
        {
            _decripter = new Decripter();
            _code = new Code();
            _encripter = new Encripter();
        }

    }
}