namespace P09CollectionHierarchy
{
    using System.Text;

    using Contracts;

    public class CollectionManipulator
    {
        private StringBuilder resultBuilder = new StringBuilder();

        public void FillCollection<T>(string[] data, IAddCollection<string> collection)
        {
            foreach (var item in data)
            {
                var index = collection.Add(item);

                resultBuilder.Append($"{index} ");
            }

            resultBuilder = resultBuilder
                .Remove(this.resultBuilder.Length - 1, 1)
                .AppendLine();
        }

        public void Remove<T>(int numberOfOperations, IAddRemoveCollection<T> collection)
        {
            for (int i = 0; i < numberOfOperations; i++)
            {
                var element = collection.Remove();

                resultBuilder.Append($"{element} ");
            }

            resultBuilder = resultBuilder
                .Remove(this.resultBuilder.Length - 1, 1)
                .AppendLine();
        }

        public string GetOperationsInfo()
        {
            return this.resultBuilder.ToString().TrimEnd();
        }
    }
}
