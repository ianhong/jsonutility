using Newtonsoft.Json;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

var schema = await JsonSchema.FromFileAsync(@"F:\\src\ecomm-nc-omsA\Source\Costco.BizTalk.OrderManagement.Import\Schemas\WebOrder.json");
 var generator = new CSharpGenerator(schema);
var file = generator.GenerateFile(); 

var tw = new StreamWriter("csharp.cs");
tw.Write(file);
tw.Close();
