using System;
using System.Collections.Generic;
using System.Reflection;

//See: https://blog.rsuter.com/use-t4-texttemplatingfilepreprocessor-in-net-standard-or-pcl-libraries/
namespace TextTemplateCodeGeneration
{
    internal static class T4Extensions
    {
        public static MethodInfo GetMethod(this Type type, string method, params Type[] parameters)
        {
            return type.GetRuntimeMethod(method, parameters);
        }
    }
}

namespace System.CodeDom.Compiler
{
    internal class CompilerErrorCollection : List<CompilerError>
    {
    }

    internal class CompilerError
    {
        public string ErrorText { get; set; }

        public bool IsWarning { get; set; }
    }
}
