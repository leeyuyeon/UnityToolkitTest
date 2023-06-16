using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using ScrollViewAlias = UnityEngine.UIElements.ScrollView;
using ScrollViewBtn;
using ScrollView = ScrollViewBtn.ScrollView;

public class ContainersMgr : MonoBehaviour
{
    private UIDocument ui_document;
    
    //Alias 그냥 한번 해봄
    private ScrollViewAlias scroll_view;
    private ListView list_view;

    private Button button_element;
    private VisualElement inner_content;

    private ScrollView scroll_view_method;
    private void Awake()
    {
        this.scroll_view_method = new ScrollView();
        this.ui_document = GetComponent<UIDocument>();
    
        this.button_element = this.ui_document.rootVisualElement.Q<Button>("ScrollviewContentCreateButton");
        this.scroll_view = this.ui_document.rootVisualElement.Q<ScrollViewAlias>("ScrollView");
        
        this.button_element.clicked += Scroll_view_add;
    }

    private void Scroll_view_add()
    {
        var inner_content_list = this.scroll_view_method.Get_inner_content();
        foreach (var element in inner_content_list)
        {
            this.scroll_view.contentContainer.Add(element);
        }
    }
}

