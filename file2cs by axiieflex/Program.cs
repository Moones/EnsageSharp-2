using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using CommandLine.Text;

namespace file2cs
{
    class Program
    {

        class Options
        {

            [Option("name", Required = true, 
            HelpText = "Specify name of file")]
            public string _name { get; set; }

            [Option("rel", Required = false, DefaultValue=null,
            HelpText = "Specify relative path of file")]
            public string _rel { get; set; }

            [Option('v', "visible", Required = false, DefaultValue = "public", 
            HelpText = "Specify visible modificator private, public, protected or internal")]
            public string _visible { get; set; }

            [Option("namespace", Required = false, DefaultValue = "",
              HelpText = "Specify namespace for output C# file")]
            public string _namespace { get; set; }

            [Option("classname", Required = false, DefaultValue = "Resource",
            HelpText = "Specify classname for output C# file")]
            public string _classname { get; set; }

            [Option("packing", Required = false, DefaultValue = "string",
            HelpText = "Specify packing method for C# file string or blob")]
            public string _packing { get; set; }

            [Option('o', "output", Required = false, DefaultValue = null,
            HelpText = "Specify output filename for C# file")]
            public string _output { get; set; }

            [Option("file", Required = true, 
            HelpText = "Specify source filename")]
            public string _file { get; set; }

            [Option('q', "quiet", Required = false, DefaultValue=true,
            HelpText = "Ignoring all errors")]
            public bool _quiet { get; set; }

            [ParserState]
            public IParserState LastParserState { get; set; }

            [HelpOption]
            public string GetUsage()
            {
                //return CommandLine.Text.HelpText.AutoBuild(this,
                //(HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
                return "";
            }
        }

        /// <summary>
        /// 
        /// file2cs /namespace:Namespace1 /classname:Resource /rel:RelativeName /packing:string|blob ...source 
        /// 
        /// </summary>
        /// <param name="args"></param>
        // Define a class to receive parsed values
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {

                string result = "";

                try
                {
                    if (options._packing.ToUpper() == "STRING")
                    {
                        var data = System.IO.File.ReadAllText(options._file);
                    }
                    else if (options._packing.ToUpper() == "BLOB") 
                    {
                        var data = System.IO.File.ReadAllBytes(options._file);
                    }
                } catch (Exception) {

                }



                if (options._output == null)
                {
                    Console.Write(result);
                }
                else
                {
                    try {
                        System.IO.File.WriteAllText(options._output, result);
                    } catch(Exception ex) {
                        if(!options._quiet) {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    
                }

            }
        }
    }
}
