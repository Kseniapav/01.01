using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTreeView
{
    public class RestoransNoteModel
    {
        public string Name { get; set; } //имя узла

        public List<RestoransNoteModel> Children { get; } // список дочерних узлов

        public RestoransNoteModel(string name)
        {
            Name = name;
            Children = new List<RestoransNoteModel>();
        }

        public RestoransNoteModel AddChildNode(string text)
        {
            RestoransNoteModel node = new RestoransNoteModel(text);
            Children.Add(node);

            return node;
        }
    }
}
