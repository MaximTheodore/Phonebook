   M S B A M L   `   `   `  ����D  @Phonebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Phonebook.ViewPhonebook.View  5      #    Phonebook.View.AddContactView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Phonebook.View     5        N� Title$  AddContactView��5
       � DataContext 5      ��  �� RelativeSource �� *Self+.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $
��Save��6   $��0,0,10,0q�6J   ��6$   �� *AddContactCommand+6J   �� 5      $��Cancel��6   ��6&   �� *CancelCommand+5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� $��Name:��6   $
��Bold"�6%   �� 5      $	��0,3q�6/   ��6   �� *	AnyName+6/   �� 5      $��Phone Number:��6   $
��Bold"�6-   $��0,10,0,0q�6?   �� 5      $	��0,3q�63   ��6   �� *PhoneNumber+63   5      5      5      