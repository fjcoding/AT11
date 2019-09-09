using System;
using args;
using Xunit;
using System.Collections; 
using System.Collections.Generic; 

namespace args.Tests
{
    public class ArgsTest
    {
        private readonly Parser _parser;

        public ArgsTest()
        {
            _parser = new Parser();
        }

        [Fact]
        public void TestVerifyBooleanArgumentIsValid()
        {
            var result = _parser.verifyBooleanArgumentIsValid("-l");
            Assert.True(result, "Error... Was expected -l");
        }

        [Fact]
        public void TestVerifyIntegerArgumentIsValid()
        {
            var result = _parser.verifyIntegerArgumentIsValid("-p 8080");
            Assert.Equal(8080, result);
        }

        // [Fact]
        // public void parseArgs()
        // {
        //     var schema = new Schema(new List<Arg>(){
        //         new Arg("-l", new Empty()),
        //         new Arg("-p", new Integer()),
        //         new Arg("-s", new String()),
        //     })
        //     var paser = new Parser(schema);
        //     var result = parser.parse("-l -p 8080 -s ayedt");
        //     Assert.Equal(true, result[0]);
        //     Assert.Equal(8080, result[1]);
        //     Assert.Equal("ayedt", result[2]);
        // }

        // [Fact]
        // public void TestVirifyArgs()
        // {
        //     Schema schema = new Schema();
            
        //     schema(new List<Arg>(){
        //         new Arg{"-l", ""},
        //         new Arg{"-p", 8080},
        //         new Arg{"-d", "/usr/logserror"}
        //     });

        //     Parser parser = new Parser(schema);
        //     var result = parser.verifySchema("-l -p 8080 -d /usr/logserror");
        //     Assert.Equal(true, result[0]);
        //     Assert.Equal(8080, result[1]);
        //     Assert.Equal("/usr/logserror", result[2]);
        // }
    }
}
