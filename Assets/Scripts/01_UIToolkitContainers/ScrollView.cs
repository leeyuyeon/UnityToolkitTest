using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace ScrollViewBtn
{
    public class ScrollView
    {
        private readonly VisualElement inner_content;
        
        public ScrollView()
        {
            this.inner_content = new VisualElement();
        }
        
        public List<VisualElement> Get_inner_content()
        {
            var inner_content_list = new List<VisualElement>();

            Clear_inner_content();
            var sample_texts = new[] { "Item1", "Item2", "Item3", "Item4" };

            foreach (var text in sample_texts)
            {
                var label = new Label(text);
                this.inner_content.Add(label);
                inner_content_list.Add(label);
            }

            return inner_content_list;
        }

        private void Clear_inner_content()
        {
            this.inner_content?.Clear();
        }
    }
}
