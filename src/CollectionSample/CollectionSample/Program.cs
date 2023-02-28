using System.Activities;

namespace CollectionSample
{
class Program
{
static void Main(string[] args)
{
//WorkflowInvoker.Invoke(new AddItemToCollectionWorkflow());

//WorkflowInvoker.Invoke(new RemoveItemFromCollectionWorkflow());

//WorkflowInvoker.Invoke(new ClearAllFromCollectionWorkflow());

//WorkflowInvoker.Invoke(new ExistsItemInCollection());

//WorkflowInvoker.Invoke(new ComplexCollectionWorlflow());

WorkflowInvoker.Invoke(new KeyValueCollectionWorkflow());

System.Console.Read();
}
}
}