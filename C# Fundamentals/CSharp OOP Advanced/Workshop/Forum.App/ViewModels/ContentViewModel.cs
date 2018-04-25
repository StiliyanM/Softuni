using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.ViewModels
{
    public abstract class ContentViewModel
    {
        private const int lineLenght = 37;

        protected ContentViewModel(string content)
        {
            this.Content = this.GetLines(content);
        }

        public string[] Content { get; }

        private string[] GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();

            ICollection<string> lines = new List<string>();

            for (int index = 0; index < content.Length; index += lineLenght)
            {
                char[] row = contentChars.Skip(index).Take(lineLenght).ToArray();

                string rowAsString = String.Join("", row);

                lines.Add(rowAsString);
            }

            return lines.ToArray();
        }
    }
}
