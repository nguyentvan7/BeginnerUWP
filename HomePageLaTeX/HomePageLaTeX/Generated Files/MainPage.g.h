﻿#pragma once
//------------------------------------------------------------------------------
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//------------------------------------------------------------------------------


namespace Windows {
    namespace UI {
        namespace Xaml {
            namespace Controls {
                ref class StackPanel;
                ref class TextBlock;
                ref class ListView;
                ref class Button;
            }
        }
    }
}

namespace HomePageLaTeX
{
    [::Windows::Foundation::Metadata::WebHostHidden]
    partial ref class MainPage : public ::Windows::UI::Xaml::Controls::Page, 
        public ::Windows::UI::Xaml::Markup::IComponentConnector,
        public ::Windows::UI::Xaml::Markup::IComponentConnector2
    {
    public:
        void InitializeComponent();
        virtual void Connect(int connectionId, ::Platform::Object^ target);
        virtual ::Windows::UI::Xaml::Markup::IComponentConnector^ GetBindingConnector(int connectionId, ::Platform::Object^ target);
    
    private:
        bool _contentLoaded;
    
        private: ::Windows::UI::Xaml::Controls::StackPanel^ topPanel;
        private: ::Windows::UI::Xaml::Controls::TextBlock^ logo;
        private: ::Windows::UI::Xaml::Controls::StackPanel^ interactPanel;
        private: ::Windows::UI::Xaml::Controls::StackPanel^ choicePanel;
        private: ::Windows::UI::Xaml::Controls::StackPanel^ recentPanel;
        private: ::Windows::UI::Xaml::Controls::ListView^ recentList;
        private: ::Windows::UI::Xaml::Controls::Button^ newButton;
        private: ::Windows::UI::Xaml::Controls::Button^ openButton;
        private: ::Windows::UI::Xaml::Controls::Button^ settingsButton;
    };
}
