using System;
using Xunit;

namespace args.Test
{
    public class ParserTest
    {
        private readonly Parser _parser;
        public ParserTest ()
        {
            _parser = new Parser();
        }
        /*
        [Fact]
        public void TestCutFirstArgument()
        {
            string schemainput = "-l -p 8080 -d /usr/logs";

            _parser.convertToArg(schemainput);

            List<Arg> schema = _parser.getListSchemas();

            var result = schema[0].getArg().getValue;

            var expected = true;

            Assert.Equal(expected, result);
        }
        */
        [Fact]
        public void WhenInputLoggingArgumentReturnFlagType()
        {
            string argCommand = "-a -p 8080 -d /usr/logs";

            var result = _parser.getFlagType(argCommand);
            var expected = "Error, the argument is not Exist";

            Assert.Equal(expected, result);
        }
    }
}
