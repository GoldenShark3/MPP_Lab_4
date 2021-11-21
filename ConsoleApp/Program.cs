using Core.TestGenerator.Implementations;

namespace ConsoleApp
{
    static class TestProgram
    {
        static void Main()
        {
            var generator = NUnitTestGenerator.CreateGenerator(builder =>
            {
                builder.MaxGenerateFiles = 10;
                builder.MaxReadFiles = 10;
                builder.MaxWriteFiles = 10;
            });
            generator.GenerateTestsAsync(@"C:\Users\Aleksey\Desktop\TestsGenerator-MPP-4\ConsoleApp\input",
                @"C:\Users\Aleksey\Desktop\TestsGenerator-MPP-4\ConsoleApp\output").Wait();
        }
    }
}