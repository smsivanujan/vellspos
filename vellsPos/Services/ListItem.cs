using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class ListItem
    {
        private int id;
        private string value;
        private string text;

        public ListItem(int id, string value, string text)
        {
            this.Id = id;
            this.Value = value;
            this.Text = text;
        }

        public int Id { get => id; set => id = value; }
        public string Value { get => value; set => this.value = value; }
        public string Text { get => text; set => text = value; }
    }
}
